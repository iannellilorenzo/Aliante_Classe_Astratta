using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aliante_Classe_Astratta;

namespace Aliante_Classe_Astratta
{
    public partial class Form1 : Form
    {
        public Aliante aliante;
        public int num;

        public Form1()
        {
            InitializeComponent();
            aliante = new Aliante();
            num = 0;
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

        private void AggBut_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(Prop1.Text, out double prop1) || prop1 < 0 || Prop1.Text == "0" || String.IsNullOrEmpty(Prop1.Text))
            {
                MessageBox.Show("Inserire un valore valido.");
                return;
            }

            if (FusoRadio.Checked)
            {
                if (String.IsNullOrEmpty(Prop2.Text))
                {
                    MessageBox.Show("Inserire un materiale valido.");
                    return;
                }

                Fusoliera fusoliera = new Fusoliera(prop1, Prop2.Text);
                aliante.Aggiunta(fusoliera);

                return;
            }

            if (AlaRadio.Checked)
            {
                if (!double.TryParse(Prop2.Text, out double prop2) || prop2 < 0 || Prop2.Text == "0" || String.IsNullOrEmpty(Prop2.Text))
                {
                    MessageBox.Show("Inserire un valore valido.");
                    return;
                }

                Ala ala = new Ala(prop1, prop2);
                aliante.Aggiunta(ala);

                return;
            }

            if (CodaRadio.Checked)
            {
                Coda coda = new Coda(prop1);
                aliante.Aggiunta(coda);

                return;
            }

            if (RuotaRadio.Checked)
            {
                if (String.IsNullOrEmpty(Prop2.Text))
                {
                    MessageBox.Show("Inserire un materiale valido.");
                    return;
                }

                if (!double.TryParse(Prop3.Text, out double prop3) || prop3 < 0 || Prop3.Text == "0" || String.IsNullOrEmpty(Prop3.Text))
                {
                    MessageBox.Show("Inserire un'altezza valida.");
                    return;
                }

                if (!double.TryParse(Prop4.Text, out double prop4) || prop4 < 0 || Prop4.Text == "0" || String.IsNullOrEmpty(Prop4.Text))
                {
                    MessageBox.Show("Inserire una larghezza valida.");
                    return;
                }

                if (!double.TryParse(Prop5.Text, out double prop5) || prop5 < 0 || Prop5.Text == "0" || String.IsNullOrEmpty(Prop5.Text))
                {
                    MessageBox.Show("Inserire un raggio valido.");
                    return;
                }

                Cerchione cerchione = new Cerchione(prop1, Prop2.Text);
                Gomma gomma = new Gomma(prop3, prop4, prop5);

                Ruota ruota = new Ruota(cerchione, gomma);

                aliante.Aggiunta(ruota);
            }
        }

        private void RimBut_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(RimIndex.Text, out int index) || index < 0 || RimIndex.Text == "0" || String.IsNullOrEmpty(RimIndex.Text))
            {
                MessageBox.Show("Inserire un indice valido.");
                return;
            }

            aliante.Rimuovi(index);
        }
    }
}
