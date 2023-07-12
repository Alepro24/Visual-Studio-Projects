using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace ProyectoHospital
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            comboBox.Items.Add("T_Pacientes");
            comboBox.Items.Add("T_Medicos");
            comboBox.Items.Add("T_Consultas");
            comboBox.Items.Add("T_Empleados");
            comboBox.Items.Add("T_Especialidades");
            comboBox.Items.Add("T_Espmedicos");
            comboBox.Items.Add("T_Camas");
            comboBox.Items.Add("T_Pisos");
            comboBox.Items.Add("T_Internaciones");
            comboBox.Items.Add("T_Precios");
            comboBox.Items.Add("T_Movimientos");
            comboBox.Items.Add("T_Laboratorios");
            comboBox.Items.Add("T_Quirofanos");
            comboBox.Items.Add("T_Operaciones");

            comboBox1.Items.Add("T_Pacientes");
            comboBox1.Items.Add("T_Medicos");
            comboBox1.Items.Add("T_Consultas");
            comboBox1.Items.Add("T_Empleados");
            comboBox1.Items.Add("T_Especialidades");
            comboBox1.Items.Add("T_Espmedicos");
            comboBox1.Items.Add("T_Camas");
            comboBox1.Items.Add("T_Pisos");
            comboBox1.Items.Add("T_Internaciones");
            comboBox1.Items.Add("T_Precios");
            comboBox1.Items.Add("T_Movimientos");
            comboBox1.Items.Add("T_Laboratorios");
            comboBox1.Items.Add("T_Quirofanos");
            comboBox1.Items.Add("T_Operaciones");

            comboBox3.Items.Add("T_Pacientes");
            comboBox3.Items.Add("T_Medicos");
            comboBox3.Items.Add("T_Consultas");
            comboBox3.Items.Add("T_Empleados");
            comboBox3.Items.Add("T_Especialidades");
            
            comboBox3.Items.Add("T_Camas");
            comboBox3.Items.Add("T_Pisos");
            comboBox3.Items.Add("T_Internaciones");
            comboBox3.Items.Add("T_Precios");
            comboBox3.Items.Add("T_Movimientos");
            comboBox3.Items.Add("T_Laboratorios");
            comboBox3.Items.Add("T_Quirofanos");
            comboBox3.Items.Add("T_Operaciones");


            datePicker2.Text =DateTime.Today.AddDays(1).ToString();
            datePicker4.Text = DateTime.Today.AddDays(1).ToString();


        }
        public string usu;
        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ginsert.IsEnabled = true;
            string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
            SqlConnection dataconnection = new SqlConnection(conexion);
            if (comboBox.SelectedIndex == 0)
            {
                Visible();
                
                label2.Content = "Nombre";
                label3.Content = "Ap.Paterno";
                label4.Content = "Ap.Materno";
                label5.Content = "Nacionalidad";
                label6.Content = "CI";
                label7.Content = "Direccion";
                label12.Content = "Fecha Nac.";
                label8.Content = "Estado civil";
                label9.Content = "N Seguro";
                label10.Content = "Sexo";
                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;

                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                label22.Visibility = System.Windows.Visibility.Hidden;
                comboBox5.Visibility = System.Windows.Visibility.Hidden;


            }
            if (comboBox.SelectedIndex == 1)
            {
                Visible();
                
                label2.Content = "Nombre";
                label3.Content = "Ap.Paterno";
                label4.Content = "Ap.Materno";
                label5.Content = "CI";
                label6.Content = "Telefono";
                label7.Content = "Direccion";
                label12.Content = "Fecha Inicio.";
                label8.Content = "Correo";
                label9.Content = "Cuenta";
                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                label22.Visibility = System.Windows.Visibility.Hidden;
                comboBox5.Visibility = System.Windows.Visibility.Hidden;

            }
            if (comboBox.SelectedIndex == 2)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidmedicos", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));
                    
                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidpacientes", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();

                label12.Content = "Fechaconsulta";
                label2.Content = "Diagnostico";
                label22.Content = "IdMedico";
                label23.Content = "Idpaciente";
                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label3.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox2.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;

            }
            if (comboBox.SelectedIndex == 3)
            {
                Visible();
                
                label2.Content = "Nombre";
                label3.Content = "Ap.Paterno";
                label4.Content = "Ap.Materno";
                label5.Content = "Nacionalidad";
                label6.Content = "CI";
                label7.Content = "Telefono";
                label8.Content = "Direccion";
                label9.Content = "Correo";
                label10.Content = "Horario";
                label11.Content = "Sexo";
                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                label22.Visibility = System.Windows.Visibility.Hidden;
                comboBox5.Visibility = System.Windows.Visibility.Hidden;

            }
            if (comboBox.SelectedIndex == 4)
            {
                Visible();
                
                label2.Content = "Especialidad";

                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label3.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                
                textBox2.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                label22.Visibility = System.Windows.Visibility.Hidden;
                comboBox5.Visibility = System.Windows.Visibility.Hidden;


            }
            if (comboBox.SelectedIndex == 5)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidespecialidades", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidmedicos", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();

                label22.Content = "Idespecialidad";
                label23.Content = "Idmedico";

                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label2.Visibility = System.Windows.Visibility.Hidden;
                label3.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox1.Visibility = System.Windows.Visibility.Hidden;
                textBox2.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;


            }
            if (comboBox.SelectedIndex == 6)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidpisos", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidpacientes", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();

                label2.Content = "Estado";
                label22.Content = "Idpiso";
                label23.Content = "Idpaciente";

                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label3.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox2.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;


            }
            if (comboBox.SelectedIndex == 7)
            {
                Visible();
                
                label2.Content = "Nsalas";
                label3.Content = "Nsalasti";

                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                label22.Visibility = System.Windows.Visibility.Hidden;
                comboBox5.Visibility = System.Windows.Visibility.Hidden;

            }
            if (comboBox.SelectedIndex == 8)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidcamas", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidpacientes", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();

                label12.Content = "Fechaentrada";
                label13.Content = "Fechasalida";
                label22.Content = "Idcama";
                label23.Content = "IdPaciente";

                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label2.Visibility = System.Windows.Visibility.Hidden;
                label3.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox1.Visibility = System.Windows.Visibility.Hidden;
                textBox2.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                
            }
            if (comboBox.SelectedIndex == 9)
            {
                Visible();
                
                label2.Content = "Precio";
                label3.Content = "Detalle";
                label4.Content = "Observacion";
                label5.Content = "Total";

                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                label22.Visibility = System.Windows.Visibility.Hidden;
                comboBox5.Visibility = System.Windows.Visibility.Hidden;
            }
            if (comboBox.SelectedIndex == 10)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidpacientes", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidprecios", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();

                label22.Content = "Idpaciente";
                label23.Content = "Idprecio";
                label12.Content = "Fecha";
                label4.Content = "Detalle";

                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label2.Visibility = System.Windows.Visibility.Hidden;
                label3.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                
                label13.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox2.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                
            }
            if (comboBox.SelectedIndex == 11)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidpacientes", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidempleados", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();

                label2.Content = "Nomestudio";
                label3.Content = "Fecha y hora";
                label12.Content = "Fecha entrega";
                label22.Content = "Idpaciente";
                label23.Content = "Idempleado";

                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;

                label13.Visibility = System.Windows.Visibility.Hidden;

                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;

            }
            if (comboBox.SelectedIndex == 12)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidpisos", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

               

                label22.Content = "Idpiso";

                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label2.Visibility = System.Windows.Visibility.Hidden;
                
                label3.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox1.Visibility = System.Windows.Visibility.Hidden;
                
                textBox2.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;


            }
            if (comboBox.SelectedIndex == 13)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidquirofanos", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidpacientes", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da2 = new SqlCommand("spidmedicos", dataconnection);
                da2.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da2.ExecuteNonQuery();
                SqlDataReader lee2 = da2.ExecuteReader();
                while (lee2.Read())
                {
                    comboBox7.Items.Add(lee2.GetInt32(0));

                }
                dataconnection.Close();

                

                label12.Content = "Fecha op.";
                label2.Content = "Hora entrada";
                label3.Content = "Hora est. salida";
                label22.Content = "Idquirofano";
                label23.Content = "Idpaciente";
                label24.Content = "Idmedico";

                label1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;

                label13.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                

                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;

            }


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //Identificador();
            if (comboBox.SelectedIndex == 0)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertpacientes", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    
                    da.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidop", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidom", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nacionalidad", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@CI", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Direccion", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechanac", SqlDbType.Date);
                    da.Parameters.Add("@Estadocivil", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nseguro", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Sexo", SqlDbType.VarChar, 25);

                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    
                    da.Parameters["@Nombre"].Value = textBox1.Text;
                    da.Parameters["@Apellidop"].Value = textBox2.Text;
                    da.Parameters["@Apellidom"].Value = textBox3.Text;
                    da.Parameters["@Nacionalidad"].Value = textBox4.Text;
                    da.Parameters["@CI"].Value = textBox5.Text;
                    da.Parameters["@Direccion"].Value = textBox6.Text;
                    da.Parameters["@Fechanac"].Value = datePicker.Text;
                    da.Parameters["@Estadocivil"].Value = textBox7.Text;
                    da.Parameters["@Nseguro"].Value = textBox8.Text;
                    da.Parameters["@Sexo"].Value = textBox9.Text;
                    da.Parameters["@Usuario"].Value = usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox.SelectedIndex == 1)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertmedicos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    
                    da.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidop", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidom", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@CI", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Telefono", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Direccion", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechainicio", SqlDbType.Date);
                    da.Parameters.Add("@Correo", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Cuenta", SqlDbType.VarChar, 25);
                    
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    
                    da.Parameters["@Nombre"].Value = textBox1.Text;
                    da.Parameters["@Apellidop"].Value = textBox2.Text;
                    da.Parameters["@Apellidom"].Value = textBox3.Text;
                    da.Parameters["@CI"].Value = textBox4.Text;
                    da.Parameters["@Telefono"].Value = textBox5.Text;
                    da.Parameters["@Direccion"].Value = textBox6.Text;
                    da.Parameters["@Fechainicio"].Value = datePicker.Text;
                    da.Parameters["@Correo"].Value = textBox7.Text;
                    da.Parameters["@Cuenta"].Value = textBox8.Text;
                    
                    da.Parameters["@Usuario"].Value = usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox.SelectedIndex == 2)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertconsultas", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    
                    da.Parameters.Add("@Fechaconsulta", SqlDbType.Date);
                    da.Parameters.Add("@Diagnostico", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idmedico", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@IdPaciente", SqlDbType.VarChar, 25);
                    
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    
                    da.Parameters["@Fechaconsulta"].Value = datePicker.Text;
                    da.Parameters["@Diagnostico"].Value = textBox1.Text;
                    da.Parameters["@Idmedico"].Value = comboBox5.Text;
                    da.Parameters["@Idpaciente"].Value = comboBox6.Text;
                    
                    da.Parameters["@Usuario"].Value =usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox.SelectedIndex == 3)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertempleados", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                   
                    da.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidop", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidom", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nacionalidad", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@CI", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Telefono", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Direccion", SqlDbType.VarChar,25);
                    da.Parameters.Add("@Correo", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Horario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Sexo", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                   
                    da.Parameters["@Nombre"].Value = textBox1.Text;
                    da.Parameters["@Apellidop"].Value = textBox2.Text;
                    da.Parameters["@Apellidom"].Value = textBox3.Text;
                    da.Parameters["@Nacionalidad"].Value = textBox4.Text;
                    da.Parameters["@CI"].Value = textBox5.Text;
                    da.Parameters["@Telefono"].Value = textBox6.Text;
                    da.Parameters["@Direccion"].Value = textBox7.Text;
                    da.Parameters["@Correo"].Value = textBox8.Text;
                    da.Parameters["@Horario"].Value = textBox9.Text;
                    da.Parameters["@Sexo"].Value = textBox10.Text;

                    da.Parameters["@Usuario"].Value = usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox.SelectedIndex == 4)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertespecialidades", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    
                    da.Parameters.Add("@Especialidad", SqlDbType.VarChar,25);
                    

                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    
                    da.Parameters["@Especialidad"].Value = textBox1.Text;
                    

                    da.Parameters["@Usuario"].Value = usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox.SelectedIndex == 5)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertespmedicos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                   
                    da.Parameters.Add("@Idespecialidad", SqlDbType.VarChar,25);
                    da.Parameters.Add("@Idmedico", SqlDbType.VarChar, 25);
                    

                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                   
                    da.Parameters["@Idespecialidad"].Value = comboBox5.Text;
                    da.Parameters["@Idmedico"].Value = comboBox6.Text;
                   

                    da.Parameters["@Usuario"].Value = usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox.SelectedIndex == 6)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertcamas", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                   
                    da.Parameters.Add("@Estadoc", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idpiso", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Camati", SqlDbType.VarChar,25);
                    

                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    
                    da.Parameters["@Estadoc"].Value = textBox1.Text;
                    da.Parameters["@Idpiso"].Value = comboBox5.Text;
                    da.Parameters["@Camati"].Value = comboBox6.Text;
                    


                    da.Parameters["@Usuario"].Value = usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox.SelectedIndex == 7)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertpisos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    
                    da.Parameters.Add("@Nsalas", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nsalasti", SqlDbType.VarChar, 25);


                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    
                    da.Parameters["@Nsalas"].Value = textBox1.Text;
                    da.Parameters["@Nsalasti"].Value = textBox2.Text;



                    da.Parameters["@Usuario"].Value = usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox.SelectedIndex == 8)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertinternaciones", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    
                    da.Parameters.Add("@Fechaentrada", SqlDbType.Date);
                    da.Parameters.Add("@Fechasalida", SqlDbType.Date);
                    da.Parameters.Add("@Idcama", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);
                    
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                   
                    da.Parameters["@Fechaentrada"].Value = datePicker.Text;
                    da.Parameters["@Fechasalida"].Value = datePicker1.Text;
                    da.Parameters["@Idcama"].Value = comboBox5.Text;
                    da.Parameters["@Idpaciente"].Value = comboBox6.Text;
                    

                    da.Parameters["@Usuario"].Value = usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox.SelectedIndex == 9)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertprecios", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    
                    da.Parameters.Add("@Precio", SqlDbType.VarChar,25);
                    da.Parameters.Add("@Detalle", SqlDbType.VarChar,25);
                    da.Parameters.Add("@Observacion", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Total", SqlDbType.VarChar, 25);

                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    
                    da.Parameters["@Precio"].Value = textBox1.Text;
                    da.Parameters["@Detalle"].Value = textBox2.Text;
                    da.Parameters["@Observacion"].Value = textBox3.Text;
                    da.Parameters["@Total"].Value = textBox4.Text;


                    da.Parameters["@Usuario"].Value = usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
           
            if (comboBox.SelectedIndex == 10)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertmovimientos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idprecio", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);
                    da.Parameters.Add("@Detalle", SqlDbType.VarChar, 25);

                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    
                    da.Parameters["@Idpaciente"].Value = comboBox5.Text;
                    da.Parameters["@Idprecio"].Value = comboBox6.Text;
                    da.Parameters["@Fecha"].Value =datePicker.Text;
                    da.Parameters["@Detalle"].Value = textBox3.Text;


                    da.Parameters["@Usuario"].Value = usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox.SelectedIndex == 11)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertlaboratorios", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    
                    da.Parameters.Add("@Nomestudio", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechayhora", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechaentrega", SqlDbType.Date);
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idempleado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                   
                    da.Parameters["@Nomestudio"].Value = textBox1.Text;
                    da.Parameters["@Fechayhora"].Value = textBox2.Text;
                    da.Parameters["@Fechaentrega"].Value = datePicker.Text;
                    da.Parameters["@Idpaciente"].Value = comboBox5.Text;
                    da.Parameters["@Idempleado"].Value = comboBox6.Text;


                    da.Parameters["@Usuario"].Value = usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox.SelectedIndex == 12)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertquirofanos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                   
                    da.Parameters.Add("@Idpiso", SqlDbType.VarChar, 25);


                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    
                    da.Parameters["@Idpiso"].Value = comboBox5.Text;


                    da.Parameters["@Usuario"].Value = usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox.SelectedIndex == 13)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spinsertoperaciones", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                   
                    da.Parameters.Add("@Fechao", SqlDbType.Date);
                    da.Parameters.Add("@Horaentrada", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Horaestsalida", SqlDbType.VarChar,25);
                    da.Parameters.Add("@Idquirofano", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idmedico", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                   
                    da.Parameters["@Fechao"].Value = datePicker.Text;
                    da.Parameters["@Horaentrada"].Value = textBox1.Text;
                    da.Parameters["@Horaestsalida"].Value = textBox2.Text;
                    da.Parameters["@Idquirofano"].Value = comboBox5.Text;
                    da.Parameters["@Idpaciente"].Value = comboBox6.Text;
                    da.Parameters["@Idmedico"].Value = comboBox7.Text;


                    da.Parameters["@Usuario"].Value = usu;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se ingreso correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }








        }

        void Visible()
        {
            
            label1.Visibility = System.Windows.Visibility.Visible;
            label2.Visibility = System.Windows.Visibility.Visible;
            label3.Visibility = System.Windows.Visibility.Visible;
            label4.Visibility = System.Windows.Visibility.Visible;
            label5.Visibility = System.Windows.Visibility.Visible;
            label6.Visibility = System.Windows.Visibility.Visible;
            label7.Visibility = System.Windows.Visibility.Visible;
            label8.Visibility = System.Windows.Visibility.Visible;
            label9.Visibility = System.Windows.Visibility.Visible;
            label10.Visibility = System.Windows.Visibility.Visible;
            label11.Visibility = System.Windows.Visibility.Visible;
            label12.Visibility = System.Windows.Visibility.Visible;
            label13.Visibility = System.Windows.Visibility.Visible;
            label22.Visibility = System.Windows.Visibility.Visible;
            label23.Visibility = System.Windows.Visibility.Visible;
            label24.Visibility = System.Windows.Visibility.Visible;
            textBox.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();
            textBox.Visibility = System.Windows.Visibility.Visible;
            textBox1.Visibility = System.Windows.Visibility.Visible;
            textBox2.Visibility = System.Windows.Visibility.Visible;
            textBox3.Visibility = System.Windows.Visibility.Visible;
            textBox4.Visibility = System.Windows.Visibility.Visible;
            textBox5.Visibility = System.Windows.Visibility.Visible;
            textBox6.Visibility = System.Windows.Visibility.Visible;
            textBox7.Visibility = System.Windows.Visibility.Visible;
            textBox8.Visibility = System.Windows.Visibility.Visible;
            textBox9.Visibility = System.Windows.Visibility.Visible;
            textBox10.Visibility = System.Windows.Visibility.Visible;
            datePicker.Visibility = System.Windows.Visibility.Visible;
            datePicker1.Visibility = System.Windows.Visibility.Visible;
            comboBox5.Visibility = System.Windows.Visibility.Visible;
            comboBox6.Visibility = System.Windows.Visibility.Visible;
            comboBox7.Visibility = System.Windows.Visibility.Visible;


        }
        public int f=0, r=0;
        public string s;
        /*void Identificador()
        {
            
            DataTable dt = new DataTable();
            string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
            SqlConnection dataconnection = new SqlConnection(conexion);
            SqlDataAdapter da = new SqlDataAdapter("select * from T_Camas", dataconnection);
            dataconnection.Open();
            da.SelectCommand.ExecuteNonQuery();
            dt.Load(da.SelectCommand.ExecuteReader());
            dataconnection.Close();
            da.Fill(dt);
            f = dt.Rows.Count+1;
            MessageBox.Show(f.ToString());
            r = f + 1;
            MessageBox.Show(r.ToString());
            s = r.ToString("D4");
            
            

        }*/

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spmpacientes", dataconnection);               
                da.CommandType = CommandType.StoredProcedure;               
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idpaciente");
                comboBox2.Items.Add("Nombre");
                comboBox2.Items.Add("Apellidop");
                comboBox2.Items.Add("Apellidom");
                comboBox2.Items.Add("Nacionalidad");
                comboBox2.Items.Add("CI");
                comboBox2.Items.Add("Fechanac");
                comboBox2.Items.Add("Estadocivil");
                comboBox2.Items.Add("Nseguro");
                comboBox2.Items.Add("Sexo");
                
               comboBox2.Items.Add("Estado");
               comboBox2.Items.Add("Usuario");
             comboBox2.Items.Add("Fecha");

            }
            if (comboBox1.SelectedIndex == 1)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spmmedicos", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idmedico");
                comboBox2.Items.Add("Nombre");
                comboBox2.Items.Add("Apellidop");
                comboBox2.Items.Add("Apellidom");
                comboBox2.Items.Add("Nacionalidad");
                comboBox2.Items.Add("CI");
                comboBox2.Items.Add("Fechanac");
                comboBox2.Items.Add("Estadocivil");
                comboBox2.Items.Add("Nseguro");
                comboBox2.Items.Add("Sexo");
                comboBox2.Items.Add("Estado");
                comboBox2.Items.Add("Usuario");
                comboBox2.Items.Add("Fecha");

            }
            if (comboBox1.SelectedIndex == 2)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spmconsultas", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idconsulta");
                comboBox2.Items.Add("Fechaconsulta");
                comboBox2.Items.Add("Diagnostico");
                comboBox2.Items.Add("Idmedico");
                comboBox2.Items.Add("Idpaciente");
                comboBox2.Items.Add("Estado");
                comboBox2.Items.Add("Usuario");
                comboBox2.Items.Add("Fecha");


            }
            if (comboBox1.SelectedIndex == 3)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spmempleados", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idempleados");
                comboBox2.Items.Add("Nombre");
                comboBox2.Items.Add("Apellidop");
                comboBox2.Items.Add("Apellidom");
                comboBox2.Items.Add("Nacionalidad");
                comboBox2.Items.Add("CI");
                comboBox2.Items.Add("Telefono");
                
                comboBox2.Items.Add("Correo");
                comboBox2.Items.Add("Horario");
                comboBox2.Items.Add("Sexo");
                comboBox2.Items.Add("Estado");
                comboBox2.Items.Add("Usuario");
                comboBox2.Items.Add("Fecha");

            }
            if (comboBox1.SelectedIndex == 4)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spmespecialidades", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idespecialidad");
                comboBox2.Items.Add("Especialidad");
                
                comboBox2.Items.Add("Estado");
                comboBox2.Items.Add("Usuario");
                comboBox2.Items.Add("Fecha");

            }
            if (comboBox1.SelectedIndex == 5)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spmespmedicos", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idespmedico");
                comboBox2.Items.Add("Idespecialidad");
                comboBox2.Items.Add("Idmedico");
               
                comboBox2.Items.Add("Estado");
                comboBox2.Items.Add("Usuario");
                comboBox2.Items.Add("Fecha");

            }
            if (comboBox1.SelectedIndex == 6)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spmcamas", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idcama");
                comboBox2.Items.Add("Estadoc");
                comboBox2.Items.Add("Idpiso");
                comboBox2.Items.Add("Idpaciente");
                
                comboBox2.Items.Add("Estado");
                comboBox2.Items.Add("Usuario");
                comboBox2.Items.Add("Fecha");

            }
            if (comboBox1.SelectedIndex == 7)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spmpisos", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idpiso");
                comboBox2.Items.Add("Nsalas");
                comboBox2.Items.Add("Nsalasti");
                
                comboBox2.Items.Add("Estado");
                comboBox2.Items.Add("Usuario");
                comboBox2.Items.Add("Fecha");

            }
            if (comboBox1.SelectedIndex == 8)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spminternaciones", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idinternacion");
                comboBox2.Items.Add("Fechaentrada");
                comboBox2.Items.Add("Fechasalida");
                comboBox2.Items.Add("Idcama");
                comboBox2.Items.Add("Idpaciente");
               
                comboBox2.Items.Add("Estado");
                comboBox2.Items.Add("Usuario");
                comboBox2.Items.Add("Fecha");

            }
            if (comboBox1.SelectedIndex == 9)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spmprecios", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idprecio");
                comboBox2.Items.Add("Precio");
                comboBox2.Items.Add("Detalle");
                comboBox2.Items.Add("Observacion");
                comboBox2.Items.Add("Total");
                
                comboBox2.Items.Add("Estado");
                comboBox2.Items.Add("Usuario");
                comboBox2.Items.Add("Fecha");

            }
            if (comboBox1.SelectedIndex == 10)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spmmovimientos", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idmovimiento");
                comboBox2.Items.Add("Idpaciente");
                comboBox2.Items.Add("Idprecio");
                comboBox2.Items.Add("Fecham");
                comboBox2.Items.Add("Detalle");
                
                comboBox2.Items.Add("Estado");
                comboBox2.Items.Add("Usuario");
                comboBox2.Items.Add("Fecha");

            }
            if (comboBox1.SelectedIndex == 11)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spmlaboratorios", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idlaboratorio");
                comboBox2.Items.Add("Nomestudio");
                comboBox2.Items.Add("Fechayhora");
                comboBox2.Items.Add("Fechaentrega");
                comboBox2.Items.Add("Idpaciente");
                comboBox2.Items.Add("Idempleado");
               
                comboBox2.Items.Add("Estado");
                comboBox2.Items.Add("Usuario");
                comboBox2.Items.Add("Fecha");

            }
            if (comboBox1.SelectedIndex == 13)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spmoperaciones", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idoperacion");
                comboBox2.Items.Add("Fechao");
                comboBox2.Items.Add("Horaentrada");
                comboBox2.Items.Add("Horaestsalida");
                comboBox2.Items.Add("Idquirofano");
                comboBox2.Items.Add("Idpaciente");
                comboBox2.Items.Add("Idmedico");
               
                comboBox2.Items.Add("Estado");
                comboBox2.Items.Add("Usuario");
                comboBox2.Items.Add("Fecha");

            }
            if (comboBox1.SelectedIndex == 12)
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlCommand da = new SqlCommand("spmquirofanos", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                dt.Load(da.ExecuteReader());
                dataconnection.Close();
                dataGrid.DataContext = dt;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Idquirofano");
                comboBox2.Items.Add("Idpiso");
                

                comboBox2.Items.Add("Estado");
                comboBox2.Items.Add("Usuario");
                comboBox2.Items.Add("Fecha");

            }
        }

        private void textBox11_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
            if (comboBox1.SelectedIndex == 0)
            {
                try
                {
                    
                       
                        string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                        SqlConnection dataconnection = new SqlConnection(conexion);
                        SqlCommand da = new SqlCommand("spselectpacientes", dataconnection);
                        da.CommandType = CommandType.StoredProcedure;
                        da.Parameters.Add("@Idpaciente", SqlDbType.Int);
                        da.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                        da.Parameters.Add("@Apellidop", SqlDbType.VarChar, 25);
                        da.Parameters.Add("@Apellidom", SqlDbType.VarChar, 25);
                        da.Parameters.Add("@Nacionalidad", SqlDbType.VarChar, 25);
                        da.Parameters.Add("@CI", SqlDbType.VarChar, 25);

                        da.Parameters.Add("@Fechanac", SqlDbType.Date);
                        da.Parameters.Add("@Estadocivil", SqlDbType.VarChar, 25);
                        da.Parameters.Add("@Nseguro", SqlDbType.VarChar, 25);
                        da.Parameters.Add("@Sexo", SqlDbType.VarChar, 25);
                        da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                        da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                        da.Parameters.Add("@Fecha", SqlDbType.Date);
                    da.Parameters["@Idpaciente"].Value = 111111;
                    if (comboBox2.SelectedIndex == 0)
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idpaciente"].Value = iii;
                    }
                        
                        da.Parameters["@Nombre"].Value = textBox11.Text;
                        da.Parameters["@Apellidop"].Value = textBox11.Text;
                        da.Parameters["@Apellidom"].Value = textBox11.Text;
                        da.Parameters["@Nacionalidad"].Value = textBox11.Text;
                        da.Parameters["@CI"].Value = textBox11.Text;

                        da.Parameters["@Fechanac"].Value = datePicker2.Text;
                        da.Parameters["@Estadocivil"].Value = textBox11.Text;
                        da.Parameters["@Nseguro"].Value = textBox11.Text;
                        da.Parameters["@Sexo"].Value = textBox11.Text;
                        da.Parameters["@Estado"].Value = textBox11.Text;
                        da.Parameters["@Usuario"].Value = textBox11.Text;
                        da.Parameters["@Fecha"].Value = datePicker2.Text;
                        dataconnection.Open();
                        da.ExecuteNonQuery();
                        dt.Load(da.ExecuteReader());
                        dataconnection.Close();
                        dataGrid.DataContext = dt;
                    
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }

            if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spselectmedicos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idmedico", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidop", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidom", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@CI", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Telefono", SqlDbType.VarChar, 25);
                    
                    da.Parameters.Add("@Fechainicio", SqlDbType.Date);
                    da.Parameters.Add("@Correo", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Cuenta", SqlDbType.VarChar, 25);

                    da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);

                    da.Parameters["@Idmedico"].Value = 111111;
                    if (comboBox2.SelectedIndex == 0)
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idmedico"].Value = iii;
                    }
                    da.Parameters["@Nombre"].Value = textBox11.Text;
                    da.Parameters["@Apellidop"].Value = textBox11.Text;
                    da.Parameters["@Apellidom"].Value = textBox11.Text;
                    da.Parameters["@CI"].Value = textBox11.Text;
                    da.Parameters["@Telefono"].Value = textBox11.Text;
                    
                    da.Parameters["@Fechainicio"].Value = datePicker2.Text;
                    da.Parameters["@Correo"].Value = textBox11.Text;
                    da.Parameters["@Cuenta"].Value = textBox11.Text;

                    da.Parameters["@Estado"].Value = textBox11.Text;
                    da.Parameters["@Usuario"].Value = textBox11.Text;
                    da.Parameters["@Fecha"].Value = datePicker2.Text;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    dt.Load(da.ExecuteReader());
                    dataconnection.Close();
                    dataGrid.DataContext = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spselectconsultas", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idconsulta", SqlDbType.Int);
                    da.Parameters.Add("@Fechaconsulta", SqlDbType.Date);
                    da.Parameters.Add("@Diagnostico", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idmedico", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@IdPaciente", SqlDbType.VarChar, 25);

                    da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);

                    da.Parameters["@Idconsulta"].Value = 999999;
                    da.Parameters["@Idmedico"].Value = 999999;
                    da.Parameters["@Idpaciente"].Value = 999999;
                    if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 3 || comboBox2.SelectedIndex == 4  )
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idconsulta"].Value = iii;
                        da.Parameters["@Idmedico"].Value = iii;
                        da.Parameters["@Idpaciente"].Value = iii;
                    }
                    da.Parameters["@Fechaconsulta"].Value = datePicker2.Text;
                    da.Parameters["@Diagnostico"].Value = textBox11.Text;
                    

                    da.Parameters["@Estado"].Value = textBox11.Text;
                    da.Parameters["@Usuario"].Value = textBox11.Text;
                    da.Parameters["@Fecha"].Value = datePicker2.Text;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    dt.Load(da.ExecuteReader());
                    dataconnection.Close();
                    dataGrid.DataContext = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spselectempleados", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idempleado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidop", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidom", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nacionalidad", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@CI", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Telefono", SqlDbType.VarChar, 25);
                   
                    da.Parameters.Add("@Correo", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Horario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Sexo", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);

                    da.Parameters["@Idempleado"].Value = 111111;
                    if (comboBox2.SelectedIndex == 0)
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idempleado"].Value = iii;
                    }
                    da.Parameters["@Nombre"].Value = textBox11.Text;
                    da.Parameters["@Apellidop"].Value = textBox11.Text;
                    da.Parameters["@Apellidom"].Value = textBox11.Text;
                    da.Parameters["@Nacionalidad"].Value = textBox11.Text;
                    da.Parameters["@CI"].Value = textBox11.Text;
                    da.Parameters["@Telefono"].Value = textBox11.Text;
                   
                    da.Parameters["@Correo"].Value = textBox11.Text;
                    da.Parameters["@Horario"].Value = textBox11.Text;
                    da.Parameters["@Sexo"].Value = textBox11.Text;

                    da.Parameters["@Estado"].Value = textBox11.Text;
                    da.Parameters["@Usuario"].Value = textBox11.Text;
                    da.Parameters["@Fecha"].Value = datePicker2.Text;
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    dt.Load(da.ExecuteReader());
                    dataconnection.Close();
                    dataGrid.DataContext = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spselectespecialidades", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idespecialidad", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Especialidad", SqlDbType.VarChar, 25);


                    da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);

                    da.Parameters["@Idespecialidad"].Value = 111111;
                    if (comboBox2.SelectedIndex == 0)
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idespecialidad"].Value = iii;
                    }
                    da.Parameters["@Especialidad"].Value = textBox11.Text;


                    da.Parameters["@Estado"].Value = textBox11.Text;
                    da.Parameters["@Usuario"].Value = textBox11.Text;
                    da.Parameters["@Fecha"].Value = datePicker2.Text;

                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    dt.Load(da.ExecuteReader());
                    dataconnection.Close();
                    dataGrid.DataContext = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 5)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spselectespmedicos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idespmedico", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idespecialidad", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idmedico", SqlDbType.VarChar, 25);


                    da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);

                    da.Parameters["@Idespmedico"].Value = 999999;
                    da.Parameters["@Idespecialidad"].Value = 999999;
                    da.Parameters["@Idmedico"].Value = 999999;
                    if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 1 || comboBox2.SelectedIndex == 2)
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idespmedico"].Value = iii;
                        da.Parameters["@Idespecialidad"].Value = iii;
                        da.Parameters["@Idmedico"].Value = iii;
                    }


                    da.Parameters["@Estado"].Value = textBox11.Text;
                    da.Parameters["@Usuario"].Value = textBox11.Text;
                    da.Parameters["@Fecha"].Value = datePicker2.Text;

                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    dt.Load(da.ExecuteReader());
                    dataconnection.Close();
                    dataGrid.DataContext = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 6)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spselectcamas", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idcama", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Estadoc", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idpiso", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Camati", SqlDbType.VarChar, 25);


                    da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);

                    da.Parameters["@Idcama"].Value = 999999;
                    da.Parameters["@Idpiso"].Value = 999999;
                    da.Parameters["@Idpaciente"].Value = 999999;
                    if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 2 || comboBox2.SelectedIndex == 3)
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idcama"].Value = iii;
                        da.Parameters["@Idpiso"].Value = iii;
                        da.Parameters["@Idpaciente"].Value = iii;
                    }

                    da.Parameters["@Estadoc"].Value = textBox11.Text;
                    



                    da.Parameters["@Estado"].Value = textBox11.Text;
                    da.Parameters["@Usuario"].Value = textBox11.Text;
                    da.Parameters["@Fecha"].Value = datePicker2.Text;

                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    dt.Load(da.ExecuteReader());
                    dataconnection.Close();
                    dataGrid.DataContext = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 7)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spselectpisos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idpiso", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nsalas", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nsalasti", SqlDbType.VarChar, 25);


                    da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);

                    da.Parameters["@Idpiso"].Value = 111111;
                    if (comboBox2.SelectedIndex == 0)
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idpiso"].Value = iii;
                    }
                    da.Parameters["@Nsalas"].Value = textBox11.Text;
                    da.Parameters["@Nsalasti"].Value = textBox11.Text;



                    da.Parameters["@Estado"].Value = textBox11.Text;
                    da.Parameters["@Usuario"].Value = textBox11.Text;
                    da.Parameters["@Fecha"].Value = datePicker2.Text;

                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    dt.Load(da.ExecuteReader());
                    dataconnection.Close();
                    dataGrid.DataContext = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 8)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spselectinternaciones", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idinternacion", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechaentrada", SqlDbType.Date);
                    da.Parameters.Add("@Fechasalida", SqlDbType.Date);
                    da.Parameters.Add("@Idcama", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);

                    da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);

                    da.Parameters["@Idinternacion"].Value = 999999;
                    da.Parameters["@Idcama"].Value = 999999;
                    da.Parameters["@Idpaciente"].Value = 999999;
                    if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 3 || comboBox2.SelectedIndex == 4)
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idinternacion"].Value = iii;
                        da.Parameters["@Idcama"].Value = iii;
                        da.Parameters["@Idpaciente"].Value = iii;
                    }
                    da.Parameters["@Fechaentrada"].Value = datePicker2.Text;
                    da.Parameters["@Fechasalida"].Value = datePicker2.Text;
                   


                    da.Parameters["@Estado"].Value = textBox11.Text;
                    da.Parameters["@Usuario"].Value = textBox11.Text;
                    da.Parameters["@Fecha"].Value = datePicker2.Text;

                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    dt.Load(da.ExecuteReader());
                    dataconnection.Close();
                    dataGrid.DataContext = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 9)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spselectprecios", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idprecio", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Precio", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Detalle", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Observacion", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Total", SqlDbType.VarChar, 25);

                    da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);

                    da.Parameters["@Idprecio"].Value = 111111;
                    if (comboBox2.SelectedIndex == 0)
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idprecio"].Value = iii;
                    }
                    da.Parameters["@Precio"].Value = textBox11.Text;
                    da.Parameters["@Detalle"].Value = textBox11.Text;
                    da.Parameters["@Observacion"].Value = textBox11.Text;
                    da.Parameters["@Total"].Value = textBox11.Text;


                    da.Parameters["@Estado"].Value = textBox11.Text;
                    da.Parameters["@Usuario"].Value = textBox11.Text;
                    da.Parameters["@Fecha"].Value = datePicker2.Text;

                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    dt.Load(da.ExecuteReader());
                    dataconnection.Close();
                    dataGrid.DataContext = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }

            if (comboBox1.SelectedIndex == 10)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spselectmovimientos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idmovimiento", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idprecio", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecham", SqlDbType.Date);
                    da.Parameters.Add("@Detalle", SqlDbType.VarChar, 25);

                    da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);

                    da.Parameters["@Idmovimiento"].Value = 999999;
                    da.Parameters["@Idpaciente"].Value = 999999;
                    da.Parameters["@Idprecio"].Value = 999999;
                    if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 1 || comboBox2.SelectedIndex == 2)
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idmovimiento"].Value = iii;
                        da.Parameters["@Idpaciente"].Value = iii;
                        da.Parameters["@Idprecio"].Value = iii;
                    }
                    da.Parameters["@Fecham"].Value = datePicker2.Text;
                    da.Parameters["@Detalle"].Value = textBox11.Text;


                    da.Parameters["@Estado"].Value = textBox11.Text;
                    da.Parameters["@Usuario"].Value = textBox11.Text;
                    da.Parameters["@Fecha"].Value = datePicker2.Text;

                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    dt.Load(da.ExecuteReader());
                    dataconnection.Close();
                    dataGrid.DataContext = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 11)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spselectlaboratorios", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idlaboratorio", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nomestudio", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechayhora", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechaentrega", SqlDbType.Date);
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idempleado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);

                    da.Parameters["@Idlaboratorio"].Value = 999999;
                    da.Parameters["@Idpaciente"].Value = 999999;
                    da.Parameters["@Idempleado"].Value = 999999;
                    if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 4 || comboBox2.SelectedIndex == 5)
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idlaboratorio"].Value = iii;
                        da.Parameters["@Idpaciente"].Value = iii;
                        da.Parameters["@Idempleado"].Value = iii;
                    }
                    da.Parameters["@Nomestudio"].Value = textBox11.Text;
                    da.Parameters["@Fechayhora"].Value = textBox11.Text;
                    da.Parameters["@Fechaentrega"].Value = datePicker2.Text;
                    


                    da.Parameters["@Estado"].Value = textBox11.Text;
                    da.Parameters["@Usuario"].Value = textBox11.Text;
                    da.Parameters["@Fecha"].Value = datePicker2.Text;

                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    dt.Load(da.ExecuteReader());
                    dataconnection.Close();
                    dataGrid.DataContext = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 12)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spselectquirofanos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idquirofano", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idpiso", SqlDbType.VarChar, 25);


                    da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);

                    da.Parameters["@Idquirofano"].Value = 999999;
                    da.Parameters["@Idpiso"].Value = 999999;
                    
                    if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 1)
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idquirofano"].Value = iii;
                        da.Parameters["@Idpiso"].Value = iii;
                       
                    }


                    da.Parameters["@Estado"].Value = textBox11.Text;
                    da.Parameters["@Usuario"].Value = textBox11.Text;
                    da.Parameters["@Fecha"].Value = datePicker2.Text;

                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    dt.Load(da.ExecuteReader());
                    dataconnection.Close();
                    dataGrid.DataContext = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 13)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spselectoperaciones", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idoperacion", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechao", SqlDbType.Date);
                    da.Parameters.Add("@Horaentrada", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Horaestsalida", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idquirofano", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idmedico", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Estado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Usuario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);

                    da.Parameters["@Idoperacion"].Value = 999999;
                    da.Parameters["@Idquirofano"].Value = 999999;
                    da.Parameters["@Idpaciente"].Value = 999999;
                    da.Parameters["@Idmedico"].Value = 999999;
                    if (comboBox2.SelectedIndex == 0 || comboBox2.SelectedIndex == 4 || comboBox2.SelectedIndex == 5 || comboBox2.SelectedIndex == 6)
                    {
                        iii = Convert.ToInt32(textBox11.Text);
                        da.Parameters["@Idoperacion"].Value = iii;
                        da.Parameters["@Idquirofano"].Value = iii;
                        da.Parameters["@Idpaciente"].Value = iii;
                        da.Parameters["@Idmedico"].Value = iii;
                    }
                    da.Parameters["@Fechao"].Value = datePicker2.Text;
                    da.Parameters["@Horaentrada"].Value = textBox11.Text;
                    da.Parameters["@Horaestsalida"].Value = textBox11.Text;
                    

                    da.Parameters["@Estado"].Value = textBox11.Text;
                    da.Parameters["@Usuario"].Value = textBox11.Text;
                    da.Parameters["@Fecha"].Value = datePicker2.Text;

                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    dt.Load(da.ExecuteReader());
                    dataconnection.Close();
                    dataGrid.DataContext = dt;
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }

        }
        
        private void button1_Click_1(object sender, RoutedEventArgs e)
        {

            ginsert.IsEnabled = true;
            button.IsEnabled = false;
            button3.IsEnabled = true;
            tabItem.Header = "EDITAR";
            string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
            SqlConnection dataconnection = new SqlConnection(conexion);
            DataRowView dataRow = (DataRowView)dataGrid.SelectedItem;
            if (comboBox1.SelectedIndex == 0)
            {
                Visible();
                label1.Content = "Idpaciente";
                label2.Content = "Nombre";
                label3.Content = "Ap.Paterno";
                label4.Content = "Ap.Materno";
                label5.Content = "Nacionalidad";
                label6.Content = "CI";
                label7.Content = "Direccion";
                label12.Content = "Fecha Nac.";
                label8.Content = "Estado civil";
                label9.Content = "N Seguro";
                label10.Content = "Sexo";

                label22.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox5.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;

                label11.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text= dataRow.Row.ItemArray[0].ToString();
                
                textBox1.Text = dataRow.Row.ItemArray[1].ToString();
                textBox2.Text = dataRow.Row.ItemArray[2].ToString();
                textBox3.Text = dataRow.Row.ItemArray[3].ToString();
                textBox4.Text = dataRow.Row.ItemArray[4].ToString();
                textBox5.Text = dataRow.Row.ItemArray[5].ToString();
                textBox6.Text = dataRow.Row.ItemArray[6].ToString();
                datePicker.Text = dataRow.Row.ItemArray[7].ToString();
                textBox7.Text = dataRow.Row.ItemArray[8].ToString();
                textBox8.Text = dataRow.Row.ItemArray[9].ToString();
                textBox9.Text = dataRow.Row.ItemArray[10].ToString();


            }
            if (comboBox1.SelectedIndex == 1)
            {
                Visible();
                label1.Content = "Idmedico";
                label2.Content = "Nombre";
                label3.Content = "Ap.Paterno";
                label4.Content = "Ap.Materno";
                label5.Content = "CI";
                label6.Content = "Telefono";
                label7.Content = "Direccion";
                label12.Content = "Fecha Inicio.";
                label8.Content = "Correo";
                label9.Content = "Cuenta";

                label22.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox5.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text = dataRow.Row.ItemArray[0].ToString();
                
                textBox1.Text = dataRow.Row.ItemArray[1].ToString();
                textBox2.Text = dataRow.Row.ItemArray[2].ToString();
                textBox3.Text = dataRow.Row.ItemArray[3].ToString();
                textBox4.Text = dataRow.Row.ItemArray[4].ToString();
                textBox5.Text = dataRow.Row.ItemArray[5].ToString();
                textBox6.Text = dataRow.Row.ItemArray[6].ToString();
                datePicker.Text = dataRow.Row.ItemArray[7].ToString();
                textBox7.Text = dataRow.Row.ItemArray[8].ToString();
                textBox8.Text = dataRow.Row.ItemArray[9].ToString();
                
            }
            if (comboBox1.SelectedIndex==2)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidmedicos", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidpacientes", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();

                label1.Content = "Idconsulta";
                label12.Content = "Fechaconsulta";
                label2.Content = "Diagnostico";
                label22.Content = "IdMedico";
                label23.Content = "Idpaciente";
                label3.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox2.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text = dataRow.Row.ItemArray[0].ToString();
               
                datePicker.Text = dataRow.Row.ItemArray[1].ToString();
               textBox1.Text= dataRow.Row.ItemArray[2].ToString();
                comboBox5.Text = dataRow.Row.ItemArray[3].ToString();
                comboBox6.Text = dataRow.Row.ItemArray[4].ToString();



            }
            if (comboBox1.SelectedIndex == 3)
            {
                Visible();
                label1.Content = "Idempleado";
                label2.Content = "Nombre";
                label3.Content = "Ap.Paterno";
                label4.Content = "Ap.Materno";
                label5.Content = "Nacionalidad";
                label6.Content = "CI";
                label7.Content = "Telefono";
                label8.Content = "Direccion";
                label9.Content = "Correo";
                label10.Content = "Horario";
                label11.Content = "Sexo";

                label22.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox5.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text = dataRow.Row.ItemArray[0].ToString();
                
                textBox1.Text = dataRow.Row.ItemArray[1].ToString();
                textBox2.Text = dataRow.Row.ItemArray[2].ToString();
                textBox3.Text = dataRow.Row.ItemArray[3].ToString();
                textBox4.Text = dataRow.Row.ItemArray[4].ToString();
                textBox5.Text = dataRow.Row.ItemArray[5].ToString();
                textBox6.Text = dataRow.Row.ItemArray[6].ToString();
                textBox7.Text = dataRow.Row.ItemArray[7].ToString();
                textBox8.Text = dataRow.Row.ItemArray[8].ToString();
                textBox9.Text = dataRow.Row.ItemArray[9].ToString();
                textBox10.Text = dataRow.Row.ItemArray[10].ToString();

            }
            if (comboBox1.SelectedIndex == 4)
            {
                Visible();
                label1.Content = "Idespecialidad";
                label2.Content = "Especialidad";

                label22.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox5.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;

                label3.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;

                textBox2.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text = dataRow.Row.ItemArray[0].ToString();
               
                textBox1.Text = dataRow.Row.ItemArray[1].ToString();
                


            }
            if (comboBox1.SelectedIndex == 5)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidespecialidades", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidmedicos", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();

                label1.Content = "Idespmedico";
                label22.Content = "Idespecialidad";
                label23.Content = "Idmedico";

                label2.Visibility = System.Windows.Visibility.Hidden;
                label3.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox1.Visibility = System.Windows.Visibility.Hidden;
                textBox2.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text = dataRow.Row.ItemArray[0].ToString();
                
                comboBox5.Text = dataRow.Row.ItemArray[1].ToString();
                comboBox6.Text = dataRow.Row.ItemArray[2].ToString();
                

            }
            if (comboBox1.SelectedIndex == 6)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidpisos", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidpacientes", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();

                label1.Content = "Idcama";
                label2.Content = "Estado";
                label22.Content = "Idpiso";
                label23.Content = "Idpaciente";

                label3.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox2.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text = dataRow.Row.ItemArray[0].ToString();
                
                textBox1.Text = dataRow.Row.ItemArray[1].ToString();
                comboBox5.Text = dataRow.Row.ItemArray[2].ToString();
                comboBox6.Text = dataRow.Row.ItemArray[3].ToString();
               


            }
            if (comboBox1.SelectedIndex == 7)
            {
                Visible();
                label1.Content = "Idpiso";
                label2.Content = "Nsalas";
                label3.Content = "Nsalasti";

                label22.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox5.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;

                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text = dataRow.Row.ItemArray[0].ToString();
                
                textBox1.Text = dataRow.Row.ItemArray[1].ToString();
                textBox2.Text = dataRow.Row.ItemArray[2].ToString();
                


            }
            if (comboBox1.SelectedIndex == 8)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidcamas", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidpacientes", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();

                label1.Content = "Idinternacion";
                label12.Content = "Fechaentrada";
                label13.Content = "Fechasalida";
                label22.Content = "Idcama";
                label23.Content = "IdPaciente";

                label2.Visibility = System.Windows.Visibility.Hidden;
                label3.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox1.Visibility = System.Windows.Visibility.Hidden;
                textBox2.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text = dataRow.Row.ItemArray[0].ToString();
                
                datePicker.Text = dataRow.Row.ItemArray[1].ToString();
                datePicker1.Text = dataRow.Row.ItemArray[2].ToString();
                comboBox5.Text = dataRow.Row.ItemArray[3].ToString();
                comboBox6.Text = dataRow.Row.ItemArray[4].ToString();
                

            }
            if (comboBox1.SelectedIndex == 9)
            {
                Visible();
                label1.Content = "Idprecio";
                label2.Content = "Precio";
                label3.Content = "Detalle";
                label4.Content = "Observacion";
                label5.Content = "Total";

                label22.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox5.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;

                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;

                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text = dataRow.Row.ItemArray[0].ToString();
                
                textBox1.Text = dataRow.Row.ItemArray[1].ToString();
                textBox2.Text = dataRow.Row.ItemArray[2].ToString();
                textBox3.Text = dataRow.Row.ItemArray[3].ToString();
                textBox4.Text = dataRow.Row.ItemArray[4].ToString();
                
            }
            if (comboBox1.SelectedIndex == 10)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidpacientes", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidprecios", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();

                label1.Content = "Idmovimiento";
                label22.Content = "Idpaciente";
                label23.Content = "Idprecio";
                label12.Content = "Fecha";
                label4.Content = "Detalle";

                label2.Visibility = System.Windows.Visibility.Hidden;
                label3.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox1.Visibility = System.Windows.Visibility.Hidden;
                textBox2.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text = dataRow.Row.ItemArray[0].ToString();
                
                comboBox5.Text = dataRow.Row.ItemArray[1].ToString();
                comboBox6.Text = dataRow.Row.ItemArray[2].ToString();
                datePicker.Text = dataRow.Row.ItemArray[3].ToString();
                textBox3.Text = dataRow.Row.ItemArray[4].ToString();
               

            }
            if (comboBox1.SelectedIndex == 11)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidpacientes", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidempleados", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();

                label1.Content = "Idlaboratorio";
                label2.Content = "Nomestudio";
                label3.Content = "Fecha y hora";
                label12.Content = "Fecha entrega";
                label22.Content = "Idpaciente";
                label23.Content = "Idempleado";

                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;

                label13.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text = dataRow.Row.ItemArray[0].ToString();
                
                textBox1.Text = dataRow.Row.ItemArray[1].ToString();
                textBox2.Text = dataRow.Row.ItemArray[2].ToString();
                datePicker.Text = dataRow.Row.ItemArray[3].ToString();
                comboBox5.Text = dataRow.Row.ItemArray[4].ToString();
                comboBox6.Text = dataRow.Row.ItemArray[5].ToString();
                

            }
            if (comboBox1.SelectedIndex == 12)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidpisos", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                

                label1.Content = "Idquirofano";
                label22.Content = "Idpiso";

                label2.Visibility = System.Windows.Visibility.Hidden;
                
                label3.Visibility = System.Windows.Visibility.Hidden;
                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;
                label12.Visibility = System.Windows.Visibility.Hidden;
                label13.Visibility = System.Windows.Visibility.Hidden;
                label24.Visibility = System.Windows.Visibility.Hidden;
                comboBox7.Visibility = System.Windows.Visibility.Hidden;
                label23.Visibility = System.Windows.Visibility.Hidden;
                comboBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox1.Visibility = System.Windows.Visibility.Hidden;
                
                textBox2.Visibility = System.Windows.Visibility.Hidden;
                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                datePicker.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text = dataRow.Row.ItemArray[0].ToString();
                
                comboBox5.Text = dataRow.Row.ItemArray[1].ToString();
                


            }
            if (comboBox1.SelectedIndex == 13)
            {
                Visible();
                SqlCommand da = new SqlCommand("spidquirofanos", dataconnection);
                da.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da.ExecuteNonQuery();
                SqlDataReader lee = da.ExecuteReader();
                while (lee.Read())
                {
                    comboBox5.Items.Add(lee.GetInt32(0));

                }
                dataconnection.Close();

                SqlCommand da1 = new SqlCommand("spidpacientes", dataconnection);
                da1.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da1.ExecuteNonQuery();
                SqlDataReader lee1 = da1.ExecuteReader();
                while (lee1.Read())
                {
                    comboBox6.Items.Add(lee1.GetInt32(0));

                }
                dataconnection.Close();
                SqlCommand da2 = new SqlCommand("spidmedicos", dataconnection);
                da2.CommandType = CommandType.StoredProcedure;
                dataconnection.Open();
                da2.ExecuteNonQuery();
                SqlDataReader lee2 = da2.ExecuteReader();
                while (lee2.Read())
                {
                    comboBox7.Items.Add(lee2.GetInt32(0));

                }
                dataconnection.Close();

                

                label1.Content = "Idoperacion";
                label12.Content = "Fecha op.";
                label2.Content = "Hora entrada";
                label3.Content = "Hora est. salida";
                label22.Content = "Idquirofano";
                label23.Content = "Idpaciente";
                label24.Content = "Idmedico";

                label4.Visibility = System.Windows.Visibility.Hidden;
                label5.Visibility = System.Windows.Visibility.Hidden;
                label6.Visibility = System.Windows.Visibility.Hidden;
                
                label7.Visibility = System.Windows.Visibility.Hidden;
                label8.Visibility = System.Windows.Visibility.Hidden;
                label9.Visibility = System.Windows.Visibility.Hidden;
                label10.Visibility = System.Windows.Visibility.Hidden;
                label11.Visibility = System.Windows.Visibility.Hidden;

                label13.Visibility = System.Windows.Visibility.Hidden;

                textBox3.Visibility = System.Windows.Visibility.Hidden;
                textBox4.Visibility = System.Windows.Visibility.Hidden;
                textBox5.Visibility = System.Windows.Visibility.Hidden;
                
                textBox6.Visibility = System.Windows.Visibility.Hidden;
                textBox7.Visibility = System.Windows.Visibility.Hidden;
                textBox8.Visibility = System.Windows.Visibility.Hidden;
                textBox9.Visibility = System.Windows.Visibility.Hidden;
                textBox10.Visibility = System.Windows.Visibility.Hidden;
                datePicker1.Visibility = System.Windows.Visibility.Hidden;
                textBox.Text = dataRow.Row.ItemArray[0].ToString();
                
                datePicker.Text = dataRow.Row.ItemArray[1].ToString();
                textBox1.Text = dataRow.Row.ItemArray[2].ToString();
                textBox2.Text = dataRow.Row.ItemArray[3].ToString();
                comboBox5.Text = dataRow.Row.ItemArray[4].ToString();
                comboBox6.Text = dataRow.Row.ItemArray[5].ToString();
                comboBox7.Text = dataRow.Row.ItemArray[6].ToString();
                

            }
            textBox.IsEnabled = false;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            tabItem.Header = "INSERTAR";
            if (comboBox1.SelectedIndex == 0)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdatepacientes", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidop", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidom", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nacionalidad", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@CI", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Direccion", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechanac", SqlDbType.Date);
                    da.Parameters.Add("@Estadocivil", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nseguro", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Sexo", SqlDbType.VarChar, 25);
                    
                    da.Parameters["@Idpaciente"].Value = textBox.Text;
                    da.Parameters["@Nombre"].Value = textBox1.Text;
                    da.Parameters["@Apellidop"].Value = textBox2.Text;
                    da.Parameters["@Apellidom"].Value = textBox3.Text;
                    da.Parameters["@Nacionalidad"].Value = textBox4.Text;
                    da.Parameters["@CI"].Value = textBox5.Text;
                    da.Parameters["@Direccion"].Value = textBox6.Text;
                    da.Parameters["@Fechanac"].Value = datePicker.Text;
                    da.Parameters["@Estadocivil"].Value = textBox7.Text;
                    da.Parameters["@Nseguro"].Value = textBox8.Text;
                    da.Parameters["@Sexo"].Value = textBox9.Text;
                    
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdatemedicos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idmedico", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidop", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidom", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@CI", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Telefono", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Direccion", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechainicio", SqlDbType.Date);
                    da.Parameters.Add("@Correo", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Cuenta", SqlDbType.VarChar, 25);

                    
                    da.Parameters["@Idmedico"].Value = textBox.Text;
                    da.Parameters["@Nombre"].Value = textBox1.Text;
                    da.Parameters["@Apellidop"].Value = textBox2.Text;
                    da.Parameters["@Apellidom"].Value = textBox3.Text;
                    da.Parameters["@CI"].Value = textBox4.Text;
                    da.Parameters["@Telefono"].Value = textBox5.Text;
                    da.Parameters["@Direccion"].Value = textBox6.Text;
                    da.Parameters["@Fechainicio"].Value = datePicker.Text;
                    da.Parameters["@Correo"].Value = textBox7.Text;
                    da.Parameters["@Cuenta"].Value = textBox8.Text;

                    
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdateconsultas", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idconsulta", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechaconsulta", SqlDbType.Date);
                    da.Parameters.Add("@Diagnostico", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idmedico", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@IdPaciente", SqlDbType.VarChar, 25);

                    
                    da.Parameters["@Idconsulta"].Value = textBox.Text;
                    da.Parameters["@Fechaconsulta"].Value = datePicker.Text;
                    da.Parameters["@Diagnostico"].Value = textBox1.Text;
                    da.Parameters["@Idmedico"].Value = comboBox5.Text;
                    da.Parameters["@Idpaciente"].Value = comboBox6.Text;

                    
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdateempleados", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idempleado", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidop", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Apellidom", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nacionalidad", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@CI", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Telefono", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Direccion", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Correo", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Horario", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Sexo", SqlDbType.VarChar, 25);
                    
                    da.Parameters["@Idempleado"].Value = textBox.Text;
                    da.Parameters["@Nombre"].Value = textBox1.Text;
                    da.Parameters["@Apellidop"].Value = textBox2.Text;
                    da.Parameters["@Apellidom"].Value = textBox3.Text;
                    da.Parameters["@Nacionalidad"].Value = textBox4.Text;
                    da.Parameters["@CI"].Value = textBox5.Text;
                    da.Parameters["@Telefono"].Value = textBox6.Text;
                    da.Parameters["@Direccion"].Value = textBox7.Text;
                    da.Parameters["@Correo"].Value = textBox8.Text;
                    da.Parameters["@Horario"].Value = textBox9.Text;
                    da.Parameters["@Sexo"].Value = textBox10.Text;

                    
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdateespecialidades", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idespecialidad", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Especialidad", SqlDbType.VarChar, 25);


                    
                    da.Parameters["@Idespecialidad"].Value = textBox.Text;
                    da.Parameters["@Especialidad"].Value = textBox1.Text;


                    
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 5)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdateespmedicos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idespmedico", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idespecialidad", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idmedico", SqlDbType.VarChar, 25);


                    
                    da.Parameters["@Idespmedico"].Value = textBox.Text;
                    da.Parameters["@Idespecialidad"].Value = comboBox5.Text;
                    da.Parameters["@Idmedico"].Value = comboBox6.Text;


                   
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 6)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdatecamas", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idcama", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Estadoc", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idpiso", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Camati", SqlDbType.VarChar, 25);


                    
                    da.Parameters["@Idcama"].Value = textBox.Text;
                    da.Parameters["@Estadoc"].Value = textBox1.Text;
                    da.Parameters["@Idpiso"].Value = comboBox5.Text;
                    da.Parameters["@Camati"].Value = comboBox6.Text;



                    
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 7)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdatepisos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idpiso", SqlDbType.Int);
                    da.Parameters.Add("@Nsalas", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nsalasti", SqlDbType.VarChar, 25);


                    
                    da.Parameters["@Idpiso"].Value = textBox.Text;
                    da.Parameters["@Nsalas"].Value = textBox1.Text;
                    da.Parameters["@Nsalasti"].Value = textBox2.Text;



                    
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 8)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdateinternaciones", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idinternacion", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechaentrada", SqlDbType.Date);
                    da.Parameters.Add("@Fechasalida", SqlDbType.Date);
                    da.Parameters.Add("@Idcama", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);

                    
                    da.Parameters["@Idinternacion"].Value = textBox.Text;
                    da.Parameters["@Fechaentrada"].Value = datePicker.Text;
                    da.Parameters["@Fechasalida"].Value = datePicker1.Text;
                    da.Parameters["@Idcama"].Value = comboBox5.Text;
                    da.Parameters["@Idpaciente"].Value = comboBox6.Text;


                   
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 9)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdateprecios", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idprecio", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Precio", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Detalle", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Observacion", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Total", SqlDbType.VarChar, 25);

                    
                    da.Parameters["@Idprecio"].Value = textBox.Text;
                    da.Parameters["@Precio"].Value = textBox1.Text;
                    da.Parameters["@Detalle"].Value = textBox2.Text;
                    da.Parameters["@Observacion"].Value = textBox3.Text;
                    da.Parameters["@Total"].Value = textBox4.Text;


                   
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }

            if (comboBox1.SelectedIndex == 10)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdatemovimientos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idmovimiento", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idprecio", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fecha", SqlDbType.Date);
                    da.Parameters.Add("@Detalle", SqlDbType.VarChar, 25);

                    
                    da.Parameters["@Idmovimiento"].Value = textBox.Text;
                    da.Parameters["@Idpaciente"].Value = comboBox5.Text;
                    da.Parameters["@Idprecio"].Value = comboBox6.Text;
                    da.Parameters["@Fecha"].Value = datePicker.Text;
                    da.Parameters["@Detalle"].Value = textBox3.Text;


                    
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 11)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdatelaboratorios", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idlaboratorio", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Nomestudio", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechayhora", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechaentrega", SqlDbType.Date);
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idempleado", SqlDbType.VarChar, 25);
                   
                    da.Parameters["@Idlaboratorio"].Value = textBox.Text;
                    da.Parameters["@Nomestudio"].Value = textBox1.Text;
                    da.Parameters["@Fechayhora"].Value = textBox2.Text;
                    da.Parameters["@Fechaentrega"].Value = datePicker.Text;
                    da.Parameters["@Idpaciente"].Value = comboBox5.Text;
                    da.Parameters["@Idempleado"].Value = comboBox6.Text;


                    
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 12)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdatequirofanos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idquirofano", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idpiso", SqlDbType.VarChar, 25);


                    
                    da.Parameters["@Idquirofano"].Value = textBox.Text;
                    da.Parameters["@Idpiso"].Value = comboBox5.Text;


                    
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 13)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spupdateoperaciones", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idoperacion", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Fechao", SqlDbType.Date);
                    da.Parameters.Add("@Horaentrada", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Horaestsalida", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idquirofano", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);
                    da.Parameters.Add("@Idmedico", SqlDbType.VarChar, 25);
                    
                    da.Parameters["@Idoperacion"].Value = textBox.Text;
                    da.Parameters["@Fechao"].Value = datePicker.Text;
                    da.Parameters["@Horaentrada"].Value = textBox2.Text;
                    da.Parameters["@Horaestsalida"].Value = textBox3.Text;
                    da.Parameters["@Idquirofano"].Value = comboBox5.Text;
                    da.Parameters["@Idpaciente"].Value = comboBox6.Text;
                    da.Parameters["@Idmedico"].Value = comboBox7.Text;


                    
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se modifico correctamente los datos");
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            textBox.IsEnabled = true;
            button3.IsEnabled = false;
            button.IsEnabled = true;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            DataRowView dataRow = (DataRowView)dataGrid.SelectedItem;
            if (comboBox1.SelectedIndex == 0)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeletepacientes", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idpaciente", SqlDbType.VarChar, 25);
                    da.Parameters["@Idpaciente"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino al paciente con id: " + dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 1)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeletemedicos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                 da.Parameters.Add("@Idmedico", SqlDbType.VarChar, 25);
                    da.Parameters["@Idmedico"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino al medico con id: "+ dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 2)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeleteconsultas", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idconsulta", SqlDbType.VarChar, 25);
                    da.Parameters["@Idconsulta"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino la consulta con id: " + dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 3)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeleteempleados", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idempleado", SqlDbType.VarChar, 25);
                    da.Parameters["@Idempleado"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino al empleado con id: " + dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 4)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeleteespecialidades", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idespecialidad", SqlDbType.VarChar, 25);
                    da.Parameters["@Idespecialidad"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino la especialidad con id: " + dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 5)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeleteespmedicos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idespmedico", SqlDbType.VarChar, 25);
                    da.Parameters["@Idespmedico"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino la esp. de medico con id: " + dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 6)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeletecamas", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idcama", SqlDbType.VarChar, 25);
                    da.Parameters["@Idcama"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino la cama con id: " + dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 7)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeletepisos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idpiso", SqlDbType.VarChar, 25);
                    da.Parameters["@Idpiso"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino el piso con id: " + dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 8)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeleteinternaciones", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idinternacion", SqlDbType.VarChar, 25);
                    da.Parameters["@Idinternacion"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino la internacion con id: " + dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 9)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeleteprecios", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idprecio", SqlDbType.VarChar, 25);
                    da.Parameters["@Idprecio"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino el precio con id: " + dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 10)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeletemovimientos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idmovimiento", SqlDbType.VarChar, 25);
                    da.Parameters["@Idmovimiento"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino el movimiento con id: " + dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 11)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeletelaboratorios", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idlaboratorio", SqlDbType.VarChar, 25);
                    da.Parameters["@Idlaboratorio"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino al laboratorio con id: " + dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 12)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeletequirofanos", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idquirofano", SqlDbType.VarChar, 25);
                    da.Parameters["@Idquirofano"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino al quirofano con id: " + dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
            if (comboBox1.SelectedIndex == 13)
            {
                try
                {
                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlCommand da = new SqlCommand("spdeleteoperaciones", dataconnection);
                    da.CommandType = CommandType.StoredProcedure;
                    da.Parameters.Add("@Idoperacion", SqlDbType.VarChar, 25);
                    da.Parameters["@Idoperacion"].Value = dataRow.Row.ItemArray[0].ToString();
                    dataconnection.Open();
                    da.ExecuteNonQuery();
                    MessageBox.Show("Se elimino la operacion con id: " + dataRow.Row.ItemArray[0].ToString());
                    dataconnection.Close();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                SqlConnection dataconnection = new SqlConnection(conexion);
                SqlDataAdapter da = new SqlDataAdapter("spusuarios", dataconnection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@Usuarioa", SqlDbType.VarChar, 25);
                da.SelectCommand.Parameters.Add("@Password", SqlDbType.VarChar, 25);
                da.SelectCommand.Parameters["@Usuarioa"].Value = textBox12.Text;
                da.SelectCommand.Parameters["@Password"].Value = passwordBox.Password;
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("BIENVENIDO");
                    tabItem.IsEnabled = true;
                    tabItem1.IsEnabled = true;
                    tabItem2.IsEnabled = true;
                    button6.IsEnabled = true;
                    button5.IsEnabled = false;
                    usu = textBox12.Text;
                    textBox12.Text = "";
                    passwordBox.Password = "";

                }
                else
                {
                    MessageBox.Show("USUARIO O PASSWORD INCORRECTO");
                
                }
             
                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Idpaciente");
                comboBox4.Items.Add("Nombre");
                comboBox4.Items.Add("Apellidop");
                comboBox4.Items.Add("Apellidom");
                
                comboBox4.Items.Add("CI");
               

                
            }
            if (comboBox3.SelectedIndex == 1)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Idmedico");
                comboBox4.Items.Add("Nombre");
                comboBox4.Items.Add("Apellidop");
                comboBox4.Items.Add("Apellidom");
                
                comboBox4.Items.Add("CI");
                
            }
            if (comboBox3.SelectedIndex == 2)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Idconsulta");
                comboBox4.Items.Add("Fechaconsulta");
                comboBox4.Items.Add("Diagnostico");
                
            }
            if (comboBox3.SelectedIndex == 3)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Idempleados");
                comboBox4.Items.Add("Nombre");
                comboBox4.Items.Add("Apellidop");
                comboBox4.Items.Add("Apellidom");
                
                comboBox4.Items.Add("CI");
                
            }
            if (comboBox3.SelectedIndex == 4)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Idespecialidad");
                comboBox4.Items.Add("Especialidad");

                
            }
            
            if (comboBox3.SelectedIndex == 5)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Idcama");
               
            }
            if (comboBox3.SelectedIndex == 6)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Idpiso");
              
            }
            if (comboBox3.SelectedIndex == 7)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Idinternacion");
                comboBox4.Items.Add("Fechaentrada");
                
            }
            if (comboBox3.SelectedIndex == 8)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Idprecio");
                comboBox4.Items.Add("Precio");
                comboBox4.Items.Add("Detalle");
               
            }
            if (comboBox3.SelectedIndex == 9)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Idmovimiento");
               
                comboBox4.Items.Add("Fecham");
                

            }
            if (comboBox3.SelectedIndex == 10)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Idlaboratorio");
                comboBox4.Items.Add("Nomestudio");
                
            }
            if (comboBox3.SelectedIndex == 11)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Idquirofano");
                
            }
            if (comboBox3.SelectedIndex == 12)
            {
                comboBox4.Items.Clear();
                comboBox4.Items.Add("Idoperacion");
                comboBox4.Items.Add("Fechao");
                comboBox4.Items.Add("Horaentrada");
               
                
            }
        }
        public int iii;
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt = new DataTable();
           

            if (comboBox3.SelectedIndex == 0)
            {
                
                    try
                    {

                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlConnection dataconnection1 = new SqlConnection(conexion);
                    if (comboBox4.SelectedIndex != 0)
                    {

                        
                        SqlCommand da = new SqlCommand("spsepacientes", dataconnection);
                        da.CommandType = CommandType.StoredProcedure;

                        da.Parameters.Add("@Comp", SqlDbType.VarChar, 25);




                        da.Parameters["@Comp"].Value = textBox13.Text;

                        dataconnection.Open();
                        da.ExecuteNonQuery();
                        SqlDataReader lee = da.ExecuteReader();
                        while (lee.Read())
                        {
                            iii = lee.GetInt32(0);
                            SqlCommand da1 = new SqlCommand("spselpacientes", dataconnection1);
                            da1.CommandType = CommandType.StoredProcedure;

                            da1.Parameters.Add("@compid", SqlDbType.Int);

                            da1.Parameters["@Compid"].Value = iii;
                            dataconnection1.Open();
                            da1.ExecuteNonQuery();
                            dt.Load(da1.ExecuteReader());
                            dataconnection1.Close();
                            dataGrid1.DataContext = dt;
                        }

                        dataconnection.Close();
                    }
                    else
                    {
                        iii = Convert.ToInt32(textBox13.Text);
                        SqlCommand da1 = new SqlCommand("spselpacientes", dataconnection1);
                        da1.CommandType = CommandType.StoredProcedure;

                        da1.Parameters.Add("@Compid", SqlDbType.Int);

                        da1.Parameters["@Compid"].Value = iii;
                        dataconnection1.Open();
                        da1.ExecuteNonQuery();
                        dt.Load(da1.ExecuteReader());
                        dataconnection1.Close();
                        dataGrid1.DataContext = dt;


                    }
                    
                    

                }
                    catch ( Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                    }
                
                
            }

            if (comboBox3.SelectedIndex == 1)
            {

                try
                {

                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlConnection dataconnection1 = new SqlConnection(conexion);
                    if (comboBox4.SelectedIndex != 0)
                    {


                        SqlCommand da = new SqlCommand("spsemedicos", dataconnection);
                        da.CommandType = CommandType.StoredProcedure;

                        da.Parameters.Add("@Comp", SqlDbType.VarChar, 25);




                        da.Parameters["@Comp"].Value = textBox13.Text;

                        dataconnection.Open();
                        da.ExecuteNonQuery();
                        SqlDataReader lee = da.ExecuteReader();
                        while (lee.Read())
                        {
                            iii = lee.GetInt32(0);
                            SqlCommand da1 = new SqlCommand("spselmedicos", dataconnection1);
                            da1.CommandType = CommandType.StoredProcedure;

                            da1.Parameters.Add("@Compid", SqlDbType.Int);

                            da1.Parameters["@Compid"].Value = iii;
                            dataconnection1.Open();
                            da1.ExecuteNonQuery();
                            dt.Load(da1.ExecuteReader());
                            dataconnection1.Close();
                            dataGrid1.DataContext = dt;
                        }

                        dataconnection.Close();
                    }
                    else
                    {
                        iii = Convert.ToInt32(textBox13.Text);
                        SqlCommand da1 = new SqlCommand("spselmedicos", dataconnection1);
                        da1.CommandType = CommandType.StoredProcedure;

                        da1.Parameters.Add("@Compid", SqlDbType.Int);

                        da1.Parameters["@Compid"].Value = iii;
                        dataconnection1.Open();
                        da1.ExecuteNonQuery();
                        dt.Load(da1.ExecuteReader());
                        dataconnection1.Close();
                        dataGrid1.DataContext = dt;


                    }



                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }


            }
            if (comboBox3.SelectedIndex == 2)
            {

                try
                {

                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlConnection dataconnection1 = new SqlConnection(conexion);
                    if (comboBox4.SelectedIndex != 0)
                    {


                        SqlCommand da = new SqlCommand("spseconsultas", dataconnection);
                        da.CommandType = CommandType.StoredProcedure;

                        da.Parameters.Add("@Comp", SqlDbType.VarChar, 25);
                        da.Parameters.Add("@F", SqlDbType.Date);



                        da.Parameters["@Comp"].Value = textBox13.Text;
                        da.Parameters["@F"].Value = datePicker4.Text;

                        dataconnection.Open();
                        da.ExecuteNonQuery();
                        SqlDataReader lee = da.ExecuteReader();
                        while (lee.Read())
                        {
                            iii = lee.GetInt32(0);
                            SqlCommand da1 = new SqlCommand("spselconsultas", dataconnection1);
                            da1.CommandType = CommandType.StoredProcedure;

                            da1.Parameters.Add("@Compid", SqlDbType.Int);

                            da1.Parameters["@Compid"].Value = iii;
                            dataconnection1.Open();
                            da1.ExecuteNonQuery();
                            dt.Load(da1.ExecuteReader());
                            dataconnection1.Close();
                            dataGrid1.DataContext = dt;
                        }

                        dataconnection.Close();
                    }
                    else
                    {
                        iii = Convert.ToInt32(textBox13.Text);
                        SqlCommand da1 = new SqlCommand("spselconsultas", dataconnection1);
                        da1.CommandType = CommandType.StoredProcedure;

                        da1.Parameters.Add("@Compid", SqlDbType.Int);

                        da1.Parameters["@Compid"].Value = iii;
                        dataconnection1.Open();
                        da1.ExecuteNonQuery();
                        dt.Load(da1.ExecuteReader());
                        dataconnection1.Close();
                        dataGrid1.DataContext = dt;


                    }



                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }


            }
            if (comboBox3.SelectedIndex == 3)
            {

                try
                {

                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlConnection dataconnection1 = new SqlConnection(conexion);
                    if (comboBox4.SelectedIndex != 0)
                    {


                        SqlCommand da = new SqlCommand("spseempleados", dataconnection);
                        da.CommandType = CommandType.StoredProcedure;

                        da.Parameters.Add("@Comp", SqlDbType.VarChar, 25);




                        da.Parameters["@Comp"].Value = textBox13.Text;

                        dataconnection.Open();
                        da.ExecuteNonQuery();
                        SqlDataReader lee = da.ExecuteReader();
                        while (lee.Read())
                        {
                            iii = lee.GetInt32(0);
                            SqlCommand da1 = new SqlCommand("spselempleados", dataconnection1);
                            da1.CommandType = CommandType.StoredProcedure;

                            da1.Parameters.Add("@Compid", SqlDbType.Int);

                            da1.Parameters["@Compid"].Value = iii;
                            dataconnection1.Open();
                            da1.ExecuteNonQuery();
                            dt.Load(da1.ExecuteReader());
                            dataconnection1.Close();
                            dataGrid1.DataContext = dt;
                        }

                        dataconnection.Close();
                    }
                    else
                    {
                        iii = Convert.ToInt32(textBox13.Text);
                        SqlCommand da1 = new SqlCommand("spselempleados", dataconnection1);
                        da1.CommandType = CommandType.StoredProcedure;

                        da1.Parameters.Add("@compid", SqlDbType.Int);

                        da1.Parameters["@compid"].Value = iii;
                        dataconnection1.Open();
                        da1.ExecuteNonQuery();
                        dt.Load(da1.ExecuteReader());
                        dataconnection1.Close();
                        dataGrid1.DataContext = dt;


                    }



                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }


            }
            if (comboBox3.SelectedIndex == 4)
            {

                try
                {

                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlConnection dataconnection1 = new SqlConnection(conexion);
                    if (comboBox4.SelectedIndex != 0)
                    {


                        SqlCommand da = new SqlCommand("spseespecialidades", dataconnection);
                        da.CommandType = CommandType.StoredProcedure;

                        da.Parameters.Add("@Comp", SqlDbType.VarChar, 25);




                        da.Parameters["@Comp"].Value = textBox13.Text;

                        dataconnection.Open();
                        da.ExecuteNonQuery();
                        SqlDataReader lee = da.ExecuteReader();
                        while (lee.Read())
                        {
                            iii = lee.GetInt32(0);
                            SqlCommand da1 = new SqlCommand("spselespecialidades", dataconnection1);
                            da1.CommandType = CommandType.StoredProcedure;

                            da1.Parameters.Add("@Compid", SqlDbType.Int);

                            da1.Parameters["@Compid"].Value = iii;
                            dataconnection1.Open();
                            da1.ExecuteNonQuery();
                            dt.Load(da1.ExecuteReader());
                            dataconnection1.Close();
                            dataGrid1.DataContext = dt;
                        }

                        dataconnection.Close();
                    }
                    else
                    {
                        iii = Convert.ToInt32(textBox13.Text);
                        SqlCommand da1 = new SqlCommand("spselespecialidades", dataconnection1);
                        da1.CommandType = CommandType.StoredProcedure;

                        da1.Parameters.Add("@Compid", SqlDbType.Int);

                        da1.Parameters["@Compid"].Value = iii;
                        dataconnection1.Open();
                        da1.ExecuteNonQuery();
                        dt.Load(da1.ExecuteReader());
                        dataconnection1.Close();
                        dataGrid1.DataContext = dt;


                    }



                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }


            }

            if (comboBox3.SelectedIndex == 5)
            {

                try
                {

                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlConnection dataconnection1 = new SqlConnection(conexion);
                   
                    
                    
                        iii = Convert.ToInt32(textBox13.Text);
                        SqlCommand da1 = new SqlCommand("spsecamas", dataconnection1);
                        da1.CommandType = CommandType.StoredProcedure;

                        da1.Parameters.Add("@Compid", SqlDbType.Int);

                        da1.Parameters["@Compid"].Value = iii;
                        dataconnection1.Open();
                        da1.ExecuteNonQuery();
                        dt.Load(da1.ExecuteReader());
                        dataconnection1.Close();
                        dataGrid1.DataContext = dt;


                    



                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }


            }
            if (comboBox3.SelectedIndex == 6)
            {

                try
                {

                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlConnection dataconnection1 = new SqlConnection(conexion);



                    iii = Convert.ToInt32(textBox13.Text);
                    SqlCommand da1 = new SqlCommand("spsepisos", dataconnection1);
                    da1.CommandType = CommandType.StoredProcedure;

                    da1.Parameters.Add("@Compid", SqlDbType.Int);

                    da1.Parameters["@Compid"].Value = iii;
                    dataconnection1.Open();
                    da1.ExecuteNonQuery();
                    dt.Load(da1.ExecuteReader());
                    dataconnection1.Close();
                    dataGrid1.DataContext = dt;






                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }


            }

            if (comboBox3.SelectedIndex == 7)
            {

                try
                {

                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlConnection dataconnection1 = new SqlConnection(conexion);
                    if (comboBox4.SelectedIndex != 0)
                    {


                        SqlCommand da = new SqlCommand("spseinternaciones", dataconnection);
                        da.CommandType = CommandType.StoredProcedure;

                        da.Parameters.Add("@F", SqlDbType.Date);




                        da.Parameters["@F"].Value = datePicker4.Text;

                        dataconnection.Open();
                        da.ExecuteNonQuery();
                        SqlDataReader lee = da.ExecuteReader();
                        while (lee.Read())
                        {
                            iii = lee.GetInt32(0);
                            SqlCommand da1 = new SqlCommand("spselinternaciones", dataconnection1);
                            da1.CommandType = CommandType.StoredProcedure;

                            da1.Parameters.Add("@compid", SqlDbType.Int);

                            da1.Parameters["@Compid"].Value = iii;
                            dataconnection1.Open();
                            da1.ExecuteNonQuery();
                            dt.Load(da1.ExecuteReader());
                            dataconnection1.Close();
                            dataGrid1.DataContext = dt;
                        }

                        dataconnection.Close();
                    }
                    else
                    {
                        iii = Convert.ToInt32(textBox13.Text);
                        SqlCommand da1 = new SqlCommand("spselinternaciones", dataconnection1);
                        da1.CommandType = CommandType.StoredProcedure;

                        da1.Parameters.Add("@Compid", SqlDbType.Int);

                        da1.Parameters["@Compid"].Value = iii;
                        dataconnection1.Open();
                        da1.ExecuteNonQuery();
                        dt.Load(da1.ExecuteReader());
                        dataconnection1.Close();
                        dataGrid1.DataContext = dt;


                    }



                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }


            }

            if (comboBox3.SelectedIndex == 8)
            {

                try
                {

                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlConnection dataconnection1 = new SqlConnection(conexion);
                    if (comboBox4.SelectedIndex != 0)
                    {


                        SqlCommand da = new SqlCommand("spseprecios", dataconnection);
                        da.CommandType = CommandType.StoredProcedure;

                        da.Parameters.Add("@Comp", SqlDbType.VarChar, 25);




                        da.Parameters["@Comp"].Value = textBox13.Text;

                        dataconnection.Open();
                        da.ExecuteNonQuery();
                        SqlDataReader lee = da.ExecuteReader();
                        while (lee.Read())
                        {
                            iii = lee.GetInt32(0);
                            SqlCommand da1 = new SqlCommand("spselprecios", dataconnection1);
                            da1.CommandType = CommandType.StoredProcedure;

                            da1.Parameters.Add("@compid", SqlDbType.Int);

                            da1.Parameters["@Compid"].Value = iii;
                            dataconnection1.Open();
                            da1.ExecuteNonQuery();
                            dt.Load(da1.ExecuteReader());
                            dataconnection1.Close();
                            dataGrid1.DataContext = dt;
                        }

                        dataconnection.Close();
                    }
                    else
                    {
                        iii = Convert.ToInt32(textBox13.Text);
                        SqlCommand da1 = new SqlCommand("spselprecios", dataconnection1);
                        da1.CommandType = CommandType.StoredProcedure;

                        da1.Parameters.Add("@Compid", SqlDbType.Int);

                        da1.Parameters["@Compid"].Value = iii;
                        dataconnection1.Open();
                        da1.ExecuteNonQuery();
                        dt.Load(da1.ExecuteReader());
                        dataconnection1.Close();
                        dataGrid1.DataContext = dt;


                    }



                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }


            }

            if (comboBox3.SelectedIndex == 9)
            {

                try
                {

                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlConnection dataconnection1 = new SqlConnection(conexion);
                    if (comboBox4.SelectedIndex != 0)
                    {


                        SqlCommand da = new SqlCommand("spsemovimientos", dataconnection);
                        da.CommandType = CommandType.StoredProcedure;

                        da.Parameters.Add("@F", SqlDbType.Date);




                        da.Parameters["@F"].Value = datePicker4.Text;

                        dataconnection.Open();
                        da.ExecuteNonQuery();
                        SqlDataReader lee = da.ExecuteReader();
                        while (lee.Read())
                        {
                            iii = lee.GetInt32(0);
                            SqlCommand da1 = new SqlCommand("spselmovimientos", dataconnection1);
                            da1.CommandType = CommandType.StoredProcedure;

                            da1.Parameters.Add("@compid", SqlDbType.Int);

                            da1.Parameters["@Compid"].Value = iii;
                            dataconnection1.Open();
                            da1.ExecuteNonQuery();
                            dt.Load(da1.ExecuteReader());
                            dataconnection1.Close();
                            dataGrid1.DataContext = dt;
                        }

                        dataconnection.Close();
                    }
                    else
                    {
                        iii = Convert.ToInt32(textBox13.Text);
                        SqlCommand da1 = new SqlCommand("spselmovimientos", dataconnection1);
                        da1.CommandType = CommandType.StoredProcedure;

                        da1.Parameters.Add("@Compid", SqlDbType.Int);

                        da1.Parameters["@Compid"].Value = iii;
                        dataconnection1.Open();
                        da1.ExecuteNonQuery();
                        dt.Load(da1.ExecuteReader());
                        dataconnection1.Close();
                        dataGrid1.DataContext = dt;


                    }



                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }


            }

            if (comboBox3.SelectedIndex == 10)
            {

                try
                {

                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlConnection dataconnection1 = new SqlConnection(conexion);
                    if (comboBox4.SelectedIndex != 0)
                    {


                        SqlCommand da = new SqlCommand("spselaboratorios", dataconnection);
                        da.CommandType = CommandType.StoredProcedure;

                        da.Parameters.Add("@Comp", SqlDbType.VarChar, 25);




                        da.Parameters["@Comp"].Value = textBox13.Text;

                        dataconnection.Open();
                        da.ExecuteNonQuery();
                        SqlDataReader lee = da.ExecuteReader();
                        while (lee.Read())
                        {
                            iii = lee.GetInt32(0);
                            SqlCommand da1 = new SqlCommand("spsellaboratorios", dataconnection1);
                            da1.CommandType = CommandType.StoredProcedure;

                            da1.Parameters.Add("@compid", SqlDbType.Int);

                            da1.Parameters["@Compid"].Value = iii;
                            dataconnection1.Open();
                            da1.ExecuteNonQuery();
                            dt.Load(da1.ExecuteReader());
                            dataconnection1.Close();
                            dataGrid1.DataContext = dt;
                        }

                        dataconnection.Close();
                    }
                    else
                    {
                        iii = Convert.ToInt32(textBox13.Text);
                        SqlCommand da1 = new SqlCommand("spsellaboratorios", dataconnection1);
                        da1.CommandType = CommandType.StoredProcedure;

                        da1.Parameters.Add("@Compid", SqlDbType.Int);

                        da1.Parameters["@Compid"].Value = iii;
                        dataconnection1.Open();
                        da1.ExecuteNonQuery();
                        dt.Load(da1.ExecuteReader());
                        dataconnection1.Close();
                        dataGrid1.DataContext = dt;


                    }



                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }


            }

            if (comboBox3.SelectedIndex ==11)
            {

                try
                {

                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlConnection dataconnection1 = new SqlConnection(conexion);
                   
                        iii = Convert.ToInt32(textBox13.Text);
                        SqlCommand da1 = new SqlCommand("spsequirofanos", dataconnection1);
                        da1.CommandType = CommandType.StoredProcedure;

                        da1.Parameters.Add("@Compid", SqlDbType.Int);

                        da1.Parameters["@Compid"].Value = iii;
                        dataconnection1.Open();
                        da1.ExecuteNonQuery();
                        dt.Load(da1.ExecuteReader());
                        dataconnection1.Close();
                        dataGrid1.DataContext = dt;


                    



                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }


            }

            if (comboBox3.SelectedIndex == 12)
            {

                try
                {

                    string conexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=true;";
                    SqlConnection dataconnection = new SqlConnection(conexion);
                    SqlConnection dataconnection1 = new SqlConnection(conexion);
                    if (comboBox4.SelectedIndex != 0)
                    {


                        SqlCommand da = new SqlCommand("spseoperaciones", dataconnection);
                        da.CommandType = CommandType.StoredProcedure;

                        da.Parameters.Add("@F", SqlDbType.Date);
                        da.Parameters.Add("@Comp", SqlDbType.VarChar, 25);



                        da.Parameters["@F"].Value = datePicker4.Text;
                        da.Parameters["@Comp"].Value = textBox13.Text;

                        dataconnection.Open();
                        da.ExecuteNonQuery();
                        SqlDataReader lee = da.ExecuteReader();
                        while (lee.Read())
                        {
                            iii = lee.GetInt32(0);
                            SqlCommand da1 = new SqlCommand("spseloperaciones", dataconnection1);
                            da1.CommandType = CommandType.StoredProcedure;

                            da1.Parameters.Add("@compid", SqlDbType.Int);

                            da1.Parameters["@Compid"].Value = iii;
                            dataconnection1.Open();
                            da1.ExecuteNonQuery();
                            dt.Load(da1.ExecuteReader());
                            dataconnection1.Close();
                            dataGrid1.DataContext = dt;
                        }

                        dataconnection.Close();
                    }
                    else
                    {
                        iii = Convert.ToInt32(textBox13.Text);
                        SqlCommand da1 = new SqlCommand("spseloperaciones", dataconnection1);
                        da1.CommandType = CommandType.StoredProcedure;

                        da1.Parameters.Add("@Compid", SqlDbType.Int);

                        da1.Parameters["@Compid"].Value = iii;
                        dataconnection1.Open();
                        da1.ExecuteNonQuery();
                        dt.Load(da1.ExecuteReader());
                        dataconnection1.Close();
                        dataGrid1.DataContext = dt;


                    }



                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.ToString());
                }


            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            tabItem.IsEnabled = false;
            tabItem1.IsEnabled = false;
            tabItem2.IsEnabled = false;
            button5.IsEnabled = true;
            button6.IsEnabled = false;
            textBox11.Text = "";
        }
    }
}
