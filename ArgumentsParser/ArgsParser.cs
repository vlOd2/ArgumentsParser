using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArgumentsParser
{
    public class ArgsParser
    {
        public List<string> ParseArguments(string[] RawArgs, string ArgumentSeparator = "-")
        {
            Dictionary<string, string> DecodedArgs = new Dictionary<string, string>();
            List<string> ParsedArgs = new List<string>();

            try
            {
                for (int i = 0; i < RawArgs.Length; i++)
                {
                    DecodedArgs.Add(RawArgs[i].Replace(ArgumentSeparator, null), RawArgs[i + 1]);
                    i += 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Couldn't decode the raw arguments.", ex);
            }

            try
            {
                foreach (var Arg in DecodedArgs)
                {
                    ParsedArgs.Add($"{Arg.Key}={Arg.Value}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Couldn't parse the decoded arguments.", ex);
            }

            return ParsedArgs;
        }

        public string GetArgumentName(string ParsedArg)
        {
            try
            {
                string ArgumentName = ParsedArg.Split('=')[0];
                return ArgumentName;
            }
            catch (Exception ex)
            {
                throw new Exception("Couldn't get the Argument's name.", ex);
            }
        }

        public string GetArgumentValue(string ParsedArg)
        {
            try
            {
                string ArgumentValue = ParsedArg.Split('=')[1];
                return ArgumentValue;
            }
            catch (Exception ex)
            {
                throw new Exception("Couldn't get the Argument's value.", ex);
            }
        }
    }
}
