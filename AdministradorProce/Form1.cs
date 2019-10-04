using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorProce{

    public partial class Form1 : Form{

        public Form1(){
            InitializeComponent();
            ActualizarProcesos();
            timer1.Enabled = true;
        }

<<<<<<< HEAD
        private void ActualizarProcesos(){
=======
        private void ActualizarProcesos()
        {
>>>>>>> ac4830a55b13684cc0d936c3a3f9a94999377214
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
<<<<<<< HEAD
            int contador = 1;
            foreach (Process pro in Process.GetProcesses())
            {
            listBox1.Items.Add(contador + ":" + pro.ProcessName); // nombre del proceso
            listBox2.Items.Add(contador + ": " + pro.Id);// id del proceso
            listBox3.Items.Add(contador + ": " + pro.WorkingSet64);// RAM del proceso
            listBox4.Items.Add(contador + ": " + pro.VirtualMemorySize64); // MEmoria virtual del proceso
            listBox5.Items.Add(contador + ": " + pro.SessionId); // CPU que usa el proceso
                contador += 1;
            }
            label6.Text = "Total de Procesos:  " + listBox1.Items.Count.ToString();
=======
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


>>>>>>> ac4830a55b13684cc0d936c3a3f9a94999377214
        }
        private void label1_Click(object sender, EventArgs e){
        }

        private void button1_Click(object sender, EventArgs e){
            ActualizarProcesos();

        }

<<<<<<< HEAD
        private void button2_Click(object sender, EventArgs e){
            try{
                foreach (Process pro in Process.GetProcesses()){
                    string strSelec = listBox1.SelectedItem.ToString(); // proceso seleccionado en el list box
                    string[] strProceso = strSelec.Split(':');// divido el contenido del listbox
=======
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
>>>>>>> ac4830a55b13684cc0d936c3a3f9a94999377214

                    if (pro.ProcessName == strProceso[1]){
                        pro.Kill(); // elimina el proceso
                    }
                }
                ActualizarProcesos();
            }
            catch (Exception ex){
                MessageBox.Show("Ningun Proceso Seleccionado " + ex,"Error Al Eliminar el Proceso",MessageBoxButtons.OK);
                ActualizarProcesos();
            }
        }
        
        private void button3_Click(object sender, EventArgs e){
            Close();
        }

        private void Form1_Load(object sender, EventArgs e){
        }

        private void timer1_Tick(object sender, EventArgs e){
            //ActualizarProcesos();
        }
    }
}
