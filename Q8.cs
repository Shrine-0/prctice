namespace Q81
{
    class Q8
    {
                string c ="",c1= "";
        public void Wrr()
        {
            Console.WriteLine("Added Value for a ,b ,c Respectively");
            int a1 = Convert.ToInt32(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            /**try{
            string c1 = Console.ReadLine();//not taking input in HELP!!!
            }catch(Exception e){
                Console.WriteLine(e.Message);
            }**/
            string c1 = Console.ReadLine();
            string con = a1+b1+c1;
            Console.WriteLine($"Concatenated value is : {con}");
            Double tot = Convert.ToDouble(a1)+Convert.ToDouble(b1)+System.Convert.ToDouble(c1);
            Console.WriteLine($"Total is : {tot}");
        }
    }
}
