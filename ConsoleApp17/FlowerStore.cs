using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class FlowerStore
    {
        public List<string> Sell (int Roza , int Romashka, int Tulpan)
        {
            List <string> all = new List <string> ();
            for (int i = 0; i < Roza; i++)
            {
                all.Add ("Roza");
            }
            for (int i = 0; i < Romashka; i++)
            {
                all.Add("Romashka");
            }
            for (int i = 0; i < Tulpan; i++)
            {
                all.Add("Tulpan");
            }
            return all;
        }
    }
}
