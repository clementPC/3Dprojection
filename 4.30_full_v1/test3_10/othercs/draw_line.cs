using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Drawing.Drawing2D;

namespace test3_10.othercs
{
    class model
    {
        public int _row, _col;
        public double _zlow, _zhigh;
        public int _color;
        public model() { }
        public model(int row, int col, double zlow, double zhigh, int color)
        {
            _row = row;
            _col = col;
            _zlow = zlow;
            _zhigh = zhigh;
            _color = color;
        }
    }

    public partial class draw_line : Form
    {
        private StreamWriter filewrite;
        private Pen pen;
        private int _row, _col;
        private double _zlow, _zhigh;
        private List<model> _models=new List<model>();
        private int num=0;
        public draw_line()
        {
            InitializeComponent();
            filewrite = File.AppendText("draw1.txt");
            pen = new Pen(Color.Red, 1); 
            this.MouseDoubleClick += draw_line_MouseDoubleClick;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //e.Graphics.DrawLines
            base.OnPaint(e);
        }

        void draw_line_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.panel1.Left = e.X;
            this.panel1.Top = e.Y;
            this.Focus();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            filewrite.Close();
            this.Close();
        }

        private void color_TextChanged(object sender, EventArgs e)
        {
            switch (color.Text)
            {
                case "0": pen.Color = Color.Black; break;
                case "1": pen.Color = Color.Red; break;
                case "2": pen.Color = Color.White; break;
                case "3": pen.Color = Color.Purple; break;
                case "4": pen.Color = Color.Yellow; break;
                case "5": pen.Color = Color.Orange; break;
                case "6": pen.Color = Color.Green; break;
                case "7": pen.Color = Color.Blue; break;
                case "8": pen.Color = Color.Gray; break;
                case "9": pen.Color = Color.Brown; break;
                case "10": pen.Color = Color.Pink; break;
                case "11": pen.Color = Color.Gold; break;
                case "12": pen.Color = Color.SpringGreen; break;
                case "13": pen.Color = Color.Silver; break;
                default: pen.Color = Color.Red; break;
            }
        }

        private void row_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.row.Text))
                _models[num]._row = Convert.ToInt32(this.row.Text);
        }

        private void col_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.col.Text))
                _models[num]._col = Convert.ToInt32(this.col.Text);
        }

        private void zlow_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.zlow.Text))
                _models[num]._zlow = Convert.ToDouble(this.zlow.Text);
        }

        private void zhigh_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.zhigh.Text))
                 _models[num]._zhigh = Convert.ToDouble(this.zhigh.Text);
        }

        private void sav_Click(object sender, EventArgs e)
        {
            _models.Add(new model());
            string data = this.row.Text + " " + this.col.Text + " " + this.zlow.Text + " " + this.zhigh.Text + " " + this.color.Text;
            filewrite.WriteLine(data);
            MessageBox.Show("save successfully");
            num++;
        }

        private void del_Click(object sender, EventArgs e)
        {
            num--;
            filewrite.Close();
            List<string> lines = new List<string>(File.ReadAllLines("draw1.txt"));
            lines.RemoveAt(lines.Count() - 1);
            File.WriteAllLines("draw1.txt", lines.ToArray());
            MessageBox.Show("delete successfully one recent data");
            filewrite = File.AppendText("data.txt");
        }
    }
}
