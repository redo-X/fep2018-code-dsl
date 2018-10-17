namespace CodeGenDslParser.Models
{
    public class Attribute
    {
        public Attribute(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; }

        public string Value { get; }
    }
}
