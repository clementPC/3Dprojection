using System.Drawing;
using System.Windows.Forms;

namespace test3_10.othercs
{
    partial class inputdata
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
            this.widMov = new System.Windows.Forms.TextBox();
            this.widMovLabel = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.z = new System.Windows.Forms.TextBox();
            this.zlabel = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.col = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.widCir = new System.Windows.Forms.TextBox();
            this.widCirLable = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.row = new System.Windows.Forms.TextBox();
            this.length = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.TextBox();
            this.ylable = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.TextBox();
            this.xlabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.widMov);
            this.panel1.Controls.Add(this.widMovLabel);
            this.panel1.Controls.Add(this.color);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.z);
            this.panel1.Controls.Add(this.zlabel);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.col);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.widCir);
            this.panel1.Controls.Add(this.widCirLable);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.row);
            this.panel1.Controls.Add(this.length);
            this.panel1.Controls.Add(this.y);
            this.panel1.Controls.Add(this.ylable);
            this.panel1.Controls.Add(this.x);
            this.panel1.Controls.Add(this.xlabel);
            this.panel1.Location = new System.Drawing.Point(45, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 178);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // widMov
            // 
            this.widMov.Location = new System.Drawing.Point(142, 90);
            this.widMov.Name = "widMov";
            this.widMov.Size = new System.Drawing.Size(39, 21);
            this.widMov.TabIndex = 22;
            this.widMov.Text = "1";
            this.widMov.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // widMovLabel
            // 
            this.widMovLabel.AutoSize = true;
            this.widMovLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.widMovLabel.Location = new System.Drawing.Point(99, 93);
            this.widMovLabel.Name = "widMovLabel";
            this.widMovLabel.Size = new System.Drawing.Size(41, 12);
            this.widMovLabel.TabIndex = 21;
            this.widMovLabel.Text = "widMov";
            this.widMovLabel.Click += new System.EventHandler(this.widMov_Click);
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(44, 90);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(47, 21);
            this.color.TabIndex = 20;
            this.color.Text = "0";
            this.color.TextChanged += new System.EventHandler(this.color_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "color";
            // 
            // z
            // 
            this.z.Location = new System.Drawing.Point(22, 63);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(69, 21);
            this.z.TabIndex = 18;
            this.z.Text = "1";
            this.z.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // zlabel
            // 
            this.zlabel.AutoSize = true;
            this.zlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.zlabel.Location = new System.Drawing.Point(5, 66);
            this.zlabel.Name = "zlabel";
            this.zlabel.Size = new System.Drawing.Size(11, 12);
            this.zlabel.TabIndex = 17;
            this.zlabel.Text = "z";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(7, 148);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(58, 23);
            this.exit.TabIndex = 16;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // col
            // 
            this.col.Location = new System.Drawing.Point(133, 36);
            this.col.Name = "col";
            this.col.Size = new System.Drawing.Size(48, 21);
            this.col.TabIndex = 15;
            this.col.Text = "0";
            this.col.TextChanged += new System.EventHandler(this.col_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(99, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "col";
            // 
            // widCir
            // 
            this.widCir.Location = new System.Drawing.Point(142, 63);
            this.widCir.Name = "widCir";
            this.widCir.Size = new System.Drawing.Size(39, 21);
            this.widCir.TabIndex = 13;
            this.widCir.Text = "1";
            this.widCir.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // widCirLable
            // 
            this.widCirLable.AutoSize = true;
            this.widCirLable.ForeColor = System.Drawing.SystemColors.Control;
            this.widCirLable.Location = new System.Drawing.Point(99, 66);
            this.widCirLable.Name = "widCirLable";
            this.widCirLable.Size = new System.Drawing.Size(41, 12);
            this.widCirLable.TabIndex = 12;
            this.widCirLable.Text = "widCir";
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(133, 148);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(64, 23);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button6_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(78, 148);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(44, 23);
            this.save.TabIndex = 10;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button5_Click);
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(133, 6);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(48, 21);
            this.row.TabIndex = 7;
            this.row.Text = "0";
            this.row.TextChanged += new System.EventHandler(this.row_TextChanged);
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.ForeColor = System.Drawing.SystemColors.Control;
            this.length.Location = new System.Drawing.Point(99, 9);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(23, 12);
            this.length.TabIndex = 6;
            this.length.Text = "row";
            this.length.Click += new System.EventHandler(this.length_Click);
            // 
            // y
            // 
            this.y.Location = new System.Drawing.Point(22, 33);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(70, 21);
            this.y.TabIndex = 5;
            this.y.Text = "0";
            this.y.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ylable
            // 
            this.ylable.AutoSize = true;
            this.ylable.ForeColor = System.Drawing.SystemColors.Control;
            this.ylable.Location = new System.Drawing.Point(4, 36);
            this.ylable.Name = "ylable";
            this.ylable.Size = new System.Drawing.Size(11, 12);
            this.ylable.TabIndex = 4;
            this.ylable.Text = "y";
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(22, 6);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(70, 21);
            this.x.TabIndex = 3;
            this.x.Text = "0";
            this.x.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // xlabel
            // 
            this.xlabel.AutoSize = true;
            this.xlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.xlabel.Location = new System.Drawing.Point(5, 9);
            this.xlabel.Name = "xlabel";
            this.xlabel.Size = new System.Drawing.Size(11, 12);
            this.xlabel.TabIndex = 2;
            this.xlabel.Text = "x";
            // 
            // inputdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "inputdata";
            this.Text = "inputdata";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox row;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.TextBox y;
        private System.Windows.Forms.Label ylable;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.Label xlabel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox widCir;
        private System.Windows.Forms.Label widCirLable;
        private System.Windows.Forms.TextBox col;
        private System.Windows.Forms.Label label1;
        private Button exit;
        private TextBox z;
        private Label zlabel;
        private TextBox color;
        private Label label2;
        private TextBox widMov;
        private Label widMovLabel;
    }
}