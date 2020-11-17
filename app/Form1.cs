using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonSchemaLab
{
    public partial class frmMain : Form
    {
        private string _schemaFileName = "";
        public frmMain()
        {
            InitializeComponent();
        }


        private void ValidateJsonManatee()
        {
            txtError.Text = "";
            var serializer = new Manatee.Json.Serialization.JsonSerializer();
            var json = Manatee.Json.JsonValue.Parse(txtJson.Text);
            var schemaJson = Manatee.Json.JsonValue.Parse(txtSchema.Text);
            var schema = new Manatee.Json.Schema.JsonSchema();
            schema.FromJson(schemaJson, serializer);
            Manatee.Json.Schema.JsonSchemaOptions.OutputFormat = Manatee.Json.Schema.SchemaValidationOutputFormat.Basic;

            var validationResults = schema.Validate(json);

            if (!validationResults.IsValid)
            {

                json = serializer.Serialize(validationResults);


                txtError.Text = JsonHelper.FormatJson(json.ToString());
            }
            else
            {
                txtError.Text = "Valid";
            }

        }
        private void ValidateJsonNewtonSoft()
        {
            JSchema schema;
            JObject data;

            try
            {
                schema = JSchema.Parse(txtSchema.Text);
            }
            catch (Exception ex)
            {
                txtError.Text = ex.ToString();
                return;
            }


            try
            {
                JsonTextReader reader = new JsonTextReader(new StringReader(txtJson.Text));
                JSchemaValidatingReader validatingReader = new JSchemaValidatingReader(reader);
                validatingReader.Schema = schema;

                JsonSerializer serializer = new JsonSerializer();
                serializer.Deserialize(validatingReader);// true
                txtError.Text = "Valid";
            }
            catch (Exception ex)
            {
                txtError.Text = ex.ToString();
                return;
            }
        }


        private void btnPasteSchema_Click(object sender, EventArgs e)
        {
            txtSchema.Text =JsonHelper.FormatJson(Clipboard.GetText());
        }

        private void btnPasteJson_Click(object sender, EventArgs e)
        {
            txtJson.Text = JsonHelper.FormatJson(Clipboard.GetText());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            txtSchema.ConvertTabToSpaces = true;
            txtSchema.TabSize = 4;
            txtSchema.AllowDrop = true;
            txtSchema.DragEnter += txt_DragEnter;
            txtSchema.DragDrop += txt_DragDrop;

            txtJson.ConvertTabToSpaces = true;
            txtJson.TabSize = 4;
            txtJson.AllowDrop = true;
            txtJson.DragEnter += txt_DragEnter;
            txtJson.DragDrop += txt_DragDrop;
            //loadTheme();
        }

        private void txt_DragDrop(object sender, DragEventArgs e)
        {
            var txt = sender as TabbedRichTextBox;
            if(txt == null)
            {
                return;
            }
            var fileName = (string[])e.Data.GetData("FileName");

            txt.Text = JsonHelper.FormatJson(File.ReadAllText(fileName[0]));
        }

        private void txt_DragEnter(object sender, DragEventArgs e)
        {
            // Determine whether string data exists in the drop data. If not, then
            // the drop effect reflects that the drop cannot occur.
            if (!e.Data.GetFormats().Contains("FileName"))
            {

                e.Effect = DragDropEffects.None;
                return;
            }
        }

        private void btnSaveSchema_Click(object sender, EventArgs e)
        {
            SaveSchema("");
        }

        private void SaveSchema(string fileName)
        {
            if(fileName != "")
            {
                File.WriteAllText(fileName, txtSchema.Text);
                return;
            }

            var dlg = new SaveFileDialog();
            
            
            dlg.FileName = fileName;

            dlg.ShowDialog(this);
            if (dlg.FileName != "")
            {
                File.WriteAllText(dlg.FileName, txtSchema.Text);
            }
            _schemaFileName = dlg.FileName;
        }

        private void txtSchema_KeyUp(object sender, KeyEventArgs e)
        {
            //Save
            if(e.Control && e.KeyCode == Keys.S)
            {
                SaveSchema(_schemaFileName);
                e.Handled = true;
                return;
            }

        }

        private void btnOpenJson_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.ShowDialog();
            
            if (_schemaFileName != "")
            {
                txtJson.Text = JsonHelper.FormatJson(File.ReadAllText(dlg.FileName));
            }

        }

        private void btnLoadSchema_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.ShowDialog();
            _schemaFileName = dlg.FileName;
            if(_schemaFileName != "")
            {
                txtSchema.Text = JsonHelper.FormatJson(File.ReadAllText(_schemaFileName));
            }
        }

        private void txtSchema_SelectionChanged(object sender, EventArgs e)
        {
            lblSchemaLine.Text =  txtSchema.GetLineFromCharIndex(txtSchema.SelectionStart).ToString();
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            //Validate
            if (e.KeyCode == Keys.F5)
            {
                ValidateJsonManatee();
                e.Handled = true;
                return;
            }

        }

        private void txtJson_SelectionChanged(object sender, EventArgs e)
        {
            lblJsonLine.Text = txtJson.GetLineFromCharIndex(txtJson.SelectionStart).ToString();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            var oldCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            ValidateJsonNewtonSoft();
            this.Cursor = oldCursor;
        }

        private void btnValidateManatee_Click(object sender, EventArgs e)
        {
            var oldCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            ValidateJsonManatee();
            this.Cursor = oldCursor;

        }

        private void loadTheme()
        {
            var fileName = "themes/dark-solarized.json";
            var theme = JsonConvert.DeserializeObject<themes.ThemeSettings>(File.ReadAllText(fileName));


            //Color color = (Color)ColorConverter.ConvertFromString("#FFDFD991");
            var c = new ColorConverter();

            this.BackColor = (Color)c.ConvertFromString(theme.Colors["tab.activeBackground"]);


            toolStrip1.BackColor = (Color)c.ConvertFromString(theme.Colors["tab.activeBackground"]);
            
            toolStrip2.BackColor = (Color)c.ConvertFromString(theme.Colors["tab.activeBackground"]);
            toolStrip3.BackColor = (Color)c.ConvertFromString(theme.Colors["tab.activeBackground"]);

            statusStrip1.ForeColor = (Color)c.ConvertFromString(theme.Colors["tab.activeForeground"]);

            txtJson.BackColor = (Color)c.ConvertFromString(theme.Colors["editor.background"]);
            txtSchema.BackColor = (Color)c.ConvertFromString(theme.Colors["editor.background"]);
            txtError.BackColor = (Color)c.ConvertFromString(theme.Colors["editor.background"]);

            txtJson.ForeColor= (Color)c.ConvertFromString(theme.Colors["input.foreground"]);
            txtSchema.ForeColor = (Color)c.ConvertFromString(theme.Colors["input.foreground"]);
            txtError.ForeColor = (Color)c.ConvertFromString(theme.Colors["input.foreground"]);

            

        }

        private void txtSchema_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
