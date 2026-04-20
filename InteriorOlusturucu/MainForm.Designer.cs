/*
 * Created by SharpDevelop.
 * User: Acr
 * Date: 25.01.2025
 * Time: 17:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace InteriorOlusturucu
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtMarkerX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarkerY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarkerZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMarkerName1 = new System.Windows.Forms.TextBox();
            this.txtPlayerAngle1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMarkerName2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtPlayerAngle2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlayerZ = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPlayerY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPlayerX = new System.Windows.Forms.TextBox();
            this.txtFromInterior = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtFileWay = new System.Windows.Forms.Label();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtToInterior = new System.Windows.Forms.NumericUpDown();
            this.lbListe = new System.Windows.Forms.ListBox();
            this.btnReflesh = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromInterior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToInterior)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMarkerX
            // 
            this.txtMarkerX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtMarkerX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarkerX.ForeColor = System.Drawing.Color.White;
            this.txtMarkerX.Location = new System.Drawing.Point(115, 65);
            this.txtMarkerX.Name = "txtMarkerX";
            this.txtMarkerX.Size = new System.Drawing.Size(130, 27);
            this.txtMarkerX.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Y";
            // 
            // txtMarkerY
            // 
            this.txtMarkerY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtMarkerY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarkerY.ForeColor = System.Drawing.Color.White;
            this.txtMarkerY.Location = new System.Drawing.Point(115, 105);
            this.txtMarkerY.Name = "txtMarkerY";
            this.txtMarkerY.Size = new System.Drawing.Size(130, 27);
            this.txtMarkerY.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Z";
            // 
            // txtMarkerZ
            // 
            this.txtMarkerZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtMarkerZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarkerZ.ForeColor = System.Drawing.Color.White;
            this.txtMarkerZ.Location = new System.Drawing.Point(115, 145);
            this.txtMarkerZ.Name = "txtMarkerZ";
            this.txtMarkerZ.Size = new System.Drawing.Size(130, 27);
            this.txtMarkerZ.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(20, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marker Konumu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtMarkerName1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPlayerAngle1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtMarkerZ);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMarkerY);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMarkerX);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(20, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 260);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlk Marker Bilgileri";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(195, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 28);
            this.button2.TabIndex = 21;
            this.button2.Text = "Al";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Marker Adı 1";
            // 
            // txtMarkerName1
            // 
            this.txtMarkerName1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtMarkerName1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarkerName1.ForeColor = System.Drawing.Color.White;
            this.txtMarkerName1.Location = new System.Drawing.Point(24, 215);
            this.txtMarkerName1.Name = "txtMarkerName1";
            this.txtMarkerName1.Size = new System.Drawing.Size(100, 27);
            this.txtMarkerName1.TabIndex = 8;
            // 
            // txtPlayerAngle1
            // 
            this.txtPlayerAngle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPlayerAngle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerAngle1.Enabled = false;
            this.txtPlayerAngle1.ForeColor = System.Drawing.Color.Gray;
            this.txtPlayerAngle1.Location = new System.Drawing.Point(145, 215);
            this.txtPlayerAngle1.Name = "txtPlayerAngle1";
            this.txtPlayerAngle1.Size = new System.Drawing.Size(100, 27);
            this.txtPlayerAngle1.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Oyuncu Açısı 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtMarkerName2);
            this.groupBox2.Controls.Add(this.txtPlayerAngle2);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtPlayerZ);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPlayerY);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPlayerX);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(310, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 260);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gidilecek Marker Bilgileri";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(195, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 28);
            this.button3.TabIndex = 22;
            this.button3.Text = "Al";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Marker Adı 2";
            // 
            // txtMarkerName2
            // 
            this.txtMarkerName2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtMarkerName2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMarkerName2.ForeColor = System.Drawing.Color.White;
            this.txtMarkerName2.Location = new System.Drawing.Point(24, 215);
            this.txtMarkerName2.Name = "txtMarkerName2";
            this.txtMarkerName2.Size = new System.Drawing.Size(100, 27);
            this.txtMarkerName2.TabIndex = 10;
            // 
            // txtPlayerAngle2
            // 
            this.txtPlayerAngle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPlayerAngle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerAngle2.Enabled = false;
            this.txtPlayerAngle2.ForeColor = System.Drawing.Color.Gray;
            this.txtPlayerAngle2.Location = new System.Drawing.Point(145, 215);
            this.txtPlayerAngle2.Name = "txtPlayerAngle2";
            this.txtPlayerAngle2.Size = new System.Drawing.Size(100, 27);
            this.txtPlayerAngle2.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(141, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 20);
            this.label16.TabIndex = 16;
            this.label16.Text = "Oyuncu Açısı 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(20, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Marker Konumu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Z";
            // 
            // txtPlayerZ
            // 
            this.txtPlayerZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtPlayerZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerZ.ForeColor = System.Drawing.Color.White;
            this.txtPlayerZ.Location = new System.Drawing.Point(115, 145);
            this.txtPlayerZ.Name = "txtPlayerZ";
            this.txtPlayerZ.Size = new System.Drawing.Size(130, 27);
            this.txtPlayerZ.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Y";
            // 
            // txtPlayerY
            // 
            this.txtPlayerY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtPlayerY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerY.ForeColor = System.Drawing.Color.White;
            this.txtPlayerY.Location = new System.Drawing.Point(115, 105);
            this.txtPlayerY.Name = "txtPlayerY";
            this.txtPlayerY.Size = new System.Drawing.Size(130, 27);
            this.txtPlayerY.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "X";
            // 
            // txtPlayerX
            // 
            this.txtPlayerX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtPlayerX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayerX.ForeColor = System.Drawing.Color.White;
            this.txtPlayerX.Location = new System.Drawing.Point(115, 65);
            this.txtPlayerX.Name = "txtPlayerX";
            this.txtPlayerX.Size = new System.Drawing.Size(130, 27);
            this.txtPlayerX.TabIndex = 0;
            // 
            // txtFromInterior
            // 
            this.txtFromInterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtFromInterior.ForeColor = System.Drawing.Color.White;
            this.txtFromInterior.Location = new System.Drawing.Point(160, 360);
            this.txtFromInterior.Name = "txtFromInterior";
            this.txtFromInterior.Size = new System.Drawing.Size(130, 27);
            this.txtFromInterior.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Şuanki Interior";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSelectFolder.FlatAppearance.BorderSize = 0;
            this.btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnSelectFolder.ForeColor = System.Drawing.Color.White;
            this.btnSelectFolder.Location = new System.Drawing.Point(20, 305);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(130, 32);
            this.btnSelectFolder.TabIndex = 11;
            this.btnSelectFolder.Text = "Klasör Seç";
            this.btnSelectFolder.UseVisualStyleBackColor = false;
            this.btnSelectFolder.Click += new System.EventHandler(this.BtnSelectFolderClick);
            // 
            // txtFileWay
            // 
            this.txtFileWay.AutoSize = true;
            this.txtFileWay.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.txtFileWay.ForeColor = System.Drawing.Color.Gray;
            this.txtFileWay.Location = new System.Drawing.Point(250, 313);
            this.txtFileWay.Name = "txtFileWay";
            this.txtFileWay.Size = new System.Drawing.Size(130, 19);
            this.txtFileWay.TabIndex = 12;
            this.txtFileWay.Text = "Klasör Yolu Bekleniyor...";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(160, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 32);
            this.button4.TabIndex = 21;
            this.button4.Text = "Yolu Al";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4Click);
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.BackColor = System.Drawing.Color.SeaGreen;
            this.btnWriteFile.FlatAppearance.BorderSize = 0;
            this.btnWriteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWriteFile.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.btnWriteFile.ForeColor = System.Drawing.Color.White;
            this.btnWriteFile.Location = new System.Drawing.Point(310, 360);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(130, 67);
            this.btnWriteFile.TabIndex = 13;
            this.btnWriteFile.Text = "Listeye Ekle";
            this.btnWriteFile.UseVisualStyleBackColor = false;
            this.btnWriteFile.Click += new System.EventHandler(this.BtnWriteFileClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 403);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Gidilecek Interior";
            // 
            // txtToInterior
            // 
            this.txtToInterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtToInterior.ForeColor = System.Drawing.Color.White;
            this.txtToInterior.Location = new System.Drawing.Point(160, 400);
            this.txtToInterior.Name = "txtToInterior";
            this.txtToInterior.Size = new System.Drawing.Size(130, 27);
            this.txtToInterior.TabIndex = 14;
            // 
            // lbListe
            // 
            this.lbListe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbListe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbListe.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbListe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbListe.FormattingEnabled = true;
            this.lbListe.ItemHeight = 18;
            this.lbListe.Location = new System.Drawing.Point(600, 45);
            this.lbListe.Name = "lbListe";
            this.lbListe.Size = new System.Drawing.Size(530, 380);
            this.lbListe.TabIndex = 16;
            this.lbListe.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LbListeMouseDoubleClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(600, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 23);
            this.label17.TabIndex = 18;
            this.label17.Text = "Marker Listesi";
            // 
            // btnReflesh
            // 
            this.btnReflesh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.btnReflesh.FlatAppearance.BorderSize = 0;
            this.btnReflesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReflesh.Location = new System.Drawing.Point(450, 360);
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Size = new System.Drawing.Size(130, 32);
            this.btnReflesh.TabIndex = 17;
            this.btnReflesh.Text = "Yenile";
            this.btnReflesh.UseVisualStyleBackColor = false;
            this.btnReflesh.Click += new System.EventHandler(this.BtnRefleshClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(450, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "Temizle (C)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
    this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 447);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1150, 26);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(328, 20);
            this.toolStripStatusLabel1.Text = "© 2024-2026 E Y Z I R™ A.Ş. Tüm Hakları Saklıdır";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1150, 473);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnReflesh);
            this.Controls.Add(this.lbListe);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtToInterior);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.txtFileWay);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtFromInterior);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interior & Marker Oluşturucu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromInterior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtToInterior)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Button btnReflesh;
		private System.Windows.Forms.ListBox lbListe;
		private System.Windows.Forms.TextBox txtPlayerAngle1;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox txtPlayerAngle2;
		private System.Windows.Forms.TextBox txtMarkerName1;
		private System.Windows.Forms.TextBox txtMarkerName2;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.NumericUpDown txtFromInterior;
		private System.Windows.Forms.NumericUpDown txtToInterior;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label txtFileWay;
		private System.Windows.Forms.Button btnWriteFile;
		private System.Windows.Forms.Button btnSelectFolder;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtPlayerX;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtPlayerY;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtPlayerZ;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtMarkerZ;
		private System.Windows.Forms.TextBox txtMarkerY;
		private System.Windows.Forms.TextBox txtMarkerX;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}
