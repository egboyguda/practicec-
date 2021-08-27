using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.count.Text = this.comboBox2.Items.Count.ToString();
        }

        private void comboBox2_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Aqua;
        }

        private void comboBox2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox2.SelectedIndex == -1) {
                MessageBox.Show("please select a value");
                return;
            }
            this.textBox1.Text = this.comboBox2.SelectedIndex.ToString();
            this.textBox2.Text = this.comboBox2.SelectedItem.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addItem();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.comboBox2.Items.Remove(this.comboBox2.SelectedItem);
            this.count.Text = comboBox2.Items.Count.ToString();
        }

        private void count_Click(object sender, EventArgs e)
        {
         
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textbox_add_Enter(object sender, EventArgs e)
        {
          
        }

        public void addItem() {
            if (this.textbox_add.Text == "") {
                MessageBox.Show("enter a value first");
                return;
            }
            this.comboBox2.Items.Add(this.textbox_add.Text);
            this.textbox_add.ResetText();
            MessageBox.Show("successfully added");
            this.count.Text = comboBox2.Items.Count.ToString();
        }

        private void textbox_add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                addItem();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            findVal();
        }

        private void search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                findVal();
            }
        }

        private void findVal() {

            if (this.comboBox2.Items.Contains(this.search.Text))
            {

                this.comboBox2.Text = this.search.Text;
                this.textBox1.Text = this.comboBox2.SelectedIndex.ToString();
                this.textBox2.Text = this.comboBox2.SelectedItem.ToString();

            }
            else
            {
                MessageBox.Show("not found");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
