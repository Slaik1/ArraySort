using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ArraySort
{
    public class Sorts
    {
        public bool FastView { get; set; }
        public Chart Chart { get; set; }
        public string SortType { get; set; }
        public int Deleay { get; set; }   

        public void UpdateStat(int[] array)
        {
            Chart.Series[SortType].Points.Clear();
            foreach (var item in array)
                Chart.Series[SortType].Points.AddY(item);
            Chart.Update();
            Thread.Sleep(Deleay);
        }

        public void Start(int[] array)
        {
            switch (SortType)
            {
                case "Buble Sort": Buble(array); break;
                case "Quick Sort": HoareSort(array, 0, array.Length - 1); break;
            }
        }

        public void Buble(int[] arr)
        {
            var n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        var tempVar = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tempVar;
                    }
                    if (!FastView)
                        UpdateStat(arr);
                }
                UpdateStat(arr);
            }
        }

        public void HoareSort(int[] array,int start,int end)
        {
            if (end == start) return;
            var pivot = array[end];
            var storeIndex = start;
            for (int i = start; i <= end - 1; i++)
                if (array[i] <= pivot)
                {
                    if (!FastView) UpdateStat(array);
                    var t = array[i];
                    array[i] = array[storeIndex];
                    array[storeIndex] = t;
                    storeIndex++;
                }
            UpdateStat(array);
            var n = array[storeIndex];
            array[storeIndex] = array[end];
            array[end] = n;
            if (storeIndex > start) HoareSort(array, start, storeIndex - 1);
            if (storeIndex < end) HoareSort(array, storeIndex + 1, end);
        }
    }
}
