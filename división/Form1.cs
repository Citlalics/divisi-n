using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace división
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // crear el objeto,y se pasa valores al constructor 
            division divi = new division(double.Parse(txt1.Text), double.Parse(txt2.Text));
            //pasar valores, se usa el ToString por que esta pasando un valor numerico 
            txtResult.Text = divi.rdivi().ToString();
            //
        }
    }
}
