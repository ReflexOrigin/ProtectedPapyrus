namespace ProjectPapyrus
{
    partial class Menu
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
                connection.Close();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.TopBar = new System.Windows.Forms.Panel();
            this.pnlChoice = new System.Windows.Forms.Panel();
            this.btnChoices = new System.Windows.Forms.Button();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.newBar = new System.Windows.Forms.Panel();
            this.New = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.pnlHomeLogo = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.viewBar = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.Choose = new System.Windows.Forms.Button();
            this.btnByKey = new System.Windows.Forms.Button();
            this.sidebar1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCalendarManual = new System.Windows.Forms.Panel();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.sidebar = new System.Windows.Forms.Panel();
            this.pnlLogoPage = new System.Windows.Forms.Panel();
            this.panelNew = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoteText = new System.Windows.Forms.RichTextBox();
            this.pnlNoteAction = new System.Windows.Forms.Panel();
            this.NewAttach = new System.Windows.Forms.Button();
            this.outKey = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.viewBarTransition = new System.Windows.Forms.Timer(this.components);
            this.panelView = new System.Windows.Forms.Panel();
            this.pnlGridView = new System.Windows.Forms.Panel();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.NoteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.NoteContent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileContent = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pnlViewAction = new System.Windows.Forms.Panel();
            this.Continue = new System.Windows.Forms.Button();
            this.keyStatus = new System.Windows.Forms.Label();
            this.pnllineUnderInputKey = new System.Windows.Forms.Panel();
            this.inputKey = new System.Windows.Forms.TextBox();
            this.pnlOkView = new System.Windows.Forms.Panel();
            this.pnlRichbox = new System.Windows.Forms.Panel();
            this.AtcName = new System.Windows.Forms.ListBox();
            this.ViewRichBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addAtch = new System.Windows.Forms.Button();
            this.ViewEncryptKey = new System.Windows.Forms.TextBox();
            this.ViewCopy = new System.Windows.Forms.Button();
            this.ViewCancel = new System.Windows.Forms.Button();
            this.viewSave = new System.Windows.Forms.Button();
            this.notesWAttachBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TopBar.SuspendLayout();
            this.pnlChoice.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.newBar.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlHomeLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.viewBar.SuspendLayout();
            this.sidebar1.SuspendLayout();
            this.pnlCalendarManual.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.pnlLogoPage.SuspendLayout();
            this.panelNew.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlNoteAction.SuspendLayout();
            this.panelView.SuspendLayout();
            this.pnlGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.pnlViewAction.SuspendLayout();
            this.pnlOkView.SuspendLayout();
            this.pnlRichbox.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesWAttachBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.Black;
            this.TopBar.Controls.Add(this.pnlChoice);
            this.TopBar.Controls.Add(this.controlPanel);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(1, 1);
            this.TopBar.Name = "TopBar";
            this.TopBar.Padding = new System.Windows.Forms.Padding(5);
            this.TopBar.Size = new System.Drawing.Size(1258, 40);
            this.TopBar.TabIndex = 2;
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.TopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // pnlChoice
            // 
            this.pnlChoice.Controls.Add(this.btnChoices);
            this.pnlChoice.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlChoice.Location = new System.Drawing.Point(5, 5);
            this.pnlChoice.Name = "pnlChoice";
            this.pnlChoice.Size = new System.Drawing.Size(40, 30);
            this.pnlChoice.TabIndex = 6;
            // 
            // btnChoices
            // 
            this.btnChoices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChoices.BackgroundImage")));
            this.btnChoices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnChoices.FlatAppearance.BorderSize = 0;
            this.btnChoices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoices.Location = new System.Drawing.Point(11, 3);
            this.btnChoices.Name = "btnChoices";
            this.btnChoices.Size = new System.Drawing.Size(22, 22);
            this.btnChoices.TabIndex = 5;
            this.btnChoices.UseVisualStyleBackColor = true;
            this.btnChoices.Click += new System.EventHandler(this.btnChoices_Click);
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.btnMaximize);
            this.controlPanel.Controls.Add(this.btnMinimize);
            this.controlPanel.Controls.Add(this.btnExitApp);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlPanel.Location = new System.Drawing.Point(1162, 5);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(91, 30);
            this.controlPanel.TabIndex = 3;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
            this.btnMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(31, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 24);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(3, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(22, 22);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExitApp.BackgroundImage")));
            this.btnExitApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExitApp.FlatAppearance.BorderSize = 0;
            this.btnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApp.Location = new System.Drawing.Point(62, 3);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(22, 22);
            this.btnExitApp.TabIndex = 0;
            this.btnExitApp.UseVisualStyleBackColor = true;
            this.btnExitApp.Click += new System.EventHandler(this.button3_Click);
            // 
            // newBar
            // 
            this.newBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.newBar.Controls.Add(this.New);
            this.newBar.Location = new System.Drawing.Point(3, 60);
            this.newBar.Name = "newBar";
            this.newBar.Size = new System.Drawing.Size(259, 51);
            this.newBar.TabIndex = 0;
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.New.FlatAppearance.BorderSize = 0;
            this.New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.ForeColor = System.Drawing.Color.White;
            this.New.Image = ((System.Drawing.Image)(resources.GetObject("New.Image")));
            this.New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.New.Location = new System.Drawing.Point(-4, 0);
            this.New.Margin = new System.Windows.Forms.Padding(0);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(253, 51);
            this.New.TabIndex = 0;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.Home);
            this.pnlHome.Location = new System.Drawing.Point(3, 3);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(259, 51);
            this.pnlHome.TabIndex = 2;
            // 
            // Home
            // 
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(-3, 0);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(250, 54);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // pnlHomeLogo
            // 
            this.pnlHomeLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlHomeLogo.Controls.Add(this.Logo);
            this.pnlHomeLogo.Controls.Add(this.label4);
            this.pnlHomeLogo.Location = new System.Drawing.Point(301, 218);
            this.pnlHomeLogo.Name = "pnlHomeLogo";
            this.pnlHomeLogo.Size = new System.Drawing.Size(602, 159);
            this.pnlHomeLogo.TabIndex = 7;
            // 
            // Logo
            // 
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(3, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(174, 153);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 3;
            this.Logo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(60)))), ((int)(((byte)(226)))));
            this.label4.Location = new System.Drawing.Point(183, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(408, 107);
            this.label4.TabIndex = 1;
            this.label4.Text = "PAPYRUS";
            // 
            // viewBar
            // 
            this.viewBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.viewBar.Controls.Add(this.btnView);
            this.viewBar.Controls.Add(this.Choose);
            this.viewBar.Controls.Add(this.btnByKey);
            this.viewBar.Location = new System.Drawing.Point(3, 117);
            this.viewBar.Name = "viewBar";
            this.viewBar.Size = new System.Drawing.Size(250, 51);
            this.viewBar.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(-5, 0);
            this.btnView.Margin = new System.Windows.Forms.Padding(0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(253, 51);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.button7_Click);
            // 
            // Choose
            // 
            this.Choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Choose.FlatAppearance.BorderSize = 0;
            this.Choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose.ForeColor = System.Drawing.Color.White;
            this.Choose.Image = ((System.Drawing.Image)(resources.GetObject("Choose.Image")));
            this.Choose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Choose.Location = new System.Drawing.Point(-3, 102);
            this.Choose.Margin = new System.Windows.Forms.Padding(0);
            this.Choose.Name = "Choose";
            this.Choose.Size = new System.Drawing.Size(253, 52);
            this.Choose.TabIndex = 2;
            this.Choose.Text = "Choose";
            this.Choose.UseVisualStyleBackColor = false;
            this.Choose.Click += new System.EventHandler(this.Choose_Click);
            // 
            // btnByKey
            // 
            this.btnByKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnByKey.FlatAppearance.BorderSize = 0;
            this.btnByKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnByKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByKey.ForeColor = System.Drawing.Color.White;
            this.btnByKey.Image = ((System.Drawing.Image)(resources.GetObject("btnByKey.Image")));
            this.btnByKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnByKey.Location = new System.Drawing.Point(-1, 50);
            this.btnByKey.Margin = new System.Windows.Forms.Padding(0);
            this.btnByKey.Name = "btnByKey";
            this.btnByKey.Size = new System.Drawing.Size(253, 52);
            this.btnByKey.TabIndex = 1;
            this.btnByKey.Text = "Have key?";
            this.btnByKey.UseVisualStyleBackColor = false;
            this.btnByKey.Click += new System.EventHandler(this.btnByKey_Click);
            // 
            // sidebar1
            // 
            this.sidebar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.sidebar1.Controls.Add(this.pnlHome);
            this.sidebar1.Controls.Add(this.newBar);
            this.sidebar1.Controls.Add(this.viewBar);
            this.sidebar1.Controls.Add(this.pnlCalendarManual);
            this.sidebar1.Controls.Add(this.btnLogout);
            this.sidebar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidebar1.Location = new System.Drawing.Point(0, 0);
            this.sidebar1.Name = "sidebar1";
            this.sidebar1.Size = new System.Drawing.Size(50, 608);
            this.sidebar1.TabIndex = 8;
            // 
            // pnlCalendarManual
            // 
            this.pnlCalendarManual.Controls.Add(this.btnCalendar);
            this.pnlCalendarManual.Controls.Add(this.btnAbout);
            this.pnlCalendarManual.Location = new System.Drawing.Point(3, 174);
            this.pnlCalendarManual.Name = "pnlCalendarManual";
            this.pnlCalendarManual.Size = new System.Drawing.Size(247, 102);
            this.pnlCalendarManual.TabIndex = 7;
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalendar.ForeColor = System.Drawing.Color.White;
            this.btnCalendar.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendar.Image")));
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCalendar.Location = new System.Drawing.Point(-3, 0);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(253, 51);
            this.btnCalendar.TabIndex = 4;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(-5, 53);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(253, 51);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 279);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(253, 51);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.sidebar1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(1, 41);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(50, 608);
            this.sidebar.TabIndex = 9;
            // 
            // pnlLogoPage
            // 
            this.pnlLogoPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(13)))), ((int)(((byte)(65)))));
            this.pnlLogoPage.Controls.Add(this.pnlHomeLogo);
            this.pnlLogoPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogoPage.Location = new System.Drawing.Point(51, 41);
            this.pnlLogoPage.Name = "pnlLogoPage";
            this.pnlLogoPage.Size = new System.Drawing.Size(1208, 608);
            this.pnlLogoPage.TabIndex = 10;
            // 
            // panelNew
            // 
            this.panelNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelNew.Controls.Add(this.panel1);
            this.panelNew.Controls.Add(this.pnlNoteAction);
            this.panelNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNew.Location = new System.Drawing.Point(51, 41);
            this.panelNew.Name = "panelNew";
            this.panelNew.Size = new System.Drawing.Size(1208, 608);
            this.panelNew.TabIndex = 8;
            this.panelNew.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NoteText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 508);
            this.panel1.TabIndex = 2;
            // 
            // NoteText
            // 
            this.NoteText.BackColor = System.Drawing.Color.Silver;
            this.NoteText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NoteText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NoteText.Location = new System.Drawing.Point(0, 0);
            this.NoteText.Name = "NoteText";
            this.NoteText.Size = new System.Drawing.Size(1208, 508);
            this.NoteText.TabIndex = 0;
            this.NoteText.Text = "";
            // 
            // pnlNoteAction
            // 
            this.pnlNoteAction.Controls.Add(this.NewAttach);
            this.pnlNoteAction.Controls.Add(this.outKey);
            this.pnlNoteAction.Controls.Add(this.btnCopy);
            this.pnlNoteAction.Controls.Add(this.cancel);
            this.pnlNoteAction.Controls.Add(this.save);
            this.pnlNoteAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNoteAction.Location = new System.Drawing.Point(0, 508);
            this.pnlNoteAction.Name = "pnlNoteAction";
            this.pnlNoteAction.Size = new System.Drawing.Size(1208, 100);
            this.pnlNoteAction.TabIndex = 1;
            // 
            // NewAttach
            // 
            this.NewAttach.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NewAttach.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NewAttach.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NewAttach.FlatAppearance.BorderSize = 2;
            this.NewAttach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.NewAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewAttach.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewAttach.ForeColor = System.Drawing.Color.Lime;
            this.NewAttach.Location = new System.Drawing.Point(424, 3);
            this.NewAttach.Name = "NewAttach";
            this.NewAttach.Size = new System.Drawing.Size(31, 31);
            this.NewAttach.TabIndex = 29;
            this.NewAttach.Text = "+";
            this.NewAttach.UseVisualStyleBackColor = true;
            this.NewAttach.Click += new System.EventHandler(this.NewAttach_Click_2);
            // 
            // outKey
            // 
            this.outKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.outKey.BackColor = System.Drawing.Color.Black;
            this.outKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outKey.Enabled = false;
            this.outKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outKey.ForeColor = System.Drawing.Color.White;
            this.outKey.Location = new System.Drawing.Point(424, 39);
            this.outKey.Name = "outKey";
            this.outKey.Size = new System.Drawing.Size(367, 22);
            this.outKey.TabIndex = 27;
            this.outKey.Visible = false;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCopy.FlatAppearance.BorderSize = 2;
            this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.Lime;
            this.btnCopy.Location = new System.Drawing.Point(424, 66);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(368, 31);
            this.btnCopy.TabIndex = 26;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Visible = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cancel.FlatAppearance.BorderSize = 2;
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.ForeColor = System.Drawing.Color.Red;
            this.cancel.Location = new System.Drawing.Point(629, 3);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(163, 31);
            this.cancel.TabIndex = 23;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.save.FlatAppearance.BorderSize = 2;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.Lime;
            this.save.Location = new System.Drawing.Point(461, 3);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(163, 31);
            this.save.TabIndex = 22;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.verifybtn_Click);
            // 
            // viewBarTransition
            // 
            this.viewBarTransition.Interval = 10;
            this.viewBarTransition.Tick += new System.EventHandler(this.viewBarTransition_Tick);
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelView.Controls.Add(this.pnlGridView);
            this.panelView.Controls.Add(this.pnlViewAction);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(51, 41);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(1208, 608);
            this.panelView.TabIndex = 11;
            this.panelView.Visible = false;
            // 
            // pnlGridView
            // 
            this.pnlGridView.Controls.Add(this.GridView);
            this.pnlGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGridView.Location = new System.Drawing.Point(0, 0);
            this.pnlGridView.Name = "pnlGridView";
            this.pnlGridView.Size = new System.Drawing.Size(1208, 477);
            this.pnlGridView.TabIndex = 0;
            // 
            // GridView
            // 
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoteID,
            this.Image,
            this.NoteContent,
            this.CreatedDate,
            this.FileName,
            this.FileContent});
            this.GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridView.Location = new System.Drawing.Point(0, 0);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            this.GridView.Size = new System.Drawing.Size(1208, 477);
            this.GridView.TabIndex = 3;
            // 
            // NoteID
            // 
            this.NoteID.HeaderText = "NoteID";
            this.NoteID.Name = "NoteID";
            this.NoteID.ReadOnly = true;
            this.NoteID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NoteID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Image
            // 
            this.Image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image.HeaderText = "Image";
            this.Image.Image = ((System.Drawing.Image)(resources.GetObject("Image.Image")));
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            // 
            // NoteContent
            // 
            this.NoteContent.HeaderText = "Notes";
            this.NoteContent.Name = "NoteContent";
            this.NoteContent.ReadOnly = true;
            // 
            // CreatedDate
            // 
            this.CreatedDate.HeaderText = "Date";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // FileName
            // 
            this.FileName.HeaderText = "File Name";
            this.FileName.Name = "FileName";
            this.FileName.ReadOnly = true;
            // 
            // FileContent
            // 
            this.FileContent.HeaderText = "Attachment";
            this.FileContent.Name = "FileContent";
            this.FileContent.ReadOnly = true;
            // 
            // pnlViewAction
            // 
            this.pnlViewAction.Controls.Add(this.Continue);
            this.pnlViewAction.Controls.Add(this.keyStatus);
            this.pnlViewAction.Controls.Add(this.pnllineUnderInputKey);
            this.pnlViewAction.Controls.Add(this.inputKey);
            this.pnlViewAction.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlViewAction.Location = new System.Drawing.Point(0, 477);
            this.pnlViewAction.Name = "pnlViewAction";
            this.pnlViewAction.Size = new System.Drawing.Size(1208, 131);
            this.pnlViewAction.TabIndex = 23;
            this.pnlViewAction.Visible = false;
            // 
            // Continue
            // 
            this.Continue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Continue.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Continue.FlatAppearance.BorderSize = 2;
            this.Continue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Continue.ForeColor = System.Drawing.Color.Lime;
            this.Continue.Location = new System.Drawing.Point(503, 46);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(214, 42);
            this.Continue.TabIndex = 24;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // keyStatus
            // 
            this.keyStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.keyStatus.AutoSize = true;
            this.keyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyStatus.ForeColor = System.Drawing.Color.Red;
            this.keyStatus.Location = new System.Drawing.Point(525, 92);
            this.keyStatus.Name = "keyStatus";
            this.keyStatus.Size = new System.Drawing.Size(171, 16);
            this.keyStatus.TabIndex = 25;
            this.keyStatus.Text = "Password did not match";
            this.keyStatus.Visible = false;
            // 
            // pnllineUnderInputKey
            // 
            this.pnllineUnderInputKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnllineUnderInputKey.BackColor = System.Drawing.Color.White;
            this.pnllineUnderInputKey.Location = new System.Drawing.Point(431, 39);
            this.pnllineUnderInputKey.Name = "pnllineUnderInputKey";
            this.pnllineUnderInputKey.Size = new System.Drawing.Size(359, 1);
            this.pnllineUnderInputKey.TabIndex = 7;
            // 
            // inputKey
            // 
            this.inputKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inputKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.inputKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputKey.ForeColor = System.Drawing.Color.Gray;
            this.inputKey.Location = new System.Drawing.Point(431, 18);
            this.inputKey.Name = "inputKey";
            this.inputKey.Size = new System.Drawing.Size(359, 19);
            this.inputKey.TabIndex = 6;
            this.inputKey.Text = "Enter Decryption Key";
            this.inputKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputKey.Click += new System.EventHandler(this.inputKey_Click);
            // 
            // pnlOkView
            // 
            this.pnlOkView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlOkView.Controls.Add(this.pnlRichbox);
            this.pnlOkView.Controls.Add(this.panel3);
            this.pnlOkView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOkView.Location = new System.Drawing.Point(51, 41);
            this.pnlOkView.Name = "pnlOkView";
            this.pnlOkView.Size = new System.Drawing.Size(1208, 608);
            this.pnlOkView.TabIndex = 12;
            this.pnlOkView.Visible = false;
            // 
            // pnlRichbox
            // 
            this.pnlRichbox.Controls.Add(this.AtcName);
            this.pnlRichbox.Controls.Add(this.ViewRichBox);
            this.pnlRichbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRichbox.Location = new System.Drawing.Point(0, 0);
            this.pnlRichbox.Name = "pnlRichbox";
            this.pnlRichbox.Size = new System.Drawing.Size(1208, 465);
            this.pnlRichbox.TabIndex = 6;
            // 
            // AtcName
            // 
            this.AtcName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AtcName.BackColor = System.Drawing.Color.Silver;
            this.AtcName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtcName.ForeColor = System.Drawing.Color.Red;
            this.AtcName.FormattingEnabled = true;
            this.AtcName.ItemHeight = 16;
            this.AtcName.Location = new System.Drawing.Point(0, 429);
            this.AtcName.Name = "AtcName";
            this.AtcName.Size = new System.Drawing.Size(1205, 36);
            this.AtcName.Sorted = true;
            this.AtcName.TabIndex = 31;
            this.AtcName.TabStop = false;
            this.AtcName.SelectedIndexChanged += new System.EventHandler(this.AtcBox_SelectedIndexChanged);
            // 
            // ViewRichBox
            // 
            this.ViewRichBox.BackColor = System.Drawing.Color.Silver;
            this.ViewRichBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewRichBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewRichBox.Location = new System.Drawing.Point(0, 0);
            this.ViewRichBox.Name = "ViewRichBox";
            this.ViewRichBox.Size = new System.Drawing.Size(1208, 465);
            this.ViewRichBox.TabIndex = 4;
            this.ViewRichBox.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addAtch);
            this.panel3.Controls.Add(this.ViewEncryptKey);
            this.panel3.Controls.Add(this.ViewCopy);
            this.panel3.Controls.Add(this.ViewCancel);
            this.panel3.Controls.Add(this.viewSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 465);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1208, 143);
            this.panel3.TabIndex = 5;
            // 
            // addAtch
            // 
            this.addAtch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addAtch.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.addAtch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addAtch.FlatAppearance.BorderSize = 2;
            this.addAtch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addAtch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAtch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAtch.ForeColor = System.Drawing.Color.Lime;
            this.addAtch.Location = new System.Drawing.Point(411, 24);
            this.addAtch.Name = "addAtch";
            this.addAtch.Size = new System.Drawing.Size(31, 31);
            this.addAtch.TabIndex = 29;
            this.addAtch.Text = "+";
            this.addAtch.UseVisualStyleBackColor = true;
            // 
            // ViewEncryptKey
            // 
            this.ViewEncryptKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewEncryptKey.BackColor = System.Drawing.Color.Black;
            this.ViewEncryptKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewEncryptKey.Enabled = false;
            this.ViewEncryptKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEncryptKey.ForeColor = System.Drawing.Color.White;
            this.ViewEncryptKey.Location = new System.Drawing.Point(411, 60);
            this.ViewEncryptKey.Name = "ViewEncryptKey";
            this.ViewEncryptKey.Size = new System.Drawing.Size(367, 22);
            this.ViewEncryptKey.TabIndex = 27;
            this.ViewEncryptKey.Visible = false;
            // 
            // ViewCopy
            // 
            this.ViewCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewCopy.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ViewCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ViewCopy.FlatAppearance.BorderSize = 2;
            this.ViewCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ViewCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCopy.ForeColor = System.Drawing.Color.Lime;
            this.ViewCopy.Location = new System.Drawing.Point(411, 89);
            this.ViewCopy.Name = "ViewCopy";
            this.ViewCopy.Size = new System.Drawing.Size(368, 31);
            this.ViewCopy.TabIndex = 26;
            this.ViewCopy.Text = "Copy";
            this.ViewCopy.UseVisualStyleBackColor = true;
            this.ViewCopy.Visible = false;
            this.ViewCopy.Click += new System.EventHandler(this.ViewCopy_Click);
            // 
            // ViewCancel
            // 
            this.ViewCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ViewCancel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ViewCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ViewCancel.FlatAppearance.BorderSize = 2;
            this.ViewCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ViewCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewCancel.ForeColor = System.Drawing.Color.Red;
            this.ViewCancel.Location = new System.Drawing.Point(616, 24);
            this.ViewCancel.Name = "ViewCancel";
            this.ViewCancel.Size = new System.Drawing.Size(163, 31);
            this.ViewCancel.TabIndex = 23;
            this.ViewCancel.Text = "Cancel";
            this.ViewCancel.UseVisualStyleBackColor = true;
            // 
            // viewSave
            // 
            this.viewSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewSave.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.viewSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.viewSave.FlatAppearance.BorderSize = 2;
            this.viewSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.viewSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSave.ForeColor = System.Drawing.Color.Lime;
            this.viewSave.Location = new System.Drawing.Point(448, 24);
            this.viewSave.Name = "viewSave";
            this.viewSave.Size = new System.Drawing.Size(163, 31);
            this.viewSave.TabIndex = 22;
            this.viewSave.Text = "Save";
            this.viewSave.UseVisualStyleBackColor = true;
            this.viewSave.Click += new System.EventHandler(this.viewSave_Click);
            // 
            // notesWAttachBindingSource1
            // 
            this.notesWAttachBindingSource1.DataMember = "NotesWAttach";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(60)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1260, 650);
            this.Controls.Add(this.pnlOkView);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelNew);
            this.Controls.Add(this.pnlLogoPage);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load_1);
            this.TopBar.ResumeLayout(false);
            this.pnlChoice.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.newBar.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlHomeLogo.ResumeLayout(false);
            this.pnlHomeLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.viewBar.ResumeLayout(false);
            this.sidebar1.ResumeLayout(false);
            this.pnlCalendarManual.ResumeLayout(false);
            this.sidebar.ResumeLayout(false);
            this.pnlLogoPage.ResumeLayout(false);
            this.panelNew.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlNoteAction.ResumeLayout(false);
            this.pnlNoteAction.PerformLayout();
            this.panelView.ResumeLayout(false);
            this.pnlGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.pnlViewAction.ResumeLayout(false);
            this.pnlViewAction.PerformLayout();
            this.pnlOkView.ResumeLayout(false);
            this.pnlRichbox.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesWAttachBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.Panel pnlChoice;
        private System.Windows.Forms.Button btnChoices;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlHomeLogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel newBar;
        private System.Windows.Forms.Panel viewBar;
        private System.Windows.Forms.Button Choose;
        private System.Windows.Forms.Button btnByKey;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.FlowLayoutPanel sidebar1;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel pnlLogoPage;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Panel panelNew;
        private System.Windows.Forms.RichTextBox NoteText;
        private System.Windows.Forms.Panel pnlNoteAction;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox outKey;
        private System.Windows.Forms.Panel pnlCalendarManual;
        private System.Windows.Forms.Timer viewBarTransition;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel pnlViewAction;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.Label keyStatus;
        private System.Windows.Forms.Panel pnllineUnderInputKey;
        private System.Windows.Forms.TextBox inputKey;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.Panel pnlOkView;
        private System.Windows.Forms.RichTextBox ViewRichBox;
        private System.Windows.Forms.Button NewAttach;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.Panel pnlRichbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addAtch;
        private System.Windows.Forms.TextBox ViewEncryptKey;
        private System.Windows.Forms.Button ViewCopy;
        private System.Windows.Forms.Button ViewCancel;
        private System.Windows.Forms.Button viewSave;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.BindingSource notesWAttachBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteID;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewButtonColumn NoteContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileName;
        private System.Windows.Forms.DataGridViewLinkColumn FileContent;
        private System.Windows.Forms.ListBox AtcName;
    }
}