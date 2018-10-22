using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace jigsaw_puzzle
{

    public partial class FormRisk : Form
    {
        FormMenu fm;
        public FormRisk(FormMenu fm1)
        {
            InitializeComponent();
            fm = fm1;

        }

        PictureBox[,] pictureBox = new PictureBox[3, 3]; 
        int n = 1;  //图片计数
        int step = 0;  //步数
        int width,height;  //窗体大小
        Image picture;  //图片
        int min = 0, sec = 0;  //计时
        Form pictureForm = new Form();  //查看原图窗体
        int perform = 0; //开始游戏后的窗体大小改变
         
        private void FormRisk_Load(object sender, EventArgs e)
        {
            width = this.Width;
            height = this.Height;
            CutPicture(width, height);
            panel1.Visible = false;
        } //窗体载入

        private void FormRisk_FormClosed(object sender, FormClosedEventArgs e)
        {
            fm.Show();
            fm.Visible = true;
            fm.Size = this.Size;
            fm.Location = this.Location;
            pictureForm.Close();
        } //窗体关闭，显示主菜单界面，位置大小与现在相同。

        private void CutPicture(int width, int height)
        {
            label1.Text = "";
            label2.Text = "当前关卡：" + n.ToString() + "/10";
            picture = Image.FromFile(@"..\素材\图片\" + n + ".jpg");
            int pictureWidth = picture.Width, picureHeigth = picture.Height;
            Bitmap btp;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    btp = new Bitmap(pictureWidth, picureHeigth);
                    Rectangle r2 = new Rectangle(i * pictureWidth / 3, j * picureHeigth / 3, pictureWidth / 3, picureHeigth / 3);
                    Rectangle r1 = new Rectangle(0, 0, pictureWidth, picureHeigth);
                    Graphics g = Graphics.FromImage(btp);
                    g.DrawImage(picture, r1, r2, GraphicsUnit.Pixel);
                    pictureBox[i, j] = new PictureBox();
                    pictureBox[i, j].Image = btp;
                    pictureBox[i, j].Location = new Point(50 + i * (width / 4 + 1), 50 + j * (height / 4 + 1));
                    pictureBox[i, j].Size = new Size(width / 4, height / 4);
                    Controls.Add(pictureBox[i, j]);
                    pictureBox[i, j].BringToFront();
                    pictureBox[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        } //图片切割

        private void buttonFind_Click(object sender, EventArgs e)
        {
            pictureForm = new Form();
            pictureForm.BackgroundImage = picture;
            pictureForm.BackgroundImageLayout = ImageLayout.Stretch;
            pictureForm.Height = 200;
            pictureForm.Width = 200;
            pictureForm.Show();
            pictureForm.Location = new Point(width+this.Location .X+30 , this.Location .Y );
        } //查看原图

        private void buttonStart_Click(object sender, EventArgs e)
        {
            perform = 1;
            timer1.Enabled = true;
            sec = 0; min = 0; step = 0;
            Random rd = new Random();
            int[] a = new int[3];
            int[] b = new int[3];
            do
            {
                a[0] = rd.Next(0, 3);
                a[1] = rd.Next(0, 3);
                a[2] = rd.Next(0, 3);
            } while (a[0] == a[1] || a[0] == a[2] || a[1] == a[2]);
            do
            {
                b[0] = rd.Next(0, 3);
                b[1] = rd.Next(0, 3);
                b[2] = rd.Next(0, 3);
            } while (b[0] == b[1] || b[0] == b[2] || b[1] == b[2]);
            int m = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    pictureBox[i, j].MouseDown +=new MouseEventHandler(pictureBox_MouseDown);
                    pictureBox[a[i], b[j]].Location = new Point(10+m*5, 50 + m*20);
                    m++;
                }
            }
            panel1.Visible = true;
            panel1.Width = width / 4 * 3;
            panel1.Height = height / 4 * 3;
            panel1.Location = new Point(130,50);
        } //开始游戏

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec == 60)
            {
                min++;
                sec = 0;
            }
            if (min <= 2)
            {
                if (sec < 10)
                {
                    label1.Text = "已用时间： 0" + min.ToString() + ":0" + sec.ToString() + "     已走步数： " + step.ToString() ;

                }
                if (sec > 9)
                {
                    label1.Text = "已用时间： 0" + min.ToString() + ":" + sec.ToString() + "     已走步数： " + step.ToString() ;
                }
            }
            if (min == 2)
            {
                if (sec == 0)
                {
                    timer1.Enabled = false;
                    
                   DialogResult result= MessageBox.Show("时间到,挑战失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   if (result ==DialogResult.OK )
                   {
                       this.Close();
                   }
                }
            }
        }  //计时
       
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        { 
            PictureBox pic = (PictureBox)sender;
       
            if (e.Button == MouseButtons.Left)
        
            {
            pic.MouseMove +=new MouseEventHandler(pictureBox_MouseMove);
            step++;
            }
        }
        
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;
                int x = this.Left;
                int y = this.Top;
                pic.Location = new Point(MousePosition.X - x - width / 6, MousePosition.Y - y - height / 6);
                pic.BringToFront();
                pic.MouseUp +=new MouseEventHandler(pictureBox_MouseUp);  
            }
            
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;
                int s = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int picX = 130 + i * (width / 4), picY = 50 + j * (height / 4);
                        if ((pictureBox[i, j].Location.X < picX + 15 && pictureBox[i, j].Location.X > picX - 15) && (pictureBox[i, j].Location.Y > picY - 15 && pictureBox[i, j].Location.Y < picY + 15))
                        {
                            s++;
                            pictureBox[i, j].Location = new Point(picX, picY);
                         }
                    }
                }
                
                if (s == 9)
                {
                    timer1.Enabled = false;
                    for (int i = 0; i < 3; i++)
			        {
                        for (int j = 0; j < 3; j++)
                        {
                            pictureBox [i ,j].Visible =false ;
                        }
                    }
                     panel1.Visible = false;
                     n++;
                     perform = 0;
                     if (n <11)
                     {
                         MessageBox.Show("进入下一关", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                     }
                     if (n==11)
                        {
                            pictureForm.Close();
                            DialogResult result1= MessageBox.Show("闯关成功，返回主菜单", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (result1==DialogResult .OK )
                            {
                                this.Close();
                            }
                        }
                      CutPicture(width,height );
                      if (pictureForm.Visible == true)
                      {
                          pictureForm.BackgroundImage = picture;
                      }
                    }  
                }
            }

        private void FormRisk_SizeChanged(object sender, EventArgs e)
        {
            if (perform ==1)
            {
                buttonStart.PerformClick();
            }
            
        }
        
    }
  
}



        





    


