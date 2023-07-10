using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_2___POO
{
    public partial class FormsCompra : Form
    {
        Compra c = new Compra();
        public FormsCompra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
            c.constroi(int.Parse(textBox1.Text), textBox2.Text, double.Parse(textBox3.Text));
            MessageBox.Show("Compra realizada com sucesso");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
