using System;
using System.Collections.Generic;
using System.Text;

namespace CommandParser
{
    class BadCommand


    {


        private Command command { get; set; }
        private String message { get; set; }

        public BadCommand(Command cmd, String msg)
        {
            this.command = cmd;
            this.message = msg;
        }

        public override string ToString()
        {
            return "Message: " + message + ", Command " + command;
        }


    }
}
