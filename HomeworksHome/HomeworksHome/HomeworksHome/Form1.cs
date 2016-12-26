using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HomeworksHome
{
    public partial class Form1 : Form
    {
        private int type_imp =3;
        private int type_mod =1;
        public int maxSize = 5;
        private object ToPut;
        Transaction_hendler Imp_hendler = new Transaction_hendler();

        public int Type_imp
        {
            get { return type_imp;  }
            set { type_imp = value; }
        
        }
        
        public int Type_mod
        {
            get { return type_mod; }
            set { type_mod = value; }

        }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }          
              

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
              

        private void START_Click(object sender, EventArgs e)
        {
            panel1.Enabled = !panel1.Enabled;
            panel2.Enabled = panel1.Enabled;
            panel3.Enabled = !panel1.Enabled;
            Stop.Enabled = !panel1.Enabled;
            Performance.Enabled= !panel1.Enabled;
            try
            {

                maxSize = Convert.ToInt32(MaxSize.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Application.Restart();
            }
            Imp_hendler.ChooseImp(type_imp, type_mod, maxSize);
           

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            type_mod = 2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            ToPut = textBox1.Text;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Array_CheckedChanged(object sender, EventArgs e)
        {
            type_imp = 1;
        }

        private void Get_Click(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Imp_hendler.pull(type_mod, type_imp).ToString();
            }
            catch (Exception )
            {
                MessageBox.Show("Buffer is empty");
                label1.Text = "empty";
                return;
            }
        }

        private void Dynamic_Arr_CheckedChanged(object sender, EventArgs e)
        {
            type_imp = 2;
        }

        private void Linked_list_CheckedChanged(object sender, EventArgs e)
        {
            type_imp = 3;
        }

        private void Native_imp_CheckedChanged(object sender, EventArgs e)
        {
            type_imp = 4;
        }

        private void Queue_CheckedChanged(object sender, EventArgs e)
        {
            Type_mod = 1;
        }

        private void Stack_CheckedChanged(object sender, EventArgs e)
        {
            Type_mod = 2;
        }

        private void Put_Click(object sender, EventArgs e)
        {
            if (Imp_hendler.SizeFact >= maxSize) 
            {
                MessageBox.Show("full");
                return;
            }
                Imp_hendler.Put(ToPut, type_mod, Type_imp);
                textBox1.Text = "";
                
            
        }

        private void Performance_Click(object sender, EventArgs e)
        {
            long time = 12345;
            Stopwatch Perfwatch = new Stopwatch();
            Perfwatch.Start();
            for (int k = 0; k < 10000000; k++)  
            {      
                Imp_hendler.Put(123456, type_mod, Type_imp);
                Imp_hendler.pull(type_mod, type_imp);
                if (k == 999999) 
                {
                    Perfwatch.Stop();                   
                    time = Perfwatch.ElapsedMilliseconds;
                }               
            }
            timer.Text = time.ToString();
        }
                        
    }
}
