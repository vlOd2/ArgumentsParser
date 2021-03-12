# ArgumentsParser
A library for C# that allows you to easily parse console arguments.

# How to use
Using ArgumentsParser is no hard task.

Here is an example of a simple usage of ArgumentsParser:
```
static void Main(string[] RawArgs)
{
      ArgsParser argsparser = new ArgsParser();

      foreach (string arg in argsparser.ParseArguments(RawArgs))
      {
          Console.WriteLine($"{argsparser.GetArgumentName(arg)} is equal to {argsparser.GetArgumentValue(arg)}");
      }
      Console.ReadLine();
}
```