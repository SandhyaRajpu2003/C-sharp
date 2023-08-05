using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication29
{
publicpartialclassForm1 : Form
    {
int count = +1;
public Form1()
        {
            InitializeComponent();
        }

privatevoid button2_Click(object sender, EventArgs e)
        {
if (count <= 7)
            {
                count = count +1;
            }
            pictureBox1.SizeMode = PictureBoxMode.StretchImage;
            pictureBox1.Image = imageList1.Images[count];
        }

privatevoid button1_Click(object sender, EventArgs e)
       {
if (count <= 7)
           {
               count = count -1;
           }
           pictureBox1.Image = imageList1.Images[count];

       }
    }
}
