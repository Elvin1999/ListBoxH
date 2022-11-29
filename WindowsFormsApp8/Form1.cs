using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public List<string> GetCars()
        {
            return new List<string>
            {
                "Mercedes",
                "Audi",
                "Polo"
            };
        }
        public Form1()
        {
            InitializeComponent();
            //listBox1.DataSource = GetCars();
            comboBox1.Items.AddRange(GetCars().ToArray());
            comboBox1.SelectedIndex = 0;

            //listBox1.Items.AddRange(GetCars().ToArray());
            checkedListBox1.Items.AddRange(GetCars().ToArray());

            //listBox1.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var myListBox=sender as ListBox;
            var data = myListBox.SelectedItem as string;
            //var data = listBox1.SelectedItem as string;
           // label1.Text = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = textBox1.Text;
            listBox1.Items.Add(data);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem as string;
            listBox1.Items.Remove(item);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedItem as string;
            label1.Text=item;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = new List<string>();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                list.Add(item as string);
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(list.ToArray());
        }
    }
}
