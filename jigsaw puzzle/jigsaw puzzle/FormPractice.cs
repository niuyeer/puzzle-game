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
    public partial class FormPractice : Form
    {
        FormMenu fm;
        public FormPractice(FormMenu fm1)
        {
            InitializeComponent();
            fm = fm1;
        }

        PictureBox[,] pictureBox= new PictureBox[3,3]; 
        int width, height;  //窗体大小
        Image picture;  //图片
        Form pictureForm = new Form();  //查看原图窗体
        string fileName;
        bool flag; 
        PictureBox pic1; 
        int temp1 = 0, temp2 = 0;
        int step = 0;
        
        private void FormPractise_Load(object sender, EventArgs e)
        {
            width = this.Width;
            height = this.Height;
        }

        private void FormPractise_FormClosed(object sender, FormClosedEventArgs e)
        {
            fm.Show();
            fm.Size = this.Size;
            fm.Location = this.Location;
            pictureForm.Close();
            
        }//窗体关闭，显示主菜单界面，位置大小与现在相同。

        private void CutPicture(int width, int height)
        {
            try
            {
                picture = Image.FromFile(fileName);
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
                        pictureBox[i, j].BorderStyle = BorderStyle.Fixed3D;
                    }
                }
            }
            catch
            {
 
            }
           
        }  //切割图片

        private void buttonFind_Click(object sender, EventArgs e)
        {
            pictureForm = new Form();
            pictureForm.BackgroundImage = picture;
            pictureForm.BackgroundImageLayout = ImageLayout.Stretch;
            pictureForm.Height = 200;
            pictureForm.Width = 200;
            pictureForm.Show();
            pictureForm.Location = new Point(width + this.Location.X + 30, this.Location.Y);
        }  //查看原始图片
       
        private void button1Add_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                fileName = openFileDialog1.FileName;
                CutPicture(width, height);
                Random rd = new Random();
                int[] a = new int[3];
                int[] b = new int[3];
                temp1 = 0; temp2 = 0;
                flag = false;
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
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        pictureBox[a[i], b[j]].Location = new Point(50 + i * (width / 4 + 1), 50 + j * (height / 4 + 1));
                        pictureBox[i, j].Click += new EventHandler(swap);
                    }
                }
            }
        }  //添加图片
        
        private void swap(object sender, EventArgs e)
        {
            step++;
            label1.Text = "已走步数：  " + (step / 2).ToString();
            //这里处理公共事件,根据单击交换数组元素； 
            PictureBox bClick = (PictureBox)sender;
            int  temp3,temp4;   
            //将被点击的控件赋给bClick变量 
            if (flag == false)
            {
                 flag = true;
                 pic1 = bClick;
                 temp1 = pic1.Location.X ;
                 temp2 = pic1.Location.Y;
            }
            else //交换
            {
                temp3 = bClick.Location.X;
                temp4 = bClick.Location.Y;
                flag = false;
                bClick.Location = new Point(temp1, temp2);
                pic1.Location = new Point(temp3, temp4);
                CheckWin();
            }
        }  //位置交换

        private void  CheckWin() //判断是否成功 
        { 
           int s=0;
           for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (pictureBox[i, j].Location ==new Point(50 + i * (width / 4 + 1), 50 + j * (height / 4 + 1)))
                    {
                        s++;
                    } 
                }
            }
           if (s==9)
           {
               MessageBox.Show("拼图完成，返回主菜单", "恭喜",MessageBoxButtons.OK ,MessageBoxIcon.Information );
               this.Close();
           }   
        }
   
    }

}

