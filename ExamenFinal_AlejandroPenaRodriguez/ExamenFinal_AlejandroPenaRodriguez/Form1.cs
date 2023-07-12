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

namespace ExamenFinal_AlejandroPenaRodriguez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                string n = textBox1.Text;
                string a = textBox2.Text;
            }
            catch(Exception er)
            {
                MessageBox.Show("Ingrese letras");
                   
            }

            if (comboBox1.SelectedIndex == 0)
            {
                string ruta = @"E:\Visual Studio Projects\ExamenFinal_AlejandroPenaRodriguez\estudiantes_Prog1.txt";
                StreamWriter escribir = new StreamWriter(ruta, true);
                escribir.WriteLine(textBox1.Text +textBox2.Text+",");
                escribir.Close();
            }
            else
            {
                if (comboBox1.SelectedIndex==1)
                {
                    string ruta = @"E:\Visual Studio Projects\ExamenFinal_AlejandroPenaRodriguez\estudiantes_Prog2.txt";
                    StreamWriter escribir = new StreamWriter(ruta, true);
                    escribir.WriteLine(textBox1.Text  + textBox2.Text+"," );
                    escribir.Close();
                }
                else
                {
                    string ruta = @"E:\Visual Studio Projects\ExamenFinal_AlejandroPenaRodriguez\estudiantes_Base.txt";
                    StreamWriter escribir = new StreamWriter(ruta, true);
                    escribir.WriteLine(textBox1.Text  + textBox2.Text +",");
                    escribir.Close();
                }
            }
               

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string archivo = openFileDialog1.FileName;
                string contenido = File.ReadAllText(archivo);
                string[] est = contenido.Split(',');
                for (int i = 0; i <= est.Length - 1;i++ )
                {
                    dataGridView1.Rows.Add();
                }
                    for (int j = 0; j <= est.Length - 1; j++)
                    {
                        dataGridView1.Rows[j].Cells[0].Value = est[j];


                    }

            }
            label6.Text = comboBox1.SelectedItem.ToString();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            
            string ruta = @"E:\Visual Studio Projects\ExamenFinal_AlejandroPenaRodriguez\reportes.txt";
            StreamWriter escribir = new StreamWriter(ruta, true);
            escribir.WriteLine("Practicas "+label6.Text);
            escribir.WriteLine("\n");
            escribir.WriteLine("Fecha: "+DateTime.Now);
            escribir.WriteLine("Materia "+label6.Text);
            escribir.WriteLine("Numero de estudiantes "+(dataGridView1.Rows.Count-1));
            escribir.WriteLine("\n");
            escribir.WriteLine("Estudiante" + "\t" + "Prac 1" + "\t" + "Prac 2" + "\t" + "Prac 3" + "\t" + "Prac 4");
            escribir.WriteLine("-----------------------------------------------------------------------------------");
            for (int i = 0; i <= dataGridView1.Rows.Count-1;i++ )
            {
                escribir.WriteLine(dataGridView1.Rows[i].Cells[0].Value + "\t" + dataGridView1.Rows[i].Cells[1].Value + "\t" + dataGridView1.Rows[i].Cells[2].Value + "\t" + dataGridView1.Rows[i].Cells[3].Value + "\t" + dataGridView1.Rows[i].Cells[4].Value);
            }
            escribir.WriteLine("-----------------------------------------------------------------------------------");
            escribir.WriteLine("Observaciones: "+textBox5.Text);
                escribir.Close();
        }
    }
}
