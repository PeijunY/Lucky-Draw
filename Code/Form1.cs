using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 抽奖
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int MinNumber = 1, MaxNumber = 100;
        static Random random = new Random(1);
        static int first = 0, second = 0, third = 0;
        static List<int> ListResult = new List<int>();
        private void timer1_Tick(object sender, EventArgs e)
        {
            random = new Random((int)DateTime.Now.Ticks);
            do
            {
                first = random.Next(MinNumber, MaxNumber);
                //random = new Random(first);
            } while (first == 0 || ListResult.Contains(first));
            lblResult1.Text = first.ToString();

            if (comboCount.SelectedIndex >= 1)
            {
                do
                {
                    second = random.Next(MinNumber, MaxNumber);
                    //random = new Random(second);
                } while (second == first || ListResult.Contains(second));
                lblResult2.Text = second.ToString();
            }

            if (comboCount.SelectedIndex == 2)
            {
                do
                {
                    third = random.Next(MinNumber, MaxNumber);
                    ///random = new Random(third);
                } while (third == second || third == first || ListResult.Contains(third));
                lblResult3.Text = third.ToString();
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // stop
            if (timer1.Enabled)
            {
                btnStart.Text = "开始(&S)";
                lblResult1.ForeColor = Color.Red; 
                if (comboCount.SelectedIndex >= 1)
                    lblResult2.ForeColor = Color.Red;
                if (comboCount.SelectedIndex == 2)
                    lblResult3.ForeColor = Color.Red;
                btnReset.Enabled = true;

                listBox1.Items.Insert(0, first);
                ListResult.Add(first);

                if (comboCount.SelectedIndex > 0)
                {
                    listBox2.Items.Insert(0, second);
                    ListResult.Add(second);
                }
                if (comboCount.SelectedIndex > 1)
                {
                    listBox3.Items.Insert(0, third);
                    ListResult.Add(third);
                }
            }
            else // start
            {
                try
                {
                    MinNumber = int.Parse(txtMin.Text);
                    MaxNumber = int.Parse(txtMax.Text) + 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误");
                    return;
                }

                if (ListResult.Count + comboCount.SelectedIndex > MaxNumber - MinNumber - 1)
                {
                    MessageBox.Show(string.Format("所剩号码数量不足：{0}！",
                                                    MaxNumber - MinNumber - ListResult.Count), "住手吧人类");
                    return;
                }
                
                btnStart.Text = "结束(&E)";
                if (comboCount.SelectedIndex < 2)
                    lblResult3.Text = "-";
                if (comboCount.SelectedIndex < 1)
                    lblResult2.Text = "-";

                lblResult1.ForeColor = Color.Black;
                if (comboCount.SelectedIndex >= 1)
                    lblResult2.ForeColor = Color.Black;
                if (comboCount.SelectedIndex == 2)
                    lblResult3.ForeColor = Color.Black;
                btnReset.Enabled = false;
            }

            timer1.Enabled = !timer1.Enabled;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ListResult.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            lblResult1.Text = "0";
            lblResult2.Text = "0";
            lblResult3.Text = "0";
            foreach (var item in listBoxInvalid.Items)
            {
                int invalidNum = int.Parse(item.ToString());
                ListResult.Add(invalidNum);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            SortListBox(listBox1);
            SortListBox(listBox2);
            SortListBox(listBox3);
        }

        private void SortListBox(ListBox listBox1)
        {
            List<int> listInt = new List<int>();
            foreach (var item in listBox1.Items)
            {
                listInt.Add((int)item);
            }
            listInt.Sort();
            listBox1.Items.Clear();
            foreach (var item in listInt)
            {
                listBox1.Items.Add(item);
            }
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            int number = int.Parse(lb.SelectedItem.ToString());
            listBoxInvalid.Items.Insert(0, number);
            lb.ClearSelected();
        }

        private void btnClearInvalid_Click(object sender, EventArgs e)
        {
            if (ListResult.Count > 0)
            {
                foreach (var item in listBoxInvalid.Items)
                {
                    int number = int.Parse(item.ToString());
                    if (ListResult.Contains(number))
                        ListResult.Remove(number);
                }
            }
            listBoxInvalid.Items.Clear();
        }
    }
}
