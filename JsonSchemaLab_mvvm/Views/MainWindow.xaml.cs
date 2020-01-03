using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaEdit;

namespace JsonSchemaLab_mvvm.Views
{
    public class MainWindow : Window
    {
        private TextEditor _schemaEditor;

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif


            // https://github.com/AvaloniaUI/AvaloniaEdit/blob/master/src/AvaloniaEdit.Demo/MainWindow.xaml.cs

            _schemaEditor = this.FindControl<TextEditor>("SchemaEditor");
            _schemaEditor.TextArea.IndentationStrategy = new AvaloniaEdit.Indentation.CSharp.CSharpIndentationStrategy();
            

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
