using polyExp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polyExp
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

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        Insan insan = new Insan();

        Elf elf = new Elf();

        Ork ork = new Ork();


        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += insan.Hizlan();
            label3.Left += elf.Hizlan();
            label2.Left += ork.Hizlan();

            if(label1.Left >= lblBitis.Left)
            {
                timer1.Stop();
                MessageBox.Show("insanlar kazandi.");
                
            }
            else if (label3.Left >= lblBitis.Left)
            {
                timer1.Stop();
                MessageBox.Show("ELFLER KAZANDI ULAN");
                
            }
            else if (label2.Left >= lblBitis.Left)
            {
                timer1.Stop();
                MessageBox.Show("orklar ezdi geçti.");
                
            }

        }
    }
}
