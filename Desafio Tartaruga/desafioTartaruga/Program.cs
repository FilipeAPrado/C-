using System;

namespace desafioTartaruga
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Informe o numero de tartarugas");
          int  numOfTurtles = Int32.Parse(Console.ReadLine());
            int fastestTurtle = 0;

            int[] velocityTurtles = new int[numOfTurtles];
            foreach(int cont in velocityTurtles)
            {
                Console.WriteLine("qual velocidade da tartaruga : ");
                velocityTurtles[contador] = Int32.Parse(Console.ReadLine());
                contador++;
            }
            
            contador = 0;
            foreach (int velocity in velocityTurtles)
            {
                
                if(fastestTurtle < velocityTurtles[contador])
                {
                    fastestTurtle = velocityTurtles[contador];
                    contador++;
                }
            }

            if(fastestTurtle >= 20)
            {
                Console.WriteLine(3);
            }
            else if(fastestTurtle >= 10 && fastestTurtle <20)
            {
                Console.WriteLine(2);
            }
            else
            {
                Console.WriteLine(1);
            }
            Console.Write(fastestTurtle);
            Console.ReadLine();

        }
    }
}
