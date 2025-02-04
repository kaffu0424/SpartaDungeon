using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartaDungeon.Module
{
    public class PlayerMessage
    {
        public static void Message(string _message, ConsoleColor _color)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;

            Console.ForegroundColor = _color;
            Console.WriteLine(_message);
            Console.ForegroundColor = defaultColor;
        }
    }
}
