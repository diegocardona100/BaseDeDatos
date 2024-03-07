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


namespace BaseDeDatos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        List<Empleado> empleados = new List<Empleado>();

        List<Reporte> reportes = new List<Reporte>();




        public void CargarEmpleados()
        {

            string fileName = "Empleados.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                Empleado empleado = new Empleado();
                empleado.NumEm = Convert.ToInt16(reader.ReadLine());
                empleado.Nombre = reader.ReadLine();
                empleado.Sueldo = Convert.ToDecimal(reader.ReadLine());


                empleados.Add(empleado);


                //reader.ReadLine();

            }

            reader.Close();

        }
        public void MostrarEmpleados()
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = empleados;
            dataGridView1.Refresh();


        }

        List<Asistencia> asistencias = new List<Asistencia>();

        public void CargarAsistencia()
        {


            string fileName = "Asistencia.txt";

            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);


            while (reader.Peek() > -1)
            {
                Asistencia asistenciaemp = new Asistencia();

                asistenciaemp.NumeroEm = Convert.ToInt16(reader.ReadLine());
                asistenciaemp.Horas = Convert.ToInt32(reader.ReadLine());
                asistenciaemp.Mes = Convert.ToInt32(reader.ReadLine());



                asistencias.Add(asistenciaemp);



                //reader.ReadLine();

            }

            reader.Close();
        }

        public void MostrarAsistencia()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = asistencias;
            dataGridView2.Refresh();
        }

        private void botonabrir_Click(object sender, EventArgs e)
        {

            //CargarEmpleados();
            MostrarEmpleados();
            CargarAsistencia();
            MostrarAsistencia();


            //openFileDialog1.ShowDialog();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            foreach (Empleado empleado in empleados)
            {
                int numEmpleado = empleado.NumEm;
                foreach (Asistencia asistencias in asistencias)
                {
                    if (empleado.NumEm == asistencias.NumeroEm)

                    {
                        Reporte reporte = new Reporte();
                        reporte.Nombreempleado = empleado.Nombre;
                        reporte.Mes = asistencias.Mes;
                        reporte.SueldoMensual = empleado.Sueldo * asistencias.Horas;
                        reportes.Add(reporte);


                    }
                }

            }

            dataGridView3.DataSource = null;
            dataGridView3.DataSource = reportes;
            dataGridView3.Refresh();



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.DataSource = empleados;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string nombre = comboBox1.SelectedValue.ToString();
            
            int noEmpleado = Convert.ToInt16(comboBox1.SelectedValue);
            /*
            for (int i = 0; i < empleados.Count; i++)
            {
                if (noEmpleado == empleados[1].NumEm)
                    textBox1.Text = empleados[i].Nombre;

            }
            */

            Empleado empleadofound = empleados.Find(c => c.NumEm == noEmpleado);

            textBox1.Text = empleadofound.Nombre;





        }

        private void button2_Click(object sender, EventArgs e)
        {

            //textBox1.Text = comboBox1.Text;



            

        }
    }
}
