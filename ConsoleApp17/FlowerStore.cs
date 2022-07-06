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
        public List<Flower> Sell (int Roza1 , int Romashka1, int Tulpan1)
        {
            List <Flower> all = new List <Flower> ();
            for (int i = 0; i < Roza1; i++)
            {
                bool allHas = AllFlowers.Any(s => s.GetType() == typeof(Roza));
                if (allHas == true)
                {
                    Roza roza = new Roza();
                    all.Add(roza);
                    Wallet += roza.Price;
                    DeleteRoza();
                }
                
            }
            for (int i = 0; i < Romashka1; i++)
            {
                bool allHas = AllFlowers.Any(s => s.GetType() == typeof(Roza));
                if (allHas == true)
                {
                    Romashka romashka = new Romashka();
                    all.Add(romashka);
                    Wallet += romashka.Price;
                    DeleteRomashka();
                }
            }
            for (int i = 0; i < Tulpan1; i++)
            {
                bool allHas = AllFlowers.Any(s => s.GetType() == typeof(Roza));
                if (allHas == true)
                {
                    Tulpan roulpan = new Tulpan();
                    all.Add(roulpan);
                    Wallet += roulpan.Price;
                    DeleteTulpan();
                }
            }
            return all;
        }
        void DeleteRoza()
        {
            for (int i =0; i< AllFlowers.Count;i++)
            {
                if (AllFlowers[i].GetType() == typeof(Roza))
                {
                    AllFlowers.Remove(AllFlowers[i]);
                    break;
                }
            }
        }
        void DeleteTulpan()
        {
            for (int i = 0; i < AllFlowers.Count; i++)
            {
                if (AllFlowers[i].GetType() == typeof(Tulpan))
                {
                    AllFlowers.Remove(AllFlowers[i]);
                    break;
                }
            }
        }
        void DeleteRomashka()
        {
            for (int i = 0; i < AllFlowers.Count; i++)
            {
                if (AllFlowers[i].GetType() == typeof(Romashka))
                {
                    AllFlowers.Remove(AllFlowers[i]);
                    break;
                }
            }
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
        public void AddFlower ()
        {
            ConsoleKeyInfo k;
            int count;
            Console.WriteLine("What flowers to add?");
            Console.WriteLine("1-Roza , 2 -Romashka  , 3 - Toulpan");
            k = Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("How much to add?");
            count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                if (k.Key == ConsoleKey.D1 && k.Key == ConsoleKey.NumPad1)
                {
                    Roza r = new Roza();
                    AllFlowers.Add(r);
                }
                else if (k.Key == ConsoleKey.D1 && k.Key == ConsoleKey.NumPad1)
                {
                    Romashka r = new Romashka();
                    AllFlowers.Add(r);
                }
                else if (k.Key == ConsoleKey.D3 && k.Key == ConsoleKey.NumPad3)
                {
                    Tulpan r = new Tulpan();
                    AllFlowers.Add(r);
                }
            }

        }
    }
}
