using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefPersistenciadeObjetos
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool sw = true;
           
            while (sw)
            {

                Console.WriteLine("\n                                        ");
                Console.WriteLine("          MENU                          ");
                Console.WriteLine("          ====                          ");
                Console.WriteLine("                                        ");
                Console.WriteLine("1. CREAR                                ");
                Console.WriteLine("2. ADICION                              ");

                Console.WriteLine("3. LISTADO                              ");
                Console.WriteLine("4. CALCULO PORCENTAJE                   ");
                Console.WriteLine("5. MAYOR PUNTAJE                        ");
                

                Console.WriteLine("6. SALIR                                ");
                Console.WriteLine("                                        ");
                Console.Write("INTRODUSCA  UNA  OPCION             =>  ");
                // leemos un caracter si esta en el intervalo 1-6 hace las 
                // Opciones que se detallan si es 7 o otro caracter sale del programa
                // haciendo un beep
                BancoPreg ejemplo = new BancoPreg(@"e:\datos.dat");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        ejemplo.crearNuevo();
                        break;
                    case '2':
                        
                        ejemplo.adicionar();

                        break;
                    case '3':
                        Console.WriteLine(" ");
                        ejemplo.listar();

                        break;
                    case '4':
                        Console.WriteLine(" ");
                        Console.WriteLine("Introduzca x");
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca y");
                        int y = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduzca z");
                        int z = int.Parse(Console.ReadLine());
                        ejemplo.calculoporcentaje(x,y,z);
                        
                        break;
                    case '5':
                         Console.WriteLine(" ");
                         ejemplo.mayorpuntaje();
                        ejemplo.mayorpuntaje1();
                        break;
                    
                    default:
                        Console.WriteLine("\n   El programa ya termino  !!!");
                        // La siguiente linea provoca un bip de la maquina.
                        //Console.Beep();
                        sw = false;
                        break;
                }
            }
        }
    }
}
