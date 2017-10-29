using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    //Contains the parsing logic
    public class Parser
    {

        public static List<Command> parseCommand(String stringToParse)
        {
            String[] commands = stringToParse.Split(',');
            List<Command> cmds = new List<Command>();

            
            foreach (String word in commands)
            {
                char[] delimiterChars = { 'l', 'r', 'u', 'd' };
                string[] words = word.Split(delimiterChars, 2);
                String direction = word.Substring(0, 1);
                int distance = Int32.Parse(words[1]);
                Command c = new Command(direction, distance);
                cmds.Add(c);
            }

            return cmds;
        }


        }
}
