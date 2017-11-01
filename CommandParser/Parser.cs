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
            string stringWithNoSpaces = new string(stringToParse.Where(c => !char.IsWhiteSpace(c)).ToArray());
            String[] commandsSplitByComma = stringWithNoSpaces.Split(',');
            String[] commandsSplitBySemiColon = stringWithNoSpaces.Split(';');

           if (commandsSplitByComma.Length > 1)
            {
                
                return splitString(commandsSplitByComma);
            }
           else if (commandsSplitBySemiColon.Length > 1)
            {
                return splitString(commandsSplitBySemiColon);
            }
           else
            {
                return null;
            }
            

            
            
                
                
                
                
            }

        private static List<Command> splitString(String[] arrayOfCommands)
        {
            List<Command> cmds = new List<Command>();
            List<BadCommand> badCmds = new List<BadCommand>();


            foreach (String word in arrayOfCommands)
            {
                char[] delimiterChars = { 'l', 'r', 'u', 'd' };
                string[] words = word.Split(delimiterChars, 2);
                String direction = word.Substring(0, 1);
                String distance;
                int dist;
                

                


                if (isCommand(word) && int.TryParse(words[words.Length - 1], out dist))
                {
                    Command c = new Command(direction, dist.ToString());
                    cmds.Add(c);
                }
                else
                {
                    distance = words[words.Length - 1];
                    int dirChecker = 0;
                    Int32.TryParse(direction, out dirChecker);
                    if (dirChecker != 0)
                    {
                        direction = "Direction Unknown!";
                    }
                    Command c = new Command(direction, distance.ToString());
                    String message = "Invalid";
                    BadCommand bc = new BadCommand(c, message);
                    badCmds.Add(bc);
                    Console.WriteLine(bc.ToString());

                }

            }

            return cmds;

            bool isCommand(String command)
            {
                int checker = 0;
                Int32.TryParse(command, out checker);
                if (checker != 0) {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
        }

        



    }





}
