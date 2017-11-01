using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    public class Program
    {
        static void Main(string[] args)
        {
            String command = "l10, r22,14,u11";
            List<Command> cmds = Parser.parseCommand(command);

            foreach (Command cmd in cmds)
            {
                Console.WriteLine(cmd.ToString());
            }
            Console.ReadLine();
        }
    }
}
