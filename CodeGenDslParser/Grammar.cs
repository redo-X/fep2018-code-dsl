using CodeGenDslParser.Models;
using Sprache;

namespace CodeGenDslParser
{
    public class Grammar
    {
        public static Section ParseText(string text)
        {
            return Section.End().Parse(text);
        }

        public static Parser<string> Identifier = Parse.Letter.AtLeastOnce().Text().Token();

        public static Parser<string> QuotedText =
            (from lquot in Parse.Char('"')
             from content in Parse.CharExcept('"').Many().Text()
             from rquot in Parse.Char('"')
             select content).Token();

        public static Parser<Attribute> Attribute =
            (from key in Identifier
            from equal in Parse.Char('=')
            from value in QuotedText
            select new Attribute(key, value)).Token();

        public static Parser<Section> Section =
            from id in Identifier
            from title in QuotedText

            from attributesLBracket in Parse.Char('[')
            from attributes in Attribute.DelimitedBy(Parse.Char(','))
            from attributesRBracket in Parse.Char(']').Token()

            from lbracket in Parse.Char('{').Token()
            from rbracket in Parse.Char('}').Token()

            select new Section(id, title, attributes);
    }
}
