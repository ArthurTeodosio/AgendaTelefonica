using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AgendaTelefonica
{
    public partial class Form1 : Form
    {
        public Pessoa Pessoa { get; set; } = new Pessoa();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            listTelefones.Items.Clear(); 
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa = new Pessoa();
            
            pessoa.Nome = Nome.Text;
            pessoa.Telefone = Telefone.Text;
            listTelefones.Items.Add(pessoa);
        }
    }
}
