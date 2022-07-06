using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class FlowerStore
    {
        
        int Wallet = 0;
        List<Flower> AllFlowers = new List<Flower>();
        public List<Flower> Sell (int Roza , int Romashka, int Tulpan)
        {
            List <Flower> all = new List <Flower> ();
            for (int i = 0; i < Roza; i++)
            {
                Roza roza = new Roza();
                all.Add (roza);
                Wallet += roza.Price;
            }
            for (int i = 0; i < Romashka; i++)
            {
                Romashka romashka = new Romashka();
                all.Add(romashka);
                Wallet += romashka.Price;
            }
            for (int i = 0; i < Tulpan; i++)
            {
                Tulpan roulpan = new Tulpan();
                all.Add(roulpan);
                Wallet += roulpan.Price;
            }
            return all;
        }
        public List<Flower> sellSequence(int Roza, int Romashka, int Tulpan)
        {
            List<Flower> all = new List<Flower>();
            int vsego= Roza + Romashka + Tulpan;
            for (int i =0; i< vsego; i++)
            {
                if(Roza!=0)
                {
                    Roza roza = new Roza();
                    all.Add(roza);
                    Wallet += roza.Price;
                    Roza--;
                }
                if (Romashka != 0)
                {
                    Romashka romashka = new Romashka();
                    all.Add(romashka);
                    Wallet += romashka.Price;
                    Romashka--;
                }
                if (Tulpan != 0)
                {
                    Tulpan roulpan = new Tulpan();
                    all.Add(roulpan);
                    Wallet += roulpan.Price;
                    Tulpan--;
                }
            }
            return all;
        }
        private void AddFlower ()
        {
            ConsoleKeyInfo k;
            int count;
            Console.WriteLine("What flowers to add?");
            Console.WriteLine("1-Roza , 2 -Romashka  , 3 - Toulpan");
            k = Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("How much to add?");
            if (k.Key == ConsoleKey.D1 && k.Key == ConsoleKey.NumPad1)
            {
                AddFlowers();
            }
           else  if (k.Key == ConsoleKey.D1 && k.Key == ConsoleKey.NumPad1)
            {
                AddFlowers();
            }
        }
    }
}
