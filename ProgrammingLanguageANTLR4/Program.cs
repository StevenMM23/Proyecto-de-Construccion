using Antlr4.Runtime;
using ProgrammingLanguageANTLR4;

var project = File.ReadAllText($"{Environment.CurrentDirectory}/Files/test.txt");

var inputStream = CharStreams.fromString(project);
var lexer = new SSJLexer(inputStream);
var tokenStream = new CommonTokenStream(lexer);
var parser = new SSJParser(tokenStream);

var tree = parser.program();
var visitor = new Visitor();

var translation = visitor.Visit(tree).ToString();
Console.WriteLine(translation);

// Console.ReadKey(true);
