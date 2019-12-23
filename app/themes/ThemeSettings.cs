using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSchemaLab.themes
{
    public class ThemeSettings
    {
        public string Type { get; set; }
        public Dictionary<string, string> Colors { get; set; }

        public List<TokenColor> tokenColors { get; set; }
    }

    public class TokenColorSettings
    {
        public string foreground { get; set; }
        public string fontStyle { get; set; }
    }

    public class TokenColor
    {
        public object scope { get; set; }
        public TokenColorSettings settings { get; set; }
        public string name { get; set; }
    }
}
