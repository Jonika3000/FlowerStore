namespace ConsoleApp17
{
    internal class FlowerStore
    {

        public int Wallet = 0;
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
                }
                
            }
            for (int i = 0; i < Romashka1; i++)
            {
                bool allHas = AllFlowers.Any(s => s.GetType() == typeof(Roza));
                if (allHas == true)
                {
                    Romashka romashka = new Romashka();
                    all.Add(romashka);
                    
                }
            }
            for (int i = 0; i < Tulpan1; i++)
            {
                bool allHas = AllFlowers.Any(s => s.GetType() == typeof(Roza));
                if (allHas == true)
                {
                    Tulpan roulpan = new Tulpan();
                    all.Add(roulpan);
                   
                }
            }
            return all;
        }
       public void ShowAll()
        {
            for (int i = 0; i < AllFlowers.Count; i++)
            {
                if (AllFlowers[i].GetType() == typeof(Romashka))
                {
                    Console.Write("Chamomile,");
                }
                if (AllFlowers[i].GetType() == typeof(Roza))
                {
                    Console.Write("Rose,");
                }
                if (AllFlowers[i].GetType() == typeof(Tulpan))
                {
                    Console.Write("Tulip,");
                }
            }
            Console.Write(".");
            Console.WriteLine();
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
            int vsego = Roza + Romashka + Tulpan;
            for (int i = 0; i < vsego; i++)
            {
                if (Roza != 0)
                {
                    Roza roza = new Roza();
                    all.Add(roza);
                    Roza--;
                }
                if (Romashka != 0)
                {
                    Romashka romashka = new Romashka();
                    all.Add(romashka);
                    
                    Romashka--;
                }
                if (Tulpan != 0)
                {
                    Tulpan roulpan = new Tulpan();
                    all.Add(roulpan);
                    
                    Tulpan--;
                }
            }
            return all;
        }
        public void Del (Order r)
        {
            for (int i = 0; i <r.flowers.Count;i++)
            {
                if (r.flowers[i].GetType() == typeof(Roza))
                {
                    DeleteRoza();
                    Wallet += r.flowers[i].Price;
                }
                if (r.flowers[i].GetType() == typeof(Romashka))
                {
                    DeleteRomashka();
                    Wallet += r.flowers[i].Price;
                }
                if (r.flowers[i].GetType() == typeof(Tulpan))
                {
                    DeleteTulpan();
                    Wallet += r.flowers[i].Price;
                }
            }
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
                if (k.Key == ConsoleKey.D1 || k.Key == ConsoleKey.NumPad1)
                {
                    Roza r = new Roza();
                    AllFlowers.Add(r);
                }
                else if (k.Key == ConsoleKey.D2 || k.Key == ConsoleKey.NumPad2)
                {
                    Romashka r = new Romashka();
                    AllFlowers.Add(r);
                }
                else if (k.Key == ConsoleKey.D3 || k.Key == ConsoleKey.NumPad3)
                {
                    Tulpan r = new Tulpan();
                    AllFlowers.Add(r);
                }
            }

        }
    }
}
