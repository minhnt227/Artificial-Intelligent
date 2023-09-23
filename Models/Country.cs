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
            if (!CheckNeighbor(country))
            {
                neighbor.Add(country);
                country.neighbor.Add(this);
            }
            else return;
        }
        public bool CheckNeighbor(Country country)
        {
            if (neighbor.Contains(country))
            {
                return true;
            }
            else return false;
        }
        public bool CanColor()
        {
            if (color != 0) return false;
            else
            {
                if (neighbor.Count == 0) return true;   //standalone country
                foreach (Country country in neighbor)  //if a neighbor is colored with the biggest color, skip, else
                {
                    if (country.color == Graph.max) return false;
                    else continue;
                }
                return true;
            } 
                
        }
    }
}
