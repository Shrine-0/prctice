// See https://aka.ms/new-console-template for more information
namespace Q61
{
    class Infoj
    {
        public int i { set; get; }
        public int j { set; get; }
        public int k { set; get; }

        public void Getinfo()
        {
            Infoj e = new Infoj();
            Console.Write("First-Term score :");
            e.i = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Second-Term score :");
            e.j = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            Console.Write("Final-Term Marks :");
            e.k = Convert.ToInt32(Console.ReadLine());
            float temp = (((e.i + e.j + e.k)));
            float Avg = (temp / 300) * 100;
            if (Avg >= 90)
            {
                Console.WriteLine($"Grade A : {Avg}");
            }
            else if (Avg >= 70 && Avg < 90)
            {
                Console.WriteLine($"Grade B : {Avg}");
            }
            else if (Avg >= 50 && Avg < 70)
            {
                Console.WriteLine($"Garde C : {Avg}");
            }
            else if (Avg >= 35 && Avg < 50)
            {
                Console.WriteLine($"Garde D : {Avg}");
            }
            else
            {
                Console.WriteLine($"Grade F : {Avg}");
            }
        }
    }

}