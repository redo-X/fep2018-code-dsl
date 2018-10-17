using System;
using System.IO;
using Sprache;
using Xunit;

namespace CodeGenDslParser.Tests
{
    public class StackTests
    {
        [Fact]
        public void AnIdentifierIsASequenceOfCharacters()
        {
            var input = File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "Resources", "DslSample01.txt"));

            var result = Grammar.ParseText(input);
        }
    }
}
