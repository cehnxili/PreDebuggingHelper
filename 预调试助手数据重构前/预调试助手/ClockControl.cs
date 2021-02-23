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
    public partial class ClockControl : UserControl
    {
        const int screenWidth = 140; //屏幕宽度
        const int screenHeight = 140; //屏幕高度
        int Angle;
        public ClockControl()
        {
            InitializeComponent();
            this.Width = screenWidth + 1;
            this.Height = screenHeight + 1;
            this.DoubleBuffered = true; //控件缓冲，避免闪烁
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.Black); //填充图形
            Pen pen = new Pen(Color.Black); //画笔
            Font hourFont = new Font("Arial", 10, FontStyle.Bold);//时钟数字的字体
            int dialRadius = Math.Min(screenWidth, screenHeight) / 2; //圆的半径

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            //默认坐标系统原点是左上角，现在把原点移到屏幕中心, 右下左上对应的轴：x,y,-x,-y
            g.TranslateTransform(dialRadius, dialRadius);

            //画时钟最外层的圆线(pen,x,y,width,height)
            //圆的中心点坐标计算：(width/2+x,height/2+y),据此可得出要使圆在坐标原点(0,0)的x,y坐标值           
            g.DrawEllipse(pen, -screenWidth / 2, -dialRadius, screenWidth, screenHeight);

            GraphicsState state = g.Save();
            //画时钟的12个数字，如果用上面RotateTransform方法则数字会倾斜、倒立，故不用
            state = g.Save();
            for (int i = 0; i < 6; i++)
            {
                //已知圆中心占坐标(x0,y0),半径r，角度a0,则圆上任一点坐标（x,y）计算：
                //x = x0 + r * cos(ao * 3.14 /180) 
                //y = y0 + r * sin(ao * 3.14 /180) 
                Point point = new Point(-6, -6); //当为(0,0)时全部数字偏右下移，故手动调整
                double dd = Math.PI / 180 * i * (360 / 6); //每次转360/12度
                float x = point.X + (float)((dialRadius - 10) * Math.Sin(dd));
                float y = point.Y + (float)((dialRadius - 10) * Math.Cos(dd));

                //因为是从顺时钟3点钟开始画，所以索引i需要加上3
                int j = i;
                if (j >6)
                    j = j -6;
                g.DrawString(j.ToString(), hourFont, brush, x, -y-12);
            }
            g.Restore(state);

            // 画时钟的图形
            state = g.Save();
            g.RotateTransform(Angle);//(dtNow.Hour - 17 + dtNow.Minute / 60f) * 360f / 12f
            //时钟指针默认指向12点钟方向,分钟指针也一样
            g.DrawPolygon(new Pen(brush), new Point[]
            {
                new Point(0,  20), new Point( 5, 0),
                new Point(0, -50), new Point(-5, 0)
            });
            g.Restore(state);

        }
        public int SetAngle(int angle)
        {
            Angle = angle;
            return Angle;
        }
    }
}
