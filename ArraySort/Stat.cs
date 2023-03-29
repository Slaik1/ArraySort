using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace ArraySort
{
    internal class Stat
    {
        public int Lenth { get; set; }
        public int MinNumber { get; set; }
        public int MaxNumber { get; set; }
        public Chart Chart { get; set; }
        public string SortType { get; set; }
        public int[] Array { get; set; }

        public int[] CreateArray()
        {
            var rnd = new Random();
            Array=new int[Lenth];
            for (int i = 0; i < Array.Length; i++)
                Array[i] = rnd.Next(MinNumber, MaxNumber);
            return Array;
        }

        public void CreateStat() 
        {
            try
            {
                Chart.Series[SortType].Points.Clear();
            }
            catch (Exception)
            {
                Chart.Series.Clear();
                Chart.Series.Add(SortType);
            }
            foreach (int item in Array)
                Chart.Series[SortType].Points.AddY(item);
        }
    }
}
