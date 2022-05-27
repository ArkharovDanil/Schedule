using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Расписание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Data
        {
            int day;
            int month;
            int year;
            int hours;
            public int Day
            {
                set { day = value; }
                get { return day; }

            }
            public int Month
            {
                set { month = value; }
                get { return month; }
            }
            public int Year
            {
                set { year = value; }
                get { return year; }
            }
            public int Hours
            {
                set { hours = value; }
                get { return hours; }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load()
        {
            for (int i=1;i<32;i++)
            comboBox1.Items.Add(i.ToString());

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Pass the filepath and filename to the StreamWriter Constructor
            StreamWriter sw = new StreamWriter("C:\\txt.txt");
            //Write a line of text
            sw.WriteLine(comboBox1.Text);
            sw.WriteLine(comboBox2.Text);
            sw.WriteLine(comboBox3.Text);
            sw.WriteLine(comboBox4.Text);
            //Write a second line of text
            sw.WriteLine("From the StreamWriter class");
            //Close the file
            sw.Close();


        }
    }
}
