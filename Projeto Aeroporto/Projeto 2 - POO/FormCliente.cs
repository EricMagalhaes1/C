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
    public partial class FormCliente : Form
    {
        Cliente cl = new Cliente();
        public FormCliente()
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
            cl.constroi(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, textBox4.Text);
            MessageBox.Show("Cliente cadastrado com sucesso");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
