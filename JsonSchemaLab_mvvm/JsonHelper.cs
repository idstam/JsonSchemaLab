using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class JsonHelper
{
    private const string INDENT_STRING = "    ";
    public static string FormatJson(string str)
    {
        var indent = 0;
        var quoted = false;
        var sb = new StringBuilder();
        for (var i = 0; i < str.Length; i++)
        {
            var ch = str[i];
            switch (ch)
            {
                case '{':
                case '[':
                    sb.Append(ch);
                    if (!quoted)
                    {
                        sb.AppendLine();
                        Enumerable.Range(0, ++indent).ToList().ForEach(item => sb.Append(INDENT_STRING));
                    }
                    break;
                case '}':
                case ']':
                    if (!quoted)
                    {
                        sb.AppendLine();
                        Enumerable.Range(0, --indent).ToList().ForEach(item => sb.Append(INDENT_STRING));
                    }
                    sb.Append(ch);
                    break;
                case '"':
                    sb.Append(ch);
                    bool escaped = false;
                    var index = i;
                    while (index > 0 && str[--index] == '\\')
                        escaped = !escaped;
                    if (!escaped)
                        quoted = !quoted;
                    break;
                case ',':
                    sb.Append(ch);
                    if (!quoted)
                    {
                        sb.AppendLine();
                        Enumerable.Range(0, indent).ToList().ForEach(item => sb.Append(INDENT_STRING));
                    }
                    break;
                case ':':
                    sb.Append(ch);
                    if (!quoted)
                        sb.Append(" ");
                    break;
                default:
                    sb.Append(ch);
                    break;
            }
        }
        var resultString = Regex.Replace(sb.ToString(), @"^\s+$[\r\n]*", string.Empty, RegexOptions.Multiline);
        return resultString;
    }

    public static string ValidateJson(string jsonText, string schemaText)
    {
        
        var serializer = new Manatee.Json.Serialization.JsonSerializer();
        var json = Manatee.Json.JsonValue.Parse(jsonText);
        var schemaJson = Manatee.Json.JsonValue.Parse(schemaText);
        var schema = new Manatee.Json.Schema.JsonSchema();
        schema.FromJson(schemaJson, serializer);
        Manatee.Json.Schema.JsonSchemaOptions.OutputFormat = Manatee.Json.Schema.SchemaValidationOutputFormat.Basic;

        var validationResults = schema.Validate(json);

        if (!validationResults.IsValid)
        {

            json = serializer.Serialize(validationResults);


            return JsonHelper.FormatJson(json.ToString());
        }
        else
        {
            return "";
        }

    }
    public static string ValidateSchema(string jsonText, string schemaText)
    {

        var serializer = new Manatee.Json.Serialization.JsonSerializer();
        var json = Manatee.Json.JsonValue.Parse(jsonText);
        var schemaJson = Manatee.Json.JsonValue.Parse(schemaText);
        var schema = new Manatee.Json.Schema.JsonSchema();
        schema.FromJson(schemaJson, serializer);
        Manatee.Json.Schema.JsonSchemaOptions.OutputFormat = Manatee.Json.Schema.SchemaValidationOutputFormat.Basic;
        

        var validationResults = schema.ValidateSchema();

        if (!validationResults.IsValid)
        {

            json = serializer.Serialize(validationResults);
            return JsonHelper.FormatJson(json.ToString());
        }
        else
        {
            return "";
        }

    }
}

