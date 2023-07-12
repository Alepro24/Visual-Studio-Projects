using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int c = 0,indice=0,cont=0,d=0,dd=0;
        string[] vec = new string[100];
        string[] veco = new string[100];
        string[] vecos = new string[100];
        string[] vecoss = new string[100];
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vec[c] = ca.Text;
            veco[c] = pa.Text;
            vecos[c] = ma.Text;
            vecoss[c] = no.Text;
            c++;
            indice++;
            ca.Text = "";
            pa.Text = "";
            ma.Text = "";
            no.Text = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string m, mensaje = "";
            m = "Carnet" + "\t" + "Paterno" +"\t"+"Materno" + "\t" + "Nombres" + "\n";
            for (int i = 0; i < indice; i++)
            {
                mensaje = mensaje + vec[i] + "\t" + veco[i] + "\t" +vecos[i] + "\t" +vecoss[i]+ "\n";
            }
            MessageBox.Show(m + mensaje);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ca.Text = "";
            pa.Text = "";
            ma.Text = "";
            no.Text = "";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            vec[dd] = ca.Text;
            veco[dd] = pa.Text;
            vecos[dd] = ma.Text;
            vecoss[dd] = no.Text;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            
            if (indice > d)
            {
                ca.Text = vec[d];
                pa.Text = veco[d];
                ma.Text = vecos[d];
                no.Text = vecoss[d];
                d++;

            }
            else
            {
                d = 0;
                ca.Text = vec[d];
                pa.Text = veco[d];
                ma.Text = vecos[d];
                no.Text = vecoss[d];
                d++;
            }

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            if (0 <= d)
            {
                ca.Text = vec[d];
                pa.Text = veco[d];
                ma.Text = vecos[d];
                no.Text = vecoss[d];
                d--;
            }
            else
            {
                d = indice - 1;

                ca.Text = vec[d];
                pa.Text = veco[d];
                ma.Text = vecos[d];
                no.Text = vecoss[d];
                d--;
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
           for (int i=0;i<indice;i++)
           {
               if (vec[i]==ca.Text)
               {
                   pa.Text = veco[i];
                   ma.Text = vecos[i];
                   no.Text = vecoss[i];
                   dd = i;
                   
               }
               
           }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            vec = vec.Where(i => i != vec[dd]).ToArray();
            veco = veco.Where(i => i != veco[dd]).ToArray();
            vecos = vecos.Where(i => i != vecos[dd]).ToArray();
            vecoss = vecoss.Where(i => i != vecoss[dd]).ToArray();
        }
    }
}
