using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace JsonSchemaLab
{
    public class TabbedRichTextBox:RichTextBox
    {
        public TabbedRichTextBox() : base() =>
    KeyDown += new KeyEventHandler(RichTextBox_KeyDown);

        [Browsable(true), Category("Settings"), Description("Convert all tabs into spaces."), EditorBrowsable(EditorBrowsableState.Always), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ConvertTabToSpaces { get; set; } = false;

        [Browsable(true), Category("Settings"), Description("The number os spaces used for replacing a tab character."), EditorBrowsable(EditorBrowsableState.Always), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int TabSize { get; set; } = 4;

        [Browsable(true), Category("Settings"), Description("The text associated with the control."), Bindable(true), EditorBrowsable(EditorBrowsableState.Always), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string Text
        {
            get => base.Text;
            set => base.Text = ConvertTabToSpaces ? value.Replace("\t", new string(' ', TabSize)) : value;
        }

        protected override bool ProcessCmdKey(ref Message Msg, Keys KeyData)
        {
            const int WM_KEYDOWN = 0x100; // https://docs.microsoft.com/en-us/windows/desktop/inputdev/wm-keydown
            const int WM_SYSKEYDOWN = 0x104; // https://docs.microsoft.com/en-us/windows/desktop/inputdev/wm-syskeydown

            if (ConvertTabToSpaces && KeyData == Keys.Tab && (Msg.Msg == WM_KEYDOWN || Msg.Msg == WM_SYSKEYDOWN))
            {
                SelectedText += new string(' ', TabSize);
                return true;
            }
            return base.ProcessCmdKey(ref Msg, KeyData);
        }

        public new void AppendText(string text)
        {
            if (ConvertTabToSpaces)
                text = text.Replace("\t", new string(' ', TabSize));
            base.AppendText(text);
        }

        private void RichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Shift && e.KeyCode == Keys.Insert) || (e.Control && e.KeyCode == Keys.V))
            {
                SuspendLayout();
                int start = SelectionStart;
                string end = Text.Substring(start);
                Text = Text.Substring(0, start);
                Text += (string)Clipboard.GetData("Text") + end;
                SelectionStart = TextLength - end.Length;
                ResumeLayout();
                e.Handled = true;
            }
        }
    }
}





