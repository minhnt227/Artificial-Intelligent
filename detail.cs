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
    public partial class detail : Form
    {
        public Country CDetail = new Country();
        public detail()
        {
            InitializeComponent();
        }
        public void Show(Country a)
        {
            if (a == null) { MessageBox.Show("Error"); }
            else
            {
                List<int> indexes = new List<int>();
                List<Country> NList = new List<Country>();
                NList.AddRange(Graph.CountryList);
                if(NList.Contains(a)) { NList.Remove(a); }
                CDetail = a;
                txtNameD.Text = a.name;
                txtcolorD.Text = a.color.ToString();
                checkNeighbor.Items.AddRange(NList.ToArray());
                checkNeighbor.DisplayMember = "name";
                foreach (var c in checkNeighbor.Items)
                {
                    
                    Country country = (Country)c;
                    if (a.CheckNeighbor(country))
                    {
                        indexes.Add(checkNeighbor.Items.IndexOf(c));
                    }
                    else continue;
                }
                foreach (int i in indexes)
                {
                    checkNeighbor.SetItemChecked(i, true);
                }
                this.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Country c in checkNeighbor.CheckedItems)
            {
                CDetail.AddNeighbor(c);
            }
            CDetail.color = int.Parse(txtcolorD.Text);
            CDetail.name = txtNameD.Text;
        }
    }
}
