namespace 预调试助手
{
    partial class winMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winMain));
            this.tbox_VEL = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.gbox_motionprofile = new System.Windows.Forms.GroupBox();
            this.tbox_JERK = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbox_KDEC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbox_DEC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbox_ACC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.time_Update = new System.Windows.Forms.Timer(this.components);
            this.gbox_positon = new System.Windows.Forms.GroupBox();
            this.tbox_PE = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbox_FVEL = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbox_FPOS = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbox_RPOS = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_set0 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_abposition = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_positive = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_NEposition = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbox_position_dis = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbox_JOGspeed = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_JOGRE = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_JOGNE = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbox_useJOG = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox_IP = new System.Windows.Forms.TextBox();
            this.rbox_terminal = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbox_Terminal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_save = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_clear = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_send = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.cbBox_enable = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_enable = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_disable = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ucBtnExt1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.rbtn_TcpIp = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtn_sim = new MaterialSkin.Controls.MaterialRadioButton();
            this.Enable_baidu = new MaterialSkin.Controls.MaterialCheckBox();
            this.btn_STOP = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_clearFault = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_delayTime = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_readB = new System.Windows.Forms.Label();
            this.btn_readA = new System.Windows.Forms.Label();
            this.tbox_BPosition = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_statABMotion = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tbox_APosition = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LED_enable = new System.Windows.Forms.Label();
            this.LED_inposition = new System.Windows.Forms.Label();
            this.LED_ACCing = new System.Windows.Forms.Label();
            this.LED_moveing = new System.Windows.Forms.Label();
            this.tabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_connect = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox_hall = new System.Windows.Forms.GroupBox();
            this.richTextBox_hall = new System.Windows.Forms.RichTextBox();
            this.cbox_hall = new MaterialSkin.Controls.MaterialCheckBox();
            this.panel_hall = new System.Windows.Forms.Panel();
            this.btn_disableALL = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_enableALL = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panel_axisState = new System.Windows.Forms.Panel();
            this.gbox_fault = new System.Windows.Forms.GroupBox();
            this.panel_fault = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_stopCol = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_yVar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_xVar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.checkBox_bufferRunClearScope = new MaterialSkin.Controls.MaterialCheckBox();
            this.numericUpDown_buffer = new System.Windows.Forms.NumericUpDown();
            this.btn_col = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btn_clearFPOS = new MaterialSkin.Controls.MaterialRaisedButton();
            this.plotView_myScope = new OxyPlot.WindowsForms.PlotView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.tbox_roundLong = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbox_roundY = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.cbox_axis2 = new System.Windows.Forms.ComboBox();
            this.tbox_roundX = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.cbox_axis1 = new System.Windows.Forms.ComboBox();
            this.tbox_xsegHeight = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbox_xsegWidth = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox_XSEG = new System.Windows.Forms.PictureBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tbox_xsegY = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tbox_xsegX = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cbox_xseg = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_xsegStart = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbox_motionprofile.SuspendLayout();
            this.gbox_positon.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_hall.SuspendLayout();
            this.panel_axisState.SuspendLayout();
            this.gbox_fault.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_buffer)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_XSEG)).BeginInit();
            this.SuspendLayout();
            // 
            // tbox_VEL
            // 
            this.tbox_VEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_VEL.Depth = 0;
            this.tbox_VEL.Hint = "   VEL";
            this.tbox_VEL.Location = new System.Drawing.Point(97, 28);
            this.tbox_VEL.MaxLength = 32767;
            this.tbox_VEL.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_VEL.Name = "tbox_VEL";
            this.tbox_VEL.PasswordChar = '\0';
            this.tbox_VEL.SelectedText = "";
            this.tbox_VEL.SelectionLength = 0;
            this.tbox_VEL.SelectionStart = 0;
            this.tbox_VEL.Size = new System.Drawing.Size(109, 23);
            this.tbox_VEL.TabIndex = 0;
            this.tbox_VEL.TabStop = false;
            this.tbox_VEL.UseSystemPasswordChar = false;
            this.tbox_VEL.Enter += new System.EventHandler(this.TextBoxes_Enter);
            this.tbox_VEL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            this.tbox_VEL.Leave += new System.EventHandler(this.TextBoxes_Leave);
            this.tbox_VEL.TextChanged += new System.EventHandler(this.tbox_VEL_TextChanged);
            // 
            // gbox_motionprofile
            // 
            this.gbox_motionprofile.Controls.Add(this.tbox_JERK);
            this.gbox_motionprofile.Controls.Add(this.tbox_KDEC);
            this.gbox_motionprofile.Controls.Add(this.tbox_DEC);
            this.gbox_motionprofile.Controls.Add(this.tbox_ACC);
            this.gbox_motionprofile.Controls.Add(this.tbox_VEL);
            this.gbox_motionprofile.Controls.Add(this.label17);
            this.gbox_motionprofile.Controls.Add(this.label16);
            this.gbox_motionprofile.Controls.Add(this.label15);
            this.gbox_motionprofile.Controls.Add(this.label14);
            this.gbox_motionprofile.Controls.Add(this.label13);
            this.gbox_motionprofile.Location = new System.Drawing.Point(10, 185);
            this.gbox_motionprofile.Name = "gbox_motionprofile";
            this.gbox_motionprofile.Size = new System.Drawing.Size(212, 171);
            this.gbox_motionprofile.TabIndex = 6;
            this.gbox_motionprofile.TabStop = false;
            this.gbox_motionprofile.Text = "运动参数";
            // 
            // tbox_JERK
            // 
            this.tbox_JERK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_JERK.Depth = 0;
            this.tbox_JERK.Hint = "   JERK";
            this.tbox_JERK.Location = new System.Drawing.Point(97, 141);
            this.tbox_JERK.MaxLength = 32767;
            this.tbox_JERK.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_JERK.Name = "tbox_JERK";
            this.tbox_JERK.PasswordChar = '\0';
            this.tbox_JERK.SelectedText = "";
            this.tbox_JERK.SelectionLength = 0;
            this.tbox_JERK.SelectionStart = 0;
            this.tbox_JERK.Size = new System.Drawing.Size(109, 23);
            this.tbox_JERK.TabIndex = 4;
            this.tbox_JERK.TabStop = false;
            this.tbox_JERK.UseSystemPasswordChar = false;
            this.tbox_JERK.Enter += new System.EventHandler(this.TextBoxes_Enter);
            this.tbox_JERK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            this.tbox_JERK.Leave += new System.EventHandler(this.TextBoxes_Leave);
            // 
            // tbox_KDEC
            // 
            this.tbox_KDEC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_KDEC.Depth = 0;
            this.tbox_KDEC.Hint = "   KDEC";
            this.tbox_KDEC.Location = new System.Drawing.Point(97, 109);
            this.tbox_KDEC.MaxLength = 32767;
            this.tbox_KDEC.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_KDEC.Name = "tbox_KDEC";
            this.tbox_KDEC.PasswordChar = '\0';
            this.tbox_KDEC.SelectedText = "";
            this.tbox_KDEC.SelectionLength = 0;
            this.tbox_KDEC.SelectionStart = 0;
            this.tbox_KDEC.Size = new System.Drawing.Size(109, 23);
            this.tbox_KDEC.TabIndex = 3;
            this.tbox_KDEC.TabStop = false;
            this.tbox_KDEC.UseSystemPasswordChar = false;
            this.tbox_KDEC.Enter += new System.EventHandler(this.TextBoxes_Enter);
            this.tbox_KDEC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            this.tbox_KDEC.Leave += new System.EventHandler(this.TextBoxes_Leave);
            // 
            // tbox_DEC
            // 
            this.tbox_DEC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_DEC.Depth = 0;
            this.tbox_DEC.Hint = "   DEC";
            this.tbox_DEC.Location = new System.Drawing.Point(97, 80);
            this.tbox_DEC.MaxLength = 32767;
            this.tbox_DEC.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_DEC.Name = "tbox_DEC";
            this.tbox_DEC.PasswordChar = '\0';
            this.tbox_DEC.SelectedText = "";
            this.tbox_DEC.SelectionLength = 0;
            this.tbox_DEC.SelectionStart = 0;
            this.tbox_DEC.Size = new System.Drawing.Size(109, 23);
            this.tbox_DEC.TabIndex = 2;
            this.tbox_DEC.TabStop = false;
            this.tbox_DEC.UseSystemPasswordChar = false;
            this.tbox_DEC.Enter += new System.EventHandler(this.TextBoxes_Enter);
            this.tbox_DEC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            this.tbox_DEC.Leave += new System.EventHandler(this.TextBoxes_Leave);
            // 
            // tbox_ACC
            // 
            this.tbox_ACC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_ACC.Depth = 0;
            this.tbox_ACC.Hint = "   ACC";
            this.tbox_ACC.Location = new System.Drawing.Point(97, 53);
            this.tbox_ACC.MaxLength = 32767;
            this.tbox_ACC.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_ACC.Name = "tbox_ACC";
            this.tbox_ACC.PasswordChar = '\0';
            this.tbox_ACC.SelectedText = "";
            this.tbox_ACC.SelectionLength = 0;
            this.tbox_ACC.SelectionStart = 0;
            this.tbox_ACC.Size = new System.Drawing.Size(109, 23);
            this.tbox_ACC.TabIndex = 1;
            this.tbox_ACC.TabStop = false;
            this.tbox_ACC.UseSystemPasswordChar = false;
            this.tbox_ACC.Enter += new System.EventHandler(this.TextBoxes_Enter);
            this.tbox_ACC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxes_KeyPress);
            this.tbox_ACC.Leave += new System.EventHandler(this.TextBoxes_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 142);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 12);
            this.label17.TabIndex = 11;
            this.label17.Text = "加加速度(JERK)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 113);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 12);
            this.label16.TabIndex = 10;
            this.label16.Text = "刹车速度(KDEC)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "减速度(DEC)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "加速度(ACC)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "速度(VEL)";
            // 
            // time_Update
            // 
            this.time_Update.Interval = 50;
            this.time_Update.Tick += new System.EventHandler(this.time_Update_Tick);
            // 
            // gbox_positon
            // 
            this.gbox_positon.Controls.Add(this.tbox_PE);
            this.gbox_positon.Controls.Add(this.tbox_FVEL);
            this.gbox_positon.Controls.Add(this.tbox_FPOS);
            this.gbox_positon.Controls.Add(this.tbox_RPOS);
            this.gbox_positon.Controls.Add(this.btn_set0);
            this.gbox_positon.Controls.Add(this.label19);
            this.gbox_positon.Controls.Add(this.label20);
            this.gbox_positon.Controls.Add(this.label21);
            this.gbox_positon.Controls.Add(this.label22);
            this.gbox_positon.Location = new System.Drawing.Point(227, 185);
            this.gbox_positon.Name = "gbox_positon";
            this.gbox_positon.Size = new System.Drawing.Size(212, 171);
            this.gbox_positon.TabIndex = 7;
            this.gbox_positon.TabStop = false;
            this.gbox_positon.Text = "当前位置";
            // 
            // tbox_PE
            // 
            this.tbox_PE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_PE.Depth = 0;
            this.tbox_PE.Hint = "   PE";
            this.tbox_PE.Location = new System.Drawing.Point(105, 109);
            this.tbox_PE.MaxLength = 32767;
            this.tbox_PE.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_PE.Name = "tbox_PE";
            this.tbox_PE.PasswordChar = '\0';
            this.tbox_PE.SelectedText = "";
            this.tbox_PE.SelectionLength = 0;
            this.tbox_PE.SelectionStart = 0;
            this.tbox_PE.Size = new System.Drawing.Size(100, 23);
            this.tbox_PE.TabIndex = 46;
            this.tbox_PE.TabStop = false;
            this.tbox_PE.UseSystemPasswordChar = false;
            // 
            // tbox_FVEL
            // 
            this.tbox_FVEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_FVEL.Depth = 0;
            this.tbox_FVEL.Hint = "   FEVL";
            this.tbox_FVEL.Location = new System.Drawing.Point(105, 80);
            this.tbox_FVEL.MaxLength = 32767;
            this.tbox_FVEL.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_FVEL.Name = "tbox_FVEL";
            this.tbox_FVEL.PasswordChar = '\0';
            this.tbox_FVEL.SelectedText = "";
            this.tbox_FVEL.SelectionLength = 0;
            this.tbox_FVEL.SelectionStart = 0;
            this.tbox_FVEL.Size = new System.Drawing.Size(100, 23);
            this.tbox_FVEL.TabIndex = 45;
            this.tbox_FVEL.TabStop = false;
            this.tbox_FVEL.UseSystemPasswordChar = false;
            // 
            // tbox_FPOS
            // 
            this.tbox_FPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_FPOS.Depth = 0;
            this.tbox_FPOS.Hint = "   FPOS";
            this.tbox_FPOS.Location = new System.Drawing.Point(105, 53);
            this.tbox_FPOS.MaxLength = 32767;
            this.tbox_FPOS.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_FPOS.Name = "tbox_FPOS";
            this.tbox_FPOS.PasswordChar = '\0';
            this.tbox_FPOS.SelectedText = "";
            this.tbox_FPOS.SelectionLength = 0;
            this.tbox_FPOS.SelectionStart = 0;
            this.tbox_FPOS.Size = new System.Drawing.Size(100, 23);
            this.tbox_FPOS.TabIndex = 44;
            this.tbox_FPOS.TabStop = false;
            this.tbox_FPOS.UseSystemPasswordChar = false;
            // 
            // tbox_RPOS
            // 
            this.tbox_RPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_RPOS.Depth = 0;
            this.tbox_RPOS.Hint = "   RPOS";
            this.tbox_RPOS.Location = new System.Drawing.Point(105, 24);
            this.tbox_RPOS.MaxLength = 32767;
            this.tbox_RPOS.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_RPOS.Name = "tbox_RPOS";
            this.tbox_RPOS.PasswordChar = '\0';
            this.tbox_RPOS.SelectedText = "";
            this.tbox_RPOS.SelectionLength = 0;
            this.tbox_RPOS.SelectionStart = 0;
            this.tbox_RPOS.Size = new System.Drawing.Size(100, 23);
            this.tbox_RPOS.TabIndex = 43;
            this.tbox_RPOS.TabStop = false;
            this.tbox_RPOS.UseSystemPasswordChar = false;
            // 
            // btn_set0
            // 
            this.btn_set0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_set0.AutoSize = true;
            this.btn_set0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_set0.Depth = 0;
            this.btn_set0.Icon = null;
            this.btn_set0.Location = new System.Drawing.Point(8, 133);
            this.btn_set0.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_set0.Name = "btn_set0";
            this.btn_set0.Primary = true;
            this.btn_set0.Size = new System.Drawing.Size(134, 36);
            this.btn_set0.TabIndex = 37;
            this.btn_set0.Text = "设置当前位置为0";
            this.btn_set0.UseVisualStyleBackColor = true;
            this.btn_set0.Click += new System.EventHandler(this.btn_set0_BtnClick);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 113);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 12);
            this.label19.TabIndex = 10;
            this.label19.Text = "位置误差(PE)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 12);
            this.label20.TabIndex = 9;
            this.label20.Text = "反馈速度(FVEL)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 55);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 12);
            this.label21.TabIndex = 8;
            this.label21.Text = "反馈位置(FPOS)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 26);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 12);
            this.label22.TabIndex = 7;
            this.label22.Text = "参考位置(RPOS)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "移动中";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(651, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "加速中";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(815, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "到位";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(739, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "使能";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_abposition);
            this.groupBox1.Controls.Add(this.btn_positive);
            this.groupBox1.Controls.Add(this.btn_NEposition);
            this.groupBox1.Controls.Add(this.tbox_position_dis);
            this.groupBox1.Controls.Add(this.tbox_JOGspeed);
            this.groupBox1.Controls.Add(this.btn_JOGRE);
            this.groupBox1.Controls.Add(this.btn_JOGNE);
            this.groupBox1.Controls.Add(this.cbox_useJOG);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(444, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 171);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "运动控制";
            // 
            // btn_abposition
            // 
            this.btn_abposition.AutoSize = true;
            this.btn_abposition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_abposition.Depth = 0;
            this.btn_abposition.Icon = null;
            this.btn_abposition.Location = new System.Drawing.Point(9, 109);
            this.btn_abposition.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_abposition.Name = "btn_abposition";
            this.btn_abposition.Primary = true;
            this.btn_abposition.Size = new System.Drawing.Size(127, 36);
            this.btn_abposition.TabIndex = 46;
            this.btn_abposition.Text = "移动到绝对位置";
            this.btn_abposition.UseVisualStyleBackColor = true;
            this.btn_abposition.Click += new System.EventHandler(this.btn_abposition_Click);
            // 
            // btn_positive
            // 
            this.btn_positive.AutoSize = true;
            this.btn_positive.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_positive.Depth = 0;
            this.btn_positive.Icon = null;
            this.btn_positive.Location = new System.Drawing.Point(121, 138);
            this.btn_positive.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_positive.Name = "btn_positive";
            this.btn_positive.Primary = true;
            this.btn_positive.Size = new System.Drawing.Size(51, 36);
            this.btn_positive.TabIndex = 45;
            this.btn_positive.Text = "正向";
            this.btn_positive.UseVisualStyleBackColor = true;
            this.btn_positive.Click += new System.EventHandler(this.btn_positive_Click);
            // 
            // btn_NEposition
            // 
            this.btn_NEposition.AutoSize = true;
            this.btn_NEposition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_NEposition.Depth = 0;
            this.btn_NEposition.Icon = null;
            this.btn_NEposition.Location = new System.Drawing.Point(9, 138);
            this.btn_NEposition.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_NEposition.Name = "btn_NEposition";
            this.btn_NEposition.Primary = true;
            this.btn_NEposition.Size = new System.Drawing.Size(51, 36);
            this.btn_NEposition.TabIndex = 44;
            this.btn_NEposition.Text = "负向";
            this.btn_NEposition.UseVisualStyleBackColor = true;
            this.btn_NEposition.Click += new System.EventHandler(this.btn_NEposition_Click);
            // 
            // tbox_position_dis
            // 
            this.tbox_position_dis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_position_dis.Depth = 0;
            this.tbox_position_dis.Hint = "  位置\\间隔";
            this.tbox_position_dis.Location = new System.Drawing.Point(107, 93);
            this.tbox_position_dis.MaxLength = 32767;
            this.tbox_position_dis.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_position_dis.Name = "tbox_position_dis";
            this.tbox_position_dis.PasswordChar = '\0';
            this.tbox_position_dis.SelectedText = "";
            this.tbox_position_dis.SelectionLength = 0;
            this.tbox_position_dis.SelectionStart = 0;
            this.tbox_position_dis.Size = new System.Drawing.Size(87, 23);
            this.tbox_position_dis.TabIndex = 43;
            this.tbox_position_dis.TabStop = false;
            this.tbox_position_dis.UseSystemPasswordChar = false;
            // 
            // tbox_JOGspeed
            // 
            this.tbox_JOGspeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_JOGspeed.Depth = 0;
            this.tbox_JOGspeed.Hint = "   JOG速度";
            this.tbox_JOGspeed.Location = new System.Drawing.Point(107, 24);
            this.tbox_JOGspeed.MaxLength = 32767;
            this.tbox_JOGspeed.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_JOGspeed.Name = "tbox_JOGspeed";
            this.tbox_JOGspeed.PasswordChar = '\0';
            this.tbox_JOGspeed.SelectedText = "";
            this.tbox_JOGspeed.SelectionLength = 0;
            this.tbox_JOGspeed.SelectionStart = 0;
            this.tbox_JOGspeed.Size = new System.Drawing.Size(87, 23);
            this.tbox_JOGspeed.TabIndex = 42;
            this.tbox_JOGspeed.TabStop = false;
            this.tbox_JOGspeed.UseSystemPasswordChar = false;
            // 
            // btn_JOGRE
            // 
            this.btn_JOGRE.AutoSize = true;
            this.btn_JOGRE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_JOGRE.Depth = 0;
            this.btn_JOGRE.Icon = null;
            this.btn_JOGRE.Location = new System.Drawing.Point(121, 49);
            this.btn_JOGRE.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_JOGRE.Name = "btn_JOGRE";
            this.btn_JOGRE.Primary = true;
            this.btn_JOGRE.Size = new System.Drawing.Size(51, 36);
            this.btn_JOGRE.TabIndex = 38;
            this.btn_JOGRE.Text = "正向";
            this.btn_JOGRE.UseVisualStyleBackColor = true;
            this.btn_JOGRE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_JOGRE_MouseDown);
            this.btn_JOGRE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_JOGRE_MouseUp);
            // 
            // btn_JOGNE
            // 
            this.btn_JOGNE.AutoSize = true;
            this.btn_JOGNE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_JOGNE.Depth = 0;
            this.btn_JOGNE.Icon = null;
            this.btn_JOGNE.Location = new System.Drawing.Point(9, 49);
            this.btn_JOGNE.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_JOGNE.Name = "btn_JOGNE";
            this.btn_JOGNE.Primary = true;
            this.btn_JOGNE.Size = new System.Drawing.Size(51, 36);
            this.btn_JOGNE.TabIndex = 37;
            this.btn_JOGNE.Text = "负向";
            this.btn_JOGNE.UseVisualStyleBackColor = true;
            this.btn_JOGNE.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_JOGNE_MouseDown);
            this.btn_JOGNE.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_JOGNE_MouseUp);
            // 
            // cbox_useJOG
            // 
            this.cbox_useJOG.AutoSize = true;
            this.cbox_useJOG.Location = new System.Drawing.Point(91, 26);
            this.cbox_useJOG.Name = "cbox_useJOG";
            this.cbox_useJOG.Size = new System.Drawing.Size(15, 14);
            this.cbox_useJOG.TabIndex = 23;
            this.cbox_useJOG.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(2, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(197, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "--------------------------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "位置、间距";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "点动(JOG)速度";
            // 
            // tbox_IP
            // 
            this.tbox_IP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbox_IP.Location = new System.Drawing.Point(82, 462);
            this.tbox_IP.Name = "tbox_IP";
            this.tbox_IP.Size = new System.Drawing.Size(116, 21);
            this.tbox_IP.TabIndex = 19;
            // 
            // rbox_terminal
            // 
            this.rbox_terminal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbox_terminal.Font = new System.Drawing.Font("宋体", 15F);
            this.rbox_terminal.Location = new System.Drawing.Point(10, 401);
            this.rbox_terminal.Name = "rbox_terminal";
            this.rbox_terminal.ReadOnly = true;
            this.rbox_terminal.Size = new System.Drawing.Size(1257, 55);
            this.rbox_terminal.TabIndex = 23;
            this.rbox_terminal.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tbox_Terminal);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Controls.Add(this.btn_clear);
            this.groupBox2.Controls.Add(this.btn_send);
            this.groupBox2.Location = new System.Drawing.Point(10, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1258, 33);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "通讯终端";
            // 
            // tbox_Terminal
            // 
            this.tbox_Terminal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_Terminal.Depth = 0;
            this.tbox_Terminal.Hint = "通讯终端输入框";
            this.tbox_Terminal.Location = new System.Drawing.Point(63, 10);
            this.tbox_Terminal.MaxLength = 32767;
            this.tbox_Terminal.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_Terminal.Name = "tbox_Terminal";
            this.tbox_Terminal.PasswordChar = '\0';
            this.tbox_Terminal.SelectedText = "";
            this.tbox_Terminal.SelectionLength = 0;
            this.tbox_Terminal.SelectionStart = 0;
            this.tbox_Terminal.Size = new System.Drawing.Size(950, 23);
            this.tbox_Terminal.TabIndex = 41;
            this.tbox_Terminal.TabStop = false;
            this.tbox_Terminal.UseSystemPasswordChar = false;
            this.tbox_Terminal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_Terminal_KeyDown);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_save.AutoSize = true;
            this.btn_save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_save.Depth = 0;
            this.btn_save.Icon = null;
            this.btn_save.Location = new System.Drawing.Point(1098, 9);
            this.btn_save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_save.Name = "btn_save";
            this.btn_save.Primary = true;
            this.btn_save.Size = new System.Drawing.Size(51, 36);
            this.btn_save.TabIndex = 40;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_BtnClick);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.AutoSize = true;
            this.btn_clear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_clear.Depth = 0;
            this.btn_clear.Icon = null;
            this.btn_clear.Location = new System.Drawing.Point(1177, 9);
            this.btn_clear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Primary = true;
            this.btn_clear.Size = new System.Drawing.Size(51, 36);
            this.btn_clear.TabIndex = 39;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_BtnClick);
            // 
            // btn_send
            // 
            this.btn_send.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_send.AutoSize = true;
            this.btn_send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_send.Depth = 0;
            this.btn_send.Icon = null;
            this.btn_send.Location = new System.Drawing.Point(1019, 9);
            this.btn_send.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_send.Name = "btn_send";
            this.btn_send.Primary = true;
            this.btn_send.Size = new System.Drawing.Size(51, 36);
            this.btn_send.TabIndex = 38;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_BtnClick);
            // 
            // cbBox_enable
            // 
            this.cbBox_enable.FormattingEnabled = true;
            this.cbBox_enable.Location = new System.Drawing.Point(71, 3);
            this.cbBox_enable.Name = "cbBox_enable";
            this.cbBox_enable.Size = new System.Drawing.Size(121, 20);
            this.cbBox_enable.TabIndex = 30;
            this.cbBox_enable.SelectedIndexChanged += new System.EventHandler(this.cbBox_enable_SelectedIndexChanged_1);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 3);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(73, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "轴选择：";
            // 
            // btn_enable
            // 
            this.btn_enable.AutoSize = true;
            this.btn_enable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_enable.Depth = 0;
            this.btn_enable.Icon = null;
            this.btn_enable.Location = new System.Drawing.Point(208, 0);
            this.btn_enable.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_enable.Name = "btn_enable";
            this.btn_enable.Primary = true;
            this.btn_enable.Size = new System.Drawing.Size(66, 36);
            this.btn_enable.TabIndex = 35;
            this.btn_enable.Text = "上使能";
            this.btn_enable.UseVisualStyleBackColor = true;
            this.btn_enable.Click += new System.EventHandler(this.btn_enable_BtnClick);
            // 
            // btn_disable
            // 
            this.btn_disable.AutoSize = true;
            this.btn_disable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_disable.Depth = 0;
            this.btn_disable.Icon = null;
            this.btn_disable.Location = new System.Drawing.Point(280, 0);
            this.btn_disable.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_disable.Name = "btn_disable";
            this.btn_disable.Primary = true;
            this.btn_disable.Size = new System.Drawing.Size(66, 36);
            this.btn_disable.TabIndex = 36;
            this.btn_disable.Text = "断使能";
            this.btn_disable.UseVisualStyleBackColor = true;
            this.btn_disable.Click += new System.EventHandler(this.btn_disable_BtnClick);
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucBtnExt1.AutoSize = true;
            this.ucBtnExt1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucBtnExt1.Depth = 0;
            this.ucBtnExt1.Icon = null;
            this.ucBtnExt1.Location = new System.Drawing.Point(1214, 466);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ucBtnExt1.MouseState = MaterialSkin.MouseState.HOVER;
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.Primary = false;
            this.ucBtnExt1.Size = new System.Drawing.Size(51, 36);
            this.ucBtnExt1.TabIndex = 37;
            this.ucBtnExt1.Text = "返回";
            this.ucBtnExt1.UseVisualStyleBackColor = true;
            this.ucBtnExt1.Click += new System.EventHandler(this.ucBtnExt1_BtnClick);
            // 
            // rbtn_TcpIp
            // 
            this.rbtn_TcpIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_TcpIp.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_TcpIp.Depth = 0;
            this.rbtn_TcpIp.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn_TcpIp.Location = new System.Drawing.Point(10, 462);
            this.rbtn_TcpIp.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn_TcpIp.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn_TcpIp.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn_TcpIp.Name = "rbtn_TcpIp";
            this.rbtn_TcpIp.Ripple = true;
            this.rbtn_TcpIp.Size = new System.Drawing.Size(69, 20);
            this.rbtn_TcpIp.TabIndex = 38;
            this.rbtn_TcpIp.TabStop = true;
            this.rbtn_TcpIp.Text = "TCP/IP";
            this.rbtn_TcpIp.UseVisualStyleBackColor = false;
            // 
            // rbtn_sim
            // 
            this.rbtn_sim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtn_sim.Depth = 0;
            this.rbtn_sim.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtn_sim.Location = new System.Drawing.Point(10, 485);
            this.rbtn_sim.Margin = new System.Windows.Forms.Padding(0);
            this.rbtn_sim.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtn_sim.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtn_sim.Name = "rbtn_sim";
            this.rbtn_sim.Ripple = true;
            this.rbtn_sim.Size = new System.Drawing.Size(69, 20);
            this.rbtn_sim.TabIndex = 39;
            this.rbtn_sim.TabStop = true;
            this.rbtn_sim.Text = "仿真";
            this.rbtn_sim.UseVisualStyleBackColor = true;
            // 
            // Enable_baidu
            // 
            this.Enable_baidu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Enable_baidu.Depth = 0;
            this.Enable_baidu.Font = new System.Drawing.Font("Roboto", 10F);
            this.Enable_baidu.Location = new System.Drawing.Point(81, 485);
            this.Enable_baidu.Margin = new System.Windows.Forms.Padding(0);
            this.Enable_baidu.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Enable_baidu.MouseState = MaterialSkin.MouseState.HOVER;
            this.Enable_baidu.Name = "Enable_baidu";
            this.Enable_baidu.Ripple = true;
            this.Enable_baidu.Size = new System.Drawing.Size(120, 20);
            this.Enable_baidu.TabIndex = 40;
            this.Enable_baidu.Text = "启用百度翻译";
            this.Enable_baidu.UseVisualStyleBackColor = true;
            // 
            // btn_STOP
            // 
            this.btn_STOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_STOP.AutoSize = true;
            this.btn_STOP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_STOP.Depth = 0;
            this.btn_STOP.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_STOP.Icon = null;
            this.btn_STOP.Location = new System.Drawing.Point(955, 466);
            this.btn_STOP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_STOP.Name = "btn_STOP";
            this.btn_STOP.Primary = true;
            this.btn_STOP.Size = new System.Drawing.Size(81, 36);
            this.btn_STOP.TabIndex = 41;
            this.btn_STOP.Text = "停止运动";
            this.btn_STOP.UseVisualStyleBackColor = true;
            this.btn_STOP.Click += new System.EventHandler(this.btn_STOP_Click);
            // 
            // btn_clearFault
            // 
            this.btn_clearFault.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clearFault.AutoSize = true;
            this.btn_clearFault.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_clearFault.Depth = 0;
            this.btn_clearFault.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_clearFault.Icon = null;
            this.btn_clearFault.Location = new System.Drawing.Point(1042, 466);
            this.btn_clearFault.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_clearFault.Name = "btn_clearFault";
            this.btn_clearFault.Primary = true;
            this.btn_clearFault.Size = new System.Drawing.Size(81, 36);
            this.btn_clearFault.TabIndex = 42;
            this.btn_clearFault.Text = "清除报错";
            this.btn_clearFault.UseVisualStyleBackColor = true;
            this.btn_clearFault.Click += new System.EventHandler(this.btn_clearFault_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.tbox_delayTime);
            this.groupBox3.Controls.Add(this.btn_readB);
            this.groupBox3.Controls.Add(this.btn_readA);
            this.groupBox3.Controls.Add(this.tbox_BPosition);
            this.groupBox3.Controls.Add(this.btn_statABMotion);
            this.groupBox3.Controls.Add(this.tbox_APosition);
            this.groupBox3.Location = new System.Drawing.Point(650, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 171);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "往返运动";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(7, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 17);
            this.label18.TabIndex = 53;
            this.label18.Text = "延时";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(6, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "位置2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 51;
            this.label1.Text = "位置1";
            // 
            // tbox_delayTime
            // 
            this.tbox_delayTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_delayTime.Depth = 0;
            this.tbox_delayTime.Hint = "延时时间";
            this.tbox_delayTime.Location = new System.Drawing.Point(60, 79);
            this.tbox_delayTime.MaxLength = 32767;
            this.tbox_delayTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_delayTime.Name = "tbox_delayTime";
            this.tbox_delayTime.PasswordChar = '\0';
            this.tbox_delayTime.SelectedText = "";
            this.tbox_delayTime.SelectionLength = 0;
            this.tbox_delayTime.SelectionStart = 0;
            this.tbox_delayTime.Size = new System.Drawing.Size(87, 23);
            this.tbox_delayTime.TabIndex = 50;
            this.tbox_delayTime.TabStop = false;
            this.tbox_delayTime.UseSystemPasswordChar = false;
            // 
            // btn_readB
            // 
            this.btn_readB.AutoSize = true;
            this.btn_readB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_readB.Location = new System.Drawing.Point(153, 47);
            this.btn_readB.Name = "btn_readB";
            this.btn_readB.Size = new System.Drawing.Size(41, 20);
            this.btn_readB.TabIndex = 49;
            this.btn_readB.Text = "读取";
            this.btn_readB.Click += new System.EventHandler(this.btn_readB_Click);
            // 
            // btn_readA
            // 
            this.btn_readA.AutoSize = true;
            this.btn_readA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_readA.Location = new System.Drawing.Point(153, 17);
            this.btn_readA.Name = "btn_readA";
            this.btn_readA.Size = new System.Drawing.Size(41, 20);
            this.btn_readA.TabIndex = 48;
            this.btn_readA.Text = "读取";
            this.btn_readA.Click += new System.EventHandler(this.btn_readA_Click);
            // 
            // tbox_BPosition
            // 
            this.tbox_BPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_BPosition.Depth = 0;
            this.tbox_BPosition.Hint = "B点 ";
            this.tbox_BPosition.Location = new System.Drawing.Point(60, 50);
            this.tbox_BPosition.MaxLength = 32767;
            this.tbox_BPosition.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_BPosition.Name = "tbox_BPosition";
            this.tbox_BPosition.PasswordChar = '\0';
            this.tbox_BPosition.SelectedText = "";
            this.tbox_BPosition.SelectionLength = 0;
            this.tbox_BPosition.SelectionStart = 0;
            this.tbox_BPosition.Size = new System.Drawing.Size(87, 23);
            this.tbox_BPosition.TabIndex = 47;
            this.tbox_BPosition.TabStop = false;
            this.tbox_BPosition.UseSystemPasswordChar = false;
            // 
            // btn_statABMotion
            // 
            this.btn_statABMotion.AutoSize = true;
            this.btn_statABMotion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_statABMotion.Depth = 0;
            this.btn_statABMotion.Icon = null;
            this.btn_statABMotion.Location = new System.Drawing.Point(6, 121);
            this.btn_statABMotion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_statABMotion.Name = "btn_statABMotion";
            this.btn_statABMotion.Primary = true;
            this.btn_statABMotion.Size = new System.Drawing.Size(51, 36);
            this.btn_statABMotion.TabIndex = 44;
            this.btn_statABMotion.Text = "运动";
            this.btn_statABMotion.UseVisualStyleBackColor = true;
            this.btn_statABMotion.Click += new System.EventHandler(this.btn_statABMotion_Click);
            // 
            // tbox_APosition
            // 
            this.tbox_APosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_APosition.Depth = 0;
            this.tbox_APosition.Hint = "A点";
            this.tbox_APosition.Location = new System.Drawing.Point(60, 21);
            this.tbox_APosition.MaxLength = 32767;
            this.tbox_APosition.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_APosition.Name = "tbox_APosition";
            this.tbox_APosition.PasswordChar = '\0';
            this.tbox_APosition.SelectedText = "";
            this.tbox_APosition.SelectionLength = 0;
            this.tbox_APosition.SelectionStart = 0;
            this.tbox_APosition.Size = new System.Drawing.Size(87, 23);
            this.tbox_APosition.TabIndex = 42;
            this.tbox_APosition.TabStop = false;
            this.tbox_APosition.UseSystemPasswordChar = false;
            // 
            // LED_enable
            // 
            this.LED_enable.Image = global::预调试助手.Properties.Resources.Off;
            this.LED_enable.Location = new System.Drawing.Point(769, 12);
            this.LED_enable.Name = "LED_enable";
            this.LED_enable.Size = new System.Drawing.Size(19, 17);
            this.LED_enable.TabIndex = 15;
            // 
            // LED_inposition
            // 
            this.LED_inposition.Image = global::预调试助手.Properties.Resources.Off;
            this.LED_inposition.Location = new System.Drawing.Point(849, 12);
            this.LED_inposition.Name = "LED_inposition";
            this.LED_inposition.Size = new System.Drawing.Size(19, 17);
            this.LED_inposition.TabIndex = 14;
            // 
            // LED_ACCing
            // 
            this.LED_ACCing.Image = global::预调试助手.Properties.Resources.Off;
            this.LED_ACCing.Location = new System.Drawing.Point(693, 12);
            this.LED_ACCing.Name = "LED_ACCing";
            this.LED_ACCing.Size = new System.Drawing.Size(19, 17);
            this.LED_ACCing.TabIndex = 13;
            // 
            // LED_moveing
            // 
            this.LED_moveing.Image = global::预调试助手.Properties.Resources.Off;
            this.LED_moveing.Location = new System.Drawing.Point(609, 12);
            this.LED_moveing.Name = "LED_moveing";
            this.LED_moveing.Size = new System.Drawing.Size(19, 17);
            this.LED_moveing.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Depth = 0;
            this.tabControl1.Location = new System.Drawing.Point(1, 66);
            this.tabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1281, 534);
            this.tabControl1.TabIndex = 44;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_connect);
            this.tabPage1.Controls.Add(this.groupBox_hall);
            this.tabPage1.Controls.Add(this.btn_disableALL);
            this.tabPage1.Controls.Add(this.btn_enableALL);
            this.tabPage1.Controls.Add(this.gbox_motionprofile);
            this.tabPage1.Controls.Add(this.gbox_positon);
            this.tabPage1.Controls.Add(this.cbBox_enable);
            this.tabPage1.Controls.Add(this.btn_clearFault);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.btn_STOP);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.ucBtnExt1);
            this.tabPage1.Controls.Add(this.Enable_baidu);
            this.tabPage1.Controls.Add(this.btn_enable);
            this.tabPage1.Controls.Add(this.rbtn_sim);
            this.tabPage1.Controls.Add(this.btn_disable);
            this.tabPage1.Controls.Add(this.rbtn_TcpIp);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbox_IP);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.rbox_terminal);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.LED_moveing);
            this.tabPage1.Controls.Add(this.LED_ACCing);
            this.tabPage1.Controls.Add(this.LED_inposition);
            this.tabPage1.Controls.Add(this.LED_enable);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel_axisState);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1273, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基础调试";
            // 
            // btn_connect
            // 
            this.btn_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_connect.AutoSize = true;
            this.btn_connect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_connect.Depth = 0;
            this.btn_connect.Icon = null;
            this.btn_connect.Location = new System.Drawing.Point(1129, 466);
            this.btn_connect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Primary = true;
            this.btn_connect.Size = new System.Drawing.Size(51, 36);
            this.btn_connect.TabIndex = 3;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_BtnClick);
            // 
            // groupBox_hall
            // 
            this.groupBox_hall.Controls.Add(this.richTextBox_hall);
            this.groupBox_hall.Controls.Add(this.cbox_hall);
            this.groupBox_hall.Controls.Add(this.panel_hall);
            this.groupBox_hall.Location = new System.Drawing.Point(856, 185);
            this.groupBox_hall.Name = "groupBox_hall";
            this.groupBox_hall.Size = new System.Drawing.Size(412, 171);
            this.groupBox_hall.TabIndex = 46;
            this.groupBox_hall.TabStop = false;
            this.groupBox_hall.Text = "霍尔状态";
            // 
            // richTextBox_hall
            // 
            this.richTextBox_hall.Location = new System.Drawing.Point(175, 67);
            this.richTextBox_hall.Name = "richTextBox_hall";
            this.richTextBox_hall.Size = new System.Drawing.Size(221, 96);
            this.richTextBox_hall.TabIndex = 2;
            this.richTextBox_hall.Text = "";
            // 
            // cbox_hall
            // 
            this.cbox_hall.AutoSize = true;
            this.cbox_hall.Depth = 0;
            this.cbox_hall.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbox_hall.Location = new System.Drawing.Point(172, 17);
            this.cbox_hall.Margin = new System.Windows.Forms.Padding(0);
            this.cbox_hall.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbox_hall.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbox_hall.Name = "cbox_hall";
            this.cbox_hall.Ripple = true;
            this.cbox_hall.Size = new System.Drawing.Size(121, 30);
            this.cbox_hall.TabIndex = 1;
            this.cbox_hall.Text = "开启霍尔检测";
            this.cbox_hall.UseVisualStyleBackColor = true;
            this.cbox_hall.CheckedChanged += new System.EventHandler(this.cbox_hall_CheckedChanged);
            // 
            // panel_hall
            // 
            this.panel_hall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_hall.Location = new System.Drawing.Point(3, 17);
            this.panel_hall.Name = "panel_hall";
            this.panel_hall.Size = new System.Drawing.Size(166, 148);
            this.panel_hall.TabIndex = 0;
            // 
            // btn_disableALL
            // 
            this.btn_disableALL.AutoSize = true;
            this.btn_disableALL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_disableALL.Depth = 0;
            this.btn_disableALL.Icon = null;
            this.btn_disableALL.Location = new System.Drawing.Point(454, 0);
            this.btn_disableALL.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_disableALL.Name = "btn_disableALL";
            this.btn_disableALL.Primary = true;
            this.btn_disableALL.Size = new System.Drawing.Size(96, 36);
            this.btn_disableALL.TabIndex = 45;
            this.btn_disableALL.Text = "全部断使能";
            this.btn_disableALL.UseVisualStyleBackColor = true;
            this.btn_disableALL.Click += new System.EventHandler(this.btn_disableALL_Click);
            // 
            // btn_enableALL
            // 
            this.btn_enableALL.AutoSize = true;
            this.btn_enableALL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_enableALL.Depth = 0;
            this.btn_enableALL.Icon = null;
            this.btn_enableALL.Location = new System.Drawing.Point(352, 0);
            this.btn_enableALL.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_enableALL.Name = "btn_enableALL";
            this.btn_enableALL.Primary = true;
            this.btn_enableALL.Size = new System.Drawing.Size(96, 36);
            this.btn_enableALL.TabIndex = 44;
            this.btn_enableALL.Text = "全部上使能";
            this.btn_enableALL.UseVisualStyleBackColor = true;
            this.btn_enableALL.Click += new System.EventHandler(this.btn_enableALL_Click);
            // 
            // panel_axisState
            // 
            this.panel_axisState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_axisState.Controls.Add(this.gbox_fault);
            this.panel_axisState.Location = new System.Drawing.Point(10, 30);
            this.panel_axisState.Name = "panel_axisState";
            this.panel_axisState.Size = new System.Drawing.Size(1258, 148);
            this.panel_axisState.TabIndex = 46;
            // 
            // gbox_fault
            // 
            this.gbox_fault.AutoSize = true;
            this.gbox_fault.Controls.Add(this.panel_fault);
            this.gbox_fault.Controls.Add(this.label23);
            this.gbox_fault.Controls.Add(this.label4);
            this.gbox_fault.Controls.Add(this.label3);
            this.gbox_fault.Controls.Add(this.label2);
            this.gbox_fault.Font = new System.Drawing.Font("宋体", 9F);
            this.gbox_fault.Location = new System.Drawing.Point(1, 7);
            this.gbox_fault.Name = "gbox_fault";
            this.gbox_fault.Size = new System.Drawing.Size(1257, 158);
            this.gbox_fault.TabIndex = 6;
            this.gbox_fault.TabStop = false;
            this.gbox_fault.Text = "轴状态";
            // 
            // panel_fault
            // 
            this.panel_fault.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_fault.AutoScroll = true;
            this.panel_fault.Location = new System.Drawing.Point(52, 20);
            this.panel_fault.Name = "panel_fault";
            this.panel_fault.Size = new System.Drawing.Size(1189, 118);
            this.panel_fault.TabIndex = 9;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(5, 103);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 12);
            this.label23.TabIndex = 8;
            this.label23.Text = "使能：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(5, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "右限位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(5, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "左限位：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "轴号：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_stopCol);
            this.tabPage2.Controls.Add(this.materialLabel8);
            this.tabPage2.Controls.Add(this.textBox_yVar);
            this.tabPage2.Controls.Add(this.materialLabel7);
            this.tabPage2.Controls.Add(this.textBox_xVar);
            this.tabPage2.Controls.Add(this.checkBox_bufferRunClearScope);
            this.tabPage2.Controls.Add(this.numericUpDown_buffer);
            this.tabPage2.Controls.Add(this.btn_col);
            this.tabPage2.Controls.Add(this.btn_clearFPOS);
            this.tabPage2.Controls.Add(this.plotView_myScope);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.btn_xsegStart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1273, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XSEG";
            // 
            // btn_stopCol
            // 
            this.btn_stopCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stopCol.AutoSize = true;
            this.btn_stopCol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_stopCol.Depth = 0;
            this.btn_stopCol.Icon = null;
            this.btn_stopCol.Location = new System.Drawing.Point(1102, 468);
            this.btn_stopCol.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_stopCol.Name = "btn_stopCol";
            this.btn_stopCol.Primary = true;
            this.btn_stopCol.Size = new System.Drawing.Size(51, 36);
            this.btn_stopCol.TabIndex = 57;
            this.btn_stopCol.Text = "停止";
            this.btn_stopCol.UseVisualStyleBackColor = true;
            this.btn_stopCol.Click += new System.EventHandler(this.btn_stopCol_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(924, 480);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(34, 19);
            this.materialLabel8.TabIndex = 56;
            this.materialLabel8.Text = "Y轴";
            // 
            // textBox_yVar
            // 
            this.textBox_yVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_yVar.Depth = 0;
            this.textBox_yVar.Hint = "";
            this.textBox_yVar.Location = new System.Drawing.Point(964, 476);
            this.textBox_yVar.MaxLength = 32767;
            this.textBox_yVar.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_yVar.Name = "textBox_yVar";
            this.textBox_yVar.PasswordChar = '\0';
            this.textBox_yVar.SelectedText = "";
            this.textBox_yVar.SelectionLength = 0;
            this.textBox_yVar.SelectionStart = 0;
            this.textBox_yVar.Size = new System.Drawing.Size(75, 23);
            this.textBox_yVar.TabIndex = 55;
            this.textBox_yVar.TabStop = false;
            this.textBox_yVar.Text = "FPOS1";
            this.textBox_yVar.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(784, 480);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(34, 19);
            this.materialLabel7.TabIndex = 54;
            this.materialLabel7.Text = "X轴";
            // 
            // textBox_xVar
            // 
            this.textBox_xVar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_xVar.Depth = 0;
            this.textBox_xVar.Hint = "";
            this.textBox_xVar.Location = new System.Drawing.Point(824, 476);
            this.textBox_xVar.MaxLength = 32767;
            this.textBox_xVar.MouseState = MaterialSkin.MouseState.HOVER;
            this.textBox_xVar.Name = "textBox_xVar";
            this.textBox_xVar.PasswordChar = '\0';
            this.textBox_xVar.SelectedText = "";
            this.textBox_xVar.SelectionLength = 0;
            this.textBox_xVar.SelectionStart = 0;
            this.textBox_xVar.Size = new System.Drawing.Size(75, 23);
            this.textBox_xVar.TabIndex = 52;
            this.textBox_xVar.TabStop = false;
            this.textBox_xVar.Text = "FPOS0";
            this.textBox_xVar.UseSystemPasswordChar = false;
            // 
            // checkBox_bufferRunClearScope
            // 
            this.checkBox_bufferRunClearScope.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox_bufferRunClearScope.AutoSize = true;
            this.checkBox_bufferRunClearScope.Depth = 0;
            this.checkBox_bufferRunClearScope.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBox_bufferRunClearScope.Location = new System.Drawing.Point(496, 472);
            this.checkBox_bufferRunClearScope.Margin = new System.Windows.Forms.Padding(0);
            this.checkBox_bufferRunClearScope.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBox_bufferRunClearScope.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBox_bufferRunClearScope.Name = "checkBox_bufferRunClearScope";
            this.checkBox_bufferRunClearScope.Ripple = true;
            this.checkBox_bufferRunClearScope.Size = new System.Drawing.Size(233, 30);
            this.checkBox_bufferRunClearScope.TabIndex = 51;
            this.checkBox_bufferRunClearScope.Text = "buffer启动后先自动清除示波器";
            this.checkBox_bufferRunClearScope.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_buffer
            // 
            this.numericUpDown_buffer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDown_buffer.Location = new System.Drawing.Point(424, 478);
            this.numericUpDown_buffer.Name = "numericUpDown_buffer";
            this.numericUpDown_buffer.Size = new System.Drawing.Size(69, 21);
            this.numericUpDown_buffer.TabIndex = 50;
            // 
            // btn_col
            // 
            this.btn_col.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_col.AutoSize = true;
            this.btn_col.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_col.Depth = 0;
            this.btn_col.Icon = null;
            this.btn_col.Location = new System.Drawing.Point(1045, 468);
            this.btn_col.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_col.Name = "btn_col";
            this.btn_col.Primary = true;
            this.btn_col.Size = new System.Drawing.Size(51, 36);
            this.btn_col.TabIndex = 49;
            this.btn_col.Text = "采集";
            this.btn_col.UseVisualStyleBackColor = true;
            this.btn_col.Click += new System.EventHandler(this.btn_col_Click);
            // 
            // btn_clearFPOS
            // 
            this.btn_clearFPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clearFPOS.AutoSize = true;
            this.btn_clearFPOS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_clearFPOS.Depth = 0;
            this.btn_clearFPOS.Icon = null;
            this.btn_clearFPOS.Location = new System.Drawing.Point(1159, 468);
            this.btn_clearFPOS.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_clearFPOS.Name = "btn_clearFPOS";
            this.btn_clearFPOS.Primary = true;
            this.btn_clearFPOS.Size = new System.Drawing.Size(51, 36);
            this.btn_clearFPOS.TabIndex = 48;
            this.btn_clearFPOS.Text = "清除";
            this.btn_clearFPOS.UseVisualStyleBackColor = true;
            this.btn_clearFPOS.Click += new System.EventHandler(this.btn_clearFPOS_Click);
            // 
            // plotView_myScope
            // 
            this.plotView_myScope.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plotView_myScope.Location = new System.Drawing.Point(424, 6);
            this.plotView_myScope.Name = "plotView_myScope";
            this.plotView_myScope.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView_myScope.Size = new System.Drawing.Size(843, 457);
            this.plotView_myScope.TabIndex = 47;
            this.plotView_myScope.Text = "plotView1";
            this.plotView_myScope.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView_myScope.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView_myScope.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.materialLabel13);
            this.groupBox4.Controls.Add(this.tbox_roundLong);
            this.groupBox4.Controls.Add(this.tbox_roundY);
            this.groupBox4.Controls.Add(this.cbox_axis2);
            this.groupBox4.Controls.Add(this.tbox_roundX);
            this.groupBox4.Controls.Add(this.materialLabel12);
            this.groupBox4.Controls.Add(this.cbox_axis1);
            this.groupBox4.Controls.Add(this.tbox_xsegHeight);
            this.groupBox4.Controls.Add(this.tbox_xsegWidth);
            this.groupBox4.Controls.Add(this.materialLabel6);
            this.groupBox4.Controls.Add(this.pictureBox_XSEG);
            this.groupBox4.Controls.Add(this.materialLabel5);
            this.groupBox4.Controls.Add(this.materialLabel4);
            this.groupBox4.Controls.Add(this.tbox_xsegY);
            this.groupBox4.Controls.Add(this.tbox_xsegX);
            this.groupBox4.Controls.Add(this.materialLabel3);
            this.groupBox4.Controls.Add(this.cbox_xseg);
            this.groupBox4.Controls.Add(this.materialLabel2);
            this.groupBox4.Location = new System.Drawing.Point(7, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(411, 499);
            this.groupBox4.TabIndex = 46;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "轨迹绘制";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(209, 45);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(34, 19);
            this.materialLabel13.TabIndex = 55;
            this.materialLabel13.Text = "Y轴";
            // 
            // tbox_roundLong
            // 
            this.tbox_roundLong.Depth = 0;
            this.tbox_roundLong.Hint = "半径";
            this.tbox_roundLong.Location = new System.Drawing.Point(285, 111);
            this.tbox_roundLong.MaxLength = 32767;
            this.tbox_roundLong.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_roundLong.Name = "tbox_roundLong";
            this.tbox_roundLong.PasswordChar = '\0';
            this.tbox_roundLong.SelectedText = "";
            this.tbox_roundLong.SelectionLength = 0;
            this.tbox_roundLong.SelectionStart = 0;
            this.tbox_roundLong.Size = new System.Drawing.Size(55, 23);
            this.tbox_roundLong.TabIndex = 51;
            this.tbox_roundLong.TabStop = false;
            this.tbox_roundLong.UseSystemPasswordChar = false;
            // 
            // tbox_roundY
            // 
            this.tbox_roundY.Depth = 0;
            this.tbox_roundY.Hint = "Y";
            this.tbox_roundY.Location = new System.Drawing.Point(352, 81);
            this.tbox_roundY.MaxLength = 32767;
            this.tbox_roundY.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_roundY.Name = "tbox_roundY";
            this.tbox_roundY.PasswordChar = '\0';
            this.tbox_roundY.SelectedText = "";
            this.tbox_roundY.SelectionLength = 0;
            this.tbox_roundY.SelectionStart = 0;
            this.tbox_roundY.Size = new System.Drawing.Size(55, 23);
            this.tbox_roundY.TabIndex = 50;
            this.tbox_roundY.TabStop = false;
            this.tbox_roundY.UseSystemPasswordChar = false;
            // 
            // cbox_axis2
            // 
            this.cbox_axis2.FormattingEnabled = true;
            this.cbox_axis2.Location = new System.Drawing.Point(248, 44);
            this.cbox_axis2.Name = "cbox_axis2";
            this.cbox_axis2.Size = new System.Drawing.Size(121, 20);
            this.cbox_axis2.TabIndex = 54;
            // 
            // tbox_roundX
            // 
            this.tbox_roundX.Depth = 0;
            this.tbox_roundX.Hint = "X";
            this.tbox_roundX.Location = new System.Drawing.Point(285, 81);
            this.tbox_roundX.MaxLength = 32767;
            this.tbox_roundX.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_roundX.Name = "tbox_roundX";
            this.tbox_roundX.PasswordChar = '\0';
            this.tbox_roundX.SelectedText = "";
            this.tbox_roundX.SelectionLength = 0;
            this.tbox_roundX.SelectionStart = 0;
            this.tbox_roundX.Size = new System.Drawing.Size(55, 23);
            this.tbox_roundX.TabIndex = 49;
            this.tbox_roundX.TabStop = false;
            this.tbox_roundX.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(6, 45);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(34, 19);
            this.materialLabel12.TabIndex = 53;
            this.materialLabel12.Text = "X轴";
            // 
            // cbox_axis1
            // 
            this.cbox_axis1.FormattingEnabled = true;
            this.cbox_axis1.Location = new System.Drawing.Point(78, 42);
            this.cbox_axis1.Name = "cbox_axis1";
            this.cbox_axis1.Size = new System.Drawing.Size(121, 20);
            this.cbox_axis1.TabIndex = 52;
            // 
            // tbox_xsegHeight
            // 
            this.tbox_xsegHeight.Depth = 0;
            this.tbox_xsegHeight.Hint = "宽";
            this.tbox_xsegHeight.Location = new System.Drawing.Point(149, 108);
            this.tbox_xsegHeight.MaxLength = 32767;
            this.tbox_xsegHeight.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_xsegHeight.Name = "tbox_xsegHeight";
            this.tbox_xsegHeight.PasswordChar = '\0';
            this.tbox_xsegHeight.SelectedText = "";
            this.tbox_xsegHeight.SelectionLength = 0;
            this.tbox_xsegHeight.SelectionStart = 0;
            this.tbox_xsegHeight.Size = new System.Drawing.Size(55, 23);
            this.tbox_xsegHeight.TabIndex = 48;
            this.tbox_xsegHeight.TabStop = false;
            this.tbox_xsegHeight.UseSystemPasswordChar = false;
            // 
            // tbox_xsegWidth
            // 
            this.tbox_xsegWidth.Depth = 0;
            this.tbox_xsegWidth.Hint = "长";
            this.tbox_xsegWidth.Location = new System.Drawing.Point(82, 108);
            this.tbox_xsegWidth.MaxLength = 32767;
            this.tbox_xsegWidth.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_xsegWidth.Name = "tbox_xsegWidth";
            this.tbox_xsegWidth.PasswordChar = '\0';
            this.tbox_xsegWidth.SelectedText = "";
            this.tbox_xsegWidth.SelectionLength = 0;
            this.tbox_xsegWidth.SelectionStart = 0;
            this.tbox_xsegWidth.Size = new System.Drawing.Size(55, 23);
            this.tbox_xsegWidth.TabIndex = 47;
            this.tbox_xsegWidth.TabStop = false;
            this.tbox_xsegWidth.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(6, 113);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(41, 19);
            this.materialLabel6.TabIndex = 46;
            this.materialLabel6.Text = "长宽";
            // 
            // pictureBox_XSEG
            // 
            this.pictureBox_XSEG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_XSEG.Location = new System.Drawing.Point(7, 162);
            this.pictureBox_XSEG.Name = "pictureBox_XSEG";
            this.pictureBox_XSEG.Size = new System.Drawing.Size(398, 331);
            this.pictureBox_XSEG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_XSEG.TabIndex = 7;
            this.pictureBox_XSEG.TabStop = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(209, 112);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(41, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "半径";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(209, 84);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(41, 19);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "圆心";
            // 
            // tbox_xsegY
            // 
            this.tbox_xsegY.Depth = 0;
            this.tbox_xsegY.Hint = "Y";
            this.tbox_xsegY.Location = new System.Drawing.Point(149, 78);
            this.tbox_xsegY.MaxLength = 32767;
            this.tbox_xsegY.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_xsegY.Name = "tbox_xsegY";
            this.tbox_xsegY.PasswordChar = '\0';
            this.tbox_xsegY.SelectedText = "";
            this.tbox_xsegY.SelectionLength = 0;
            this.tbox_xsegY.SelectionStart = 0;
            this.tbox_xsegY.Size = new System.Drawing.Size(55, 23);
            this.tbox_xsegY.TabIndex = 4;
            this.tbox_xsegY.TabStop = false;
            this.tbox_xsegY.UseSystemPasswordChar = false;
            // 
            // tbox_xsegX
            // 
            this.tbox_xsegX.Depth = 0;
            this.tbox_xsegX.Hint = "X";
            this.tbox_xsegX.Location = new System.Drawing.Point(82, 78);
            this.tbox_xsegX.MaxLength = 32767;
            this.tbox_xsegX.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbox_xsegX.Name = "tbox_xsegX";
            this.tbox_xsegX.PasswordChar = '\0';
            this.tbox_xsegX.SelectedText = "";
            this.tbox_xsegX.SelectionLength = 0;
            this.tbox_xsegX.SelectionStart = 0;
            this.tbox_xsegX.Size = new System.Drawing.Size(55, 23);
            this.tbox_xsegX.TabIndex = 3;
            this.tbox_xsegX.TabStop = false;
            this.tbox_xsegX.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 85);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(73, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "矩形起点";
            // 
            // cbox_xseg
            // 
            this.cbox_xseg.FormattingEnabled = true;
            this.cbox_xseg.Items.AddRange(new object[] {
            "圆",
            "矩形"});
            this.cbox_xseg.Location = new System.Drawing.Point(78, 16);
            this.cbox_xseg.Name = "cbox_xseg";
            this.cbox_xseg.Size = new System.Drawing.Size(121, 20);
            this.cbox_xseg.TabIndex = 1;
            this.cbox_xseg.SelectedIndexChanged += new System.EventHandler(this.cbox_xseg_SelectedIndexChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 17);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(63, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "圆/矩形";
            // 
            // btn_xsegStart
            // 
            this.btn_xsegStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_xsegStart.AutoSize = true;
            this.btn_xsegStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_xsegStart.Depth = 0;
            this.btn_xsegStart.Icon = null;
            this.btn_xsegStart.Location = new System.Drawing.Point(1216, 468);
            this.btn_xsegStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_xsegStart.Name = "btn_xsegStart";
            this.btn_xsegStart.Primary = true;
            this.btn_xsegStart.Size = new System.Drawing.Size(51, 36);
            this.btn_xsegStart.TabIndex = 45;
            this.btn_xsegStart.Text = "运动";
            this.btn_xsegStart.UseVisualStyleBackColor = true;
            this.btn_xsegStart.Click += new System.EventHandler(this.btn_xsegStart_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.tabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(120, 37);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(1162, 23);
            this.materialTabSelector1.TabIndex = 45;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // winMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1285, 600);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "winMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "预调试助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.winMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.winMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbox_motionprofile.ResumeLayout(false);
            this.gbox_motionprofile.PerformLayout();
            this.gbox_positon.ResumeLayout(false);
            this.gbox_positon.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox_hall.ResumeLayout(false);
            this.groupBox_hall.PerformLayout();
            this.panel_axisState.ResumeLayout(false);
            this.panel_axisState.PerformLayout();
            this.gbox_fault.ResumeLayout(false);
            this.gbox_fault.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_buffer)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_XSEG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbox_motionprofile;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer time_Update;
        private System.Windows.Forms.GroupBox gbox_positon;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LED_moveing;
        private System.Windows.Forms.Label LED_ACCing;
        private System.Windows.Forms.Label LED_inposition;
        private System.Windows.Forms.Label LED_enable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox cbox_useJOG;
        private System.Windows.Forms.TextBox tbox_IP;
        private System.Windows.Forms.RichTextBox rbox_terminal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.ComboBox cbBox_enable;
        private MaterialSkin.Controls.MaterialRaisedButton btn_set0;
        private MaterialSkin.Controls.MaterialRaisedButton btn_JOGRE;
        private MaterialSkin.Controls.MaterialRaisedButton btn_JOGNE;
        private MaterialSkin.Controls.MaterialRaisedButton btn_save;
        private MaterialSkin.Controls.MaterialRaisedButton btn_clear;
        private MaterialSkin.Controls.MaterialRaisedButton btn_send;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton btn_enable;
        private MaterialSkin.Controls.MaterialRaisedButton btn_disable;
        private MaterialSkin.Controls.MaterialFlatButton ucBtnExt1;
        private MaterialSkin.Controls.MaterialRadioButton rbtn_TcpIp;
        private MaterialSkin.Controls.MaterialRadioButton rbtn_sim;
        private MaterialSkin.Controls.MaterialCheckBox Enable_baidu;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_Terminal;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_position_dis;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_JOGspeed;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_PE;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_FVEL;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_FPOS;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_RPOS;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_JERK;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_KDEC;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_DEC;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_ACC;
        private MaterialSkin.Controls.MaterialRaisedButton btn_abposition;
        private MaterialSkin.Controls.MaterialRaisedButton btn_positive;
        private MaterialSkin.Controls.MaterialRaisedButton btn_NEposition;
        private MaterialSkin.Controls.MaterialRaisedButton btn_STOP;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_VEL;
        private MaterialSkin.Controls.MaterialRaisedButton btn_clearFault;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_BPosition;
        private MaterialSkin.Controls.MaterialRaisedButton btn_statABMotion;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_APosition;
        private System.Windows.Forms.Label btn_readB;
        private System.Windows.Forms.Label btn_readA;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_delayTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.ComboBox cbox_axis1;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.ComboBox cbox_axis2;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_roundLong;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_roundY;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_roundX;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_xsegHeight;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_xsegWidth;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialRaisedButton btn_xsegStart;
        private System.Windows.Forms.PictureBox pictureBox_XSEG;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_xsegY;
        private MaterialSkin.Controls.MaterialSingleLineTextField tbox_xsegX;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox cbox_xseg;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialRaisedButton btn_col;
        private MaterialSkin.Controls.MaterialRaisedButton btn_clearFPOS;
        private OxyPlot.WindowsForms.PlotView plotView_myScope;
        private System.Windows.Forms.NumericUpDown numericUpDown_buffer;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_yVar;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField textBox_xVar;
        private MaterialSkin.Controls.MaterialCheckBox checkBox_bufferRunClearScope;
        private MaterialSkin.Controls.MaterialRaisedButton btn_stopCol;
        private MaterialSkin.Controls.MaterialRaisedButton btn_disableALL;
        private MaterialSkin.Controls.MaterialRaisedButton btn_enableALL;
        private System.Windows.Forms.Panel panel_axisState;
        private System.Windows.Forms.GroupBox gbox_fault;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_hall;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_hall;
        private MaterialSkin.Controls.MaterialCheckBox cbox_hall;
        private System.Windows.Forms.RichTextBox richTextBox_hall;
        private MaterialSkin.Controls.MaterialRaisedButton btn_connect;
        private System.Windows.Forms.Panel panel_fault;
    }
}

