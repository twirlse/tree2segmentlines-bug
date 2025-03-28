
using Spectre.Console;
using Spectre.Console.Rendering;

var textWriter = new StringWriter();
var console = AnsiConsole.Create(new AnsiConsoleSettings());

var tree = new Tree("Root");
var child = tree.AddNode("Child 1");
var child2 = child.AddNode("Child 2");

var segments = tree.GetSegments(console);
var lines = Segment.SplitLines(segments);
