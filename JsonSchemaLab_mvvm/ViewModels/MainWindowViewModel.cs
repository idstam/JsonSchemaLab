using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using ReactiveUI;
using System.IO;

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
            ErrorText = JsonHelper.ValidateJson(JsonText, SchemaText);
        }

        public void ValidateSchema()
        {
            ErrorText = JsonHelper.ValidateSchema(JsonText, SchemaText);
        }

        public async void OpenSchema_Click()
        {
            var d = new OpenFileDialog();
            var w = ((IClassicDesktopStyleApplicationLifetime)App.Current.ApplicationLifetime).MainWindow;

            var result = await d.ShowAsync(w);
            if (result.Length > 0)
            {
                var str = File.ReadAllText(result[0]);
                SchemaText = JsonHelper.FormatJson(str);
            }
        }
        public void PasteSchema_Click()
        {
            SchemaText = JsonHelper.FormatJson(Application.Current.Clipboard.GetTextAsync().Result);
        }
        public async void SaveSchema_Click()
        {
            var d = new SaveFileDialog();
            var w = ((IClassicDesktopStyleApplicationLifetime)App.Current.ApplicationLifetime).MainWindow;
            var result = await d.ShowAsync(w);
            if (result.Length > 0)
            {
                File.WriteAllText(result, SchemaText);
            }

        }
        public async void OpenJson_Click()
        {
            var d = new OpenFileDialog();
            var w = ((IClassicDesktopStyleApplicationLifetime)App.Current.ApplicationLifetime).MainWindow;

            var result = await d.ShowAsync(w);
            if (result.Length > 0)
            {
                var str = File.ReadAllText(result[0]);
                JsonText = JsonHelper.FormatJson(str);
            }

        }
        public void PasteJson_Click()
        {
            JsonText = JsonHelper.FormatJson(Application.Current.Clipboard.GetTextAsync().Result);
        }
        public async void SaveJson_Click()
        {
            var d = new SaveFileDialog();
            var w = ((IClassicDesktopStyleApplicationLifetime)App.Current.ApplicationLifetime).MainWindow;
            var result = await d.ShowAsync(w);
            if (result.Length > 0)
            {
                File.WriteAllText(result, JsonText);
            }
        }
    }
}
