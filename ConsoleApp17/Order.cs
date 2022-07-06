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
        bool _status;
        public int id
        { get { return _id; } set { _id = value; } }
        public List<Flower> flowers
        { get { return _flowers; } set { _flowers = value; } }
        public bool Status
        { get { return _status; } set { _status = value; } }
        public  Order( int num)
        {
            _status = false;
            
            id = num;
        }
    }
}
