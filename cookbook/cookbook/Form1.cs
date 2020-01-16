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
    public partial class Form1 : Form
    {
        ServiceClient service = new ServiceClient();
        public Form1()
        {
            InitializeComponent();

            //fill ingred  boxes
            var smth = service.GetIngred();
            ComboBox[] boxes = new ComboBox[] { ingred1C, ingred2C, ingred3C, ingred4C, ingred5C };
            for (var i = 0; i < 5; i++)
                for (var j = 0; j < smth.Length; j++)
                    boxes[i].Items.Add(smth[j]);

            //fill measure boxes
            smth = service.GetMeasure();
            ComboBox[] boxes2 = new ComboBox[] { measure1C, measure2C, measure3C, measure4C, measure5C };
            for (var i = 0; i < 5; i++)
                for (var j = 0; j < smth.Length; j++)
                    boxes2[i].Items.Add(smth[j]);

            //fill autor box
            smth = service.GetAutor();
            for (var i = 0; i < smth.Length; i++)
                autorC.Items.Add(smth[i]);

            //fill kitchen box
            smth = service.GetKitchen();
            for (var i = 0; i < smth.Length; i++)
                kitchenC.Items.Add(smth[i]);

            //fill howto box
            smth = service.GetHowto();
            for (var i = 0; i < smth.Length; i++)
                howtoC.Items.Add(smth[i]);

            //fill howto box
            smth = service.GetCategory();
            for (var i = 0; i < smth.Length; i++)
                categoryC.Items.Add(smth[i]);
        }

        private void addReceptB_Click(object sender, EventArgs e)
        {
            string name, description, calories, howto, autor, kitchen, category;
            name = titleT.Text;
            description = descriptionT.Text;
            category = categoryC.Text;
            howto = howtoC.Text;
            autor = autorC.Text;
            kitchen = kitchenC.Text;
            calories = caloriesT.Text;

            string ingred1, ingred2, ingred3, ingred4, ingred5;
            if (ingred1C.Text != "")
                ingred1 = ingred1C.Text;
            else
                ingred1 = "s";
            if (ingred2C.Text != "")
                ingred2 = ingred2C.Text;
            else
                ingred2 = "s";
            if (ingred3C.Text != "")
                ingred3 = ingred3C.Text;
            else
                ingred3 = "s";
            if (ingred4C.Text != "")
                ingred4 = ingred4C.Text;
            else
                ingred4 = "s";
            if (ingred5C.Text != "")
                ingred5 = ingred5C.Text;
            else
                ingred5 = "s";

            int measureV1, measureV2, measureV3, measureV4, measureV5;
            if (measure1T.Text != "")
                measureV1 = Convert.ToInt32(measure1T.Text);
            else
                measureV1 = -1;

            if (measure2T.Text != "")
                measureV2 = Convert.ToInt32(measure2T.Text);
            else
                measureV2 = -1;

            if (measure3T.Text != "")
                measureV3 = Convert.ToInt32(measure3T.Text);
            else
                measureV3 = -1;

            if (measure4T.Text != "")
                measureV4 = Convert.ToInt32(measure4T.Text);
            else
                measureV4 = -1;

            if (measure5T.Text != "")
                measureV5 = Convert.ToInt32(measure5T.Text);
            else
                measureV5 = -1;

            string measure1, measure2, measure3, measure4, measure5;
            if (measure1C.Text != "")
                measure1 = measure1C.Text;
            else
                measure1 = "s";
            if (measure2C.Text != "")
                measure2 = measure2C.Text;
            else
                measure2 = "s";
            if (measure3C.Text != "")
                measure3 = measure3C.Text;
            else
                measure3 = "s";
            if (measure4C.Text != "")
                measure4 = measure4C.Text;
            else
                measure4 = "s";
            if (measure5C.Text != "")
                measure5 = measure5C.Text;
            else
                measure5 = "s";


            service.AddRecept(name, autor, kitchen, howto, category, description, calories, ingred1, measureV1, measure1,
                              ingred2, measureV2, measure2, ingred3, measureV3, measure3, ingred4, measureV4, measure4,
                              ingred5, measureV5, measure5);

            //MessageBox.Show( string.Join("\n", service.Test()) );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new adding("autor");
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new adding("kitchen");
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form2 = new adding("ingredient");
            form2.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
