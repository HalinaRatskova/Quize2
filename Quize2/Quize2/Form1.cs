using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quize2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fname.Text = "";
            lname.Text = "";
            tel.Text = "";

      
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((fname.Text == "") || (lname.Text == "") || (tel.Text == ""))
            {
                MessageBox.Show("Fill all information");
            }

            else if(fname.Text == "")
            {
                MessageBox.Show("Enter first name");
            }

            else if (lname.Text == "")
            {
                MessageBox.Show("Enter last name");
            }

            else if (tel.Text == "")
            {
                MessageBox.Show("Enter phone number");
            }
                else
            {


                FileStream stream =
                    new FileStream(@"c:\Exam\users.txt", FileMode.Append, FileAccess.Write);

                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.WriteLine("First name: "+  fname.Text +" " + "Last name: "+   lname.Text+ " " + "Telephone: "+ tel.Text+" ", @"c:\Exam\users.txt");
                }

                MessageBox.Show("User registred");

            }


        }

        private void fname_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(@"c:\Exam\users.txt");
                MessageBox.Show("Deleted");
            }
            catch (Exception exc)
            {
                //Log system
                Console.Write(exc.Message);
        }
    }
        
        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            string countUser;
            
                FileStream steam = new FileStream(@"c:\Exam\users.txt", FileMode.Open, FileAccess.Read);
                using (StreamReader reader = new StreamReader(steam))
                {


                    while (!reader.EndOfStream)
                    {
                        countUser = reader.ReadLine();
                        count++;
                    }

                }
                MessageBox.Show($"Total number of users {count}");
            }
            
        }
    }
    
    


