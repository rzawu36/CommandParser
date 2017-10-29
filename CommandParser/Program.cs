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
            List<Command> cmds = Parser.parseCommand("l24,r32,u30,d22");

            foreach (Command cmd in cmds)
            {
                Console.WriteLine(cmd.ToString());
            }
            Console.ReadLine();
        }
    }
}
