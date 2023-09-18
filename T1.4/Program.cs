using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fcu = "please enter fcu (MPA) = ";
            Console.WriteLine(fcu);
            var FCU = Double.Parse(Console.ReadLine());
            
            var fy = "please enter fy (MPA) = ";
            Console.WriteLine(fy);
            var Fy = Double.Parse(Console.ReadLine());

            var width = "please enter Width (mm2) = ";
            Console.WriteLine(width);
            var Width = Double.Parse(Console.ReadLine());
           
            var depth = "please enter Depth (mm2) = ";
            Console.WriteLine(depth);
            var Depth = Double.Parse(Console.ReadLine());
            
            var AC  = Width * Depth;
            Console.WriteLine("AC = "+ AC + "mm2");
            var As = 0.01 * AC;
            Console.WriteLine("AS = " + As + " mm2");
           
            Console.WriteLine("Pu = 0.35 * AC * fcu + 0.67 * As * Fy");
            var Pu = 0.35 * AC * FCU + 0.67 * As * Fy;
            Console.WriteLine("Pu = " + Pu * 0.001 + " Kn");


        }
    }
}
