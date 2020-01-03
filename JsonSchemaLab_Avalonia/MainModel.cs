using System;
using System.Collections.Generic;
using System.Text;

namespace JsonSchemaLab_Avalonia
{
    public class MainModel:Avalonia.Diagnostics.ViewModels.
    {
        public string JsonText { get; set; }
        public string SchemaText { get; set; }
        public string ErrorText { get; set; }
    }
}
