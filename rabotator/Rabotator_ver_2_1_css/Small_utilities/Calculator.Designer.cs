namespace Rabotator.Small_utilities
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.valueLabelPlus = new System.Windows.Forms.Label();
            this.valueLabel7 = new System.Windows.Forms.Label();
            this.valueLabelDot = new System.Windows.Forms.Label();
            this.valueLabelDel = new System.Windows.Forms.Label();
            this.valueLabel8 = new System.Windows.Forms.Label();
            this.valueLabel9 = new System.Windows.Forms.Label();
            this.valueLabel0 = new System.Windows.Forms.Label();
            this.valueLabelSlash = new System.Windows.Forms.Label();
            this.valueLabelMinus = new System.Windows.Forms.Label();
            this.valueLabel4 = new System.Windows.Forms.Label();
            this.valueLabel3 = new System.Windows.Forms.Label();
            this.valueLabel5 = new System.Windows.Forms.Label();
            this.valueLabel2 = new System.Windows.Forms.Label();
            this.valueLabel6 = new System.Windows.Forms.Label();
            this.valueLabel1 = new System.Windows.Forms.Label();
            this.valueLabelStar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rabotator.Properties.Resources.Dark_exit_closethesession_close_6317;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.valueLabelPlus, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.valueLabel7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.valueLabelDot, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.valueLabelDel, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.valueLabel8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.valueLabel9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.valueLabel0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.valueLabelSlash, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.valueLabelMinus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.valueLabel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.valueLabel3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.valueLabel5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.valueLabel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.valueLabel6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.valueLabel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.valueLabelStar, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 82);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(331, 294);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // valueLabelPlus
            // 
            this.valueLabelPlus.AutoSize = true;
            this.valueLabelPlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabelPlus.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabelPlus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabelPlus.Location = new System.Drawing.Point(250, 220);
            this.valueLabelPlus.Name = "valueLabelPlus";
            this.valueLabelPlus.Size = new System.Drawing.Size(77, 73);
            this.valueLabelPlus.TabIndex = 0;
            this.valueLabelPlus.Text = "+";
            this.valueLabelPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabelPlus.Click += new System.EventHandler(this.Label_Click);
            this.valueLabelPlus.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabelPlus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabel7
            // 
            this.valueLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.valueLabel7.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabel7.Location = new System.Drawing.Point(1, 1);
            this.valueLabel7.Margin = new System.Windows.Forms.Padding(0);
            this.valueLabel7.Name = "valueLabel7";
            this.valueLabel7.Size = new System.Drawing.Size(81, 72);
            this.valueLabel7.TabIndex = 0;
            this.valueLabel7.Text = "7";
            this.valueLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabel7.Click += new System.EventHandler(this.Label_Click);
            this.valueLabel7.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabel7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabelDot
            // 
            this.valueLabelDot.AutoSize = true;
            this.valueLabelDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabelDot.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabelDot.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabelDot.Location = new System.Drawing.Point(86, 220);
            this.valueLabelDot.Name = "valueLabelDot";
            this.valueLabelDot.Size = new System.Drawing.Size(75, 73);
            this.valueLabelDot.TabIndex = 0;
            this.valueLabelDot.Text = ".";
            this.valueLabelDot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabelDot.Click += new System.EventHandler(this.Label_Click);
            this.valueLabelDot.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabelDot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabelDel
            // 
            this.valueLabelDel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueLabelDel.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabelDel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabelDel.Location = new System.Drawing.Point(168, 220);
            this.valueLabelDel.Name = "valueLabelDel";
            this.valueLabelDel.Size = new System.Drawing.Size(75, 73);
            this.valueLabelDel.TabIndex = 0;
            this.valueLabelDel.Text = "DEL";
            this.valueLabelDel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabelDel.Click += new System.EventHandler(this.ValueLabelDel_Click);
            this.valueLabelDel.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabelDel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabel8
            // 
            this.valueLabel8.AutoSize = true;
            this.valueLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabel8.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabel8.Location = new System.Drawing.Point(86, 1);
            this.valueLabel8.Name = "valueLabel8";
            this.valueLabel8.Size = new System.Drawing.Size(75, 72);
            this.valueLabel8.TabIndex = 0;
            this.valueLabel8.Text = "8";
            this.valueLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabel8.Click += new System.EventHandler(this.Label_Click);
            this.valueLabel8.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabel8.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabel9
            // 
            this.valueLabel9.AutoSize = true;
            this.valueLabel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabel9.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel9.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabel9.Location = new System.Drawing.Point(168, 1);
            this.valueLabel9.Name = "valueLabel9";
            this.valueLabel9.Size = new System.Drawing.Size(75, 72);
            this.valueLabel9.TabIndex = 0;
            this.valueLabel9.Text = "9";
            this.valueLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabel9.Click += new System.EventHandler(this.Label_Click);
            this.valueLabel9.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabel9.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabel0
            // 
            this.valueLabel0.AutoSize = true;
            this.valueLabel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabel0.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel0.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabel0.Location = new System.Drawing.Point(4, 220);
            this.valueLabel0.Name = "valueLabel0";
            this.valueLabel0.Size = new System.Drawing.Size(75, 73);
            this.valueLabel0.TabIndex = 0;
            this.valueLabel0.Text = "0";
            this.valueLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabel0.Click += new System.EventHandler(this.Label_Click);
            this.valueLabel0.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabel0.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabelSlash
            // 
            this.valueLabelSlash.AutoSize = true;
            this.valueLabelSlash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabelSlash.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabelSlash.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabelSlash.Location = new System.Drawing.Point(250, 1);
            this.valueLabelSlash.Name = "valueLabelSlash";
            this.valueLabelSlash.Size = new System.Drawing.Size(77, 72);
            this.valueLabelSlash.TabIndex = 0;
            this.valueLabelSlash.Text = "/";
            this.valueLabelSlash.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabelSlash.Click += new System.EventHandler(this.Label_Click);
            this.valueLabelSlash.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabelSlash.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabelMinus
            // 
            this.valueLabelMinus.AutoSize = true;
            this.valueLabelMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabelMinus.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabelMinus.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabelMinus.Location = new System.Drawing.Point(250, 147);
            this.valueLabelMinus.Name = "valueLabelMinus";
            this.valueLabelMinus.Size = new System.Drawing.Size(77, 72);
            this.valueLabelMinus.TabIndex = 0;
            this.valueLabelMinus.Text = "-";
            this.valueLabelMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabelMinus.Click += new System.EventHandler(this.Label_Click);
            this.valueLabelMinus.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabelMinus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabel4
            // 
            this.valueLabel4.AutoSize = true;
            this.valueLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabel4.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabel4.Location = new System.Drawing.Point(4, 74);
            this.valueLabel4.Name = "valueLabel4";
            this.valueLabel4.Size = new System.Drawing.Size(75, 72);
            this.valueLabel4.TabIndex = 0;
            this.valueLabel4.Text = "4";
            this.valueLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabel4.Click += new System.EventHandler(this.Label_Click);
            this.valueLabel4.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabel3
            // 
            this.valueLabel3.AutoSize = true;
            this.valueLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabel3.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabel3.Location = new System.Drawing.Point(168, 147);
            this.valueLabel3.Name = "valueLabel3";
            this.valueLabel3.Size = new System.Drawing.Size(75, 72);
            this.valueLabel3.TabIndex = 0;
            this.valueLabel3.Text = "3";
            this.valueLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabel3.Click += new System.EventHandler(this.Label_Click);
            this.valueLabel3.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabel5
            // 
            this.valueLabel5.AutoSize = true;
            this.valueLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabel5.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabel5.Location = new System.Drawing.Point(86, 74);
            this.valueLabel5.Name = "valueLabel5";
            this.valueLabel5.Size = new System.Drawing.Size(75, 72);
            this.valueLabel5.TabIndex = 0;
            this.valueLabel5.Text = "5";
            this.valueLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabel5.Click += new System.EventHandler(this.Label_Click);
            this.valueLabel5.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabel2
            // 
            this.valueLabel2.AutoSize = true;
            this.valueLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabel2.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabel2.Location = new System.Drawing.Point(86, 147);
            this.valueLabel2.Name = "valueLabel2";
            this.valueLabel2.Size = new System.Drawing.Size(75, 72);
            this.valueLabel2.TabIndex = 0;
            this.valueLabel2.Text = "2";
            this.valueLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabel2.Click += new System.EventHandler(this.Label_Click);
            this.valueLabel2.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabel6
            // 
            this.valueLabel6.AutoSize = true;
            this.valueLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabel6.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabel6.Location = new System.Drawing.Point(168, 74);
            this.valueLabel6.Name = "valueLabel6";
            this.valueLabel6.Size = new System.Drawing.Size(75, 72);
            this.valueLabel6.TabIndex = 0;
            this.valueLabel6.Text = "6";
            this.valueLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabel6.Click += new System.EventHandler(this.Label_Click);
            this.valueLabel6.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabel1
            // 
            this.valueLabel1.AutoSize = true;
            this.valueLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabel1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabel1.Location = new System.Drawing.Point(4, 147);
            this.valueLabel1.Name = "valueLabel1";
            this.valueLabel1.Size = new System.Drawing.Size(75, 72);
            this.valueLabel1.TabIndex = 0;
            this.valueLabel1.Text = "1";
            this.valueLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabel1.Click += new System.EventHandler(this.Label_Click);
            this.valueLabel1.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // valueLabelStar
            // 
            this.valueLabelStar.AutoSize = true;
            this.valueLabelStar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueLabelStar.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueLabelStar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.valueLabelStar.Location = new System.Drawing.Point(250, 74);
            this.valueLabelStar.Name = "valueLabelStar";
            this.valueLabelStar.Size = new System.Drawing.Size(77, 72);
            this.valueLabelStar.TabIndex = 0;
            this.valueLabelStar.Text = "*";
            this.valueLabelStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.valueLabelStar.Click += new System.EventHandler(this.Label_Click);
            this.valueLabelStar.MouseLeave += new System.EventHandler(this.Label_MouseLeave);
            this.valueLabelStar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label_MouseMove);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(329, 83);
            this.textBox1.TabIndex = 2;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(331, 376);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculator_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Calculator_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label valueLabelPlus;
        private System.Windows.Forms.Label valueLabelDel;
        private System.Windows.Forms.Label valueLabelDot;
        private System.Windows.Forms.Label valueLabel0;
        private System.Windows.Forms.Label valueLabelMinus;
        private System.Windows.Forms.Label valueLabel3;
        private System.Windows.Forms.Label valueLabel2;
        private System.Windows.Forms.Label valueLabel1;
        private System.Windows.Forms.Label valueLabelStar;
        private System.Windows.Forms.Label valueLabel6;
        private System.Windows.Forms.Label valueLabel5;
        private System.Windows.Forms.Label valueLabel4;
        private System.Windows.Forms.Label valueLabelSlash;
        private System.Windows.Forms.Label valueLabel9;
        private System.Windows.Forms.Label valueLabel8;
        private System.Windows.Forms.Label valueLabel7;
        private System.Windows.Forms.TextBox textBox1;
    }
}