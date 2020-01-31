using System.Drawing;
using System.Windows.Forms;

namespace BilliardsManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.mesaBillar1 = new BilliardsManager.Mesa();
            this.mesaBillar2 = new BilliardsManager.Mesa();
            this.mesaBillar3 = new BilliardsManager.Mesa();
            this.mesaBillar4 = new BilliardsManager.Mesa();
            this.mesaBillar5 = new BilliardsManager.Mesa();
            this.mesaBillar6 = new BilliardsManager.Mesa();
            this.mesaBillar7 = new BilliardsManager.Mesa();
            this.Mesa1 = new BilliardsManager.Mesa();
            this.Mesa2 = new BilliardsManager.Mesa();
            this.Mesa3 = new BilliardsManager.Mesa();
            this.Mesa4 = new BilliardsManager.Mesa();
            this.Mesa5 = new BilliardsManager.Mesa();
            this.Mesa6 = new BilliardsManager.Mesa();
            this.mesaVarios = new BilliardsManager.Mesa();
            this.mesaCocina = new BilliardsManager.Mesa();
            this.mesaBaño = new BilliardsManager.Mesa();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 557);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 548);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mesaBillar1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mesaBillar2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.mesaBillar3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mesaBillar4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mesaBillar5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mesaBillar6, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.mesaBillar7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 542);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 100);
            this.panel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(893, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.25F);
            this.label1.Location = new System.Drawing.Point(150, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(591, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesas de Billar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(802, 591);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoScroll = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.Mesa1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Mesa2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.Mesa3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.Mesa4, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.Mesa5, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.Mesa6, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(796, 585);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.panel2, 2);
            this.panel2.Controls.Add(this.tableLayoutPanel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 100);
            this.panel2.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(773, 100);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.25F);
            this.label2.Location = new System.Drawing.Point(132, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(507, 60);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mesas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(802, 591);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoScroll = true;
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.mesaVarios, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.mesaCocina, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.mesaBaño, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(802, 591);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.tableLayoutPanel5.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.tableLayoutPanel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(779, 100);
            this.panel3.TabIndex = 10;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.Controls.Add(this.pictureBox5, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.pictureBox6, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.Padding = new System.Windows.Forms.Padding(20);
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(779, 100);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.25F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(133, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(511, 60);
            this.label3.TabIndex = 0;
            this.label3.Text = "Otros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::BilliardsManager.Properties.Resources.derecha;
            this.pictureBox2.Location = new System.Drawing.Point(747, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox2.Size = new System.Drawing.Size(123, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BilliardsManager.Properties.Resources.izquierda;
            this.pictureBox1.Location = new System.Drawing.Point(23, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(121, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(645, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox3.Size = new System.Drawing.Size(105, 54);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Image = global::BilliardsManager.Properties.Resources.izquierda2;
            this.pictureBox4.Location = new System.Drawing.Point(23, 23);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox4.Size = new System.Drawing.Size(103, 54);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.ErrorImage = null;
            this.pictureBox5.Image = global::BilliardsManager.Properties.Resources.derecha3;
            this.pictureBox5.Location = new System.Drawing.Point(650, 23);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox5.Size = new System.Drawing.Size(106, 54);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.ErrorImage = null;
            this.pictureBox6.Image = global::BilliardsManager.Properties.Resources.izquierda3;
            this.pictureBox6.Location = new System.Drawing.Point(23, 23);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox6.Size = new System.Drawing.Size(104, 54);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // mesaBillar1
            // 
            this.mesaBillar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mesaBillar1.BackgroundImage")));
            this.mesaBillar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mesaBillar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesaBillar1.Location = new System.Drawing.Point(3, 136);
            this.mesaBillar1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.mesaBillar1.MinimumSize = new System.Drawing.Size(200, 300);
            this.mesaBillar1.Name = "mesaBillar1";
            this.mesaBillar1.Padding = new System.Windows.Forms.Padding(35);
            this.mesaBillar1.Size = new System.Drawing.Size(443, 300);
            this.mesaBillar1.TabIndex = 2;
            // 
            // mesaBillar2
            // 
            this.mesaBillar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mesaBillar2.BackgroundImage")));
            this.mesaBillar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mesaBillar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesaBillar2.Location = new System.Drawing.Point(452, 136);
            this.mesaBillar2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.mesaBillar2.MinimumSize = new System.Drawing.Size(200, 300);
            this.mesaBillar2.Name = "mesaBillar2";
            this.mesaBillar2.Padding = new System.Windows.Forms.Padding(35);
            this.mesaBillar2.Size = new System.Drawing.Size(444, 300);
            this.mesaBillar2.TabIndex = 3;
            // 
            // mesaBillar3
            // 
            this.mesaBillar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mesaBillar3.BackgroundImage")));
            this.mesaBillar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mesaBillar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesaBillar3.Location = new System.Drawing.Point(3, 442);
            this.mesaBillar3.MinimumSize = new System.Drawing.Size(200, 300);
            this.mesaBillar3.Name = "mesaBillar3";
            this.mesaBillar3.Padding = new System.Windows.Forms.Padding(35);
            this.mesaBillar3.Size = new System.Drawing.Size(443, 300);
            this.mesaBillar3.TabIndex = 4;
            // 
            // mesaBillar4
            // 
            this.mesaBillar4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mesaBillar4.BackgroundImage")));
            this.mesaBillar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mesaBillar4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesaBillar4.Location = new System.Drawing.Point(452, 442);
            this.mesaBillar4.MinimumSize = new System.Drawing.Size(200, 300);
            this.mesaBillar4.Name = "mesaBillar4";
            this.mesaBillar4.Padding = new System.Windows.Forms.Padding(35);
            this.mesaBillar4.Size = new System.Drawing.Size(444, 300);
            this.mesaBillar4.TabIndex = 5;
            // 
            // mesaBillar5
            // 
            this.mesaBillar5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mesaBillar5.BackgroundImage")));
            this.mesaBillar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mesaBillar5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesaBillar5.Location = new System.Drawing.Point(3, 748);
            this.mesaBillar5.MinimumSize = new System.Drawing.Size(200, 300);
            this.mesaBillar5.Name = "mesaBillar5";
            this.mesaBillar5.Padding = new System.Windows.Forms.Padding(35);
            this.mesaBillar5.Size = new System.Drawing.Size(443, 300);
            this.mesaBillar5.TabIndex = 6;
            // 
            // mesaBillar6
            // 
            this.mesaBillar6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mesaBillar6.BackgroundImage")));
            this.mesaBillar6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mesaBillar6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesaBillar6.Location = new System.Drawing.Point(452, 748);
            this.mesaBillar6.MinimumSize = new System.Drawing.Size(200, 300);
            this.mesaBillar6.Name = "mesaBillar6";
            this.mesaBillar6.Padding = new System.Windows.Forms.Padding(35);
            this.mesaBillar6.Size = new System.Drawing.Size(444, 300);
            this.mesaBillar6.TabIndex = 7;
            // 
            // mesaBillar7
            // 
            this.mesaBillar7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mesaBillar7.BackgroundImage")));
            this.mesaBillar7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.mesaBillar7, 2);
            this.mesaBillar7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesaBillar7.Location = new System.Drawing.Point(3, 1054);
            this.mesaBillar7.MinimumSize = new System.Drawing.Size(200, 300);
            this.mesaBillar7.Name = "mesaBillar7";
            this.mesaBillar7.Padding = new System.Windows.Forms.Padding(70, 40, 70, 40);
            this.mesaBillar7.Size = new System.Drawing.Size(893, 300);
            this.mesaBillar7.TabIndex = 8;
            // 
            // Mesa1
            // 
            this.Mesa1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mesa1.BackgroundImage")));
            this.Mesa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mesa1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mesa1.Location = new System.Drawing.Point(3, 136);
            this.Mesa1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.Mesa1.MinimumSize = new System.Drawing.Size(200, 300);
            this.Mesa1.Name = "Mesa1";
            this.Mesa1.Padding = new System.Windows.Forms.Padding(35);
            this.Mesa1.Size = new System.Drawing.Size(383, 300);
            this.Mesa1.TabIndex = 12;
            this.Mesa1.Paint += new System.Windows.Forms.PaintEventHandler(this.Mesa1_Paint);
            // 
            // Mesa2
            // 
            this.Mesa2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mesa2.BackgroundImage")));
            this.Mesa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mesa2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mesa2.Location = new System.Drawing.Point(392, 136);
            this.Mesa2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.Mesa2.MinimumSize = new System.Drawing.Size(200, 300);
            this.Mesa2.Name = "Mesa2";
            this.Mesa2.Padding = new System.Windows.Forms.Padding(35);
            this.Mesa2.Size = new System.Drawing.Size(384, 300);
            this.Mesa2.TabIndex = 13;
            // 
            // Mesa3
            // 
            this.Mesa3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mesa3.BackgroundImage")));
            this.Mesa3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mesa3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mesa3.Location = new System.Drawing.Point(3, 442);
            this.Mesa3.MinimumSize = new System.Drawing.Size(200, 300);
            this.Mesa3.Name = "Mesa3";
            this.Mesa3.Padding = new System.Windows.Forms.Padding(35);
            this.Mesa3.Size = new System.Drawing.Size(383, 300);
            this.Mesa3.TabIndex = 14;
            // 
            // Mesa4
            // 
            this.Mesa4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mesa4.BackgroundImage")));
            this.Mesa4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mesa4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mesa4.Location = new System.Drawing.Point(392, 442);
            this.Mesa4.MinimumSize = new System.Drawing.Size(200, 300);
            this.Mesa4.Name = "Mesa4";
            this.Mesa4.Padding = new System.Windows.Forms.Padding(35);
            this.Mesa4.Size = new System.Drawing.Size(384, 300);
            this.Mesa4.TabIndex = 15;
            // 
            // Mesa5
            // 
            this.Mesa5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mesa5.BackgroundImage")));
            this.Mesa5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mesa5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mesa5.Location = new System.Drawing.Point(3, 748);
            this.Mesa5.MinimumSize = new System.Drawing.Size(200, 300);
            this.Mesa5.Name = "Mesa5";
            this.Mesa5.Padding = new System.Windows.Forms.Padding(35);
            this.Mesa5.Size = new System.Drawing.Size(383, 300);
            this.Mesa5.TabIndex = 16;
            // 
            // Mesa6
            // 
            this.Mesa6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mesa6.BackgroundImage")));
            this.Mesa6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mesa6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mesa6.Location = new System.Drawing.Point(392, 748);
            this.Mesa6.MinimumSize = new System.Drawing.Size(200, 300);
            this.Mesa6.Name = "Mesa6";
            this.Mesa6.Padding = new System.Windows.Forms.Padding(35);
            this.Mesa6.Size = new System.Drawing.Size(384, 300);
            this.Mesa6.TabIndex = 17;
            // 
            // mesaVarios
            // 
            this.mesaVarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mesaVarios.BackgroundImage")));
            this.mesaVarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel5.SetColumnSpan(this.mesaVarios, 2);
            this.mesaVarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesaVarios.Location = new System.Drawing.Point(3, 442);
            this.mesaVarios.MinimumSize = new System.Drawing.Size(200, 300);
            this.mesaVarios.Name = "mesaVarios";
            this.mesaVarios.Padding = new System.Windows.Forms.Padding(70, 40, 70, 40);
            this.mesaVarios.Size = new System.Drawing.Size(779, 300);
            this.mesaVarios.TabIndex = 11;
            // 
            // mesaCocina
            // 
            this.mesaCocina.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mesaCocina.BackgroundImage")));
            this.mesaCocina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mesaCocina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesaCocina.Location = new System.Drawing.Point(3, 136);
            this.mesaCocina.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.mesaCocina.MinimumSize = new System.Drawing.Size(200, 300);
            this.mesaCocina.Name = "mesaCocina";
            this.mesaCocina.Padding = new System.Windows.Forms.Padding(35);
            this.mesaCocina.Size = new System.Drawing.Size(386, 300);
            this.mesaCocina.TabIndex = 2;
            // 
            // mesaBaño
            // 
            this.mesaBaño.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mesaBaño.BackgroundImage")));
            this.mesaBaño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mesaBaño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mesaBaño.Location = new System.Drawing.Point(395, 136);
            this.mesaBaño.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.mesaBaño.MinimumSize = new System.Drawing.Size(200, 300);
            this.mesaBaño.Name = "mesaBaño";
            this.mesaBaño.Padding = new System.Windows.Forms.Padding(35);
            this.mesaBaño.Size = new System.Drawing.Size(387, 300);
            this.mesaBaño.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 557);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox4;
        private Mesa Mesa1;
        private Mesa Mesa2;
        private Mesa Mesa3;
        private Mesa Mesa4;
        private Mesa Mesa5;
        private Mesa Mesa6;
        private TableLayoutPanel tableLayoutPanel1;
        private Mesa mesaBillar1;
        private Mesa mesaBillar2;
        private Mesa mesaBillar3;
        private Mesa mesaBillar4;
        private Mesa mesaBillar5;
        private Mesa mesaBillar6;
        private Mesa mesaBillar7;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel5;
        private Mesa mesaVarios;
        private Mesa mesaCocina;
        private Mesa mesaBaño;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel6;
        private PictureBox pictureBox5;
        private Label label3;
        internal PictureBox pictureBox6;
    }
}