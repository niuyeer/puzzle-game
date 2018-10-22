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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

       
        int music = 1;
        
        SoundPlayer player = new SoundPlayer(@"..\素材\窗体设计\云水禅心.wav");

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();   
        }  //按钮退出游戏
        
        public void buttonMusic_Click(object sender, EventArgs e)
        {
            if (music % 2 == 0)
            {
                buttonMusic.BackgroundImage  = Image.FromFile(@"..\素材\窗体设计\2010092614474845_副本.png");
                player.Play();
                player.PlayLooping();
            }
            else
            {
                buttonMusic.BackgroundImage = Image.FromFile(@"..\素材\窗体设计\2010092614474845_副本_副本.png");
                player.Stop();
            }
            music++;
        }  //背景音乐
        
        private void buttonRisk_Click(object sender, EventArgs e)
        {
            FormRisk formRisk = new FormRisk(this);
            formRisk.Show();
            formRisk.Size = this.Size;
            formRisk.Location = this.Location;
            this.Hide (); 
        }  //冒险模式
         
        public void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // dialogresult 窗体关闭时返回一个窗体结果
            DialogResult result = MessageBox.Show("确定退出游戏？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                e.Cancel = false;
            }  //确定退出
            else
            {
                e.Cancel = true ; 
            }  //取消 
        } //窗体退出游戏

        private void FormMenu_Load(object sender, EventArgs e)
        {
            player.Play();
            player.PlayLooping(); //背景音乐
        }

        private void buttonPractice_Click_1(object sender, EventArgs e)
        {
            FormPractice formPractice = new FormPractice(this);
            formPractice.Show();
            formPractice.Size = this.Size;
            formPractice.Location = this.Location;
            this.Hide();
        }  //练习模式

       
    }
    
}
