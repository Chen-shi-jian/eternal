using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eternal
{
    public partial class Form_Love : Form
    {
        private Color penColor=Color.Red;
        private Color backColor = Color.White;
        private int penWd = 1;
        private double a;
        
        public Form_Love()
        {
            InitializeComponent();
        }

        private void Form_Love_Load(object sender, EventArgs e)
        {
            int SH = Screen.PrimaryScreen.Bounds.Height;
            int SW = Screen.PrimaryScreen.Bounds.Width;
            this.Width = SW;
            this.Height = SH;
            int X =SW - 350;
            int Y =  60;
            trackBar_Range.SetBounds(X,Y,300,25);

            Y = 30;
            panel_information.SetBounds(X, Y, 300, 20);

            X =30;
            Y = 100;
            panel_Draw.SetBounds(X,Y,this.Width-60,this.Height-150);

            X = this.Width - 52; 
            Y = this.Height - button_DropOut.Height;
            button_DropOut.SetBounds(X, Y, 52, 20);

            comboBox_PenWd.SelectedIndex = 0;
            label_R.Text = "R:" + 0;

            if (panel_Draw.Height<450 || panel_Draw.Width<500)
            {
                MessageBox.Show("屏幕分辨率不足！","请调节屏幕分辨率", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void trackBar_Range_ValueChanged(object sender, EventArgs e)
        {
            a = (trackBar_Range.Value) / 1000.0;
            label_R.Text = "R:" + a;
            panel_Draw.Refresh();
        }

        private void panel_Draw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //X范围宽度
            int ch = 181;
            Point[] points1 = new Point[2 * ch + 1];
            Point[] points = new Point[2 * ch + 1];
            int xMultiple = 135;
            int yMultiple = 110;
            double x;
            double y;
            for (int i = 0; i < points.Length; i++)
            {
                a = (trackBar_Range.Value)/1000.0;
                if (a == 100.0)
                {
                    a = 50;
                }
                x = (i-ch)/100.0;
                y = -Math.Pow(x*x, 1.0 / 3.0) + 0.9 * Math.Sqrt(3.3 - x * x) * Math.Sin(a * Math.PI * x);
                
                points[i] = new Point(Convert.ToInt32(x*xMultiple), Convert.ToInt32(y*yMultiple));
            }

            a = (trackBar_Range.Value) / 1000.0;
            if (a == 150.0)
            {
                int X, Y;
                X = panel_Draw.Width / 2 - 8;
                Y = panel_Draw.Height / 2 - 5;
                button_DropOut.Visible = true;
                

                int b = 150;
                for (int i = 0; i < points1.Length; i++)
                {
                    x = (i - ch) / 100.0;
                    y = -Math.Pow(x * x, 1.0 / 3.0) + 0.9 * Math.Sqrt(3.3 - x * x) * Math.Sin(b * Math.PI * x);
                    points1[i] = new Point(Convert.ToInt32(x * 13.5), Convert.ToInt32(y *11));
                }
            }

            //设置笔
            Pen mypen = new Pen(penColor, penWd);
            System.Drawing.Drawing2D.AdjustableArrowCap arrow = new AdjustableArrowCap(8, 8, false);

            //获取绘制面板的中心
            //int halfWidth = panel_Draw.Width / 2;
            //int halfHeigh = panel_Draw.Height / 2;
            //绘制坐标轴
            //g.DrawLine(mypen, 7, halfHeigh, panel_Draw.Width - 7, halfHeigh);
            //g.DrawLine(mypen, halfWidth, panel_Draw.Height - 5, halfWidth, 5);


            //改变坐标原点.通过使此 System.Drawing.Graphics 的变换矩阵左乘指定的平移来更改坐标系统的原点。
            g.TranslateTransform(panel_Draw.Width / 2, panel_Draw.Height / 2+50);
            g.DrawLines(mypen, points);
            if(a==150.0)
            {
                g.DrawLines(mypen, points1);
            }
        }

        //设置背景色
        private void button_BackgroundColor_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                backColor= colorDialog1.Color;
                this.BackColor = backColor;
                this.panel_Draw.BackColor = backColor;
                panel_Draw.Refresh();
            }
        }

        //设置前景色
        private void button_Foreground_Click(object sender, EventArgs e)
        {
            DialogResult dr = colorDialog1.ShowDialog();
            //如果选中颜色，单击“确定”按钮则改变文本框的文本颜色
            if (dr == DialogResult.OK)
            {
               penColor= colorDialog1.Color;
               panel_Draw.Refresh();
            }
        }

        //设置笔宽
        private void comboBox_PenWd_SelectedIndexChanged(object sender, EventArgs e)
        {
            penWd = comboBox_PenWd.SelectedIndex+1;
            panel_Draw.Refresh();
        }

        //重置
        private void button_Reset_Click(object sender, EventArgs e)
        {
            penColor = Color.Red;
            backColor = Color.White;
            this.BackColor = backColor;
            this.panel_Draw.BackColor = backColor;
            comboBox_PenWd.SelectedIndex = 0;
            penWd = comboBox_PenWd.SelectedIndex + 1;
            trackBar_Range.Value = 0;
            a = (trackBar_Range.Value) / 1000.0;
            label_R.Text = "R:" + a;
            this.button_DropOut.Visible = false;
        }

        private void button_DropOut_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
