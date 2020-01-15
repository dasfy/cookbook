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
        }

        private void addReceptB_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
