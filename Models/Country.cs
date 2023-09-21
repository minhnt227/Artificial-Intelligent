using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring.Models
{
    public class Country
    {
        public Country()
        {
            name = string.Empty;
            color = 0;
            neighbor = null;
        }

        public Country(string name, int color, List<Country> neighbor)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.color = color;
            this.neighbor = neighbor ?? throw new ArgumentNullException(nameof(neighbor));
        }

        public Country(string name, int color)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.color = color;
        }

        public Country(string name)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            color = 0;
        }
        
        public string name { get; set; }
        public int color {  get; set; }
        public List<Country> neighbor { get; set; } = new List<Country>();

        public void CShow()
        {
            detail Cdetail = new detail();
            Cdetail.Show(this);
        }
        public void AddNeighbor(Country country)
        {
            neighbor.Add(country);
            country.neighbor.Add(this);
        }
        public bool CheckNeighbor(Country country)
        {
            if (neighbor.Contains(country))
            {
                return true;
            }
            else return false;
        }
    }
}
