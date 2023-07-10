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
    public partial class FormsAeronave : Form
    {
        Aeronave aero = new Aeronave();
        public FormsAeronave()
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
            aero.constroi(int.Parse(textBox1.Text), textBox2.Text, int.Parse(textBox3.Text), int.Parse(textBox5.Text));
                MessageBox.Show("Aeroporto cadastrado com sucesso");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
