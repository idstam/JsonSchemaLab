using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace JsonSchemaLab_Avalonia
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        public MainModel MainModel;

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            MainModel = new MainModel();
            MainModel.SchemaText = "adsfadfadf";
        }

        public void OpenSchema_Click()
        {

        }
        public void PasteSchema_Click()
        {
            MainModel.SchemaText = Application.Current.Clipboard.GetTextAsync().Result;
        }
        public void SaveSchema_Click()
        {
            
        }
        public void OpenJson_Click()
        {

        }
        public void PasteJson_Click()
        {
            
        }
        public void SaveJson_Click()
        {

        }

    }
}
