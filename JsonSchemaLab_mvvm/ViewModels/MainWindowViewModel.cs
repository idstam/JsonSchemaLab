using Avalonia;
using ReactiveUI;

namespace JsonSchemaLab_mvvm.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _schemaText;
        private int _schemaLineNumber;
        private string _jsonText;
        private int _jsonLineNumber;
        private string _errorText;



        public string SchemaText
        {
            get => _schemaText;
            set => this.RaiseAndSetIfChanged(ref _schemaText, value);
        }
        public string JsonText
        {
            get => _jsonText;
            set => this.RaiseAndSetIfChanged(ref _jsonText, value);
        }
        public string ErrorText
        {
            get => _errorText;
            set => this.RaiseAndSetIfChanged(ref _errorText, value);
        }

        public void Validate()
        {

        }

        public void OpenSchema_Click()
        {

        }
        public void PasteSchema_Click()
        {
            SchemaText = Application.Current.Clipboard.GetTextAsync().Result;
        }
        public void SaveSchema_Click()
        {

        }
        public void OpenJson_Click()
        {

        }
        public void PasteJson_Click()
        {
            JsonText = Application.Current.Clipboard.GetTextAsync().Result;
        }
        public void SaveJson_Click()
        {

        }
    }
}
