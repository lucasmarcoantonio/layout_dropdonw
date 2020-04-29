using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace layout_2
{
    public partial class Form1 : Form
    {
        private bool isCollapsed;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                
                dropdown.Height += 80;
                if (dropdown.Size == dropdown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

                
                dropdown.Height += 160;
              
                if (dropdown.Size == dropdown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }

            }
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        
    }
}
