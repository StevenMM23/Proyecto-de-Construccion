using Antlr4.Runtime;
using ProgrammingLanguageANTLR4;

var project = File.ReadAllText($"C:\\Users\\estev\\Desktop\\ProyectoLanguage\\ProgrammingLanguageANTLR4\\test.txt");

var inputStream = CharStreams.fromString(project);
var lexer = new SSJLexer(inputStream);
var tokenStream = new CommonTokenStream(lexer);
var parser = new SSJParser(tokenStream);

var tree = parser.program();
var visitor = new Visitor();

var translation = visitor.Visit(tree);
Console.WriteLine(translation);

Console.ReadKey(true);
