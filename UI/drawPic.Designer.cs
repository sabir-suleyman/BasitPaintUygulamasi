﻿namespace Esgis_Paint
{
    partial class drawPic
    {

        private System.ComponentModel.IContainer components = null;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(drawPic));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dessinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.effacerToutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown_Epaisseur = new System.Windows.Forms.NumericUpDown();
            this.groupBox_Epaisseur = new System.Windows.Forms.GroupBox();
            this.groupBox_Couleur = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_ColorActual = new System.Windows.Forms.PictureBox();
            this.pictureBox_Color2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Color5 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox_Color3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Color6 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Color1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Color4 = new System.Windows.Forms.PictureBox();
            this.groupBox_Outils = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_ZoomOut = new System.Windows.Forms.Button();
            this.btn_ZoomIn = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.groupBox_Formes = new System.Windows.Forms.GroupBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox_Fichier = new System.Windows.Forms.GroupBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label_Info = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Epaisseur)).BeginInit();
            this.groupBox_Epaisseur.SuspendLayout();
            this.groupBox_Couleur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color4)).BeginInit();
            this.groupBox_Outils.SuspendLayout();
            this.groupBox_Formes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_Fichier.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crayon";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(63, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 516);
            this.panel1.TabIndex = 5;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.dessinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1105, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirToolStripMenuItem,
            this.enregistrerToolStripMenuItem,
            this.imprimerToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.fichierToolStripMenuItem.Text = "Dosya";
            this.fichierToolStripMenuItem.Click += new System.EventHandler(this.fichierToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ouvrirToolStripMenuItem.Text = "Resmi aç";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enregistrerToolStripMenuItem.Text = "Kayıt ol";
            this.enregistrerToolStripMenuItem.Click += new System.EventHandler(this.enregistrerToolStripMenuItem_Click);
            // 
            // imprimerToolStripMenuItem
            // 
            this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
            this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imprimerToolStripMenuItem.Text = "Yazdır";
            this.imprimerToolStripMenuItem.Click += new System.EventHandler(this.imprimerToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Çıkış";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // dessinToolStripMenuItem
            // 
            this.dessinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.effacerToutToolStripMenuItem});
            this.dessinToolStripMenuItem.Name = "dessinToolStripMenuItem";
            this.dessinToolStripMenuItem.Size = new System.Drawing.Size(51, 21);
            this.dessinToolStripMenuItem.Text = "Çizim";
            this.dessinToolStripMenuItem.Click += new System.EventHandler(this.dessinToolStripMenuItem_Click);
            // 
            // effacerToutToolStripMenuItem
            // 
            this.effacerToutToolStripMenuItem.Name = "effacerToutToolStripMenuItem";
            this.effacerToutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.effacerToutToolStripMenuItem.Text = "Tümünü sil";
            this.effacerToutToolStripMenuItem.Click += new System.EventHandler(this.effacerToutToolStripMenuItem_Click);
            // 
            // numericUpDown_Epaisseur
            // 
            this.numericUpDown_Epaisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Epaisseur.Location = new System.Drawing.Point(8, 28);
            this.numericUpDown_Epaisseur.Name = "numericUpDown_Epaisseur";
            this.numericUpDown_Epaisseur.Size = new System.Drawing.Size(74, 32);
            this.numericUpDown_Epaisseur.TabIndex = 14;
            this.numericUpDown_Epaisseur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Epaisseur.ValueChanged += new System.EventHandler(this.numericUpDown_Epaisseur_ValueChanged);
            // 
            // groupBox_Epaisseur
            // 
            this.groupBox_Epaisseur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Epaisseur.Controls.Add(this.numericUpDown_Epaisseur);
            this.groupBox_Epaisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Epaisseur.Location = new System.Drawing.Point(358, 47);
            this.groupBox_Epaisseur.Name = "groupBox_Epaisseur";
            this.groupBox_Epaisseur.Size = new System.Drawing.Size(103, 76);
            this.groupBox_Epaisseur.TabIndex = 15;
            this.groupBox_Epaisseur.TabStop = false;
            this.groupBox_Epaisseur.Text = "Kalınlık";
            // 
            // groupBox_Couleur
            // 
            this.groupBox_Couleur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Couleur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox_Couleur.Controls.Add(this.pictureBox2);
            this.groupBox_Couleur.Controls.Add(this.pictureBox_ColorActual);
            this.groupBox_Couleur.Controls.Add(this.pictureBox_Color2);
            this.groupBox_Couleur.Controls.Add(this.pictureBox_Color5);
            this.groupBox_Couleur.Controls.Add(this.button3);
            this.groupBox_Couleur.Controls.Add(this.pictureBox_Color3);
            this.groupBox_Couleur.Controls.Add(this.pictureBox_Color6);
            this.groupBox_Couleur.Controls.Add(this.pictureBox_Color1);
            this.groupBox_Couleur.Controls.Add(this.pictureBox_Color4);
            this.groupBox_Couleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Couleur.Location = new System.Drawing.Point(467, 47);
            this.groupBox_Couleur.Name = "groupBox_Couleur";
            this.groupBox_Couleur.Size = new System.Drawing.Size(329, 76);
            this.groupBox_Couleur.TabIndex = 16;
            this.groupBox_Couleur.TabStop = false;
            this.groupBox_Couleur.Text = "Renkler";
            this.groupBox_Couleur.Enter += new System.EventHandler(this.groupBox_Couleur_Enter);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(94, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox_ColorActual
            // 
            this.pictureBox_ColorActual.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_ColorActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_ColorActual.Location = new System.Drawing.Point(38, 23);
            this.pictureBox_ColorActual.Name = "pictureBox_ColorActual";
            this.pictureBox_ColorActual.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_ColorActual.TabIndex = 10;
            this.pictureBox_ColorActual.TabStop = false;
            // 
            // pictureBox_Color2
            // 
            this.pictureBox_Color2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Color2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Color2.Location = new System.Drawing.Point(150, 23);
            this.pictureBox_Color2.Name = "pictureBox_Color2";
            this.pictureBox_Color2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Color2.TabIndex = 9;
            this.pictureBox_Color2.TabStop = false;
            this.pictureBox_Color2.Click += new System.EventHandler(this.pictureBox_Color2_Click);
            // 
            // pictureBox_Color5
            // 
            this.pictureBox_Color5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Color5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Color5.Location = new System.Drawing.Point(206, 23);
            this.pictureBox_Color5.Name = "pictureBox_Color5";
            this.pictureBox_Color5.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Color5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Color5.TabIndex = 8;
            this.pictureBox_Color5.TabStop = false;
            this.pictureBox_Color5.Click += new System.EventHandler(this.pictureBox_Color5_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Esgis_Paint.Properties.Resources.More_32px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(234, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 41);
            this.button3.TabIndex = 0;
            this.button3.Text = "Daha Fazla";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox_Color3
            // 
            this.pictureBox_Color3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Color3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Color3.Location = new System.Drawing.Point(66, 23);
            this.pictureBox_Color3.Name = "pictureBox_Color3";
            this.pictureBox_Color3.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Color3.TabIndex = 7;
            this.pictureBox_Color3.TabStop = false;
            this.pictureBox_Color3.Click += new System.EventHandler(this.pictureBox_Color3_Click);
            // 
            // pictureBox_Color6
            // 
            this.pictureBox_Color6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Color6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Color6.Location = new System.Drawing.Point(178, 23);
            this.pictureBox_Color6.Name = "pictureBox_Color6";
            this.pictureBox_Color6.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Color6.TabIndex = 6;
            this.pictureBox_Color6.TabStop = false;
            this.pictureBox_Color6.Click += new System.EventHandler(this.pictureBox_Color6_Click);
            // 
            // pictureBox_Color1
            // 
            this.pictureBox_Color1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Color1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Color1.Location = new System.Drawing.Point(10, 23);
            this.pictureBox_Color1.Name = "pictureBox_Color1";
            this.pictureBox_Color1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Color1.TabIndex = 5;
            this.pictureBox_Color1.TabStop = false;
            this.pictureBox_Color1.Click += new System.EventHandler(this.pictureBox_Color1_Click);
            // 
            // pictureBox_Color4
            // 
            this.pictureBox_Color4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_Color4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Color4.Location = new System.Drawing.Point(122, 23);
            this.pictureBox_Color4.Name = "pictureBox_Color4";
            this.pictureBox_Color4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox_Color4.TabIndex = 3;
            this.pictureBox_Color4.TabStop = false;
            this.pictureBox_Color4.Click += new System.EventHandler(this.pictureBox_Color4_Click);
            // 
            // groupBox_Outils
            // 
            this.groupBox_Outils.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Outils.Controls.Add(this.btn_clear);
            this.groupBox_Outils.Controls.Add(this.btn_ZoomOut);
            this.groupBox_Outils.Controls.Add(this.btn_ZoomIn);
            this.groupBox_Outils.Controls.Add(this.btn_pencil);
            this.groupBox_Outils.Controls.Add(this.btn_eraser);
            this.groupBox_Outils.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Outils.Location = new System.Drawing.Point(63, 47);
            this.groupBox_Outils.Name = "groupBox_Outils";
            this.groupBox_Outils.Size = new System.Drawing.Size(289, 76);
            this.groupBox_Outils.TabIndex = 17;
            this.groupBox_Outils.TabStop = false;
            this.groupBox_Outils.Text = "Araçlar";
            this.groupBox_Outils.Enter += new System.EventHandler(this.groupBox_Outils_Enter);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btn_clear.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_clear.Location = new System.Drawing.Point(206, 28);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 37);
            this.btn_clear.TabIndex = 19;
            this.btn_clear.Text = "Temizle";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_ZoomOut
            // 
            this.btn_ZoomOut.Image = global::Esgis_Paint.Properties.Resources.Zoom_Out_32px;
            this.btn_ZoomOut.Location = new System.Drawing.Point(155, 28);
            this.btn_ZoomOut.Name = "btn_ZoomOut";
            this.btn_ZoomOut.Size = new System.Drawing.Size(45, 37);
            this.btn_ZoomOut.TabIndex = 18;
            this.btn_ZoomOut.UseVisualStyleBackColor = true;
            // 
            // btn_ZoomIn
            // 
            this.btn_ZoomIn.Image = global::Esgis_Paint.Properties.Resources.Zoom_In_32px;
            this.btn_ZoomIn.Location = new System.Drawing.Point(104, 28);
            this.btn_ZoomIn.Name = "btn_ZoomIn";
            this.btn_ZoomIn.Size = new System.Drawing.Size(45, 37);
            this.btn_ZoomIn.TabIndex = 17;
            this.btn_ZoomIn.UseVisualStyleBackColor = true;
            // 
            // btn_pencil
            // 
            this.btn_pencil.Image = global::Esgis_Paint.Properties.Resources.Edit_32px;
            this.btn_pencil.Location = new System.Drawing.Point(2, 28);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(45, 37);
            this.btn_pencil.TabIndex = 0;
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.Image = global::Esgis_Paint.Properties.Resources.Erase_32px;
            this.btn_eraser.Location = new System.Drawing.Point(53, 28);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(45, 37);
            this.btn_eraser.TabIndex = 1;
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // groupBox_Formes
            // 
            this.groupBox_Formes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Formes.Controls.Add(this.pictureBox13);
            this.groupBox_Formes.Controls.Add(this.pictureBox14);
            this.groupBox_Formes.Controls.Add(this.pictureBox5);
            this.groupBox_Formes.Controls.Add(this.pictureBox4);
            this.groupBox_Formes.Controls.Add(this.pictureBox3);
            this.groupBox_Formes.Controls.Add(this.pictureBox1);
            this.groupBox_Formes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Formes.Location = new System.Drawing.Point(964, 129);
            this.groupBox_Formes.Name = "groupBox_Formes";
            this.groupBox_Formes.Size = new System.Drawing.Size(78, 291);
            this.groupBox_Formes.TabIndex = 17;
            this.groupBox_Formes.TabStop = false;
            this.groupBox_Formes.Text = "Şekiller";
            this.groupBox_Formes.Enter += new System.EventHandler(this.groupBox_Formes_Enter);
            // 
            // pictureBox13
            // 
            this.pictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox13.Image = global::Esgis_Paint.Properties.Resources.Rectangle_Stroked_32px;
            this.pictureBox13.Location = new System.Drawing.Point(9, 149);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(35, 35);
            this.pictureBox13.TabIndex = 13;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox13_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox14.Image = global::Esgis_Paint.Properties.Resources.Circle_32px;
            this.pictureBox14.Location = new System.Drawing.Point(9, 190);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(35, 35);
            this.pictureBox14.TabIndex = 12;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox14_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::Esgis_Paint.Properties.Resources.Happy_32px;
            this.pictureBox5.Location = new System.Drawing.Point(9, 231);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::Esgis_Paint.Properties.Resources.Hearts_32px;
            this.pictureBox4.Location = new System.Drawing.Point(9, 108);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Esgis_Paint.Properties.Resources.Cloud_32px;
            this.pictureBox3.Location = new System.Drawing.Point(9, 67);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Esgis_Paint.Properties.Resources.Star_32px;
            this.pictureBox1.Location = new System.Drawing.Point(9, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox_Fichier
            // 
            this.groupBox_Fichier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox_Fichier.Controls.Add(this.btn_print);
            this.groupBox_Fichier.Controls.Add(this.btn_save);
            this.groupBox_Fichier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Fichier.Location = new System.Drawing.Point(802, 47);
            this.groupBox_Fichier.Name = "groupBox_Fichier";
            this.groupBox_Fichier.Size = new System.Drawing.Size(239, 76);
            this.groupBox_Fichier.TabIndex = 18;
            this.groupBox_Fichier.TabStop = false;
            this.groupBox_Fichier.Text = "Dosya";
            this.groupBox_Fichier.Enter += new System.EventHandler(this.groupBox_Fichier_Enter);
            // 
            // btn_print
            // 
            this.btn_print.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.Image = global::Esgis_Paint.Properties.Resources.Print_32px;
            this.btn_print.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_print.Location = new System.Drawing.Point(103, 23);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(88, 41);
            this.btn_print.TabIndex = 6;
            this.btn_print.Text = "Yazdır";
            this.btn_print.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Image = global::Esgis_Paint.Properties.Resources.Save_32px;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_save.Location = new System.Drawing.Point(9, 23);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 41);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Kaydet";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = global::Esgis_Paint.Properties.Resources.Cancel_32px;
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_close.Location = new System.Drawing.Point(964, 526);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(88, 41);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Kapat";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(123, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gomme";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label_Info
            // 
            this.label_Info.AutoSize = true;
            this.label_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info.Location = new System.Drawing.Point(6, 26);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(46, 18);
            this.label_Info.TabIndex = 19;
            this.label_Info.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label_Info);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(964, 426);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(77, 76);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dosya";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // drawPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1105, 676);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.groupBox_Formes);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox_Couleur);
            this.Controls.Add(this.groupBox_Fichier);
            this.Controls.Add(this.groupBox_Epaisseur);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox_Outils);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "drawPic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basit Paint Programı";
            this.Load += new System.EventHandler(this.drawPic_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Epaisseur)).EndInit();
            this.groupBox_Epaisseur.ResumeLayout(false);
            this.groupBox_Couleur.ResumeLayout(false);
            this.groupBox_Couleur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Color4)).EndInit();
            this.groupBox_Outils.ResumeLayout(false);
            this.groupBox_Formes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_Fichier.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dessinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem effacerToutToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown_Epaisseur;
        private System.Windows.Forms.GroupBox groupBox_Epaisseur;
        private System.Windows.Forms.GroupBox groupBox_Couleur;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_ZoomIn;
        private System.Windows.Forms.Button btn_ZoomOut;
        private System.Windows.Forms.GroupBox groupBox_Outils;
        private System.Windows.Forms.GroupBox groupBox_Formes;
        private System.Windows.Forms.GroupBox groupBox_Fichier;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pictureBox_ColorActual;
        private System.Windows.Forms.PictureBox pictureBox_Color2;
        private System.Windows.Forms.PictureBox pictureBox_Color5;
        private System.Windows.Forms.PictureBox pictureBox_Color3;
        private System.Windows.Forms.PictureBox pictureBox_Color6;
        private System.Windows.Forms.PictureBox pictureBox_Color1;
        private System.Windows.Forms.PictureBox pictureBox_Color4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}