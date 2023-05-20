using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores1
{
    class Program
    {
        static void Main(string[] args)
        {

            //TAREAAAAAAAAAAAA= CICLAR EL PROGRAMA
            //SI INTRODUZCO LA PRIMERA OPCION, NECESITO VER LA SEGUNDA OPCION
            int op;
            int [] Vector = new int[7];
            int acumsuma=0; // El valor de esta variable no es constante
            int acumresta = 0;
            int acumultiplicacion = 1;
      

            do{

                Console.BackgroundColor = ConsoleColor.Black;   
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("******* MENÚ *******");
                Console.WriteLine("1.- Llenado del Vector");
                Console.WriteLine("2.- Visualizar el Vector");
                Console.WriteLine("3.- Suma de los elementos del Vector");
                Console.WriteLine("4.- Resta de los elementos del Vector");
                Console.WriteLine("5.- Multiplicación de los elementos del Vector");
                Console.WriteLine("6.- Salir"); 
                Console.WriteLine("DIGITE LA OPCION QUE DESEE: ");
                op = int.Parse(Console.ReadLine());




                switch (op)
                {
                    case 1:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Clear(); 
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("****LLENADO DEL VECTOR****");

                        for (int indice = 0; indice <7; indice++) //para el llenado del vector
                        {
                            Console.WriteLine("Ingresa el dato " + (indice + 1).ToString());
                            Vector[indice] = int.Parse(Console.ReadLine());//Llenado del vector
                            Console.WriteLine(" ");

                        }

                        break;


                    case 2:

                        Console.Clear();

                        Console.WriteLine("****VISUALIZAR EL VECTOR****");


                            Console.Write("--------------------------------------------------");
                            Console.WriteLine(" ");
                     
                            Console.Write(" ");
                            Console.Write(" | ");
                            Console.Write(" ");
                       
                            Console.Write(Vector[0].ToString()); //Visualizar el vector
                            Console.Write(" ");
                         
                            Console.Write(" | ");
                     
                            Console.Write(" ");
                            Console.Write(Vector[1].ToString());
                   
                            Console.Write(" ");
                            Console.Write(" | ");
                            Console.Write(" ");
                  
                            Console.Write(Vector[2].ToString());
                            Console.Write(" ");
             
                            Console.Write(" | ");
                            Console.Write(" ");
                   
                            Console.Write(Vector[3].ToString());
                            Console.Write(" ");
                  
                            Console.Write(" | ");
     
                            Console.Write(" ");
                            Console.Write(Vector[4].ToString());
                            Console.Write(" ");
          
                            Console.Write(" | ");
     
                            Console.Write(" ");
                            Console.Write(Vector[5].ToString());
             
                            Console.Write(" ");
                            Console.Write(" | ");
                            Console.Write(" ");
  
                            Console.Write(Vector[6].ToString());
      
                            Console.Write(" ");
                            Console.Write(" | ");
  
                            Console.Write(" ");
                            Console.WriteLine(" "); 
                            Console.Write("--------------------------------------------------");


                      

                        Console.ReadLine();
                            break;

                    case 3:

                        Console.Clear();

                        Console.WriteLine("****SUMA DE LOS ELEMENTOS DEL VECTOR****");
                        acumsuma = 0; 


                      for (int indice=0; indice < Vector.Length; indice++)
                        {

                            acumsuma += Vector[indice]; // acumsuma= acumsuma +Vector[indice]; ES LO MISMO

                        }

                        Console.Write(Vector[0].ToString()); Console.Write(" + ");  Console.Write(Vector[1].ToString()); Console.Write(" + ");  Console.Write(Vector[2].ToString()); Console.Write(" + ");  Console.Write(Vector[3].ToString()); Console.Write(" + ");  Console.Write(Vector[4].ToString()); Console.Write(" + ");  Console.Write(Vector[5].ToString()); Console.Write(" + ");  Console.Write(Vector[6].ToString()); Console.Write(" = "); Console.Write(acumsuma.ToString());

                        // Console.WriteLine("El resultado de la suma es: " + acumsuma.ToString()); // Se pobe afuera delk for porque sino se cicla y aparece muchas veces
                        Console.ReadLine();

                            break;

                    case 4:

                        Console.Clear(); 
                        Console.WriteLine("****RESTA DE LOS ELEMENTOS DEL VECTOR****");

                        acumresta = 0; 

                        for (int indice = 0; indice < Vector.Length; indice++)
                        {

                            acumresta = acumresta - Vector[indice]; // acumresta -= Vector[indice];; ES LO MISMO

                        }

                        Console.Write("    "); Console.WriteLine(Vector[0].ToString());
                        Console.WriteLine(" - ");
                        Console.Write("    "); Console.WriteLine(Vector[1].ToString());
                        Console.WriteLine(" - ");
                        Console.Write("    "); Console.WriteLine(Vector[2].ToString());
                        Console.WriteLine(" - ");
                        Console.Write("    "); Console.WriteLine(Vector[3].ToString());
                        Console.WriteLine(" - ");
                        Console.Write("    "); Console.WriteLine(Vector[4].ToString());
                        Console.WriteLine(" - ");
                        Console.Write("    "); Console.WriteLine(Vector[5].ToString());
                        Console.WriteLine(" - ");
                        Console.Write("    "); Console.WriteLine(Vector[6].ToString());
                        Console.WriteLine("--------------");
                        Console.WriteLine(acumresta.ToString());




                       // Console.WriteLine("El resultado de la resta es: " + acumresta.ToString());
                        Console.ReadLine();

                        break;

                    case 5:

                        Console.Clear();
                        Console.WriteLine("****MULTIPLICACION DE LOS ELEMENTOS DEL VECTOR****");

                        acumultiplicacion = 1;

                        for (int indice = 0; indice < Vector.Length; indice++)
                        {

                            acumultiplicacion *= Vector[indice]; //acummultiplicacion= acummultiplicacion * Vector[indice]; 
                            Console.Write(acumultiplicacion.ToString()); Console.Write(" x "); Console.Write(Vector[indice].ToString()); Console.Write(" = "); Console.WriteLine(acumultiplicacion.ToString());

                        }

                       
                       // Console.WriteLine("El resultado de la multiplicacion es: " + acumultiplicacion.ToString());
                        Console.ReadLine(); 

                        break;
                }


            } while (op != 6);

        }
    }
}
