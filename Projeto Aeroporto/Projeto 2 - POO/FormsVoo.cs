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
    public partial class FormsVoo : Form
    {
        Voo voo = new Voo();  
        public FormsVoo()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
                voo.constroi(int.Parse(textBox1.Text), textBox2.Text);
                MessageBox.Show("Voo registrado com sucesso");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            Form1 form = new Form1();
            form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
