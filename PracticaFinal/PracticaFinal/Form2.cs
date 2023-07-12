using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaFinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox1.Text = "UNIVERSIDAD DEL VALLE" + "\t" + "NOMBRE: ALEJANDRO PENA" + "\t" + "ASIGNAATURA: PROGRAMACION II" + "\t" + "CARRERA: ING. INDUSTRIAL Y DE SISTEMAS";
            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
