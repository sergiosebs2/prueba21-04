using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1RAappDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// METODO BOTON PARA LA CLASE FORM1, SE VA A EJECUTAR CUANDO HAGA CLICK
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(" TRIPA Y CORAZON ");        
            string texto = CajaParaNombre.Text;
            SaludoPosta.Text = "HOLA QUERIDO " + texto;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("SE ABRIRA EL PROGRAMA...");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("HAS CERRADO LA APLICACION, ME MUERO...");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SaludoPosta_Click(object sender, EventArgs e)
        {

        }

        private void CajaParaNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
