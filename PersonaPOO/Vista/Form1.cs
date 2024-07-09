using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalcularEdad();
        }

        private void CalcularEdad()
        {
            int year = int.Parse(txtYear.Text);
            int month = int.Parse(txtMonth.Text);
            int day = int.Parse(txtDay.Text);

            DateTime birthDate = new DateTime(year, month, day);
            TimeSpan age = DateTime.Now.Subtract(birthDate);

            int years = (int)(age.TotalDays / 365.25);

            MessageBox.Show("Tu edad es: " + years + " años.");
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            imc();
        }
        private void imc()
        {
            double peso = double.Parse(txtPeso.Text);
            double estatura = double.Parse(txtEstatura.Text) / 100.0;

            double imc = peso / (estatura * estatura);

            MessageBox.Show("Tu índice de masa corporal es: " + imc.ToString("F2"));
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
