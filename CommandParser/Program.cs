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
            List<Command> cmds = Parser.parseCommand("l2410,r3234,u32330,d2312");

            foreach (Command cmd in cmds)
            {
                Console.WriteLine(cmd.ToString());
            }
            Console.ReadLine();
        }
    }
}
