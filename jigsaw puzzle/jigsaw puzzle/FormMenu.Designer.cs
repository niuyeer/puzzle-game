namespace jigsaw_puzzle
{
    partial class FormMenu
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.buttonMusic = new System.Windows.Forms.Button();
            this.buttonRisk = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPractice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMusic
            // 
            this.buttonMusic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMusic.BackgroundImage")));
            this.buttonMusic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMusic.Location = new System.Drawing.Point(30, 12);
            this.buttonMusic.Name = "buttonMusic";
            this.buttonMusic.Size = new System.Drawing.Size(42, 39);
            this.buttonMusic.TabIndex = 3;
            this.buttonMusic.UseVisualStyleBackColor = true;
            this.buttonMusic.Click += new System.EventHandler(this.buttonMusic_Click);
            // 
            // buttonRisk
            // 
            this.buttonRisk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRisk.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRisk.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonRisk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRisk.BackgroundImage")));
            this.buttonRisk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRisk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRisk.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRisk.Location = new System.Drawing.Point(318, 198);
            this.buttonRisk.Name = "buttonRisk";
            this.buttonRisk.Size = new System.Drawing.Size(163, 67);
            this.buttonRisk.TabIndex = 0;
            this.buttonRisk.Text = "冒险模式";
            this.buttonRisk.UseVisualStyleBackColor = false;
            this.buttonRisk.Click += new System.EventHandler(this.buttonRisk_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.Location = new System.Drawing.Point(318, 406);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(163, 67);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPractice
            // 
            this.buttonPractice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPractice.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPractice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonPractice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPractice.BackgroundImage")));
            this.buttonPractice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPractice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPractice.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPractice.Location = new System.Drawing.Point(318, 302);
            this.buttonPractice.Name = "buttonPractice";
            this.buttonPractice.Size = new System.Drawing.Size(163, 67);
            this.buttonPractice.TabIndex = 1;
            this.buttonPractice.Text = "练习模式";
            this.buttonPractice.UseVisualStyleBackColor = false;
            this.buttonPractice.Click += new System.EventHandler(this.buttonPractice_Click_1);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 572);
            this.Controls.Add(this.buttonPractice);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRisk);
            this.Controls.Add(this.buttonMusic);
            this.Name = "FormMenu";
            this.Text = "自由拼图";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMusic;
        private System.Windows.Forms.Button buttonRisk;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPractice;
    }
}

