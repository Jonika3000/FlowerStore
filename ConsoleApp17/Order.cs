using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Order
    {
        private int _id;
        List<Flower> _flowers = new List<Flower>();
        bool status;
        public int id
        { get { return id; } set { id = value; } }
        public List<Flower> flowers
        { get { return _flowers; } set { _flowers = value; } }
       public  Order( int num)
        {
            status = false;
            
            id = num;
        }
    }
}
