using Graph_Coloring.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Coloring
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Country A;
            if ( txtName.Text.Length == 0)
            {
                MessageBox.Show("Please input something first");
            }
            A = new Country(txtName.Text);
            Graph.n++;
            Graph.CountryList.Add(A);
            listBox1.Items.AddRange(Graph.CountryList.ToArray());
            listBox1.DisplayMember = "name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Country select = listBox1.SelectedItem as Country;
                select.CShow();
            }
            catch (NullReferenceException ex) 
            { MessageBox.Show(ex.ToString()); }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(Graph.CountryList.ToArray());
            listBox1.DisplayMember = "name";
        }
    }
}
