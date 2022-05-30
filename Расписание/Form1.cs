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
            for (int i = 1; i < 32; i++)
                comboBox1.Items.Add(i.ToString());
            comboBox2.Items.Add("Январь");
            comboBox2.Items.Add("Февраль");
            comboBox2.Items.Add("Март");
            comboBox2.Items.Add("Апрель");
            comboBox2.Items.Add("Май");
            comboBox2.Items.Add("Июнь");
            comboBox2.Items.Add("Июль");
            comboBox2.Items.Add("Август");
            comboBox2.Items.Add("Сентябрь");
            comboBox2.Items.Add("Октябрь");
            comboBox2.Items.Add("Ноябрь");
            comboBox2.Items.Add("Декабрь");
            
            for (int i = 2022; i < 2030; i++)
                comboBox3.Items.Add(i.ToString());
            comboBox4.Items.Add(4.ToString());
            comboBox4.Items.Add(8.ToString());
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
           
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            StreamWriter wr = new StreamWriter("texts\\txt.txt", true);
            string line = comboBox1.Text +" "+ comboBox2.Text + " " + comboBox3.Text + " " + comboBox4.Text+"\n";
            wr.Write(line);
            wr.Close();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader("texts\\txt.txt");
            //Read the first line of text
            string line = sr.ReadLine();
            DataTable dt = new DataTable();
            dt.Columns.Add("Day");
            dt.Columns.Add("Month");
            dt.Columns.Add("Year");
            dt.Columns.Add("Hours");
            //Continue to read until you reach end of file
            while (line != "" && line != null)
            {
                //write the line to console window
                string[] words=line.Split();
                DataRow r = dt.NewRow();
                r["Day"] = Convert.ToInt32(words[0]);
                r["Month"] = words[1];
                r["Year"] = Convert.ToInt32(words[2]);
                r["Hours"] = words[3];
                dt.Rows.Add(r);
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            dataGridView1.DataSource = dt;
            sr.Close();
            Console.ReadLine();
        }
    }
}
