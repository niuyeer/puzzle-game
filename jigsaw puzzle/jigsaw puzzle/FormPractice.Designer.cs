namespace jigsaw_puzzle
{
    partial class FormPractice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPractice));
            this.button1Add = new System.Windows.Forms.Button();
            this.buttonFind = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1Add
            // 
            this.button1Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1Add.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1Add.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1Add.Location = new System.Drawing.Point(367, 12);
            this.button1Add.Name = "button1Add";
            this.button1Add.Size = new System.Drawing.Size(108, 47);
            this.button1Add.TabIndex = 0;
            this.button1Add.Text = "添加图片";
            this.button1Add.UseVisualStyleBackColor = false;
            this.button1Add.Click += new System.EventHandler(this.button1Add_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFind.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFind.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonFind.Location = new System.Drawing.Point(535, 12);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(108, 47);
            this.buttonFind.TabIndex = 1;
            this.buttonFind.Text = "查看原图";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(38, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 2;
            // 
            // FormPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.button1Add);
            this.Name = "FormPractice";
            this.Text = "练习模式";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPractise_FormClosed);
            this.Load += new System.EventHandler(this.FormPractise_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Add;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;


    }
}