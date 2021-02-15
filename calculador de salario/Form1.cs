using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculador_de_salario
{
    public partial class posLab : Form
    {
        public posLab()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
         //Text Box
            string puesto = combBoxPuesto.Text;
            double salarionormal = double.Parse(txtSalario.Text);
            double descuento = 0.20;
            double salariofinal = 0;

            switch (puesto)
            {
                case "Gerente":
                    descuento = salarionormal * 0.20;
                    salariofinal = salarionormal - descuento;
                    break;

                case "SubGerente":
                    descuento = salarionormal * 0.15;
                    salariofinal = salarionormal - descuento;
                    break;

                case "Secretaria":
                    descuento = salarionormal * 0.05;
                    salariofinal = salarionormal - descuento;
                    break;
            }

            //MessageBox.Show("Bienvenido a POO " + nombre + " este es tu primer formulario");
            MessageBox.Show(" Estimado " + nombre + ", su salario aplicando descuentos será de: " + salariofinal + " Dolares Norte Americanos");



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void posLab_Load(object sender, EventArgs e)
        {
            combBoxPuesto.Items.Clear();
            combBoxPuesto.Items.Add("Gerente");
            combBoxPuesto.Items.Add("Subgerente");
            combBoxPuesto.Items.Add("Secretaria");
            fecha.Text = DateTime.Now.ToLongDateString();
            hora.Text = DateTime.Now.ToShortTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
