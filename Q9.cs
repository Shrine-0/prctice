namespace Q91
{
    class Q9
    {
        public void Guess()
        {
            Random r = new Random();
            Console.WriteLine("Guess a number between 0 and 6: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = r.Next(0, 6);
            if (num == temp)
                Console.WriteLine($"you won : {temp}");
            else
                Console.WriteLine($"you lose try again : {temp}");

        }
    }
}