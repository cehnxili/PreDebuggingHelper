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

namespace 预调试助手
{
    public partial class textform : Form
    {
        ////定义一个bool变量标识是否拖动窗体
        //private bool isMove = false;
        ////记录鼠标的位置
        //private Point point;
        public textform()
        {
            InitializeComponent();
        }

        private void textform_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
        }

        private void textform_MouseDown(object sender, MouseEventArgs e)
        {
            //isMove = true;
            ////记录鼠标的位置
            //point = e.Location;
        }

        private void textform_MouseUp(object sender, MouseEventArgs e)
        {
            ////不允许在移动窗体
            //isMove = false;
        }

        private void textform_MouseMove(object sender, MouseEventArgs e)
        {
            //if (isMove)
            //{

            //    //记录鼠标移动后的值
            //    Point p = e.Location;
            //    //计算鼠标按下和移动后的距离
            //    int x = p.X - point.X;
            //    int y = p.Y - point.Y;
            //    //窗体的位置
            //    this.Location = new Point(this.Location.X + x, this.Location.Y + y);

            //}
        }
    }
}
