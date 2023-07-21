using System;



namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Kanye: {RonVSKanyeAPI.Kanye()}");

                Console.WriteLine($"Ron Swanson: {RonVSKanyeAPI.Ron()}");

            }
        }
    }
}
