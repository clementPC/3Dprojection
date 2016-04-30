using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

using System.IO;

namespace test3_10.othercs
{
    class draw1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Pen pen;
        private Pen pen1;
        private Graphics g;
        private Button button1;
        private System.Windows.Forms.Button exit;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

//draw1  -------for Form1
        public draw1()
        {
            InitializeComponent();
            pen = new Pen(Color.Gold, 1);
            pen1 = new Pen(Color.Yellow, 1);
            pen.DashStyle = DashStyle.Custom;
            pen.DashPattern = new float[] { 4f, 40f };
            g = this.CreateGraphics();            
        }

        private void InitializeComponent()
        {
            this.exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(12, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "save";
            this.button1.Size = new System.Drawing.Size(75, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Top = 0;
            this.Left = 0;
            this.ClientSize = new System.Drawing.Size(2560, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "draw1";
            this.Text = "draw1";
            this.Load += new System.EventHandler(this.calibration_Load);
            this.ResumeLayout(false);

        }
        private void calibration_Load(object sender, EventArgs e)
        {
            this.Paint += calibration_Paint;
        }
        void calibration_Paint(object sender, PaintEventArgs e)
        {
            drawpic();
            //g.DrawLine(pen, 1129, 432, 109, 426);
            //g.DrawLine(pen, 1082, 454, 150, 448);//(5,6)
            //g.DrawLine(pen, 173, 458, 1070, 462);//(5,7)
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void changecolor(int color)
        {
            switch (color)
            {
                case 0: pen.Color = Color.Black; break;
                case 1: pen.Color = Color.Red; break;
                case 2: pen.Color = Color.White; break;
                case 3: pen.Color = Color.Purple; break;
                case 4: pen.Color = Color.Yellow; break;
                case 5: pen.Color = Color.Orange; break;
                case 6: pen.Color = Color.Green; break;
                case 7: pen.Color = Color.Blue; break;
                case 8: pen.Color = Color.Gray; break;
                case 9: pen.Color = Color.Brown; break;
                case 10: pen.Color = Color.Pink; break;
                case 11: pen.Color = Color.SpringGreen; break;
                case 12: pen.Color = Color.SpringGreen; break;
                case 13: pen.Color = Color.Silver; break;
                default: pen.Color = Color.Red; break;
            }
        }

        private void convert(List<string> lines,int row,int col,double z1,double z2,int right){
            string[] cor_ref1 = lines[(row-1) * 26 + col*2-2].Split();
            string[] cor_ref2 = lines[(row-1) * 26 + col*2-1].Split();
            int x1 = (Convert.ToInt32(cor_ref1[3]) > Convert.ToInt32(cor_ref2[3])) ? Convert.ToInt32(cor_ref1[3]) : Convert.ToInt32(cor_ref2[3]);
            int y1 = (Convert.ToInt32(cor_ref1[4]) > Convert.ToInt32(cor_ref2[4])) ? Convert.ToInt32(cor_ref1[4]) : Convert.ToInt32(cor_ref2[4]);
            int x2 = (Convert.ToInt32(cor_ref1[3]) < Convert.ToInt32(cor_ref2[3])) ? Convert.ToInt32(cor_ref1[3]) : Convert.ToInt32(cor_ref2[3]);
            int y2 = (Convert.ToInt32(cor_ref1[4]) < Convert.ToInt32(cor_ref2[4])) ? Convert.ToInt32(cor_ref1[4]) : Convert.ToInt32(cor_ref2[4]);
            int _x1, _y1, _x2, _y2;
            _x1 = (int)((x1 - x2) * z1 + x2);
            _y1 = (int)((y1 - y2) * z1 + y2);
            _x2 = (int)((x1 - x2) * z2 + x2);
            _y2 = (int)((y1 - y2) * z2 + y2);
            if (right == 1)
            {
                _x1 += 1280;
                _x2 += 1280;
            }

            g.DrawLine(pen, _x1, _y1,_x2, _y2);
        }
        private void drawpic()
        {
            String input;
            int row, col, color;
            double z1, z2;
            List<string> lines = new List<string>(File.ReadAllLines("data.txt"));
            //lines.AddRange(File.ReadAllLines("4_21cylinder32.txt"));
            //路径为数据文本所在文件夹
            StreamReader sr = File.OpenText(@"4_21cylinder31.txt");    //sr = reference
            while ((input = sr.ReadLine()) != null)
            {
                string[] arrays_sr = input.Split();
                if (arrays_sr.Count() == 5)
                { 
                row = Convert.ToInt32(arrays_sr[0]);
                col = Convert.ToInt32(arrays_sr[1]);
                z1 = Convert.ToDouble(arrays_sr[2]);
                z2 = Convert.ToDouble(arrays_sr[3]);
                color = Convert.ToInt32(arrays_sr[4]);
                if (color != 0)
                    changecolor(color);
                    convert(lines,row, col, z1, z2,0);
                }
            }
            sr = File.OpenText(@"4_21cylinder32.txt");    //sr = reference
            while ((input = sr.ReadLine()) != null)
            {
                string[] arrays_sr = input.Split();
                if (arrays_sr.Count() == 5)
                {
                    row = Convert.ToInt32(arrays_sr[0]);
                    col = Convert.ToInt32(arrays_sr[1]);
                    z1 = Convert.ToDouble(arrays_sr[2]);
                    z2 = Convert.ToDouble(arrays_sr[3]);
                    color = Convert.ToInt32(arrays_sr[4]);
                    if (color != 0)
                        changecolor(color);
                    convert(lines, row, col, z1, z2,1);
                }
            }
            sr.Close();
        }
        
        private void FormCpy()
        {
            string sFileName = "";
            string sPath = @"C:\用户\clement\Desktop\"; //path different
            Random rnd = new Random();
            int width = 0;
            int heigh = 0;
            width = 2560;
            heigh = 768;
            Image myImage = new Bitmap(width, heigh);
            
            System.Reflection.Assembly ass = System.Reflection.Assembly.GetExecutingAssembly();
            sFileName = sPath + DateTime.Now.ToString("yyyyMMddHHmm") + ".jpg";
            Graphics g = Graphics.FromImage(myImage);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(width, heigh));
            myImage.Save(sFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormCpy();
        }
    }
}
