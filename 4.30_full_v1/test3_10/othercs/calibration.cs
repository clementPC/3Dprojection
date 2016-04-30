using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test3_10.othercs
{
    public partial class calibration : Form
    {
        public calibration()
        {
            InitializeComponent();
        }

        private void calibration_Load(object sender, EventArgs e)
        {
            this.Paint += calibration_Paint;
            this.MouseDoubleClick += calibration_MouseDoubleClick;
        }

        void calibration_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.exit.Left = e.X;
            this.exit.Top = e.Y;
        }

        void calibration_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen0 = new Pen(Color.Gold, 1); //金
            Pen pen1 = new Pen(Color.Chocolate, 1); //巧克力
            Pen pen2 = new Pen(Color.AliceBlue, 1); //爱丽丝蓝
            Pen pen3 = new Pen(Color.Purple, 1); //紫
            Pen pen4 = new Pen(Color.GreenYellow, 1);  //绿黄
            Pen pen5 = new Pen(Color.Orange, 1); //橙
            Pen pen6 = new Pen(Color.DeepSkyBlue, 1);  //深天空蓝
            Pen pen7 = new Pen(Color.IndianRed, 1);  //偏粉
            Pen pen8 = new Pen(Color.Magenta, 1);  //紫红
            Pen pen9 = new Pen(Color.SaddleBrown, 1);  //棕
            Pen pen10 = new Pen(Color.LightSeaGreen, 1);  //海绿
            Pen pen11 = new Pen(Color.Crimson, 1);  //深红
            Pen pen12 = new Pen(Color.SpringGreen, 1);  //春绿
            Pen pen13 = new Pen(Color.Gold, 1);  //紫罗兰

            pen13.DashStyle = DashStyle.Custom;
            pen13.DashPattern = new float[] { 5f, 60f };

            //row1
            g.DrawLine(pen13, 1, 70, 1220, 75);//(1,1)
            g.DrawLine(pen13, 25, 105, 1190, 105);  //(1,2)
            g.DrawLine(pen13, 1160, 134, 50, 129);  //(1,3)
            g.DrawLine(pen13, 1135, 158, 75, 156);  //(1,4)
            g.DrawLine(pen13, 1110, 183, 100, 180);  //(1,5)    overlap(2,2)
            g.DrawLine(pen13, 1090, 203, 125, 200); //(1,6)    overlap(2,3)
            g.DrawLine(pen13, 1070, 224, 145, 220);//(1,7)
            g.DrawLine(pen13, 165, 239, 1055, 242);//(1,8)
            g.DrawLine(pen13, 1040, 259, 185, 256);//(1,9)
            g.DrawLine(pen13, 200, 272, 1025, 274);//(1,10)  overlap(3,3)
            g.DrawLine(pen13, 1010, 289, 215, 286);//(1,11)
            g.DrawLine(pen13, 995, 303, 230, 300); //(1,12)
            g.DrawLine(pen13, 240, 312, 985, 315); //(1,13)  
            
    
            //row2
            g.DrawLine(pen13, 0, 147, 1217, 150);   //(2,1)
            g.DrawLine(pen13, 1183, 177, 25, 174);  //(2,2)
            g.DrawLine(pen13, 1154, 204, 50, 202);//(2,3)  overlap(1,6)
            g.DrawLine(pen13, 1127, 225, 75, 223);//(2,4)  overlap(1,7)
            g.DrawLine(pen13, 105, 244, 1105, 247);//(2,5)
            g.DrawLine(pen13, 1088, 265, 135, 264);//(2,6)
            g.DrawLine(pen13, 150, 282, 1069, 282);//(2,7)
            g.DrawLine(pen13, 1053, 298, 165, 298);//(2,8)
            g.DrawLine(pen13, 180, 312, 1031, 313);//(2,9) overlap(3,1)
            g.DrawLine(pen13, 1020, 326, 200, 326);//(2,10)  overlap(3,6)  (4,2)
            g.DrawLine(pen13, 217, 338, 1008, 339);//(2,11)  overlap(3,7)
            g.DrawLine(pen13, 229, 350, 992, 350); //(2,12)
            g.DrawLine(pen13, 980, 362, 245, 361);//(2,13)   overlap (4,4)
            
            
            //row3
            g.DrawLine(pen13, 1219, 231, 20, 228);//(3,1)
            g.DrawLine(pen13, 45, 250, 1185, 254);//(3,2)
            g.DrawLine(pen13, 1153, 275, 70, 272);//(3,3) overlap(1,10)
            g.DrawLine(pen13, 90, 291, 1127, 294);//(3,4)
            g.DrawLine(pen13, 1106, 313, 110, 307);//(3,5)  overlap(4,1) (2,9)
            g.DrawLine(pen13, 135, 324, 1080, 329);//(3,6)   overlap(4,2) (2,10)
            g.DrawLine(pen13, 1070, 344, 154, 339);//(3,7)
            g.DrawLine(pen13, 1050, 357, 169, 352);//(3,8)
            g.DrawLine(pen13, 191, 365, 1030, 370);//(3,9)
            g.DrawLine(pen13, 200, 377, 1015, 380);//(3,10)
            g.DrawLine(pen13, 1004, 391, 217, 387);//(3,11) overlap(5,1)(4,6)
            g.DrawLine(pen13, 996, 401, 228, 398);//(3,12)   overlap(5,2)(4,7)
            g.DrawLine(pen13, 243, 407, 980, 410);//(3,13)
            
            
            //row4
            g.DrawLine(pen13, 8, 305, 1205, 307);//(4,1)
            g.DrawLine(pen13, 1170, 331, 45, 327);//(4,2)
            g.DrawLine(pen13, 1140, 346, 70, 342);//(4,3)
            g.DrawLine(pen13, 95, 360, 1122, 362);//(4,4) overlap(2,13)
            g.DrawLine(pen13, 115, 374, 1094, 376); //(4,5)
            g.DrawLine(pen13, 1080, 390, 135, 388);//(4,6) overlap(5,1)
            g.DrawLine(pen13, 1060, 402, 170, 400);//(4,7)  overlap(5,2)
            g.DrawLine(pen13, 180, 411, 1041, 413);//(4,8)
            g.DrawLine(pen13, 1024, 423, 197, 422);//(4,9)
            g.DrawLine(pen13, 209, 431, 1015, 433);//(4,10) overlap(5,4)
            g.DrawLine(pen13, 997, 441, 228, 440);//(4,11)   overlap(5,5)
            g.DrawLine(pen13, 239, 448, 985, 449);//(4,12)  overlap(5,6)
            g.DrawLine(pen13, 977, 456, 255, 456);//(4,13)
           
            

            //row5
            g.DrawLine(pen13, 15, 384, 1208, 391);//(5,1) overlap(4,6)
            g.DrawLine(pen13, 1185, 405, 55, 401);//(5,2)
            g.DrawLine(pen13, 85, 414, 1153, 419);//(5,3)
            g.DrawLine(pen13, 1129, 432, 109, 427);//(5,4)
            g.DrawLine(pen13, 136, 438, 1105, 443);//(5,5)  overlap(4,11)
            g.DrawLine(pen13, 1082, 453, 150, 449);//(5,6)
            g.DrawLine(pen13, 173, 458, 1060, 462);//(5,7)
            g.DrawLine(pen13, 1040, 471, 190, 467);//(5,8)  overlap(6,1)
            g.DrawLine(pen13, 204, 475, 1030, 479);//(5,9)  overlap(6,2)
            g.DrawLine(pen13, 1015, 486, 222, 483);//(5,10)
            g.DrawLine(pen13, 240, 490, 1003, 493);//(5,11)  overlap(6,3)
            g.DrawLine(pen13, 991, 500, 245, 496);//(5,12)  overlap(6,4)
            g.DrawLine(pen13, 259, 502, 980, 505);//(5,13)  overlap(6,5)
            
    
            
            //row6
            g.DrawLine(pen13, 20, 464, 1205, 466);//(6,1)
            g.DrawLine(pen13, 1177, 480, 50, 476);//(6,2) 
            g.DrawLine(pen13, 80, 486, 1153, 487);//(6,3)
            g.DrawLine(pen13, 1126, 498, 105, 495);//(6,4)
            g.DrawLine(pen13, 1104, 506, 134, 504);//(6,5)  overlap(5,13)
            g.DrawLine(pen13, 1080, 514, 160, 512);//(6,6)
            g.DrawLine(pen13, 175, 518, 1060, 519);//(6,7)
            g.DrawLine(pen13, 1048, 527, 196, 525);//(6,8)
            g.DrawLine(pen13, 212, 531, 1035, 532);//(6,9)
            g.DrawLine(pen13, 1023, 537, 222, 536);//(6,10)
            g.DrawLine(pen13, 234, 541, 1008, 543);//(6,11)
            g.DrawLine(pen13, 994, 546, 251, 546);//(6,12)  overlap(7,1)
            g.DrawLine(pen13, 263, 551, 980, 551);//(6,13)  overlap(7,2)
            
            

            //row7
            g.DrawLine(pen13, 24, 541, 1203, 546);  //(7,1) overlap(6,12)
            g.DrawLine(pen13, 1169, 555, 55, 550);//(7,2)  overlap(6,13)
            g.DrawLine(pen13, 80, 555, 1142, 560);//(7,3)
            g.DrawLine(pen13, 1124, 566, 103, 561);//(7,4)
            g.DrawLine(pen13, 130, 566, 1100, 571);//(7,5)
            g.DrawLine(pen13, 1085, 577, 160, 571);//(7,6)
            g.DrawLine(pen13, 182, 576, 1066, 580);//(7,7)
            g.DrawLine(pen13, 1045, 583, 200, 580);//(7,8)
            g.DrawLine(pen13, 216, 584, 1030, 586);//(7,9)
            g.DrawLine(pen13, 1017, 589, 230, 588);//(7,10)
            g.DrawLine(pen13, 246, 590, 1003, 593);//(7,11)
            g.DrawLine(pen13, 986, 596, 260, 593);//(7,12)       
            g.DrawLine(pen13, 275, 596, 967, 599);  //(7,13)
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
