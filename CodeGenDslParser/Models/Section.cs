using System.Collections.Generic;

namespace CodeGenDslParser.Models
{
    public class Section
    {
        public Section(string id, string name, IEnumerable<Attribute> attributes)
        {
            Id = id;
            Name = name;
            Attributes = attributes;
        }

        public string Id { get; }

        public string Name { get; }

        public IEnumerable<Attribute> Attributes { get; }
    }
}
