namespace 电子族谱管理系统
{
    partial class 查询管理界面
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(查询管理界面));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sex1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.textinput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spouse_name = new System.Windows.Forms.TextBox();
            this.spouse_state = new System.Windows.Forms.ComboBox();
            this.textaddress = new System.Windows.Forms.TextBox();
            this.textplace = new System.Windows.Forms.TextBox();
            this.dateTimedeath = new System.Windows.Forms.DateTimePicker();
            this.dateTimebirth = new System.Windows.Forms.DateTimePicker();
            this.text世代 = new System.Windows.Forms.TextBox();
            this.text姓名 = new System.Windows.Forms.TextBox();
            this.text父亲ID = new System.Windows.Forms.TextBox();
            this.text族谱ID = new System.Windows.Forms.TextBox();
            this.text成员ID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Father = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.ItemSize = new System.Drawing.Size(76, 22);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 339);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.sex1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.search);
            this.tabPage1.Controls.Add(this.textinput);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.spouse_name);
            this.tabPage1.Controls.Add(this.spouse_state);
            this.tabPage1.Controls.Add(this.textaddress);
            this.tabPage1.Controls.Add(this.textplace);
            this.tabPage1.Controls.Add(this.dateTimedeath);
            this.tabPage1.Controls.Add(this.dateTimebirth);
            this.tabPage1.Controls.Add(this.text世代);
            this.tabPage1.Controls.Add(this.text姓名);
            this.tabPage1.Controls.Add(this.text父亲ID);
            this.tabPage1.Controls.Add(this.text族谱ID);
            this.tabPage1.Controls.Add(this.text成员ID);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "查询成员";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sex1
            // 
            this.sex1.FormattingEnabled = true;
            this.sex1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sex1.Location = new System.Drawing.Point(135, 242);
            this.sex1.Margin = new System.Windows.Forms.Padding(2);
            this.sex1.Name = "sex1";
            this.sex1.Size = new System.Drawing.Size(114, 24);
            this.sex1.TabIndex = 120;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(433, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 25);
            this.button2.TabIndex = 119;
            this.button2.Text = "退  出";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Transparent;
            this.search.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.search.Location = new System.Drawing.Point(308, 6);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(80, 25);
            this.search.TabIndex = 119;
            this.search.Text = "查  询";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textinput
            // 
            this.textinput.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textinput.Location = new System.Drawing.Point(175, 7);
            this.textinput.Margin = new System.Windows.Forms.Padding(2);
            this.textinput.Name = "textinput";
            this.textinput.Size = new System.Drawing.Size(114, 25);
            this.textinput.TabIndex = 118;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(39, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 117;
            this.label2.Text = "输入成员ID：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 116;
            this.label1.Text = "查询成员结果如下：";
            // 
            // spouse_name
            // 
            this.spouse_name.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.spouse_name.Location = new System.Drawing.Point(377, 278);
            this.spouse_name.Margin = new System.Windows.Forms.Padding(2);
            this.spouse_name.Name = "spouse_name";
            this.spouse_name.Size = new System.Drawing.Size(134, 25);
            this.spouse_name.TabIndex = 115;
            this.spouse_name.TextChanged += new System.EventHandler(this.textspouse_TextChanged);
            // 
            // spouse_state
            // 
            this.spouse_state.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.spouse_state.FormattingEnabled = true;
            this.spouse_state.Items.AddRange(new object[] {
            "已婚",
            "未婚",
            "再婚",
            "丧偶",
            "离异",
            "其他"});
            this.spouse_state.Location = new System.Drawing.Point(377, 243);
            this.spouse_state.Margin = new System.Windows.Forms.Padding(2);
            this.spouse_state.Name = "spouse_state";
            this.spouse_state.Size = new System.Drawing.Size(134, 23);
            this.spouse_state.TabIndex = 114;
            // 
            // textaddress
            // 
            this.textaddress.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textaddress.Location = new System.Drawing.Point(379, 201);
            this.textaddress.Margin = new System.Windows.Forms.Padding(2);
            this.textaddress.Name = "textaddress";
            this.textaddress.Size = new System.Drawing.Size(132, 25);
            this.textaddress.TabIndex = 113;
            // 
            // textplace
            // 
            this.textplace.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textplace.Location = new System.Drawing.Point(377, 167);
            this.textplace.Margin = new System.Windows.Forms.Padding(2);
            this.textplace.Name = "textplace";
            this.textplace.Size = new System.Drawing.Size(134, 25);
            this.textplace.TabIndex = 112;
            // 
            // dateTimedeath
            // 
            this.dateTimedeath.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimedeath.Location = new System.Drawing.Point(377, 130);
            this.dateTimedeath.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimedeath.Name = "dateTimedeath";
            this.dateTimedeath.Size = new System.Drawing.Size(135, 25);
            this.dateTimedeath.TabIndex = 111;
            // 
            // dateTimebirth
            // 
            this.dateTimebirth.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimebirth.Location = new System.Drawing.Point(378, 97);
            this.dateTimebirth.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimebirth.Name = "dateTimebirth";
            this.dateTimebirth.Size = new System.Drawing.Size(135, 25);
            this.dateTimebirth.TabIndex = 110;
            // 
            // text世代
            // 
            this.text世代.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text世代.Location = new System.Drawing.Point(135, 275);
            this.text世代.Margin = new System.Windows.Forms.Padding(2);
            this.text世代.Name = "text世代";
            this.text世代.Size = new System.Drawing.Size(114, 25);
            this.text世代.TabIndex = 109;
            // 
            // text姓名
            // 
            this.text姓名.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text姓名.Location = new System.Drawing.Point(135, 205);
            this.text姓名.Margin = new System.Windows.Forms.Padding(2);
            this.text姓名.Name = "text姓名";
            this.text姓名.Size = new System.Drawing.Size(114, 25);
            this.text姓名.TabIndex = 106;
            this.text姓名.TextChanged += new System.EventHandler(this.text姓名_TextChanged);
            // 
            // text父亲ID
            // 
            this.text父亲ID.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text父亲ID.Location = new System.Drawing.Point(135, 171);
            this.text父亲ID.Margin = new System.Windows.Forms.Padding(2);
            this.text父亲ID.Name = "text父亲ID";
            this.text父亲ID.Size = new System.Drawing.Size(114, 25);
            this.text父亲ID.TabIndex = 105;
            // 
            // text族谱ID
            // 
            this.text族谱ID.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text族谱ID.Location = new System.Drawing.Point(135, 134);
            this.text族谱ID.Margin = new System.Windows.Forms.Padding(2);
            this.text族谱ID.Name = "text族谱ID";
            this.text族谱ID.Size = new System.Drawing.Size(114, 25);
            this.text族谱ID.TabIndex = 104;
            // 
            // text成员ID
            // 
            this.text成员ID.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text成员ID.Location = new System.Drawing.Point(135, 99);
            this.text成员ID.Margin = new System.Windows.Forms.Padding(2);
            this.text成员ID.Name = "text成员ID";
            this.text成员ID.Size = new System.Drawing.Size(114, 25);
            this.text成员ID.TabIndex = 103;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(286, 209);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 15);
            this.label13.TabIndex = 102;
            this.label13.Text = "居 住 地：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(287, 245);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 101;
            this.label14.Text = "配偶状态：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(60, 282);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 15);
            this.label15.TabIndex = 100;
            this.label15.Text = "世  代：";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(287, 174);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(83, 15);
            this.label16.TabIndex = 99;
            this.label16.Text = "出 生 地：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(60, 141);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 15);
            this.label17.TabIndex = 98;
            this.label17.Text = "族谱ID：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(60, 178);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 15);
            this.label18.TabIndex = 97;
            this.label18.Text = "父亲ID：";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(287, 278);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 15);
            this.label19.TabIndex = 96;
            this.label19.Text = "配偶姓名：";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(287, 137);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 15);
            this.label20.TabIndex = 95;
            this.label20.Text = "死亡日期：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(287, 102);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 15);
            this.label21.TabIndex = 94;
            this.label21.Text = "出生日期：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(60, 246);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(68, 15);
            this.label22.TabIndex = 93;
            this.label22.Text = "性  别：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(60, 213);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 15);
            this.label23.TabIndex = 92;
            this.label23.Text = "姓  名：";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(60, 106);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 15);
            this.label24.TabIndex = 91;
            this.label24.Text = "成员ID：";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.Father);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "查询后代";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(427, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 25);
            this.button3.TabIndex = 124;
            this.button3.Text = "退  出";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(294, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 123;
            this.button1.Text = "查  询";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Father
            // 
            this.Father.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Father.Location = new System.Drawing.Point(152, 8);
            this.Father.Margin = new System.Windows.Forms.Padding(2);
            this.Father.Name = "Father";
            this.Father.Size = new System.Drawing.Size(114, 25);
            this.Father.TabIndex = 122;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(17, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 19);
            this.label3.TabIndex = 121;
            this.label3.Text = "输入成员ID：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(534, 223);
            this.dataGridView1.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(15, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 19);
            this.label4.TabIndex = 119;
            this.label4.Text = "查询后代结果如下：";
            // 
            // 查询管理界面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(561, 337);
            this.Controls.Add(this.tabControl1);
            this.Name = "查询管理界面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询管理";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox spouse_name;
        private System.Windows.Forms.ComboBox spouse_state;
        private System.Windows.Forms.TextBox textaddress;
        private System.Windows.Forms.TextBox textplace;
        private System.Windows.Forms.DateTimePicker dateTimedeath;
        private System.Windows.Forms.DateTimePicker dateTimebirth;
        private System.Windows.Forms.TextBox text世代;
        private System.Windows.Forms.TextBox text姓名;
        private System.Windows.Forms.TextBox text父亲ID;
        private System.Windows.Forms.TextBox text族谱ID;
        private System.Windows.Forms.TextBox text成员ID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox sex1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Father;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}