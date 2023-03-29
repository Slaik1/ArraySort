using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArraySort
{
    public partial class Form1 : Form
    {
        public int[] Array { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateStat();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateStat();
        }
        private void comboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateStat();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            var Sort = new Sorts
            {
                FastView = checkBoxFastView.Checked,
                Chart = chart,
                SortType = comboBoxSort.Text,
                Deleay = int.Parse(textBoxDelay.Text)
            };
            Sort.Start(Array);
        }

        public void CreateStat()
        {
            var Stat = new Stat
            {
                Lenth = int.Parse(textBoxLenth.Text),
                MinNumber = int.Parse(textBoxMinNum.Text),
                MaxNumber = int.Parse(textBoxMaxNum.Text),
                Chart = chart,
                SortType = comboBoxSort.Text
            };
            Array = Stat.CreateArray();
            Stat.CreateStat();
        }
    }
}
