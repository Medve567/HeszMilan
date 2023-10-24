using HeszMilan;

namespace HeszMilan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bolygo> bolygo = new();
            using StreamReader sr = new(path: @"..\..\..\src\solsys.txt",
            encoding: System.Text.Encoding.UTF8);
            {
                while (!sr.EndOfStream) bolygo.Add(new Bolygo(sr.ReadLine()));
  
            }
            


            Console.WriteLine("1. Feladat:");
            Console.WriteLine($"{bolygo.Count} bolygó van a naprendszerben");

            Console.WriteLine("2. Feladat:");
            var atlag = bolygo.Average(p => p.HoldSzama);
            Console.WriteLine($"a naprendszerben egy bolygónak átlagosan {atlag} holdja van");

            Console.WriteLine("3. Feladat:");
            var legnagyobbTerfogatu = bolygo.OrderByDescending(p => p.TerfogatAranyF)
                .First();
            Console.WriteLine($"a legnagyobb térfogatú bolygó a {legnagyobbTerfogatu.Nev}");

            Console.WriteLine("4. Feladat:");
            Console.WriteLine("Írd be a kerestt bolygó nevét: ");
            string keres = Console.ReadLine();
            foreach (Bolygo item in bolygo)
            {
                if (keres == item.Nev)
                {
                    Console.WriteLine($"Keresett bolygó {keres} benne van.");
                }
                else
                {
                    Console.WriteLine($"sajnos nincs ilyen nevű bolygó a naprendszerben");
                }
            }

            Console.WriteLine("5. Feladat:");
            Console.WriteLine("Írj be egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());
            var keresH = bolygo.Where(p => p.HoldSzama > szam);
            if (keresH.Count() != 0)
            {
                Console.WriteLine($"a következő bolygónak van {keresH}-nál/nél több holdja: {szam}");
                foreach (var a in keresH)
                {
                    Console.Write($"'{a.}';");
                }
            }
            else Console.WriteLine($"Nincs ilyen ο(=•ω＜=)ρ⌒☆");
        }
    }



}
    
