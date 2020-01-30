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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelMesaBillar3 = new BilliardsManager.PanelMesaBillar();
            this.panelMesaBillar4 = new BilliardsManager.PanelMesaBillar();
            this.panelMesaBillar5 = new BilliardsManager.PanelMesaBillar();
            this.panelMesaBillar7 = new BilliardsManager.PanelMesaBillar();
            this.panelMesaBillar1 = new BilliardsManager.PanelMesaBillar();
            this.panelMesaBillar2 = new BilliardsManager.PanelMesaBillar();
            this.panelMesaBillar8 = new BilliardsManager.PanelMesaBillar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 654);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(961, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelMesaBillar3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelMesaBillar4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelMesaBillar5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelMesaBillar7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelMesaBillar1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelMesaBillar2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panelMesaBillar8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(955, 622);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panelMesaBillar3
            // 
            this.panelMesaBillar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMesaBillar3.BackgroundImage")));
            this.panelMesaBillar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMesaBillar3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesaBillar3.Location = new System.Drawing.Point(3, 109);
            this.panelMesaBillar3.MinimumSize = new System.Drawing.Size(200, 300);
            this.panelMesaBillar3.Name = "panelMesaBillar3";
            this.panelMesaBillar3.Size = new System.Drawing.Size(471, 300);
            this.panelMesaBillar3.TabIndex = 2;
            // 
            // panelMesaBillar4
            // 
            this.panelMesaBillar4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMesaBillar4.BackgroundImage")));
            this.panelMesaBillar4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMesaBillar4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesaBillar4.Location = new System.Drawing.Point(480, 109);
            this.panelMesaBillar4.MinimumSize = new System.Drawing.Size(200, 300);
            this.panelMesaBillar4.Name = "panelMesaBillar4";
            this.panelMesaBillar4.Size = new System.Drawing.Size(472, 300);
            this.panelMesaBillar4.TabIndex = 3;
            // 
            // panelMesaBillar5
            // 
            this.panelMesaBillar5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMesaBillar5.BackgroundImage")));
            this.panelMesaBillar5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMesaBillar5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesaBillar5.Location = new System.Drawing.Point(3, 415);
            this.panelMesaBillar5.MinimumSize = new System.Drawing.Size(200, 300);
            this.panelMesaBillar5.Name = "panelMesaBillar5";
            this.panelMesaBillar5.Size = new System.Drawing.Size(471, 300);
            this.panelMesaBillar5.TabIndex = 4;
            // 
            // panelMesaBillar7
            // 
            this.panelMesaBillar7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMesaBillar7.BackgroundImage")));
            this.panelMesaBillar7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMesaBillar7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesaBillar7.Location = new System.Drawing.Point(480, 415);
            this.panelMesaBillar7.MinimumSize = new System.Drawing.Size(200, 300);
            this.panelMesaBillar7.Name = "panelMesaBillar7";
            this.panelMesaBillar7.Size = new System.Drawing.Size(472, 300);
            this.panelMesaBillar7.TabIndex = 5;
            // 
            // panelMesaBillar1
            // 
            this.panelMesaBillar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMesaBillar1.BackgroundImage")));
            this.panelMesaBillar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMesaBillar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesaBillar1.Location = new System.Drawing.Point(3, 721);
            this.panelMesaBillar1.MinimumSize = new System.Drawing.Size(200, 300);
            this.panelMesaBillar1.Name = "panelMesaBillar1";
            this.panelMesaBillar1.Size = new System.Drawing.Size(471, 300);
            this.panelMesaBillar1.TabIndex = 6;
            // 
            // panelMesaBillar2
            // 
            this.panelMesaBillar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMesaBillar2.BackgroundImage")));
            this.panelMesaBillar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMesaBillar2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesaBillar2.Location = new System.Drawing.Point(480, 721);
            this.panelMesaBillar2.MinimumSize = new System.Drawing.Size(200, 300);
            this.panelMesaBillar2.Name = "panelMesaBillar2";
            this.panelMesaBillar2.Size = new System.Drawing.Size(472, 300);
            this.panelMesaBillar2.TabIndex = 7;
            // 
            // panelMesaBillar8
            // 
            this.panelMesaBillar8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMesaBillar8.BackgroundImage")));
            this.panelMesaBillar8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMesaBillar8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMesaBillar8.Location = new System.Drawing.Point(3, 1027);
            this.panelMesaBillar8.MinimumSize = new System.Drawing.Size(200, 300);
            this.panelMesaBillar8.Name = "panelMesaBillar8";
            this.panelMesaBillar8.Size = new System.Drawing.Size(471, 300);
            this.panelMesaBillar8.TabIndex = 8;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 100);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.25F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(949, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesas de Billar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 654);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private PanelMesaBillar panelMesaBillar3;
        private PanelMesaBillar panelMesaBillar4;
        private PanelMesaBillar panelMesaBillar5;
        private PanelMesaBillar panelMesaBillar7;
        private PanelMesaBillar panelMesaBillar1;
        private PanelMesaBillar panelMesaBillar2;
        private PanelMesaBillar panelMesaBillar8;
        private TabPage tabPage2;
        private Panel panel1;
        private Label label1;
    }
}