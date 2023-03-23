using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;

namespace ProgrammingLanguageANTLR4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var project = File.ReadAllText($"C:\\Users\\estev\\Desktop\\ProyectoLanguage\\ProgrammingLanguageANTLR4\\test.txt");
            var inputStream = CharStreams.fromString(project);
            var lexer = new SSJLexer(inputStream);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new SSJParser(tokenStream);

            var tree = parser.program();
            var visitor = new myVisitor();

            var translation = visitor.Visit(tree);
            Console.WriteLine(translation);

            Console.ReadKey(true);
        }
    }
}
