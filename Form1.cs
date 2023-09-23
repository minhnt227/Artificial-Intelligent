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
                if (listBox1.SelectedItem is null)
                {
                    MessageBox.Show("Select something bro :<", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            Graph.SaveFile();
            MessageBox.Show("OK!", "Save Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Graph.GraphColoring();
            MessageBox.Show("OK!", "Color Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
