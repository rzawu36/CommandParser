using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    //Contains the drone commands
    public class Command
    {
       
        private String direction { get; set; }
        private String distance { get; set; }

        public Command(String direction, String distance)
        {
            this.direction = direction;
            this.distance = distance;
        }
       
        
        public override string ToString()
        {
            return "Direction: " + direction + ", Distance: " + distance;
        }









    }
}
    
