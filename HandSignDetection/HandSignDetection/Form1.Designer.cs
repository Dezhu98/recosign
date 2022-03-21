using System.Windows.Forms;

namespace HandSignDetection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.vthsbtn = new System.Windows.Forms.Button();
            this.tthsbtn = new System.Windows.Forms.Button();
            this.sdbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closebtn = new System.Windows.Forms.Button();
            this.stopcamerabtn = new System.Windows.Forms.Button();
            this.startcamerabtn = new System.Windows.Forms.Button();
            this.backgroundload = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dictionarybtn = new System.Windows.Forms.Button();
            this.dictionarybtn1 = new System.Windows.Forms.Button();
            this.letterpanel1 = new System.Windows.Forms.Panel();
            this.M = new System.Windows.Forms.Button();
            this.L = new System.Windows.Forms.Button();
            this.K = new System.Windows.Forms.Button();
            this.J = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.letterpanel2 = new System.Windows.Forms.Panel();
            this.N = new System.Windows.Forms.Button();
            this.O = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Button();
            this.Q = new System.Windows.Forms.Button();
            this.R = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Button();
            this.T = new System.Windows.Forms.Button();
            this.U = new System.Windows.Forms.Button();
            this.V = new System.Windows.Forms.Button();
            this.W = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.Y = new System.Windows.Forms.Button();
            this.Z = new System.Windows.Forms.Button();
            this.closebtn1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.texttths = new System.Windows.Forms.TextBox();
            this.transformtths = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer2 = new AxWMPLib.AxWindowsMediaPlayer();
            this.axWindowsMediaPlayer3 = new AxWMPLib.AxWindowsMediaPlayer();
            this.recordbtn = new System.Windows.Forms.Button();
            this.processbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.backgroundload.SuspendLayout();
            this.letterpanel1.SuspendLayout();
            this.letterpanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.vthsbtn);
            this.panel1.Controls.Add(this.tthsbtn);
            this.panel1.Controls.Add(this.sdbtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 500);
            this.panel1.TabIndex = 0;
            // 
            // vthsbtn
            // 
            this.vthsbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.vthsbtn.FlatAppearance.BorderSize = 2;
            this.vthsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vthsbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.vthsbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.vthsbtn.Location = new System.Drawing.Point(0, 197);
            this.vthsbtn.Name = "vthsbtn";
            this.vthsbtn.Size = new System.Drawing.Size(159, 36);
            this.vthsbtn.TabIndex = 4;
            this.vthsbtn.Text = "Voice To Hand Signs";
            this.vthsbtn.UseVisualStyleBackColor = true;
            this.vthsbtn.Click += new System.EventHandler(this.vthsbtn_Click);
            // 
            // tthsbtn
            // 
            this.tthsbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.tthsbtn.FlatAppearance.BorderSize = 2;
            this.tthsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tthsbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.tthsbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.tthsbtn.Location = new System.Drawing.Point(0, 161);
            this.tthsbtn.Name = "tthsbtn";
            this.tthsbtn.Size = new System.Drawing.Size(159, 36);
            this.tthsbtn.TabIndex = 3;
            this.tthsbtn.Text = "Text To Hand Signs";
            this.tthsbtn.UseVisualStyleBackColor = true;
            this.tthsbtn.Click += new System.EventHandler(this.tthsbtn_Click);
            // 
            // sdbtn
            // 
            this.sdbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.sdbtn.FlatAppearance.BorderSize = 2;
            this.sdbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sdbtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.sdbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.sdbtn.Location = new System.Drawing.Point(0, 125);
            this.sdbtn.Name = "sdbtn";
            this.sdbtn.Size = new System.Drawing.Size(159, 36);
            this.sdbtn.TabIndex = 2;
            this.sdbtn.Text = "Sign Detection";
            this.sdbtn.UseVisualStyleBackColor = true;
            this.sdbtn.Click += new System.EventHandler(this.sdbtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(159, 125);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // closebtn
            // 
            this.closebtn.FlatAppearance.BorderSize = 0;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.ForeColor = System.Drawing.Color.White;
            this.closebtn.Location = new System.Drawing.Point(776, 19);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(21, 22);
            this.closebtn.TabIndex = 1;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = true;
            // 
            // stopcamerabtn
            // 
            this.stopcamerabtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.stopcamerabtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.stopcamerabtn.FlatAppearance.BorderSize = 0;
            this.stopcamerabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopcamerabtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopcamerabtn.ForeColor = System.Drawing.Color.Black;
            this.stopcamerabtn.Location = new System.Drawing.Point(159, 464);
            this.stopcamerabtn.Name = "stopcamerabtn";
            this.stopcamerabtn.Size = new System.Drawing.Size(313, 36);
            this.stopcamerabtn.TabIndex = 4;
            this.stopcamerabtn.Text = "Stop Camera";
            this.stopcamerabtn.UseVisualStyleBackColor = false;
            this.stopcamerabtn.Click += new System.EventHandler(this.stopcamerabtn_Click);
            // 
            // startcamerabtn
            // 
            this.startcamerabtn.BackColor = System.Drawing.Color.Green;
            this.startcamerabtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.startcamerabtn.FlatAppearance.BorderSize = 0;
            this.startcamerabtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startcamerabtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.startcamerabtn.ForeColor = System.Drawing.Color.Black;
            this.startcamerabtn.Location = new System.Drawing.Point(159, 428);
            this.startcamerabtn.Name = "startcamerabtn";
            this.startcamerabtn.Size = new System.Drawing.Size(313, 36);
            this.startcamerabtn.TabIndex = 5;
            this.startcamerabtn.Text = "Start Camera";
            this.startcamerabtn.UseVisualStyleBackColor = false;
            this.startcamerabtn.Click += new System.EventHandler(this.startcamerabtn_Click);
            // 
            // backgroundload
            // 
            this.backgroundload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.backgroundload.Controls.Add(this.panel4);
            this.backgroundload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.backgroundload.Location = new System.Drawing.Point(159, 405);
            this.backgroundload.Name = "backgroundload";
            this.backgroundload.Size = new System.Drawing.Size(313, 23);
            this.backgroundload.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 23);
            this.panel4.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dictionarybtn
            // 
            this.dictionarybtn.FlatAppearance.BorderSize = 2;
            this.dictionarybtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dictionarybtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dictionarybtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.dictionarybtn.Location = new System.Drawing.Point(405, 536);
            this.dictionarybtn.Name = "dictionarybtn";
            this.dictionarybtn.Size = new System.Drawing.Size(0, 36);
            this.dictionarybtn.TabIndex = 3;
            this.dictionarybtn.Text = "Dictionary";
            this.dictionarybtn.UseVisualStyleBackColor = true;
            // 
            // dictionarybtn1
            // 
            this.dictionarybtn1.BackColor = System.Drawing.Color.Green;
            this.dictionarybtn1.FlatAppearance.BorderSize = 0;
            this.dictionarybtn1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dictionarybtn1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dictionarybtn1.ForeColor = System.Drawing.Color.Black;
            this.dictionarybtn1.Location = new System.Drawing.Point(241, 353);
            this.dictionarybtn1.Name = "dictionarybtn1";
            this.dictionarybtn1.Size = new System.Drawing.Size(0, 36);
            this.dictionarybtn1.TabIndex = 7;
            this.dictionarybtn1.Text = "Dictionary";
            this.dictionarybtn1.UseVisualStyleBackColor = false;
            this.dictionarybtn1.Click += new System.EventHandler(this.dictionarybtn1_Click);
            // 
            // letterpanel1
            // 
            this.letterpanel1.Controls.Add(this.M);
            this.letterpanel1.Controls.Add(this.L);
            this.letterpanel1.Controls.Add(this.K);
            this.letterpanel1.Controls.Add(this.J);
            this.letterpanel1.Controls.Add(this.I);
            this.letterpanel1.Controls.Add(this.H);
            this.letterpanel1.Controls.Add(this.G);
            this.letterpanel1.Controls.Add(this.F);
            this.letterpanel1.Controls.Add(this.E);
            this.letterpanel1.Controls.Add(this.D);
            this.letterpanel1.Controls.Add(this.C);
            this.letterpanel1.Controls.Add(this.B);
            this.letterpanel1.Controls.Add(this.A);
            this.letterpanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.letterpanel1.Location = new System.Drawing.Point(159, 0);
            this.letterpanel1.Name = "letterpanel1";
            this.letterpanel1.Size = new System.Drawing.Size(313, 22);
            this.letterpanel1.TabIndex = 8;
            this.letterpanel1.Visible = false;
            // 
            // M
            // 
            this.M.Dock = System.Windows.Forms.DockStyle.Left;
            this.M.Location = new System.Drawing.Point(252, 0);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(21, 22);
            this.M.TabIndex = 21;
            this.M.Text = "M";
            this.M.UseVisualStyleBackColor = true;
            this.M.Click += new System.EventHandler(this.M_Click);
            // 
            // L
            // 
            this.L.Dock = System.Windows.Forms.DockStyle.Left;
            this.L.Location = new System.Drawing.Point(231, 0);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(21, 22);
            this.L.TabIndex = 20;
            this.L.Text = "L";
            this.L.UseVisualStyleBackColor = true;
            this.L.Click += new System.EventHandler(this.L_Click);
            // 
            // K
            // 
            this.K.Dock = System.Windows.Forms.DockStyle.Left;
            this.K.Location = new System.Drawing.Point(210, 0);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(21, 22);
            this.K.TabIndex = 19;
            this.K.Text = "K";
            this.K.UseVisualStyleBackColor = true;
            this.K.Click += new System.EventHandler(this.K_Click);
            // 
            // J
            // 
            this.J.Dock = System.Windows.Forms.DockStyle.Left;
            this.J.Location = new System.Drawing.Point(189, 0);
            this.J.Name = "J";
            this.J.Size = new System.Drawing.Size(21, 22);
            this.J.TabIndex = 18;
            this.J.Text = "J";
            this.J.UseVisualStyleBackColor = true;
            this.J.Click += new System.EventHandler(this.J_Click);
            // 
            // I
            // 
            this.I.Dock = System.Windows.Forms.DockStyle.Left;
            this.I.Location = new System.Drawing.Point(168, 0);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(21, 22);
            this.I.TabIndex = 17;
            this.I.Text = "I";
            this.I.UseVisualStyleBackColor = true;
            this.I.Click += new System.EventHandler(this.I_Click);
            // 
            // H
            // 
            this.H.Dock = System.Windows.Forms.DockStyle.Left;
            this.H.Location = new System.Drawing.Point(147, 0);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(21, 22);
            this.H.TabIndex = 16;
            this.H.Text = "H";
            this.H.UseVisualStyleBackColor = true;
            this.H.Click += new System.EventHandler(this.H_Click);
            // 
            // G
            // 
            this.G.Dock = System.Windows.Forms.DockStyle.Left;
            this.G.Location = new System.Drawing.Point(126, 0);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(21, 22);
            this.G.TabIndex = 15;
            this.G.Text = "G";
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.G_Click);
            // 
            // F
            // 
            this.F.Dock = System.Windows.Forms.DockStyle.Left;
            this.F.Location = new System.Drawing.Point(105, 0);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(21, 22);
            this.F.TabIndex = 14;
            this.F.Text = "F";
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.F_Click);
            // 
            // E
            // 
            this.E.Dock = System.Windows.Forms.DockStyle.Left;
            this.E.Location = new System.Drawing.Point(84, 0);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(21, 22);
            this.E.TabIndex = 13;
            this.E.Text = "E";
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.E_Click);
            // 
            // D
            // 
            this.D.Dock = System.Windows.Forms.DockStyle.Left;
            this.D.Location = new System.Drawing.Point(63, 0);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(21, 22);
            this.D.TabIndex = 12;
            this.D.Text = "D";
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.D_Click);
            // 
            // C
            // 
            this.C.Dock = System.Windows.Forms.DockStyle.Left;
            this.C.Location = new System.Drawing.Point(42, 0);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(21, 22);
            this.C.TabIndex = 11;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // B
            // 
            this.B.Dock = System.Windows.Forms.DockStyle.Left;
            this.B.Location = new System.Drawing.Point(21, 0);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(21, 22);
            this.B.TabIndex = 10;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // A
            // 
            this.A.Dock = System.Windows.Forms.DockStyle.Left;
            this.A.Location = new System.Drawing.Point(0, 0);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(21, 22);
            this.A.TabIndex = 9;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.A_Click);
            // 
            // letterpanel2
            // 
            this.letterpanel2.Controls.Add(this.N);
            this.letterpanel2.Controls.Add(this.O);
            this.letterpanel2.Controls.Add(this.P);
            this.letterpanel2.Controls.Add(this.Q);
            this.letterpanel2.Controls.Add(this.R);
            this.letterpanel2.Controls.Add(this.S);
            this.letterpanel2.Controls.Add(this.T);
            this.letterpanel2.Controls.Add(this.U);
            this.letterpanel2.Controls.Add(this.V);
            this.letterpanel2.Controls.Add(this.W);
            this.letterpanel2.Controls.Add(this.X);
            this.letterpanel2.Controls.Add(this.Y);
            this.letterpanel2.Controls.Add(this.Z);
            this.letterpanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.letterpanel2.Location = new System.Drawing.Point(159, 22);
            this.letterpanel2.Name = "letterpanel2";
            this.letterpanel2.Size = new System.Drawing.Size(313, 22);
            this.letterpanel2.TabIndex = 9;
            this.letterpanel2.Visible = false;
            // 
            // N
            // 
            this.N.Dock = System.Windows.Forms.DockStyle.Right;
            this.N.Location = new System.Drawing.Point(40, 0);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(21, 22);
            this.N.TabIndex = 35;
            this.N.Text = "N";
            this.N.UseVisualStyleBackColor = true;
            this.N.Click += new System.EventHandler(this.N_Click);
            // 
            // O
            // 
            this.O.Dock = System.Windows.Forms.DockStyle.Right;
            this.O.Location = new System.Drawing.Point(61, 0);
            this.O.Name = "O";
            this.O.Size = new System.Drawing.Size(21, 22);
            this.O.TabIndex = 34;
            this.O.Text = "O";
            this.O.UseVisualStyleBackColor = true;
            this.O.Click += new System.EventHandler(this.O_Click);
            // 
            // P
            // 
            this.P.Dock = System.Windows.Forms.DockStyle.Right;
            this.P.Location = new System.Drawing.Point(82, 0);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(21, 22);
            this.P.TabIndex = 33;
            this.P.Text = "P";
            this.P.UseVisualStyleBackColor = true;
            this.P.Click += new System.EventHandler(this.P_Click);
            // 
            // Q
            // 
            this.Q.Dock = System.Windows.Forms.DockStyle.Right;
            this.Q.Location = new System.Drawing.Point(103, 0);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(21, 22);
            this.Q.TabIndex = 32;
            this.Q.Text = "Q";
            this.Q.UseVisualStyleBackColor = true;
            this.Q.Click += new System.EventHandler(this.Q_Click);
            // 
            // R
            // 
            this.R.Dock = System.Windows.Forms.DockStyle.Right;
            this.R.Location = new System.Drawing.Point(124, 0);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(21, 22);
            this.R.TabIndex = 31;
            this.R.Text = "R";
            this.R.UseVisualStyleBackColor = true;
            this.R.Click += new System.EventHandler(this.R_Click);
            // 
            // S
            // 
            this.S.Dock = System.Windows.Forms.DockStyle.Right;
            this.S.Location = new System.Drawing.Point(145, 0);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(21, 22);
            this.S.TabIndex = 30;
            this.S.Text = "S";
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // T
            // 
            this.T.Dock = System.Windows.Forms.DockStyle.Right;
            this.T.Location = new System.Drawing.Point(166, 0);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(21, 22);
            this.T.TabIndex = 29;
            this.T.Text = "T";
            this.T.UseVisualStyleBackColor = true;
            this.T.Click += new System.EventHandler(this.T_Click);
            // 
            // U
            // 
            this.U.Dock = System.Windows.Forms.DockStyle.Right;
            this.U.Location = new System.Drawing.Point(187, 0);
            this.U.Name = "U";
            this.U.Size = new System.Drawing.Size(21, 22);
            this.U.TabIndex = 28;
            this.U.Text = "U";
            this.U.UseVisualStyleBackColor = true;
            this.U.Click += new System.EventHandler(this.U_Click);
            // 
            // V
            // 
            this.V.Dock = System.Windows.Forms.DockStyle.Right;
            this.V.Location = new System.Drawing.Point(208, 0);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(21, 22);
            this.V.TabIndex = 27;
            this.V.Text = "V";
            this.V.UseVisualStyleBackColor = true;
            this.V.Click += new System.EventHandler(this.V_Click);
            // 
            // W
            // 
            this.W.Dock = System.Windows.Forms.DockStyle.Right;
            this.W.Location = new System.Drawing.Point(229, 0);
            this.W.Name = "W";
            this.W.Size = new System.Drawing.Size(21, 22);
            this.W.TabIndex = 26;
            this.W.Text = "W";
            this.W.UseVisualStyleBackColor = true;
            this.W.Click += new System.EventHandler(this.W_Click);
            // 
            // X
            // 
            this.X.Dock = System.Windows.Forms.DockStyle.Right;
            this.X.Location = new System.Drawing.Point(250, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(21, 22);
            this.X.TabIndex = 25;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = true;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // Y
            // 
            this.Y.Dock = System.Windows.Forms.DockStyle.Right;
            this.Y.Location = new System.Drawing.Point(271, 0);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(21, 22);
            this.Y.TabIndex = 24;
            this.Y.Text = "Y";
            this.Y.UseVisualStyleBackColor = true;
            this.Y.Click += new System.EventHandler(this.Y_Click);
            // 
            // Z
            // 
            this.Z.Dock = System.Windows.Forms.DockStyle.Right;
            this.Z.Location = new System.Drawing.Point(292, 0);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(21, 22);
            this.Z.TabIndex = 23;
            this.Z.Text = "Z";
            this.Z.UseVisualStyleBackColor = true;
            this.Z.Click += new System.EventHandler(this.Z_Click);
            // 
            // closebtn1
            // 
            this.closebtn1.Dock = System.Windows.Forms.DockStyle.Right;
            this.closebtn1.FlatAppearance.BorderSize = 0;
            this.closebtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.closebtn1.Location = new System.Drawing.Point(292, 0);
            this.closebtn1.Name = "closebtn1";
            this.closebtn1.Size = new System.Drawing.Size(21, 22);
            this.closebtn1.TabIndex = 23;
            this.closebtn1.Text = "X";
            this.closebtn1.UseVisualStyleBackColor = true;
            this.closebtn1.Click += new System.EventHandler(this.closebtn1_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.closebtn1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(159, 44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(313, 22);
            this.panel5.TabIndex = 24;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(159, 161);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(316, 220);
            this.axWindowsMediaPlayer1.TabIndex = 25;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // texttths
            // 
            this.texttths.Location = new System.Drawing.Point(199, 52);
            this.texttths.Multiline = true;
            this.texttths.Name = "texttths";
            this.texttths.Size = new System.Drawing.Size(229, 77);
            this.texttths.TabIndex = 26;
            // 
            // transformtths
            // 
            this.transformtths.Location = new System.Drawing.Point(264, 135);
            this.transformtths.Name = "transformtths";
            this.transformtths.Size = new System.Drawing.Size(94, 26);
            this.transformtths.TabIndex = 27;
            this.transformtths.Text = "Transform";
            this.transformtths.UseVisualStyleBackColor = true;
            this.transformtths.Click += new System.EventHandler(this.transformtths_Click);
            // 
            // axWindowsMediaPlayer2
            // 
            this.axWindowsMediaPlayer2.Enabled = true;
            this.axWindowsMediaPlayer2.Location = new System.Drawing.Point(159, 167);
            this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";
            this.axWindowsMediaPlayer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer2.OcxState")));
            this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(313, 333);
            this.axWindowsMediaPlayer2.TabIndex = 28;
            // 
            // axWindowsMediaPlayer3
            // 
            this.axWindowsMediaPlayer3.Enabled = true;
            this.axWindowsMediaPlayer3.Location = new System.Drawing.Point(159, 161);
            this.axWindowsMediaPlayer3.Name = "axWindowsMediaPlayer3";
            this.axWindowsMediaPlayer3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer3.OcxState")));
            this.axWindowsMediaPlayer3.Size = new System.Drawing.Size(313, 339);
            this.axWindowsMediaPlayer3.TabIndex = 30;
            this.axWindowsMediaPlayer3.Enter += new System.EventHandler(this.axWindowsMediaPlayer3_Enter);
            // 
            // recordbtn
            // 
            this.recordbtn.Location = new System.Drawing.Point(222, 72);
            this.recordbtn.Name = "recordbtn";
            this.recordbtn.Size = new System.Drawing.Size(84, 43);
            this.recordbtn.TabIndex = 29;
            this.recordbtn.Text = "Record";
            this.recordbtn.UseVisualStyleBackColor = true;
            this.recordbtn.Click += new System.EventHandler(this.recordbtn_Click);
            // 
            // processbtn
            // 
            this.processbtn.Location = new System.Drawing.Point(327, 72);
            this.processbtn.Name = "processbtn";
            this.processbtn.Size = new System.Drawing.Size(84, 43);
            this.processbtn.TabIndex = 32;
            this.processbtn.Text = "Process Recording";
            this.processbtn.UseVisualStyleBackColor = true;
            this.processbtn.Click += new System.EventHandler(this.processbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(472, 500);
            this.Controls.Add(this.processbtn);
            this.Controls.Add(this.axWindowsMediaPlayer3);
            this.Controls.Add(this.recordbtn);
            this.Controls.Add(this.texttths);
            this.Controls.Add(this.axWindowsMediaPlayer2);
            this.Controls.Add(this.transformtths);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.letterpanel2);
            this.Controls.Add(this.letterpanel1);
            this.Controls.Add(this.dictionarybtn1);
            this.Controls.Add(this.dictionarybtn);
            this.Controls.Add(this.backgroundload);
            this.Controls.Add(this.startcamerabtn);
            this.Controls.Add(this.stopcamerabtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoSign";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.backgroundload.ResumeLayout(false);
            this.letterpanel1.ResumeLayout(false);
            this.letterpanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button sdbtn;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button closebtn;
        private Button stopcamerabtn;
        private Button startcamerabtn;
        private Panel backgroundload;
        private Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private Button dictionarybtn;
        private Button dictionarybtn1;
        private Panel letterpanel1;
        private Button A;
        private Button M;
        private Button L;
        private Button K;
        private Button J;
        private Button I;
        private Button H;
        private Button G;
        private Button F;
        private Button E;
        private Button D;
        private Button C;
        private Button B;
        private Panel letterpanel2;
        private Button N;
        private Button O;
        private Button P;
        private Button Q;
        private Button R;
        private Button S;
        private Button T;
        private Button U;
        private Button V;
        private Button W;
        private Button X;
        private Button Y;
        private Button Z;
        private Button closebtn1;
        private Panel panel5;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button tthsbtn;
        private TextBox texttths;
        private Button transformtths;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer2;
        private Button vthsbtn;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer3;
        private Button recordbtn;
        private Button processbtn;
    }
}