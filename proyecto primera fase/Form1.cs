using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_primera_fase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void abrirformhijo(object formhijo)
        {
            if (this.contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0) ;
            Form inicio = formhijo as Form;
            inicio.TopLevel = false;
            inicio.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(inicio);
            this.contenedor.Tag = inicio;
            inicio.Show();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Form2());
        }
    }
}
