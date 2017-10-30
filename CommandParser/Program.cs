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
            String stringCommand = "lx20,r32,d12,u12";
            List<Command> cmds = Parser.parseCommand(stringCommand);

            foreach (Command cmd in cmds)
            {
                Console.WriteLine(cmd.ToString());
            }
            Console.ReadLine();
        }
    }
}
