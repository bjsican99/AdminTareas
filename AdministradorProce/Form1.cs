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

        private void ActualizarProcesos(){
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox5.Items.Clear();
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
        }
        private void label1_Click(object sender, EventArgs e){
        }

        private void button1_Click(object sender, EventArgs e){
            ActualizarProcesos();

        }

        private void button2_Click(object sender, EventArgs e){
            try{
                foreach (Process pro in Process.GetProcesses()){
                    string strSelec = listBox1.SelectedItem.ToString(); // proceso seleccionado en el list box
                    string[] strProceso = strSelec.Split(':');// divido el contenido del listbox

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
