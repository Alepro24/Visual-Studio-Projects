using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PracticaFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string ruta = @"V:\estudiantes.txt";
            if (ruta == " ")
            {
                StreamWriter escribir = new StreamWriter(ruta, true);
                escribir.WriteLine("Alarcon Gonzalo,Aguirre Fernanda,Brito Alan,Carrasco Daniel,Fernadez Luis,Gonzales Maria,Mariaca Pablo,Perez Dilan,Ramos Jaime,Zamora Belen ");
                escribir.Close();
            }
            dataGridView1.Hide();
            label1.Hide();
            label2.Hide();
            comboBox1.Hide();
            comboBox2.Hide();
            button1.Hide();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            label1.Show();
            label2.Show();
            comboBox1.Show();
            comboBox2.Show();
            button1.Show();
            comboBox2.SelectedIndex = 0;

            StreamReader contenido = new StreamReader(@"V:\estudiantes.txt");
            string conte = contenido.ReadToEnd();
            string[] est = conte.Split(',');
            
            string contenidos = ("Alarcon Gonzalo,70,56,88,35,100,89|Aguirre Fernanda,89,67,87,95,68,78|Brito Alan,96,56,87,76,71,50|Carrasco Daniel,90,87,97,56,34,100|Fernadez Luis,76,98,93,85,83,78|Gonzales Maria,87,98,95,96,93,84|Mariaca Pablo,87,76,97,45,100,78|Perez Dilan,45,76,23,57,64,69|Ramos Jaime,56,87,65,45,86,90|Zamora Belen,56,87,98,67,85,100 ");
            string[] registros = contenidos.Split('|');

            foreach(string registro in registros)
            {
                string[] notas = registro.Split(',');
                dataGridView1.Rows.Add(notas[0], notas[1], notas[2], notas[3],notas[4],notas[5],notas[6]);
            }
            
           
            
            /*for (int j = 0; j <= 9; j++)
           {
                dataGridView1.Rows[j].Cells[0].Value = est[j];
                

           }*/
            
                
        }
        string contenidos = ("Alarcon Gonzalo,70,56,88,35,100,89|Aguirre Fernanda,89,67,87,95,68,78|Brito Alan,96,56,87,76,71,50|Carrasco Daniel,90,87,97,56,34,100|Fernadez Luis,76,98,93,85,83,78|Gonzales Maria,87,98,95,96,93,84|Mariaca Pablo,87,76,97,45,100,78|Perez Dilan,45,76,23,57,64,69|Ramos Jaime,56,87,65,45,86,90|Zamora Belen,56,87,98,67,85,100 ");
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0)
            {
                string ruta = @"V:\PracticasPrimerParcial.txt";
                StreamWriter escribir = new StreamWriter(ruta, true);
                escribir.WriteLine(contenidos);
                escribir.Close();
            }
            else
            {
                if (comboBox1.SelectedIndex==1)
                {
                    string ruta = @"V:\PracticasSegundoParcial.txt";
                    StreamWriter escribir = new StreamWriter(ruta, true);
                    escribir.WriteLine(contenidos);
                    escribir.Close();
                }
                else
                {
                    string ruta = @"V:\PracticasFinal.txt";
                    StreamWriter escribir = new StreamWriter(ruta, true);
                    escribir.WriteLine(contenidos);
                    escribir.Close();
                }
            }
            
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
               string cont = File.ReadAllText(openFileDialog1.FileName);
               string[] registros = cont.Split('|');

               foreach (string registro in registros)
               {
                   string[] notas = registro.Split(',');
                   dataGridView1.Rows.Add(notas[0],notas[1], notas[2], notas[3], notas[4], notas[5], notas[6]);
               }
                

               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ruta = @"V:\Imp.txt";
            StreamWriter escribir = new StreamWriter(ruta, true);
            escribir.WriteLine("----------PRACTICAS "+comboBox1.SelectedText);
            escribir.WriteLine("\n");
            escribir.WriteLine("Fecha: "+comboBox2.SelectedText);
            escribir.WriteLine("\n");
            escribir.WriteLine("Numero de Estudiantes: 10");
            escribir.WriteLine("----------------------------------------------");
            escribir.WriteLine("Estudiante        Practica 1          Practica 2              Practica 3            Practica 4            Practica 5            Practica 6");
            string[] registros = contenidos.Split('|');

            foreach (string registro in registros)
            {
                string[] notas = registro.Split(',');
                escribir.WriteLine(notas[0] + "  " + notas[1] + "     " + notas[2] + "      " + notas[3] + "      " + notas[4] + "      " + notas[5] + "      " + notas[6]);
                escribir.WriteLine("\t");

            }
            escribir.WriteLine("----------------------------------------------");
            escribir.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ayuda = new Form2();
            ayuda.Show();


        }
    }
}
