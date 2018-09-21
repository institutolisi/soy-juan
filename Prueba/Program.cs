using System;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
           // string lineaescrita = Console.ReadLine();
           // Console.WriteLine("ested escribio: " + lineaescrita);
           // int numero=0;
           // int numero2=5
           // Console.WriteLine(numero+numero2);
        
           // int i;
          //for ( i=1; i<10; i++)
          //{
             // Console.WriteLine("numero:" +i);
          // if (i% 2==0)
          // Console.WriteLine(i + "es numero par");
          // else
           //  Console.WriteLine(i+ "es numero impar");
           Console.WriteLine("escribe un numero:");
           int numero;
           if (int.TryParse(Console.ReadLine(), out numero))
             // Console.WriteLine(numero+1);
              {
                  int result=1; 
                  for (int i=2; i<=numero;i++ )
                  result=result*i;
                  Console.WriteLine($"El factorial de {numero} es {result}.");

              }
            else
            Console.WriteLine("no escribiste un numero adios.");
            
          // int numero =int.Parse(Console.ReadLine());
          // Console.WriteLine(numero+1);
        //  }

        }
        
        int siguiente (int numero)
        {
            return numero +1;
        }
    }
}
