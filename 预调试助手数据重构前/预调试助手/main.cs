using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace 预调试助手
{
    public partial class Form_Guide : MaterialForm
    {

        private readonly MaterialSkinManager materialSkinManager;

        string defaultPath;
        string iniPath;
        string fanode1, subnode11, subnode12, subnode13, fanode2, subnode21, subnode22, subnode23;
        string txtP11, txtP12, txtP13, txtP21, txtP22, txtP23;
        string picP11, picP12, picP13, picP21, picP22, picP23;
        string AXIS1 = "", AXIS2 = "";
        string FontName, FontSize, FontColor;

        bool isCuTi=false, isXieTi=false;

        private void ziti_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_xieti.Checked&&!cbox_cuti.Checked)//斜体
            {
                label_test.Font = new Font(FontName,Convert.ToInt32( FontSize),FontStyle.Italic);
                isCuTi = false;
                isXieTi = true;
            }
            else if ( !cbox_xieti.Checked&&cbox_cuti.Checked)//粗体
            {
                label_test.Font = new Font(FontName, Convert.ToInt32(FontSize), FontStyle.Bold);
                isCuTi = true;
                isXieTi = false;
            }
            else if (cbox_xieti.Checked&& cbox_cuti.Checked)//粗斜体
            {
                label_test.Font = new Font(FontName, Convert.ToInt32(FontSize), FontStyle.Bold | FontStyle.Italic);
                isCuTi = true;
                isXieTi = true;
            }
            else//都未选择则恢复原样
            {
                label_test.Font = new Font(FontName, Convert.ToInt32(FontSize), FontStyle.Regular);
                isCuTi = false;
                isXieTi = false;
            }
        }

        Color newcolor;

        private void btn_resetFont_Click(object sender, EventArgs e)
        {
            label_test.Font = new Font("黑体", (float)10.0, label_test.Font.Style);
        }

        bool firstPoint = false;

        INI iniFile;

        public Form_Guide()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            label_test.Parent = pictureBox1;
        }
        private void Form_Guide_Load(object sender, EventArgs e)
        {
            string str = System.Windows.Forms.Application.StartupPath;
            iniPath = str + "\\config.ini";
            iniFile = new INI(iniPath);
            defaultPath = str + "\\project file";
            NodesChange();
            firstPoint = true;
            label_test.ForeColor = Color.FromArgb(Convert.ToInt32( FontColor));                         //FromName(FontColor);
            label_test.Font = new Font(FontName, Convert.ToInt32(FontSize), label_test.Font.Style);
        }

        private void NodesChange()
        {
            ReadDate();
            treeViewEx1.Nodes.Add(fanode1);
            treeViewEx1.Nodes[0].Nodes.Add(subnode11);
            treeViewEx1.Nodes[0].Nodes.Add(subnode12);
            treeViewEx1.Nodes[0].Nodes.Add(subnode13);
            treeViewEx1.Nodes.Add(fanode2);
            treeViewEx1.Nodes[1].Nodes.Add(subnode21);
            treeViewEx1.Nodes[1].Nodes.Add(subnode22);
            treeViewEx1.Nodes[1].Nodes.Add(subnode23);

            treeViewEx1.ExpandAll();
            
        }
        private void Pic_creat(string path)
        {
            pictureBox1.Image = Image.FromFile(path);
            //pictureBox2.Image = null;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void Txt_creat(string path)
        {
            label_test.Text = "";
            try
            {
                // 创建一个 StreamReader 的实例来读取文件 
                // using 语句也能关闭 StreamReader
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;

                    // 从文件读取并显示行，直到文件的末尾 
                    while ((line = sr.ReadLine()) != null)
                    {
                        label_test.Text += line + "\n";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "文件被删除");
            }
        }
        private void toolTips_show(string path1,string geshi, string path2)
        {
            toolTip1.SetToolTip(pictureBox1, "可以更改根目录文件夹下" + path1 + "文件，格式为"+ geshi);
            toolTip1.SetToolTip(label_test, "可以更改根目录文件夹下" + path2 + "文件，格式为TXT");
        }

        private void treeViewEx1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ReadDate();
            if (e.Button == System.Windows.Forms.MouseButtons.Left)  //单击鼠标左键才响应
            {
                if (e.Node.Level == 1)                               //判断子节点才响应
                {
                    if (e.Node.Text == subnode11)
                    {
                        Pic_creat(defaultPath + "\\" + picP11 + ".png");//
                        Txt_creat(defaultPath + "\\" + txtP11 + ".txt");
                        toolTips_show(picP11,"PNG", txtP11);
                    }
                    else if (e.Node.Text == subnode12)
                    {
                        Pic_creat(defaultPath + "\\" + picP12 + ".png");
                        Txt_creat(defaultPath + "\\" + txtP12 + ".txt");
                        toolTips_show(picP12, "PNG", txtP12);
                    }
                    else if (e.Node.Text == subnode13)
                    {
                        Pic_creat(defaultPath + "\\" + picP13 + ".png");
                        Txt_creat(defaultPath + "\\" + txtP13 + ".txt");
                        toolTips_show(picP13, "PNG", txtP13);
                    }
                    else if (e.Node.Text == subnode21)
                    {
                        Pic_creat(defaultPath + "\\" + picP21 + ".png");
                        Txt_creat(defaultPath + "\\" + txtP21 + ".txt");
                        toolTips_show(picP21, "PNG", txtP21);
                    }
                    else if (e.Node.Text == subnode22)
                    {
                        Pic_creat(defaultPath + "\\" + picP22 + ".gif");
                        Txt_creat(defaultPath + "\\" + txtP22 + ".txt");
                        toolTips_show(picP22, "GIF", txtP22);
                    }
                    else if (e.Node.Text == subnode23)
                    {
                        Pic_creat(defaultPath + "\\" + picP23 + ".gif");
                        Txt_creat(defaultPath + "\\" + txtP23 + ".txt");
                        toolTips_show(picP23, "GIF", txtP23);
                    }
                    //文件框中显示鼠标点击的节点名称
                }
            }
        }
        private void Form_Guide_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btn_skip_Click_1(object sender, EventArgs e)
        {
            winMain fm = new winMain();
            fm.Show();
            this.Hide();
        }
        #region G_CODE
        private void btn_change_Click(object sender, EventArgs e)
        {
            Gcodetext.Text = "";
            rtbox_preGcode.Text = "原文档为" + "\n";
            string path = "";

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "txt|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                path = openFile.FileName;
            }
            // 创建一个 StreamReader 的实例来读取文件 
            // using 语句也能关闭 StreamReader
            if (string.IsNullOrEmpty(path)) { MessageBox.Show("请选择文件"); return; }
            using (StreamReader sr = new StreamReader(path))
            {
                string line, x_positon = "", y_position = "", vel = "";

                // 从文件读取并显示行，直到文件的末尾 
                while ((line = sr.ReadLine()) != null)
                {
                    rtbox_preGcode.Text += line + "\n";
                    if (line.Contains("G01"))
                    {
                        string[] linearray = line.Split(' ');

                        linearray[2] = Regex.Replace(linearray[2], @"[^\d.\d]", "");
                        // 如果是数字，则转换为decimal类型
                        if (Regex.IsMatch(linearray[2], @"^[+-]?\d*[.]?\d*$"))
                        {
                            decimal result = decimal.Parse(linearray[2]);
                            x_positon = result.ToString();
                        }
                        linearray[3] = Regex.Replace(linearray[3], @"[^\d.\d]", "");
                        // 如果是数字，则转换为decimal类型
                        if (Regex.IsMatch(linearray[3], @"^[+-]?\d*[.]?\d*$"))
                        {
                            decimal result = decimal.Parse(linearray[3]);
                            y_position = result.ToString();
                        }
                        linearray[5] = Regex.Replace(linearray[5], @"[^\d.\d]", "");
                        // 如果是数字，则转换为decimal类型
                        if (Regex.IsMatch(linearray[5], @"^[+-]?\d*[.]?\d*$"))
                        {
                            decimal result = decimal.Parse(linearray[5]);
                            double Vel = (double)result / 60;
                            vel = Vel.ToString();
                        }
                    }
                    if (!string.IsNullOrEmpty(x_positon))
                    {
                        if (firstPoint)
                        {
                            Gcodetext.Text += "!转换文档为" + "\n";
                            Gcodetext.Text += "PTP/E (" + AXIS1 + "," + AXIS2 + ")," + x_positon + "," + y_position + "\n";
                            Gcodetext.Text += "XSEG(" + AXIS1 + "," + AXIS2 + ")," + x_positon + "," + y_position + "\n";
                            firstPoint = false;
                        }
                        else
                        {
                            Gcodetext.Text += "LINE/V (" + AXIS1 + "," + AXIS2 + ")," + x_positon + "," + y_position + "," + vel + "\n";
                        }
                    }
                }
                Gcodetext.Text += "ENDS(" + AXIS1 + "," + AXIS2 + ")" + "\n";
                Gcodetext.Text += "TILL GSEG(" + AXIS1 + ")=-1" + "\n";
                Gcodetext.Text += "STOP";
            }
        }

        private void btn_Gsave_Click(object sender, EventArgs e)
        {
            firstPoint = true;
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "txt|*.txt";
            saveFile.FileName = "XSEG.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                string Path = saveFile.FileName;
                File.WriteAllText(Path, Gcodetext.Text);
                MessageBox.Show("转换完成");
            }
        }
        #endregion
        #region  读数据

        private void tbox_color_Click(object sender, EventArgs e)
        {
            ColorDialog colorchange = new ColorDialog();
            if (colorchange.ShowDialog() == DialogResult.OK)
            {
                newcolor = colorchange.Color;
                tbox_color.BackColor = newcolor;
            }
            else
            {
                newcolor = label_test.ForeColor;
                tbox_color.BackColor = newcolor;
            }
        }

        private void btn_downset_Click(object sender, EventArgs e)
        {
            iniFile.IniWriteValue("TreeNodeMean", "picPoint11", picPoint11.Text);
            iniFile.IniWriteValue("TreeNodeMean", "picPoint12", picPoint12.Text);
            iniFile.IniWriteValue("TreeNodeMean", "picPoint13", picPoint13.Text);
            iniFile.IniWriteValue("TreeNodeMean", "picPoint21", picPoint21.Text);
            iniFile.IniWriteValue("TreeNodeMean", "picPoint22", picPoint22.Text);
            iniFile.IniWriteValue("TreeNodeMean", "picPoint23", picPoint23.Text);

            iniFile.IniWriteValue("TreeNodeMean", "txtPoint11", txtPoint11.Text);
            iniFile.IniWriteValue("TreeNodeMean", "txtPoint12", txtPoint12.Text);
            iniFile.IniWriteValue("TreeNodeMean", "txtPoint13", txtPoint13.Text);
            iniFile.IniWriteValue("TreeNodeMean", "txtPoint21", txtPoint21.Text);
            iniFile.IniWriteValue("TreeNodeMean", "txtPoint22", txtPoint22.Text);
            iniFile.IniWriteValue("TreeNodeMean", "txtPoint23", txtPoint23.Text);

            iniFile.IniWriteValue("TreeNodeMean", "treeNode1", treeNode1.Text);
            iniFile.IniWriteValue("TreeNodeMean", "treeNode11", treeNode11.Text);
            iniFile.IniWriteValue("TreeNodeMean", "treeNode12", treeNode12.Text);
            iniFile.IniWriteValue("TreeNodeMean", "treeNode13", treeNode13.Text);
            iniFile.IniWriteValue("TreeNodeMean", "treeNode2", treeNode12.Text);
            iniFile.IniWriteValue("TreeNodeMean", "treeNode21", treeNode21.Text);
            iniFile.IniWriteValue("TreeNodeMean", "treeNode22", treeNode22.Text);
            iniFile.IniWriteValue("TreeNodeMean", "treeNode23", treeNode23.Text);

            iniFile.IniWriteValue("GcodeInfo", "AXIS1", tbox_GcodeAxis1.Text);
            iniFile.IniWriteValue("GcodeInfo", "AXIS2", tbox_GcodeAxis2.Text);

            float Fontsize = Convert.ToInt32(tbox_fontSize.Text);
            try
            {
                label_test.Font = new Font(tbox_fontName.Text, Fontsize, label_test.Font.Style);
                label_test.ForeColor = newcolor;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "设置字体警告");
            }
            //将字体相关参数写入INI
            iniFile.IniWriteValue("TxtStyle", "FontSize", Fontsize.ToString());
            iniFile.IniWriteValue("TxtStyle", "FontName", tbox_fontName.Text);
            iniFile.IniWriteValue("TxtStyle", "FontColor", newcolor.ToArgb().ToString());

            if (isCuTi&&!isXieTi)
            {
                iniFile.IniWriteValue("TxtStyle", "FontBold", "true");
                iniFile.IniWriteValue("TxtStyle", "FontItalic", "false");
            }
            else if (!isCuTi && isXieTi)
            {
                iniFile.IniWriteValue("TxtStyle", "FontBold", "false");
                iniFile.IniWriteValue("TxtStyle", "FontItalic", "true");
            }
            else if (isCuTi && isXieTi)
            {
                iniFile.IniWriteValue("TxtStyle", "FontBold", "true");
                iniFile.IniWriteValue("TxtStyle", "FontItalic", "true");
            }
            else if (!isCuTi && !isXieTi)
            {
                iniFile.IniWriteValue("TxtStyle", "FontBold", "false");
                iniFile.IniWriteValue("TxtStyle", "FontItalic", "false");
            }

            groupBox_pic.Enabled = false;
            groupBox_text.Enabled = false;
            groupBox_tree.Enabled = false;
            groupBox_Gcode.Enabled = false;
            groupBox_textStyle.Enabled = false;

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    treeViewEx1.Nodes.Clear();
                    NodesChange();
                    break;
                case 2://如果为软件配置，将所有的box先关闭
                    groupBox_pic.Enabled = false;
                    groupBox_text.Enabled = false;
                    groupBox_tree.Enabled = false;
                    groupBox_Gcode.Enabled = false;
                    groupBox_textStyle.Enabled = false;
                    break;
            }
        }

        private void btn_readData_Click(object sender, EventArgs e)
        {
            groupBox_textStyle.Enabled = true;
            groupBox_pic.Enabled = true;
            groupBox_text.Enabled = true;
            groupBox_tree.Enabled = true;
            groupBox_Gcode.Enabled = true;
            treeNode1.Text = iniFile.IniReadValue("TreeNodeMean", "treeNode1");
            treeNode11.Text = iniFile.IniReadValue("TreeNodeMean", "treeNode11");
            treeNode12.Text = iniFile.IniReadValue("TreeNodeMean", "treeNode12");
            treeNode13.Text = iniFile.IniReadValue("TreeNodeMean", "treeNode13");
            treeNode2.Text = iniFile.IniReadValue("TreeNodeMean", "treeNode2");
            treeNode21.Text = iniFile.IniReadValue("TreeNodeMean", "treeNode21");
            treeNode22.Text = iniFile.IniReadValue("TreeNodeMean", "treeNode22");
            treeNode23.Text = iniFile.IniReadValue("TreeNodeMean", "treeNode23");

            txtPoint11.Text = iniFile.IniReadValue("TreeNodeMean", "txtPoint11");
            txtPoint12.Text = iniFile.IniReadValue("TreeNodeMean", "txtPoint12");
            txtPoint13.Text = iniFile.IniReadValue("TreeNodeMean", "txtPoint13");
            txtPoint21.Text = iniFile.IniReadValue("TreeNodeMean", "txtPoint21");
            txtPoint22.Text = iniFile.IniReadValue("TreeNodeMean", "txtPoint22");
            txtPoint23.Text = iniFile.IniReadValue("TreeNodeMean", "txtPoint23");

            picPoint11.Text = iniFile.IniReadValue("TreeNodeMean", "picPoint11");
            picPoint12.Text = iniFile.IniReadValue("TreeNodeMean", "picPoint12");
            picPoint13.Text = iniFile.IniReadValue("TreeNodeMean", "picPoint13");
            picPoint21.Text = iniFile.IniReadValue("TreeNodeMean", "picPoint21");
            picPoint22.Text = iniFile.IniReadValue("TreeNodeMean", "picPoint22");
            picPoint23.Text = iniFile.IniReadValue("TreeNodeMean", "picPoint23");

            tbox_GcodeAxis1.Text = iniFile.IniReadValue("GcodeInfo", "AXIS1");
            tbox_GcodeAxis2.Text = iniFile.IniReadValue("GcodeInfo", "AXIS2");

            tbox_fontName.Text = iniFile.IniReadValue("TxtStyle", "FontName");
            try
            {
                tbox_color.BackColor = Color.FromArgb(Convert.ToInt32(FontColor));
            }
            catch (Exception)
            {
                MessageBox.Show("INI文件TxtStyle内中的FontColor值为空，请填写颜色值");
            }
            tbox_fontSize.Text = iniFile.IniReadValue("TxtStyle", "FontSize");

           string fontisbold= iniFile.IniReadValue("TxtStyle", "FontBold");
           string fontisItalic= iniFile.IniReadValue("TxtStyle", "FontItalic");

            if (fontisbold == "false" && fontisItalic == "true")//斜体
            {
                label_test.Font = new Font(FontName, Convert.ToInt32(FontSize), FontStyle.Italic);
                cbox_cuti.Checked = false;
                cbox_xieti.Checked = true;
            }
            else if (fontisbold == "true" && fontisItalic == "false")//粗体
            {
                label_test.Font = new Font(FontName, Convert.ToInt32(FontSize), FontStyle.Bold);
                cbox_cuti.Checked = true;
                cbox_xieti.Checked = false;
            }
            else if (fontisbold == "true" && fontisItalic == "true")//粗斜体
            {
                label_test.Font = new Font(FontName, Convert.ToInt32(FontSize), FontStyle.Bold | FontStyle.Italic);
                cbox_cuti.Checked = true;
                cbox_xieti.Checked = true;
            }
            else if(fontisbold == "false" && fontisItalic == "false")//都未选择则恢复原样
            {
                label_test.Font = new Font(FontName, Convert.ToInt32(FontSize), FontStyle.Regular);
                cbox_cuti.Checked = false;
                cbox_xieti.Checked = false;
            }


            //添加软件设置GIF
            try
            {
                pictureBox_softSetup.Image = Image.FromFile(defaultPath + "\\软件配置.gif");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "文件被删除");
            }
        }
        private void ReadDate()
        {
            fanode1 = iniFile.IniReadValue("TreeNodeMean", "treeNode1");
            subnode11 = iniFile.IniReadValue("TreeNodeMean", "treeNode11");
            subnode12 = iniFile.IniReadValue("TreeNodeMean", "treeNode12");
            subnode13 = iniFile.IniReadValue("TreeNodeMean", "treeNode13");
            fanode2 = iniFile.IniReadValue("TreeNodeMean", "treeNode2");
            subnode21 = iniFile.IniReadValue("TreeNodeMean", "treeNode21");
            subnode22 = iniFile.IniReadValue("TreeNodeMean", "treeNode22");
            subnode23 = iniFile.IniReadValue("TreeNodeMean", "treeNode23");

            AXIS1 = iniFile.IniReadValue("GcodeInfo", "AXIS1");
            AXIS2 = iniFile.IniReadValue("GcodeInfo", "AXIS2");

            txtP11 = iniFile.IniReadValue("TreeNodeMean", "txtPoint11");
            txtP12 = iniFile.IniReadValue("TreeNodeMean", "txtPoint12");
            txtP13 = iniFile.IniReadValue("TreeNodeMean", "txtPoint13");
            txtP21 = iniFile.IniReadValue("TreeNodeMean", "txtPoint21");
            txtP22 = iniFile.IniReadValue("TreeNodeMean", "txtPoint22");
            txtP23 = iniFile.IniReadValue("TreeNodeMean", "txtPoint23");

            picP11 = iniFile.IniReadValue("TreeNodeMean", "picPoint11");
            picP12 = iniFile.IniReadValue("TreeNodeMean", "picPoint12");
            picP13 = iniFile.IniReadValue("TreeNodeMean", "picPoint13");
            picP21 = iniFile.IniReadValue("TreeNodeMean", "picPoint21");
            picP22 = iniFile.IniReadValue("TreeNodeMean", "picPoint22");
            picP23 = iniFile.IniReadValue("TreeNodeMean", "picPoint23");

            FontName = iniFile.IniReadValue("TxtStyle", "FontName");
            FontColor = iniFile.IniReadValue("TxtStyle", "FontColor");
            FontSize = iniFile.IniReadValue("TxtStyle", "FontSize");

            string fontisbold = iniFile.IniReadValue("TxtStyle", "FontBold");
            string fontisItalic = iniFile.IniReadValue("TxtStyle", "FontItalic");

            if (fontisbold == "false" && fontisItalic == "true")//斜体
            {
                label_test.Font = new Font(FontName, Convert.ToInt32(FontSize), FontStyle.Italic);
            }
            else if (fontisbold == "true" && fontisItalic == "false")//粗体
            {
                label_test.Font = new Font(FontName, Convert.ToInt32(FontSize), FontStyle.Bold);
            }
            else if (fontisbold == "true" && fontisItalic == "true")//粗斜体
            {
                label_test.Font = new Font(FontName, Convert.ToInt32(FontSize), FontStyle.Bold | FontStyle.Italic);
            }
            else if (fontisbold == "false" && fontisItalic == "false")//都未选择则恢复原样
            {
                label_test.Font = new Font(FontName, Convert.ToInt32(FontSize), FontStyle.Regular);
            }
        }
        #endregion

    }
}