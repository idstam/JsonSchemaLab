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

        private void btnValidate_Click(object sender, EventArgs e)
        {
            ValidateJson();
        }

        private void ValidateJson()
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
                txtError.Text = "";
            }
            catch (Exception ex)
            {
                txtError.Text = ex.ToString();
                return;
            }
        }


        private void btnPasteSchema_Click(object sender, EventArgs e)
        {
            txtSchema.Text = Clipboard.GetText();
        }

        private void btnPasteJson_Click(object sender, EventArgs e)
        {
            txtJson.Text = Clipboard.GetText();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtSchema.ConvertTabToSpaces = true;
            txtSchema.TabSize = 4;
            txtJson.ConvertTabToSpaces = true;
            txtJson.TabSize = 4;
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
                txtJson.Text = File.ReadAllText(dlg.FileName);
            }

        }

        private void btnLoadSchema_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.ShowDialog();
            _schemaFileName = dlg.FileName;
            if(_schemaFileName != "")
            {
                txtSchema.Text = File.ReadAllText(_schemaFileName);
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
                ValidateJson();
                e.Handled = true;
                return;
            }

        }

        private void txtJson_SelectionChanged(object sender, EventArgs e)
        {
            lblJsonLine.Text = txtJson.GetLineFromCharIndex(txtJson.SelectionStart).ToString();
        }
    }
}
