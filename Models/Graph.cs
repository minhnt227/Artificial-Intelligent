using System;
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
        public static int n; //number of countries
        public static int max = 1; //maximum number of colors used in graph, start with 1
        public static List<Country> CountryList = new List<Country>();

        public static void CreateGraph()
        {
            for (int i = 0; i < n; i++)
            {
                Country country = new Country();
                CountryList.Add(country);
            }
        }
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
                    writer.WriteLine("\t\tNeighbor List: ");
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
        // ??? :D ???
        public static void LoadFile()
        {
            string filename = "MapData";
            try
            {
                FileStream input = new FileStream (filename, FileMode .Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);
                string line;
                while ((line =  reader.ReadLine()) != null)
                {
                    //if (line.Contains("Neighbor")) continue;
                    //else 
                    if (line.StartsWith("Country"))
                    {
                        Country country = new Country(); 
                        string[] list = line.Split(' ');
                        country.name = list[1]; country.color = int.Parse(list[3]);
                        line = reader.ReadLine();
                        while ((line = reader.ReadLine()) != null && !line.StartsWith("Country"))
                        {
                            if (line is null) break;
                            list = line.Split(':');
                            Country nb = new Country(list[0], int.Parse(list[1]));
                            foreach (string s in list)
                            {
                                MessageBox.Show(s);
                            }
                            //nb.name = list[0];
                            //nb.color = int.Parse(list[1]);
                            country.AddNeighbor(nb);
                        }
                        CountryList.Add(country);
                        
                    }
                    
                }
                MessageBox.Show(CountryList.ToArray().ToString());
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
    }
}
