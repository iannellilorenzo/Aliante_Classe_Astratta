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

            Prop3.Hide();
            Prop4.Hide();
            Prop5.Hide();

            Prop2.Show();
            Label2.Show();

            Label1.Text = "Lunghezza";
            Label2.Text = "Materiale";
        }

        private void AlaRadio_CheckedChanged(object sender, EventArgs e)
        {
            CercLabel.Hide();
            GomLabel.Hide();

            Label3.Hide();
            Label4.Hide();
            Label5.Hide();

            Prop3.Hide();
            Prop4.Hide();
            Prop5.Hide();

            Label1.Show();
            Label2.Show();

            Label1.Text = "Lunghezza";
            Label2.Text = "Apertura";
        }

        private void CodaRadio_CheckedChanged(object sender, EventArgs e)
        {
            CercLabel.Hide();
            GomLabel.Hide();

            Label2.Hide();
            Label3.Hide();
            Label4.Hide();
            Label5.Hide();

            Prop2.Hide();
            Prop3.Hide();
            Prop4.Hide();
            Prop5.Hide();

            Label1.Show();

            Label1.Text = "Lunghezza";
        }

        private void RuotaRadio_CheckedChanged(object sender, EventArgs e)
        {
            CercLabel.Show();
            GomLabel.Show();

            Label2.Show();
            Label3.Show();
            Label4.Show();
            Label5.Show();

            Prop2.Show();
            Prop3.Show();
            Prop4.Show();
            Prop5.Show();

            Label1.Text = "Pollici";
            Label2.Text = "Materiale";

            Label3.Text = "Altezza";
            Label4.Text = "Larghezza";
            Label5.Text = "Raggio";
        }
    }
}
