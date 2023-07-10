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
    public partial class FormsPassagem : Form
    {
        Passagem pa = new Passagem();
        public FormsPassagem()
        {
            InitializeComponent();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            try
            {
            pa.constroi(int.Parse(textBox1.Text),textBox2.Text,textBox4.Text,textBox5.Text, textBox3.Text);
            MessageBox.Show("Passagem comprada com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
