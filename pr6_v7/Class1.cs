using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr6_v7
{
    class Triad
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Therd { get; set; }

        public Triad(int first, int second, int therd)
        {
            First = first;
            Second = second;
            Therd = therd;
        }

        public static bool operator >(Triad p1, Triad p2)
        {
            return p1.First > p2.First || p1.First == p2.First && p1.Second > p2.Second && p1.Therd > p2.Therd;
        }

        public static bool operator <(Triad p1, Triad p2)
        {
            return p1.First < p2.First && (p1.Second < p2.Second || p1.Second == p2.Second) && (p1.Therd < p2.Therd || p1.Therd == p2.Therd);
        }

        public static Triad operator ++(Triad triad)
        {
            triad.First += 10;
            triad.Second += 10;
            triad.Therd += 10;

            return triad;
        }
    }
}
