using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DefPersistenciadeObjetos
{
    class BancoPreg
    {
       
         private string Nombre;
        public BancoPreg( string nombreArchivo ) {
            Nombre = nombreArchivo;
        }

        public void crearNuevo()
        {
            if (System.IO.File.Exists(Nombre))
            {
                Console.WriteLine("Realmente quiere borrar el archivo?. s/n");
                if (Console.ReadKey().KeyChar == 's')
                    System.IO.File.Delete(Nombre);
            }
            else
                Console.WriteLine("El archivo no existe.");
        }

        public void adicionar()
        {
            // Abrimos el archivo o se crea un nuevo archivo si no existe
            Stream arch = File.Open(Nombre, FileMode.Append);
            BinaryWriter escribe = new BinaryWriter(arch);
            Pregunta preg = new Pregunta();
            try
            {
                do
                {
                    preg.leerRegistro();
                    preg.escribir(escribe);
                    Console.Write("Desea continuar añadiendo registros? s/n => ");
                } while (Console.ReadKey().KeyChar == 's');
            }
            catch (Exception)
            {
                Console.WriteLine("Fallo en adicionar el objeto !!!");
            }
            finally
            {
                arch.Close();
            }
        }

        public void listar()
        {
            // Abrimos el archivo o se crea un nuevo archivo si no existe
            Stream arch = File.Open(Nombre, FileMode.OpenOrCreate);
            BinaryReader lee = new BinaryReader(arch);
            Pregunta preg = new Pregunta();
            try
            {
                while (true)
                {
                    preg.leer(lee);
                    preg.mostrar();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fin de archivo ...");
            }
            finally
            {
                arch.Close();
            }
        }
        public int pmax = 0;
        public void mayorpuntaje()
        {
           
            
            // Abrimos el archivo o se crea un nuevo archivo si no existe
            Stream arch = File.Open(Nombre, FileMode.OpenOrCreate);
            BinaryReader lee = new BinaryReader(arch);
            Pregunta preg = new Pregunta();
            try
            {
                while (true)
                {
                    
                    preg.leer(lee);
                    if (preg.Puntaje>pmax)
                    {
                        pmax = preg.Puntaje;
                       
                    }

                    
                    


                        
                    
                    
                }

                
            }
            catch (Exception)
            {
                Console.WriteLine(" ");
            }
            finally
            {
                 
                    arch.Close();
                
            }
            
        }

        public void calculoporcentaje(int x,int y,int z)
        {
            int cpunt = 0;
            // Abrimos el archivo o se crea un nuevo archivo si no existe
            Stream arch = File.Open(Nombre, FileMode.OpenOrCreate);
            BinaryReader lee = new BinaryReader(arch);
            Pregunta preg = new Pregunta();
            try
            {
                while (true)
                {
                    preg.leer(lee);
                    if (preg.Numero == x||preg.Numero == y||preg.Numero == z)
                    {
                        
                    }
                    else
                    {
                        cpunt = cpunt + preg.Puntaje;
                    }
                      


                    
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fin de archivo ...");
            }
            finally
            {
                Console.WriteLine("El puntaje obtenido es " + cpunt);
                arch.Close();
            }
        }
        public void mayorpuntaje1()
        {
            int pumax = pmax;
            // Abrimos el archivo o se crea un nuevo archivo si no existe
            Stream arch = File.Open(Nombre, FileMode.OpenOrCreate);
            BinaryReader lee = new BinaryReader(arch);
            Pregunta preg = new Pregunta();
            try
            {
                while (true)
                {

                    preg.leer(lee);
                    if (preg.Puntaje==pmax)
                    {
                        preg.mostrar();
                    }








                }


            }
            catch (Exception)
            {
                Console.WriteLine("Fin de archivo ...");
            }
            finally
            {

                arch.Close();

            }

        }
    }
}
