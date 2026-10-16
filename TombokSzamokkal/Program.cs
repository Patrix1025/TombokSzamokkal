namespace TombokSzamokkal
{
    internal class Program
    {
        static int[] tomb = new int[15];
        static Random r= new Random();
        static void Feltolt()
        {            
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(-20, 21);
            }
            foreach(int item in tomb)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Osszegzes()
        {
            int osszeg = 0;
            foreach (int item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine("A tömb elemeinek összege: " + osszeg);
        }

        static void Megszamlalas()
        {
            int negativ = 0;
            int pozitiv = 0;
            foreach (int item in tomb)
            {
                if (item < 0)
                {
                    negativ++;
                }
                else if (item > 0)
                {
                    pozitiv++;
                }
            }
            Console.WriteLine("Negatív számok száma: " + negativ);
            Console.WriteLine("Pozitív számok száma: " + pozitiv);
        }

        static void Eldontes()
        {
            int i = 0;
            while (i < tomb.Length && tomb[i] != 0)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van 0 a tömbben.");

            }
            else
            {
                Console.WriteLine("Nincs 0 a tömbben.");

            }
        }

        static void Kereses()
        {
            int keresett = 0;
            int i = 0;
            while (i < tomb.Length && tomb[i] != keresett)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine($"A keresett szám az {i}. indexben található.");
            }
            else
            {
                Console.WriteLine("A keresett szám nincs a tömbben.");
            }
        }

        static void Kivalasztas()
        {
            tomb[8] = 10;
            int i = 0;
            while (tomb[i] != 10)
            {
                i++;
            }
            Console.WriteLine($"A keresett szám megtalálható az {i + 1}. helyen");
        }


        static void Main(string[] args)
        {
            Feltolt();
            Osszegzes();
            Megszamlalas();
            Eldontes();
            Kereses();
            Kivalasztas();
            
        }
    }
}
