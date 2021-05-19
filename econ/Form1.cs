using econ.econnClasess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace econ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        connClass c = new connClass();
            
             
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btsave_Click(object sender, EventArgs e)
        {
            c.firstname = textfname.Text;
            c.lastname = textlname.Text;
            c.contact = textcon.Text;
            c.address = textaddress.Text;
            c.gender = combogender.Text;

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("Successfully Save");
            }
            else
            {
                MessageBox.Show("faild");

            }
        }
    }
}
