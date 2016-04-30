namespace test3_10.othercs
{
    partial class draw_line
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.sav = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zhigh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.zlow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.col = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.row = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.del);
            this.panel1.Controls.Add(this.sav);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.color);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.zhigh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.zlow);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.col);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.row);
            this.panel1.Location = new System.Drawing.Point(45, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 164);
            this.panel1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(86, 139);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(41, 22);
            this.exit.TabIndex = 12;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(48, 139);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(33, 22);
            this.del.TabIndex = 11;
            this.del.Text = "del";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // sav
            // 
            this.sav.Location = new System.Drawing.Point(9, 139);
            this.sav.Name = "sav";
            this.sav.Size = new System.Drawing.Size(33, 22);
            this.sav.TabIndex = 10;
            this.sav.Text = "sav";
            this.sav.UseVisualStyleBackColor = true;
            this.sav.Click += new System.EventHandler(this.sav_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "color";
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(49, 112);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(68, 21);
            this.color.TabIndex = 8;
            this.color.TextChanged += new System.EventHandler(this.color_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "zhigh";
            // 
            // zhigh
            // 
            this.zhigh.Location = new System.Drawing.Point(49, 85);
            this.zhigh.Name = "zhigh";
            this.zhigh.Size = new System.Drawing.Size(68, 21);
            this.zhigh.TabIndex = 6;
            this.zhigh.TextChanged += new System.EventHandler(this.zhigh_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "zlow";
            // 
            // zlow
            // 
            this.zlow.Location = new System.Drawing.Point(49, 58);
            this.zlow.Name = "zlow";
            this.zlow.Size = new System.Drawing.Size(68, 21);
            this.zlow.TabIndex = 4;
            this.zlow.TextChanged += new System.EventHandler(this.zlow_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "col";
            // 
            // col
            // 
            this.col.Location = new System.Drawing.Point(49, 31);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(68, 21);
            this.col.TabIndex = 2;
            this.col.TextChanged += new System.EventHandler(this.col_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "row";
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(49, 4);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(68, 21);
            this.row.TabIndex = 0;
            this.row.TextChanged += new System.EventHandler(this.row_TextChanged);
            // 
            // draw_line
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "draw_line";
            this.Text = "draw_line";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox zhigh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox zlow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox col;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox row;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button sav;
    }
}