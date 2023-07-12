using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DefPersistenciadeObjetos
{
     [Serializable]
    class Pregunta
    {
        private int numero, puntaje;
        private string texto, respuesta;

        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }
        public int Puntaje
        {
            get
            {
                return puntaje;
            }
            set
            {
                puntaje = value;
            }
        }
        public string  Texto
        {
            get
            {
                return texto;
            }
            set
            {
                texto = value;
            }
        }
        public string Respuesta
        {
            get
            {
                return respuesta;
            }
            set
            {
                respuesta = value;
            }
        }

        public void leerRegistro()
        {
            Console.WriteLine(" ");
            Console.Write("Numero  => ");
            Numero = int.Parse(Console.ReadLine());
            Console.Write("Texto  => ");
            Texto = Console.ReadLine();
            Console.Write("Respuesta  => ");
            Respuesta = Console.ReadLine();
            Console.Write("Puntaje  => ");
            Puntaje = int.Parse(Console.ReadLine());
        }

         public void mostrar()
        {
            Console.WriteLine(Numero + " " + Texto + " " + Respuesta + " " + Puntaje);
        }

         public void escribir(BinaryWriter escritor)
         {
             escritor.Write(this.Numero);
             escritor.Write(this.Texto);
             escritor.Write(this.Respuesta);
             escritor.Write(this.Puntaje);
         }

         public void leer(BinaryReader lector)
         {
             this.Numero = lector.ReadInt32();
             this.Texto = lector.ReadString();
             this.Respuesta = lector.ReadString();
             this.Puntaje = lector.ReadInt32();
             
         }



    }
}
