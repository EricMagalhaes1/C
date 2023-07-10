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
    public partial class FormsEmpresa : Form
    {
        Empresa emp = new Empresa();
        public FormsEmpresa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                emp.constroi(int.Parse(textBox1.Text), textBox2.Text);
                MessageBox.Show("Empresa cadastrada com sucesso");
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
