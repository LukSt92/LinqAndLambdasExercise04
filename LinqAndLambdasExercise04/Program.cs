using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdasExercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            //TallGuy tallGuy = new TallGuy() {Name = "Jimmy", Height = 76 };
            //tallGuy.TalkAboutYourself();
            //Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}");
            //tallGuy.Honk();

            int[] values = new int[] { 0, 12, 44, 36, 92, 54, 13, 8 };
            IEnumerable<int> result =
                from v in values
                where v < 37
                orderby -v
                select v;

            var res = values.Where(v => v < 37).OrderBy(v => -v);
        }
    }
}
