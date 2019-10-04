using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace AdministradorProce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ActualizarProcesos();

        }

        private void ActualizarProcesos()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
            int id = 1;
            foreach (Process procesos in Process.GetProcesses())
            {
                listBox1.Items.Add(id + ": " + procesos.ProcessName );
                listBox2.Items.Add(id + ": " + procesos.Id);
                listBox3.Items.Add(id + ": " + procesos.WorkingSet64);
                listBox4.Items.Add(id + ": " + procesos.VirtualMemorySize64);
                listBox5.Items.Add(id + ": " + procesos.SessionId);
                id = id + 1;
           
            }
            label6.Text = "Total de Procesos:  " + listBox1.Items.Count.ToString();


        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarProcesos();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (Process Programa in Process.GetProcesses())
                {
                    String seleccion = listBox1.SelectedItem.ToString();
                    String[] proceso = seleccion.Split(':');
                    if (Programa.ProcessName == proceso[1])
                    {
                        Programa.Kill();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
