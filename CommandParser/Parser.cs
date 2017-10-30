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
            String[] commandsSplitByComma = stringToParse.Split(',');
            String[] commandsSplitBySemiColon = stringToParse.Split(';');

           if (commandsSplitByComma.Length > 0)
            {
                return splitString(commandsSplitByComma);
            }
           else if (commandsSplitBySemiColon.Length > 0)
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
                int distance;
               
                if (int.TryParse(words[1], out distance))
                {
                    Command c = new Command(direction, distance);
                    cmds.Add(c);
                }
                else
                {
                    distance = Int32.Parse(words[1]);
                    Command c = new Command(direction, distance);
                    String message = "Invalid Command Format";
                    BadCommand bc = new BadCommand(c, message);
                    badCmds.Add(bc);
                    bc.ToString();

                }




            }

            return cmds;
        }



    }





}
