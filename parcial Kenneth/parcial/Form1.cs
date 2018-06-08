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
namespace parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<libros> libro = new List<libros>();
        List<alumno> alumno = new List<alumno>();

        private void Form1_Load(object sender, EventArgs e)
        {
            string archivo = "libros.txt";
            FileStream leer = new FileStream(archivo, FileMode.Open, FileAccess.Read);
            StreamReader lectro = new StreamReader(leer);
            while (lectro.Peek() > -1)
            {
                libros tem = new libros();
                tem.Nombre = lectro.ReadLine();
                tem.Carne = Convert.ToInt16(lectro.ReadLine());
                libro.Add(tem);

            }
            lectro.Close();
            for (int a = 0; a < libro.Count; a++)
            {
                comboBox1.Items.Add(libro[a].Nombre);
                //add = agregar 
                // intems espacios de conbobx1
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "h.txt";
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            for (int i = 0; i < libro.Count(); i++)
            {
                if (comboBox1.Text == (libro[i].Nombre))
                {
                    writer.WriteLine(libro[i].Carne);
                    writer.WriteLine(textBox1.Text);
                    alumno tem = new alumno();
                    tem.Carne = Convert.ToInt16(textBox1.Text);
                    tem.Nombre = (libro[i].Nombre);
                    alumno.Add(tem);


                }
            }
            writer.Close();
            textBox1.Text = "";
            textBox1.Focus();
            comboBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = "alumnos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            for (int a = 0; a < alumno.Count; a++)
            {
                if (textBox1.Text == (alumno[a].Carne.ToString()))
                {
                    alumno tem = new alumno();
                    tem.Carne = (alumno[a].Carne);
                    tem.Nombre = (alumno[a].Nombre);
                    alumno.Add(tem);
                }
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = alumno;
                dataGridView1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                string fileName = "alumnos.txt";
                FileStream stream = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(stream);
                for (int a = 0; a < alumno.Count; a++)
                {
                    if (textBox1.Text == (alumno[a].Carne.ToString()))
                    {
                        alumno tem = new alumno();
                        tem.Carne = (alumno[a].Carne);
                        tem.Nombre = (alumno[a].Nombre);
                        alumno.Add(tem);
                    }
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = alumno;
                    dataGridView1.Refresh();
                }

            }
        }
    }
}
