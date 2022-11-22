using System;
namespace myproject
{  
    class Program
    {
        void garis(int g)
        {
            for(int i = 0; i < g; i++)
            {
                Console.Write("**");      
            }           
        }
        static void Main(string[] args)
        {   Random rand = new Random();
            gariss G = new gariss();
            int nyawa = 3;
            int nilai = 0; 
            garis(15);            
            while(nyawa > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("hp : "+nyawa+"       nilai : "+nilai);
                int angka1 = rand.Next(0,10);
                int angka2 = rand.Next(0,10);
                int hasil = angka1 + angka2;
                Console.Write($"hasil dari {angka1} + {angka2} ? ");
                int jawaban = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                if(jawaban==hasil)
                {
                    Console.WriteLine("Benar");
                    nilai++;
                }
                else
                {
                    Console.WriteLine("Salah");
                    nyawa--;
                }
                Console.WriteLine("");
                garis(15);
            }
            Console.WriteLine("");
            Console.WriteLine("Game Over");
            Console.WriteLine("");
            Console.WriteLine("nilai : "+nilai);            
        }
    }
}
