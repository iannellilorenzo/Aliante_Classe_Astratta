using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aliante_Classe_Astratta
{
    public partial class Form1 : Form
    {
        public Aliante aliante;

        public Form1()
        {
            InitializeComponent();
            aliante = new Aliante();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FusoRadio_CheckedChanged(object sender, EventArgs e)
        {
            CercLabel.Hide();
            GomLabel.Hide();

            Label3.Hide();
            Label4.Hide();
            Label5.Hide();

            Label1.Text = "Lunghezza";
            Label2.Text = "Materiale";
        }
    }
}
