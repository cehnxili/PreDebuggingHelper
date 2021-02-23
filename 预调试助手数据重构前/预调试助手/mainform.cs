using ACS.SPiiPlusNET;
using BDTranslate.Models;
using HZH_Controls.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;

namespace 预调试助手
{
    public partial class winMain : MaterialForm
    {
        #region 定义变量
        private readonly MaterialSkinManager materialSkinManager;

        FileSave fileSave = new FileSave();

        Api channel;
        LineSeries m_lineSeries;

        Thread m_threadGetData;
        bool m_threadRun;

        double m_dLastPntX;
        double m_dLastPntY;

        bool m_bIsClearScop;
        ProgramBuffer m_bufferNum;

        private Label[] m_lblLeftLimit;
        private Label[] m_lblRightLimit;
        private Label[] m_lblFatult;
        private Label[] m_lblEnableState;

        private MotorStates m_nMotorState;
        private object m_objReadVar = null;
        private Array m_arrReadVector = null;
        private double m_PE;

        private const int MAX_UI_LIMIT_CNT = 64;

        int m_axis_count;

        int PreHallState;

        private TranClass tranClass = new TranClass();

        private ACS.SPiiPlusNET.Axis[] m_arrAxisList = null;

        string Path;

        #endregion
        #region 初始化
        public winMain()
        {
            InitializeComponent();

            channel = new Api();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            m_lineSeries = new LineSeries();

            initform();
            SetUpPlot();
        }
        void SetUpPlot()
        {
            PlotModel plotModel = new PlotModel();
            plotModel.TitleFont = "宋体";
            plotModel.DefaultFontSize = 9;
            plotModel.DefaultFontSize = 9;
            plotModel.DefaultFont = "宋体";
            //  plotModel.Title = "二维示波器";

            LinearAxis lineAxisY = new LinearAxis();
            lineAxisY.IntervalLength = 10;
            lineAxisY.Position = AxisPosition.Left;
            lineAxisY.IsZoomEnabled = true;

            LinearAxis lineAxisX = new LinearAxis();
            lineAxisX.IntervalLength = 10;
            lineAxisX.Position = AxisPosition.Bottom;
            lineAxisX.IsZoomEnabled = true;



            LineSeries lineSeries = new LineSeries();
            m_lineSeries.Color = OxyColors.Blue;

            plotModel.Axes.Add(lineAxisX);
            plotModel.Axes.Add(lineAxisY);
            plotModel.Series.Add(m_lineSeries);

            plotView_myScope.Model = plotModel;
        }
        private void addFormToTabPage()
        {
            winMain main = new winMain();
            main.TopLevel = false;
            main.Size = new Size(100, 100);
            main.Location = new Point(0, 0);

            TabPage tp = new TabPage();
            tabControl1.TabPages.Add(tp);
            tp.Name = main.Name;

            tp.Controls.Add(main);
            main.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btn_connect.BackColor = Color.Orange;
            tbox_IP.Text = "10.0.0.100";
            rbtn_TcpIp.Checked = true;
            FrmTips.ShowTipsError(this, "欢迎使用,请首先连接控制器");
            Path = Application.StartupPath + "\\AutoSave";
        }
        private void initform()
        {
            tbox_ACC.Enabled = false;
            tbox_VEL.Enabled = false;
            tbox_DEC.Enabled = false;
            tbox_JERK.Enabled = false;
            tbox_JOGspeed.Enabled = false;
            tbox_KDEC.Enabled = false;
            tbox_position_dis.Enabled = false;
            tbox_Terminal.Enabled = false;
            cbox_useJOG.Enabled = false;

            btn_enable.AutoSize = false;
            btn_enable.Size = new Size(66, 25);
            btn_disable.AutoSize = false;
            btn_disable.Size = new Size(66, 25);

            btn_enableALL.AutoSize = false;
            btn_enableALL.Size = new Size(100, 25);
            btn_disableALL.AutoSize = false;
            btn_disableALL.Size = new Size(100, 25);

            btn_JOGNE.AutoSize = false;
            btn_JOGNE.Size = new Size(66, 23);
            btn_JOGRE.AutoSize = false;
            btn_JOGRE.Size = new Size(66, 23);
            btn_save.AutoSize = false;
            btn_save.Size = new Size(66, 23);
            btn_send.AutoSize = false;
            btn_send.Size = new Size(66, 23);
            btn_set0.AutoSize = false;
            btn_set0.Size = new Size(200, 23);
            btn_clear.AutoSize = false;
            btn_clear.Size = new Size(66, 23);
            rbtn_TcpIp.AutoSize = false;
            rbtn_TcpIp.Size = new Size(69, 23);
            rbtn_sim.AutoSize = false;
            rbtn_sim.Size = new Size(69, 23);
            Enable_baidu.AutoSize = false;
            Enable_baidu.Size = new Size(120, 23);

            btn_abposition.AutoSize = false;
            btn_abposition.Size = new Size(200, 23);
            btn_NEposition.AutoSize = false;
            btn_NEposition.Size = new Size(66, 23);
            btn_positive.AutoSize = false;
            btn_positive.Size = new Size(66, 23);

            tbox_VEL.Tag = 0;
            tbox_ACC.Tag = 1;
            tbox_DEC.Tag = 2;
            tbox_KDEC.Tag = 3;
            tbox_JERK.Tag = 4;


        }
        private void InitFormAfter()
        {
            tbox_ACC.Enabled = true;
            tbox_VEL.Enabled = true;
            tbox_DEC.Enabled = true;
            tbox_JERK.Enabled = true;
            tbox_JOGspeed.Enabled = true;
            tbox_KDEC.Enabled = true;
            tbox_position_dis.Enabled = true;
            tbox_Terminal.Enabled = true;
            cbox_useJOG.Enabled = true;

        }
        private void rbtn_sim_CheckedChanged(object sender, EventArgs e)
        {
            tbox_IP.Enabled = false;
        }
        private void rbtn_TcpIp_CheckedChanged(object sender, EventArgs e)
        {
            tbox_IP.Enabled = true;
        }
        private void btn_connect_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (!channel.IsConnected)
                {
                    if (rbtn_TcpIp.Checked)
                    {
                        channel.OpenCommEthernetTCP(tbox_IP.Text, 701);
                        //自动保存#SI
                        string SIInfomation = channel.Transaction("#SI");
                        string ECName = channel.Transaction("?SN");
                        fileSave.SISave(Path + "\\" + ECName.Trim() + ".txt", SIInfomation);
                        //自动保存SPI
                        string datetime = System.DateTime.Now.ToLongDateString();
                        string filename = Path + "\\" + datetime.Trim() + ".spi";
                        ApplicationFileInfo info = channel.AnalyzeApplication(null);
                        fileSave.SPISave(filename, info);
                    }
                    else if (rbtn_sim.Checked)
                    {
                        channel.OpenCommSimulator();
                    }
                    btn_connect.Text = "断开连接";
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    m_axis_count = Convert.ToInt32(channel.GetAxesCount());
                    m_arrAxisList = new ACS.SPiiPlusNET.Axis[m_axis_count + 1];
                    for (int i = 0; i < m_axis_count; i++)
                    {
                        cbBox_enable.Items.Add(i.ToString());
                        cbox_axis1.Items.Add(i.ToString());
                        cbox_axis2.Items.Add(i.ToString());
                        m_arrAxisList[i] = (ACS.SPiiPlusNET.Axis)i;
                    }
                    m_arrAxisList[m_axis_count] = ACS.SPiiPlusNET.Axis.ACSC_NONE;

                    cbBox_enable.SelectedIndex = 0;
                    cbox_axis1.SelectedIndex = 0;
                    cbox_axis2.SelectedIndex = 1;
                    cbox_xseg.SelectedIndex = 0;
                    btn_enable.Enabled = true;
                    btn_disable.Enabled = true;

                    time_Update.Interval = 500;
                    time_Update.Enabled = true;
                    InitFormAfter();
                    dynamic_creatlabel();
                }
                else if (btn_connect.Text == "断开连接")
                {
                    channel.CloseComm();
                    btn_connect.Text = "连接";
                    btn_connect.ForeColor = Color.FromArgb(255, 77, 58);
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    time_Update.Enabled = false;
                }
            }
            catch (ACSException EX)
            {
                if (Enable_baidu.Checked)
                {
                    string args = EX.Message;
                    string reply = TransAPI(args);
                    MessageBox.Show(reply, "连接错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(EX.Message, "连接错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //动态创建限位
        private void dynamic_creatlabel()
        {
            panel_fault.Controls.Clear();

            m_lblFatult = new Label[m_axis_count];
            for (int i = 0; i < m_axis_count; i++)
            {
                m_lblFatult[i] = new Label();
                m_lblFatult[i].Size = new Size(17, 12);
                m_lblFatult[i].Location = new Point(3 + i * 22, 2);
                m_lblFatult[i].Image = null;
                m_lblFatult[i].Name = i.ToString();
                m_lblFatult[i].Text = i.ToString();
                panel_fault.Controls.Add(m_lblFatult[i]);
            }
            m_lblLeftLimit = new Label[m_axis_count];
            for (int i = 0; i < m_axis_count; i++)
            {

                m_lblLeftLimit[i] = new Label();
                m_lblLeftLimit[i].Size = new Size(19, 17);
                m_lblLeftLimit[i].Location = new Point(1 + i * 22, 30);
                m_lblLeftLimit[i].Image = Properties.Resources.Off;
                m_lblLeftLimit[i].Name = "lblLL" + i.ToString();
                panel_fault.Controls.Add(m_lblLeftLimit[i]);
            }
            m_lblRightLimit = new Label[m_axis_count];
            for (int i = 0; i < m_axis_count; i++)
            {
                m_lblRightLimit[i] = new Label();
                m_lblRightLimit[i].Size = new Size(19, 17);
                m_lblRightLimit[i].Location = new Point(1 + i * 22, 55);
                m_lblRightLimit[i].Image = Properties.Resources.Off;
                m_lblRightLimit[i].Name = "lblRL" + i.ToString();
                panel_fault.Controls.Add(m_lblRightLimit[i]);
            }
            m_lblEnableState = new Label[m_axis_count];
            for (int i = 0; i < m_axis_count; i++)
            {

                m_lblEnableState[i] = new Label();
                m_lblEnableState[i].Size = new Size(19, 17);
                m_lblEnableState[i].Location = new Point(1 + i * 22, 80);
                m_lblEnableState[i].Image = Properties.Resources.Off;
                m_lblEnableState[i].Name = "lblRL" + i.ToString();
                m_lblEnableState[i].Click += new System.EventHandler(lb_Click);
                panel_fault.Controls.Add(m_lblEnableState[i]);
            }

        }

        private void lb_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            Label lab = sender as Label;
            string axisn = System.Text.RegularExpressions.Regex.Replace(lab.Name, @"[^0-9]+", "");
            int axis_NO = Convert.ToInt32(axisn);
            m_nMotorState = channel.GetMotorState((ACS.SPiiPlusNET.Axis)axis_NO);

            if ((m_nMotorState & MotorStates.ACSC_MST_ENABLE) != 0)
            {
                channel.Disable((ACS.SPiiPlusNET.Axis)axis_NO);
            }
            else
            {
                channel.Enable((ACS.SPiiPlusNET.Axis)axis_NO);
            }
        }

        //开关使能
        private void btn_enable_BtnClick(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            channel.Enable((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex);
        }
        private void btn_disable_BtnClick(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            channel.Disable((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex);
        }
        #endregion
        #region 限位状态、运动参数获取
        //获取运动参数
        private void UpdateMotionProfile()
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            tbox_VEL.Text = channel.GetVelocity((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex).ToString();
            tbox_ACC.Text = channel.GetAcceleration((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex).ToString();
            tbox_DEC.Text = channel.GetDeceleration((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex).ToString();
            tbox_KDEC.Text = channel.GetKillDeceleration((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex).ToString();
            tbox_JERK.Text = channel.GetJerk((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex).ToString();
        }
        private void cbBox_enable_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProfile();
        }
        private void UpdateProfile()
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            tbox_VEL.Text = channel.GetVelocity((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex).ToString();
            tbox_ACC.Text = channel.GetAcceleration((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex).ToString();
            tbox_DEC.Text = channel.GetDeceleration((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex).ToString();
            tbox_KDEC.Text = channel.GetKillDeceleration((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex).ToString();
            tbox_JERK.Text = channel.GetJerk((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex).ToString();
        }
        //更新限位、位置参数
        private void time_Update_Tick(object sender, EventArgs e)
        {
            //获取当前选中的轴
            int axis_NO = cbBox_enable.SelectedIndex;
            double hallState = 0.0;
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            try
            {
                m_nMotorState = channel.GetMotorState((ACS.SPiiPlusNET.Axis)axis_NO);

                m_PE = (double)channel.ReadVariable("PE", ProgramBuffer.ACSC_NONE, axis_NO, axis_NO);
                //获取当前状态
                if ((m_nMotorState & MotorStates.ACSC_MST_MOVE) != 0) LED_moveing.Image = Properties.Resources.On; else LED_moveing.Image = Properties.Resources.Off;
                if ((m_nMotorState & MotorStates.ACSC_MST_ACC) != 0) LED_ACCing.Image = Properties.Resources.On; else LED_ACCing.Image = Properties.Resources.Off;
                if ((m_nMotorState & MotorStates.ACSC_MST_INPOS) != 0) LED_inposition.Image = Properties.Resources.On; else LED_inposition.Image = Properties.Resources.Off;
                if ((m_nMotorState & MotorStates.ACSC_MST_ENABLE) != 0) LED_enable.Image = Properties.Resources.On; else LED_enable.Image = Properties.Resources.Off;

                if (cbox_hall.Checked)
                {
                  hallState= channel.GetConf(262, axis_NO);//获取hall的值
                  UpdateHallState(axis_NO, Convert.ToInt32(hallState));
                }

                PreHallState = Convert.ToInt32(hallState);//将本次的值传给

                //获取当前位置
                tbox_RPOS.Text = string.Format("{0:0.000}", channel.GetRPosition((ACS.SPiiPlusNET.Axis)axis_NO));
                tbox_FPOS.Text = string.Format("{0:0.000}", channel.GetFPosition((ACS.SPiiPlusNET.Axis)axis_NO));
                tbox_FVEL.Text = string.Format("{0:0.000}", channel.GetFVelocity((ACS.SPiiPlusNET.Axis)axis_NO));
                tbox_PE.Text = string.Format("{0:0.000}", m_PE);

                //获取限位状态
                m_objReadVar = channel.ReadVariableAsVector("FAULT", ProgramBuffer.ACSC_NONE, 0, m_axis_count - 1, -1, -1);
                if (m_objReadVar != null)
                {
                    m_arrReadVector = m_objReadVar as Array;
                    if (m_arrReadVector != null)
                    {
                        for (int i = 0; i < m_axis_count; i++)
                        {
                            UpdateLimitState(i, (int)m_arrReadVector.GetValue(i));
                            UpdateEnableState(i);
                        }
                    }
                }
            }
            catch (ACSException EX)
            {
                if (Enable_baidu.Checked)
                {
                    string args = EX.Message;
                    string reply = TransAPI(args);
                    MessageBox.Show(reply, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(EX.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        // 更新限位状态
        private void UpdateLimitState(int axisNo, int fault)
        {
            if (axisNo < MAX_UI_LIMIT_CNT)
            {
                if ((fault & (int)SafetyControlMasks.ACSC_SAFETY_LL) != 0) m_lblLeftLimit[axisNo].Image = Properties.Resources.Error; else m_lblLeftLimit[axisNo].Image = Properties.Resources.Off;
                if ((fault & (int)SafetyControlMasks.ACSC_SAFETY_RL) != 0) m_lblRightLimit[axisNo].Image = Properties.Resources.Error; else m_lblRightLimit[axisNo].Image = Properties.Resources.Off;
            }
        }
        private void UpdateEnableState(int axisNo)
        {
            if (axisNo < MAX_UI_LIMIT_CNT)
            {
                m_nMotorState = channel.GetMotorState((ACS.SPiiPlusNET.Axis)axisNo);
                if ((m_nMotorState & MotorStates.ACSC_MST_ENABLE) != 0) m_lblEnableState[axisNo].Image = Properties.Resources.On; else m_lblEnableState[axisNo].Image = Properties.Resources.Off;
            }
        }
        private void UpdateHallState(int axisNo, int state)
        {
            if (state == PreHallState) { return; }
            if (state >= 0)
            {
                ClockControl clock = new ClockControl();
                clock.SetAngle(state*60);
                panel_hall.Controls.Add(clock);
                richTextBox_hall.Text += state + "\n";
            }
            else
            {
                richTextBox_hall.Text += state+"\n";
            }
        }
        #endregion
        # region 设置当前位置为0
        private void btn_set0_BtnClick(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            //设置当前位置为0
            channel.SetFPosition((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, 0);
        }
        #endregion
        #region JOG运动
        private void btn_JOGNE_MouseDown(object sender, MouseEventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            time_Update.Interval = 50;
            double JOGNE_SPEED = 0.0F;
            try
            {
                if (cbox_useJOG.Checked)
                {
                    JOGNE_SPEED = Convert.ToDouble(tbox_JOGspeed.Text);
                    if (JOGNE_SPEED > 0) { JOGNE_SPEED = JOGNE_SPEED * (-1); }
                    channel.Jog(MotionFlags.ACSC_AMF_VELOCITY, (ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, JOGNE_SPEED);
                }
                else
                {
                    channel.Jog(0, (ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, (Double)GlobalDirection.ACSC_NEGATIVE_DIRECTION);
                }
            }
            catch (ACSException EX)
            {
                if (Enable_baidu.Checked)
                {
                    string args = EX.Message;
                    string reply = TransAPI(args);
                    MessageBox.Show(reply, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(EX.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_JOGRE_MouseDown(object sender, MouseEventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            time_Update.Interval = 50;
            double JOGNE_SPEED = 0.0F;
            try
            {
                if (cbox_useJOG.Checked)
                {
                    JOGNE_SPEED = Convert.ToDouble(tbox_JOGspeed.Text);
                    if (JOGNE_SPEED < 0) { JOGNE_SPEED = JOGNE_SPEED * (-1); }
                    channel.Jog(MotionFlags.ACSC_AMF_VELOCITY, (ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, JOGNE_SPEED);
                }
                else
                {
                    channel.Jog(0, (ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, (Double)GlobalDirection.ACSC_POSITIVE_DIRECTION);
                }
            }
            catch (ACSException EX)
            {
                if (Enable_baidu.Checked)
                {
                    string args = EX.Message;
                    string reply = TransAPI(args);
                    MessageBox.Show(reply, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(EX.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btn_JOGRE_MouseUp(object sender, MouseEventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            channel.Halt((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex);
            time_Update.Interval = 500;
        }
        private void btn_JOGNE_MouseUp(object sender, MouseEventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            channel.Halt((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex);
            time_Update.Interval = 500;
        }
        #endregion
        #region 通讯终端
        private void btn_send_BtnClick(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            initTerminal();
        }
        private void tbox_Terminal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                initTerminal();
            }
        }
        private void initTerminal()
        {
            try
            {
                string cmd = tbox_Terminal.Text.ToUpper();
                if (Enable_baidu.Checked)
                {
                    string args = channel.Transaction(cmd);
                    string[] argsArray= new string[args.Length/500];
                    for (int i = 0; i < args.Length/500; i++)
                    {

                        argsArray[i] = args.Substring(500*i,500);
                        if (!string.IsNullOrEmpty(argsArray[i]))
                        {
                            string reply = TransAPI(argsArray[i]);
                            Thread.Sleep(100);
                            rbox_terminal.Text += cmd + "\n";
                            rbox_terminal.Text += reply + "\n" + ":" + "\n";
                        }


                    }

                }
                else
                {
                    rbox_terminal.Text += cmd + "\n";
                    rbox_terminal.Text += channel.Transaction(cmd) + ":" + "\n";
                }
            }
            catch (ACSException EX)
            {
                if (Enable_baidu.Checked)
                {
                    string args = EX.Message;
                    string reply = TransAPI(args);
                    MessageBox.Show(reply, "通讯终端错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(EX.Message, "通讯终端错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rbox_terminal.Text = "错误代码为：" + Convert.ToString(EX.ErrorCode) + "\n";
            }
        }
        private void btn_clear_BtnClick(object sender, EventArgs e)
        {
            rbox_terminal.Text = "";
        }
        private void btn_save_BtnClick(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            SaveFileDialog file = new SaveFileDialog();
            file.Title = "通讯终端输出结果保存";
            file.Filter = "文本文件|*.txt|全部文件|*.*";
            file.RestoreDirectory = true;//是否记录上次的路径
            file.FileName = tbox_Terminal.Text;
            if (file.ShowDialog() == DialogResult.OK)
            {
                string Path = file.FileName;
                File.WriteAllText(Path, rbox_terminal.Text);
            }
        }
        #endregion
        #region 百度翻译
        static string TransAPI(string args)
        {
            // 原文
            string q = args;
            // 源语言
            string from = "auto";
            // 目标语言
            string to = "zh";
            // 改成您的APP ID
            string appId = "20201203000635687";
            Random rd = new Random();
            string salt = rd.Next(100000).ToString();
            // 改成您的密钥
            string secretKey = "l4ILmi5BEkVCKkA_PtGk";
            string sign = EncryptString(appId + q + salt + secretKey);
            string url = "http://api.fanyi.baidu.com/api/trans/vip/translate?";
            url += "q=" + HttpUtility.UrlEncode(q);
            url += "&from=" + from;
            url += "&to=" + to;
            url += "&appid=" + appId;
            url += "&salt=" + salt;
            url += "&sign=" + sign;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;
            request.Timeout = 60000;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));

            JsonTextReader jsonTextReader = new JsonTextReader(myStreamReader);
            JsonSerializer serializer = new JsonSerializer();
            var r = serializer.Deserialize<TranClass>(jsonTextReader);
            return r.Trans_result[0].dst;
        }
        // 计算MD5值
        public static string EncryptString(string str)
        {
            MD5 md5 = MD5.Create();
            // 将字符串转换成字节数组
            byte[] byteOld = Encoding.UTF8.GetBytes(str);
            // 调用加密方法
            byte[] byteNew = md5.ComputeHash(byteOld);
            // 将加密结果转换为字符串
            StringBuilder sb = new StringBuilder();
            foreach (byte b in byteNew)
            {
                // 将字节转换成16进制表示的字符串，
                sb.Append(b.ToString("x2"));
            }
            // 返回加密的字符串
            return sb.ToString();
        }
        #endregion
        #region 界面转换
        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            Form_Guide fm = new Form_Guide();
            fm.Show();
            this.Hide();
        }

        private void winMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        #endregion
        #region 提示
        private void tbox_Terminal_MouseClick(object sender, MouseEventArgs e)
        {
            FrmTips.ShowTipsWarning(this, "输出多行字符时请关闭翻译，如#SI、#EtherCAT等");
        }

        private void Enable_baidu_CheckedChanged(object sender, EventArgs e)
        {
            FrmTips.ShowTipsWarning(this, "仅在联网时可用");
        }

        #endregion
        #region 停止运动
        private void btn_STOP_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            channel.KillAll();
        }
        #endregion
        #region 改变参数
        private void TextBoxes_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                double lfTemp = 0.0f;
                Control textBox = sender as Control;
                if (textBox != null)
                {
                    // Allow numbers (0 ~ 9), . (DOT), Backspace
                    if ((e.KeyChar >= 0x30 && e.KeyChar <= 0x39) || e.KeyChar == 0x2E || e.KeyChar == 0x08 || e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
                    {
                        if ((e.KeyChar == 0x2E) && (textBox.Text.Contains(Convert.ToString(0x2E)))) e.KeyChar = (char)0x00;
                        if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
                        {
                            e.Handled = true;

                            lfTemp = Convert.ToDouble(textBox.Text.Trim());
                            int g = (int)textBox.Tag;
                            switch (g)
                            {
                                // Immediately change value (On the fly) : SetVelocityImm() 
                                // Affect next motion	: SetVelocity()	

                                case 0: channel.SetVelocityImm((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, lfTemp); break;
                                case 1: channel.SetAccelerationImm((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, lfTemp); break;
                                case 2: channel.SetDecelerationImm((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, lfTemp); break;
                                case 3: channel.SetKillDecelerationImm((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, lfTemp); break;
                                case 4: channel.SetJerkImm((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, lfTemp); break;
                            }
                            //textBox.SelectAll();
                        }
                    }
                    else e.KeyChar = (char)0x00;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("TextBoxes_KeyPress() Error\n" + ex.ToString());
            }
        }
        private void cbBox_enable_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateMotionProfile();
        }
        private void TextBoxes_Enter(object sender, EventArgs e)
        {
            try
            {
                TextBox textBox = sender as TextBox;
                if (textBox != null) textBox.SelectAll();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("TextBoxes_Enter() Error\n" + ex.ToString());
            }
        }

        private void TextBoxes_Leave(object sender, EventArgs e)
        {
            try
            {
                double lfTemp = 0.0f;

                TextBox textBox = sender as TextBox;
                if (textBox == null) return;

                lfTemp = Convert.ToDouble(textBox.Text.Trim());
                int g = (int)textBox.Tag;
                switch (g)
                {
                    case 0: channel.SetVelocityImm((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, lfTemp); break;
                    case 1: channel.SetAccelerationImm((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, lfTemp); break;
                    case 2: channel.SetDecelerationImm((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, lfTemp); break;
                    case 3: channel.SetKillDecelerationImm((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, lfTemp); break;
                    case 4: channel.SetJerkImm((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, lfTemp); break;
                }

                textBox.SelectAll();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("TextBoxes_Leave() Error\n" + ex.ToString());
            }
        }

        #endregion
        #region 绝对运动
        private void btn_abposition_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            double lfTargetPos = 0.0f;
            try
            {
                if (tbox_position_dis.Text.Length > 0)
                {
                    lfTargetPos = Convert.ToDouble(tbox_position_dis.Text);
                    channel.ToPoint(0, (ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, lfTargetPos);
                }
            }
            catch (Exception ex)
            {
                if (Enable_baidu.Checked)
                {
                    string args = ex.Message;
                    string reply = TransAPI(args);
                    MessageBox.Show(reply, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region 绝对位置运动
        private void btn_NEposition_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            double lfTargetPos = 0.0f;
            try
            {
                if (tbox_position_dis.Text.Length > 0)
                {
                    lfTargetPos = Convert.ToDouble(tbox_position_dis.Text);
                    if (lfTargetPos > 0) lfTargetPos = lfTargetPos * (-1);
                    channel.ToPoint(MotionFlags.ACSC_AMF_RELATIVE, (ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, lfTargetPos);
                }
            }
            catch (Exception ex)
            {
                if (Enable_baidu.Checked)
                {
                    string args = ex.Message;
                    string reply = TransAPI(args);
                    MessageBox.Show(reply, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_positive_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            double lfTargetPos = 0.0f;
            try
            {
                if (tbox_position_dis.Text.Length > 0)
                {
                    lfTargetPos = Convert.ToDouble(tbox_position_dis.Text);
                    if (lfTargetPos < 0) lfTargetPos = lfTargetPos * (-1);
                    channel.ToPoint(MotionFlags.ACSC_AMF_RELATIVE, (ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex, lfTargetPos);
                }
            }
            catch (Exception ex)
            {
                if (Enable_baidu.Checked)
                {
                    string args = ex.Message;
                    string reply = TransAPI(args);
                    MessageBox.Show(reply, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #region 清除报错
        private void btn_clearFault_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            for (int i = 0; i < m_arrAxisList.Length - 1; i++)
            {
                channel.FaultClear(m_arrAxisList[i]);
            }
        }
        #endregion
        #region  往返运动
        private void btn_readA_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            tbox_APosition.Text = Convert.ToString(channel.GetFPosition((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex));
        }
        private void btn_readB_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            tbox_BPosition.Text = Convert.ToString(channel.GetFPosition((ACS.SPiiPlusNET.Axis)cbBox_enable.SelectedIndex));
        }
        private void btn_statABMotion_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            string Axis = cbBox_enable.SelectedIndex.ToString();
            string dwell = tbox_delayTime.Text;
            string APositon = tbox_APosition.Text;
            string BPositon = tbox_BPosition.Text;
            try
            {
                string cmd = "MPTP/C " + Axis + "," + dwell;
                string args = channel.Transaction(cmd);
                rbox_terminal.Text += args + "\n";

                cmd = "POINT " + Axis + "," + APositon;
                args = channel.Transaction(cmd);
                rbox_terminal.Text += args + "\n";

                cmd = "POINT " + Axis + "," + BPositon;
                args = channel.Transaction(cmd);
                rbox_terminal.Text += args + "\n";

                cmd = "ENDS " + Axis;
                args = channel.Transaction(cmd);
                rbox_terminal.Text += args + "\n";
            }
            catch (ACSException EX)
            {
                if (Enable_baidu.Checked)
                {
                    string args = EX.Message;
                    string reply = TransAPI(args);
                    MessageBox.Show(reply, "往返运动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(EX.Message, "往返运动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rbox_terminal.Text = "错误代码为：" + Convert.ToString(EX.ErrorCode) + "\n";
            }
        }

        #endregion

        private void cbox_xseg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string defaultPath;
            defaultPath = System.Windows.Forms.Application.StartupPath + "\\project file";

            switch (cbox_xseg.SelectedIndex)
            {
                case 0:
                    tbox_xsegX.Enabled = false;
                    tbox_xsegY.Enabled = false;
                    tbox_xsegHeight.Enabled = false;
                    tbox_xsegWidth.Enabled = false;
                    tbox_roundLong.Enabled = true;
                    tbox_roundX.Enabled = true;
                    tbox_roundY.Enabled = true;
                    pictureBox_XSEG.Image = Image.FromFile(defaultPath + "\\圆.png");
                    break;
                case 1:
                    tbox_xsegX.Enabled = true;
                    tbox_xsegY.Enabled = true;
                    tbox_xsegHeight.Enabled = true;
                    tbox_xsegWidth.Enabled = true;
                    tbox_roundLong.Enabled = false;
                    tbox_roundX.Enabled = false;
                    tbox_roundY.Enabled = false;
                    pictureBox_XSEG.Image = Image.FromFile(defaultPath + "\\矩形.png");
                    break;
            }
        }

        private void btn_xsegStart_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            if (string.IsNullOrEmpty(cbox_axis1.Text) || string.IsNullOrEmpty(cbox_axis2.Text)) { MessageBox.Show("请选择轴", "XSEG运动控制提示"); return; }

            int type = cbox_xseg.SelectedIndex;
            ACS.SPiiPlusNET.Axis axis1 = (ACS.SPiiPlusNET.Axis)cbox_axis1.SelectedIndex;
            ACS.SPiiPlusNET.Axis axis2 = (ACS.SPiiPlusNET.Axis)cbox_axis2.SelectedIndex;
            ACS.SPiiPlusNET.Axis[] axes = { axis1, axis2, ACS.SPiiPlusNET.Axis.ACSC_NONE };
            double roundX = 0, roundY = 0, roundangle = 0, xsegX = 0, xsegY = 0, xsegW = 0, xsegH = 0;
            int delayTime = -1;

            switch (type)
            {
                case 0:
                    if (string.IsNullOrEmpty(tbox_roundX.Text) || string.IsNullOrEmpty(tbox_roundY.Text) || string.IsNullOrEmpty(tbox_roundY.Text)) { MessageBox.Show("请填写圆参数", "XSEG运动参数提示"); return; }
                    roundX = Convert.ToDouble(tbox_roundX.Text);
                    roundY = Convert.ToDouble(tbox_roundY.Text);
                    roundangle = Convert.ToDouble(tbox_roundLong.Text);
                    break;
                case 1:
                    if (string.IsNullOrEmpty(tbox_xsegHeight.Text) || string.IsNullOrEmpty(tbox_xsegWidth.Text) || string.IsNullOrEmpty(tbox_xsegX.Text) || string.IsNullOrEmpty(tbox_xsegY.Text)) { MessageBox.Show("请填写矩形参数", "XSEG运动参数提示"); return; }
                    xsegX = Convert.ToDouble(tbox_xsegX.Text);
                    xsegY = Convert.ToDouble(tbox_xsegY.Text);
                    xsegW = Convert.ToDouble(tbox_xsegWidth.Text);
                    xsegH = Convert.ToDouble(tbox_xsegHeight.Text);
                    break;
            }

            Thread p = new Thread(() =>
            {
                double[] Point1 = { 0, 0 };
                double[] center = { 0, 0 };
                double[] FinalPoint = { 0, 0 };

                channel.EnableM(axes);
                channel.WaitMotorEnabled(axis1, 1, delayTime);
                channel.WaitMotorEnabled(axis2, 1, delayTime);
                switch (type)
                {
                    case 0://选择的是圆


                        center[0] = roundX; center[1] = roundY + roundangle;
                        channel.ToPointM(MotionFlags.ACSC_NONE, axes, center);
                        channel.WaitMotionEnd(axis1, delayTime);
                        channel.WaitMotionEnd(axis2, delayTime);
                        channel.ExtendedSegmentedMotion(MotionFlags.ACSC_NONE, axes, center, Api.ACSC_NONE, Api.ACSC_NONE, Api.ACSC_NONE, Api.ACSC_NONE, Api.ACSC_NONE, null);
                        center[0] = roundX; center[1] = roundY;
                        FinalPoint[0] = roundX; FinalPoint[1] = roundY + roundangle;
                        channel.ExtendedSegmentArc1(MotionFlags.ACSC_NONE, axes, center, FinalPoint, RotationDirection.ACSC_CLOCKWISE, Api.ACSC_NONE, Api.ACSC_NONE, Api.ACSC_NONE, null, null, Api.ACSC_NONE, null);
                        channel.EndSequenceM(axes);
                        channel.WaitMotionEnd(axis1, delayTime);
                        channel.WaitMotionEnd(axis2, delayTime);
                        break;
                    case 1://选择的是矩形
                        Point1[0] = xsegX; Point1[1] = xsegY;
                        channel.ToPointM(MotionFlags.ACSC_NONE, axes, Point1);
                        channel.WaitMotionEnd(axis1, delayTime);
                        channel.WaitMotionEnd(axis2, delayTime);
                        channel.ExtendedSegmentedMotion(
                            MotionFlags.ACSC_NONE,
                            axes,
                            Point1,
                            Api.ACSC_NONE,
                            Api.ACSC_NONE,
                            Api.ACSC_NONE,
                            Api.ACSC_NONE,
                            Api.ACSC_NONE,
                            null);
                        Point1[0] = xsegX + xsegW; Point1[1] = xsegY;
                        channel.Line(axes, Point1);
                        Point1[0] = xsegX + xsegW; Point1[1] = xsegY - xsegH;
                        channel.Line(axes, Point1);
                        Point1[0] = xsegX; Point1[1] = xsegY - xsegH;
                        channel.Line(axes, Point1);
                        Point1[0] = xsegX; Point1[1] = xsegY;
                        channel.Line(axes, Point1);
                        channel.EndSequenceM(axes);
                        channel.WaitMotionEnd(axis1, delayTime);
                        channel.WaitMotionEnd(axis2, delayTime);
                        break;
                }
            });
            p.Start();
        }

        private void btn_clearFPOS_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            m_lineSeries.Points.Clear();
            plotView_myScope.Model.InvalidatePlot(true);
        }

        private void btn_col_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            m_threadRun = true;//将线程标志位设置为真
            m_bufferNum = (ProgramBuffer)numericUpDown_buffer.Value;
            m_threadGetData = new Thread(() => UpdateScope());//将updatescope方法与线程关联
            m_threadGetData.IsBackground = true;//后台运行线程功能打开
            m_threadGetData.Name = "m_threadGetData";
            m_threadGetData.Start();//打开线程
            AllowInput(false);//将按钮名称改为停止采集
        }

        private void AllowInput(bool isAllowInput)
        {
            textBox_xVar.Enabled = isAllowInput;
            textBox_yVar.Enabled = isAllowInput;
            numericUpDown_buffer.Enabled = isAllowInput;
        }

        void UpdateScope()
        {
            while (m_threadRun)
            {
                try
                {
                    string axis1 = textBox_xVar.Text;
                    string axis2 = textBox_yVar.Text;
                    double xpnt = (double)channel.ReadVariable(axis1);
                    double ypnt = (double)channel.ReadVariable(axis2);
                    if (m_dLastPntX != xpnt || m_dLastPntY != ypnt)
                    {
                        m_lineSeries.Points.Add(new DataPoint(xpnt, ypnt));
                        m_dLastPntX = xpnt;
                        m_dLastPntY = ypnt;
                        //MessageBox.Show(Thread.CurrentThread.Name);
                    }

                    if (checkBox_bufferRunClearScope.Checked)
                    {
                        if (m_bIsClearScop && ((ProgramStates.ACSC_PST_RUN & channel.GetProgramState(m_bufferNum)) == ProgramStates.ACSC_PST_RUN))
                        {
                            m_bIsClearScop = false;
                            m_lineSeries.Points.Clear();
                        }
                        else if (!m_bIsClearScop && ((ProgramStates.ACSC_PST_RUN & channel.GetProgramState(m_bufferNum)) != ProgramStates.ACSC_PST_RUN))
                        {
                            m_bIsClearScop = true;
                        }
                    }

                    plotView_myScope.Model.InvalidatePlot(true);
                    Thread.Sleep(10);
                }
                catch (ACSException ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Invoke((MethodInvoker)delegate
                    {
                        AllowInput(true);
                    });
                    break;
                }
            }
        }

        private void winMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_threadGetData != null && m_threadGetData.IsAlive)
            {
                m_threadRun = false;
                m_threadGetData.Join();
            }

            channel.CloseComm();
        }

        private void btn_stopCol_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            if (m_threadGetData.IsAlive)//如果线程还在运行
            {
                m_threadRun = false;//将线程标志位设置为假
                m_threadGetData.Join();//阻塞线程的运行
            }
            AllowInput(true);//将按钮名称改为开始采集
        }
        //全部上使能
        private void btn_enableALL_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            for (int i = 0; i < m_axis_count; i++)
            {
                channel.Enable((ACS.SPiiPlusNET.Axis)i);
            }
        }
        //全部断使能
        private void btn_disableALL_Click(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            for (int i = 0; i < m_axis_count; i++)
            {
                channel.Disable((ACS.SPiiPlusNET.Axis)i);
            }
        }



        private void cbox_hall_CheckedChanged(object sender, EventArgs e)
        {
            if (!channel.IsConnected) { MessageBox.Show("请先连接ACS控制器", "ACS未连接警示"); return; }
            if (cbox_hall.Checked)
            {
                ClockControl clock = new ClockControl();
                clock.SetAngle(0);
                panel_hall.Controls.Add(clock);
            }
        }

        private void tbox_VEL_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbox_VEL.Text))
            {
                int VEL = Convert.ToInt32(tbox_VEL.Text);
                tbox_ACC.Text = (VEL * 10).ToString();
                tbox_DEC.Text = (VEL * 10).ToString();
                tbox_KDEC.Text = (VEL * 100).ToString();
                tbox_JERK.Text = (VEL * 100).ToString();
            }
        }
    }
}
namespace BDTranslate.Models
{
    public class TranClass
    {
        public string From { get; set; }
        public string To { get; set; }
        public List<Trans_result> Trans_result { get; set; }
    }
    public class Trans_result
    {
        public string src { get; set; }
        public string dst { get; set; }
    }
}