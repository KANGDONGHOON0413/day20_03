using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day20_03
{
    

    public partial class Form1 : Form
    {
        Bitmap bitM;

        public Form1()
        {
            InitializeComponent();

            bitM = new Bitmap(400, 300);
            SetClientSizeCore(400, 300);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //메모리에서 그려지는 부분
            Graphics graphics = Graphics.FromImage(bitM);
            graphics.Clear(Color.Green);
            for(int i = 0; i < 10; i++)
            {
                graphics.DrawString("C# programing", Font, Brushes.Black, 10, i*10);
            }
            graphics.DrawRectangle(Pens.Black, 100, 10, 200, 100);

            //폼에 출력
            e.Graphics.DrawImage(bitM, 0, 0);
        }
    }
}
