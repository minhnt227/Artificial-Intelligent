using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Coloring.Models
{
    public static class Graph
    {
        public static int max = 1; //maximum number of colors used in graph, start with 1
        public static List<Country> CountryList = new List<Country>();

        
        //Save current map to a MapData file
        public static void SaveFile(string filename)
        {
            SortGraph();
            try
            {
                FileStream output = new FileStream(filename, FileMode.OpenOrCreate,FileAccess.Write);
                StreamWriter writer = new StreamWriter(output);
                foreach (Country c in CountryList)
                {
                    writer.WriteLine("Country: {0} .\tColor: {1}",c.name , c.color);
                    writer.WriteLine("\t\tNeighbor List ");
                    foreach (Country nb in c.neighbor)
                    {
                        writer.WriteLine("\t\t    {0} : {1}", nb.name, nb.color);
                    }
                    

                }
                writer.WriteLine("MAXIMUM COLORS: {0}", Graph.max);
                writer.Close();
                output.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void LoadFile()
        {
            string filename = "../../Models/MapData";
            try
            {
                FileStream input = new FileStream (filename, FileMode .Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                string line;
                Country c = new Country();
                while ((line =  reader.ReadLine()) != null)
                {
                    
                    if (line.Contains("Country")) //create an empty country list
                    {
                        string[] list = line.Split(' ');
                        
                        c = Find(list[1].Trim());
                        
                        if (c != null)
                        {
                            continue;
                        }
                        else
                        {
                            Country country = new Country(list[1].Trim(), int.Parse(list[3]));
                            CountryList.Add(country);
                            c = country;
                            continue;
                        }
                    }
                    else
                    if (line.Contains("Neighbor")) continue;
                    else
                    if (line.Contains("MAXIMUM"))
                    {
                        string[] list = line.Split(' ');
                        max = int.Parse(list[2]);
                        continue; 
                    }
                    else
                    //////////////////////////////////////////////////////////
                    {
                        string[] nblist = line.Split(':');
                        
                        Country nb;
                        if ((nb = Find(nblist[0].Trim()) ) != null)
                        {
                            if (c.CheckNeighbor(nb)) continue;
                            c.AddNeighbor(nb);
                        }
                        else
                        {
                            nb = new Country(nblist[0].Trim(), int.Parse(nblist[1]));
                            CountryList.Add(nb);
                            c.AddNeighbor(nb);
                        }
                    }
                }
                input.Close();
                reader.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void SortGraph()
        {
            CountryList.Sort(new NeighborComparer());
            CountryList.Reverse();
        }
        //Check if a graph is fully colored or not 
        public static bool IsFullyColored()
        {
            foreach (Country country in CountryList)
            {
                if (country.color == 0) return false;
                else continue;
            }    
            return true;
        }
        public static void GraphColoring()
        {
            while (!IsFullyColored())
            {
                foreach (Country country in CountryList)
                {
                    if (country.CanColor())
                    {
                        country.color = max;
                        continue;
                    }
                    continue;
                }
                max++;
            }
            max--;
        }
        public static Country Find(string name)
        {
            foreach (Country country in CountryList) 
            {
                if (country.name == name) return country;
            }
            return null;
        }
    }
}
