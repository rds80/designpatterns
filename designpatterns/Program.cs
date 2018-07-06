using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace designpatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimaryPlayer player = PrimaryPlayer.Instance;
            WriteLine($"{player.Name} - lvl {player.Level}");
            ReadKey();
        }
    }
}
