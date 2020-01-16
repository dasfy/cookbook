using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cookbook.ServiceReference2;
using Npgsql;

namespace cookbook
{
    public partial class adding : Form
    {
        ServiceClient service = new ServiceClient();
        string param = "";
        public adding(string parameter)
        {
            param = parameter;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (param == "autor")
            {
                service.AddAutors(textBox1.Text);
            }
            if (param == "kitchen")
            {
                service.AddKitchens(textBox1.Text);
            }
            if (param == "ingredient")
            {
                service.AddIngredients(textBox1.Text);
            }

            Form form1 = new Form1();
            form1.Show();
        }
    }
}
