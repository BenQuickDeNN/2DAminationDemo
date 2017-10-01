namespace _2DAminationEditor
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Width = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Height = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button_CreateNewAmination = new System.Windows.Forms.Button();
            this.pictureBox_Main = new System.Windows.Forms.PictureBox();
            this.button_PreFrame = new System.Windows.Forms.Button();
            this.button_NextFrame = new System.Windows.Forms.Button();
            this.label_FramePage = new System.Windows.Forms.Label();
            this.button_CreateNewFrame = new System.Windows.Forms.Button();
            this.button_ExportAmination = new System.Windows.Forms.Button();
            this.button_DeleteFrame = new System.Windows.Forms.Button();
            this.openFileDialog_Image = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_Amination = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "宽度:";
            // 
            // numericUpDown_Width
            // 
            this.numericUpDown_Width.Location = new System.Drawing.Point(53, 12);
            this.numericUpDown_Width.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Width.Name = "numericUpDown_Width";
            this.numericUpDown_Width.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown_Width.TabIndex = 2;
            this.numericUpDown_Width.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericUpDown_Height
            // 
            this.numericUpDown_Height.Location = new System.Drawing.Point(200, 12);
            this.numericUpDown_Height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Height.Name = "numericUpDown_Height";
            this.numericUpDown_Height.Size = new System.Drawing.Size(50, 21);
            this.numericUpDown_Height.TabIndex = 3;
            this.numericUpDown_Height.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "高度:";
            // 
            // button_CreateNewAmination
            // 
            this.button_CreateNewAmination.Location = new System.Drawing.Point(273, 10);
            this.button_CreateNewAmination.Name = "button_CreateNewAmination";
            this.button_CreateNewAmination.Size = new System.Drawing.Size(75, 23);
            this.button_CreateNewAmination.TabIndex = 5;
            this.button_CreateNewAmination.Text = "新建动画";
            this.button_CreateNewAmination.UseVisualStyleBackColor = true;
            this.button_CreateNewAmination.Click += new System.EventHandler(this.ToolBoxClickEventHandler);
            // 
            // pictureBox_Main
            // 
            this.pictureBox_Main.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Main.Location = new System.Drawing.Point(14, 55);
            this.pictureBox_Main.Name = "pictureBox_Main";
            this.pictureBox_Main.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_Main.TabIndex = 6;
            this.pictureBox_Main.TabStop = false;
            // 
            // button_PreFrame
            // 
            this.button_PreFrame.Location = new System.Drawing.Point(14, 526);
            this.button_PreFrame.Name = "button_PreFrame";
            this.button_PreFrame.Size = new System.Drawing.Size(75, 23);
            this.button_PreFrame.TabIndex = 7;
            this.button_PreFrame.Text = "上一帧";
            this.button_PreFrame.UseVisualStyleBackColor = true;
            this.button_PreFrame.Click += new System.EventHandler(this.ToolBoxClickEventHandler);
            // 
            // button_NextFrame
            // 
            this.button_NextFrame.Location = new System.Drawing.Point(175, 526);
            this.button_NextFrame.Name = "button_NextFrame";
            this.button_NextFrame.Size = new System.Drawing.Size(75, 23);
            this.button_NextFrame.TabIndex = 8;
            this.button_NextFrame.Text = "下一帧";
            this.button_NextFrame.UseVisualStyleBackColor = true;
            this.button_NextFrame.Click += new System.EventHandler(this.ToolBoxClickEventHandler);
            // 
            // label_FramePage
            // 
            this.label_FramePage.AutoSize = true;
            this.label_FramePage.Location = new System.Drawing.Point(112, 531);
            this.label_FramePage.Name = "label_FramePage";
            this.label_FramePage.Size = new System.Drawing.Size(23, 12);
            this.label_FramePage.TabIndex = 9;
            this.label_FramePage.Text = "0/0";
            // 
            // button_CreateNewFrame
            // 
            this.button_CreateNewFrame.Location = new System.Drawing.Point(287, 526);
            this.button_CreateNewFrame.Name = "button_CreateNewFrame";
            this.button_CreateNewFrame.Size = new System.Drawing.Size(75, 23);
            this.button_CreateNewFrame.TabIndex = 10;
            this.button_CreateNewFrame.Text = "新建帧";
            this.button_CreateNewFrame.UseVisualStyleBackColor = true;
            this.button_CreateNewFrame.Click += new System.EventHandler(this.ToolBoxClickEventHandler);
            // 
            // button_ExportAmination
            // 
            this.button_ExportAmination.Location = new System.Drawing.Point(500, 526);
            this.button_ExportAmination.Name = "button_ExportAmination";
            this.button_ExportAmination.Size = new System.Drawing.Size(75, 23);
            this.button_ExportAmination.TabIndex = 12;
            this.button_ExportAmination.Text = "导出动画";
            this.button_ExportAmination.UseVisualStyleBackColor = true;
            this.button_ExportAmination.Click += new System.EventHandler(this.ToolBoxClickEventHandler);
            // 
            // button_DeleteFrame
            // 
            this.button_DeleteFrame.Location = new System.Drawing.Point(400, 526);
            this.button_DeleteFrame.Name = "button_DeleteFrame";
            this.button_DeleteFrame.Size = new System.Drawing.Size(75, 23);
            this.button_DeleteFrame.TabIndex = 13;
            this.button_DeleteFrame.Text = "删除当前帧";
            this.button_DeleteFrame.UseVisualStyleBackColor = true;
            this.button_DeleteFrame.Click += new System.EventHandler(this.ToolBoxClickEventHandler);
            // 
            // openFileDialog_Image
            // 
            this.openFileDialog_Image.Filter = "(*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.bmp)|*.bmp";
            this.openFileDialog_Image.Title = "选择图片";
            // 
            // saveFileDialog_Amination
            // 
            this.saveFileDialog_Amination.Filter = "(*.amin2d)|*.amin2d";
            this.saveFileDialog_Amination.Title = "导出动画";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button_DeleteFrame);
            this.Controls.Add(this.button_ExportAmination);
            this.Controls.Add(this.button_CreateNewFrame);
            this.Controls.Add(this.label_FramePage);
            this.Controls.Add(this.button_NextFrame);
            this.Controls.Add(this.button_PreFrame);
            this.Controls.Add(this.pictureBox_Main);
            this.Controls.Add(this.button_CreateNewAmination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_Height);
            this.Controls.Add(this.numericUpDown_Width);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2D Amination Editor";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Width;
        private System.Windows.Forms.NumericUpDown numericUpDown_Height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_CreateNewAmination;
        private System.Windows.Forms.PictureBox pictureBox_Main;
        private System.Windows.Forms.Button button_PreFrame;
        private System.Windows.Forms.Button button_NextFrame;
        private System.Windows.Forms.Label label_FramePage;
        private System.Windows.Forms.Button button_CreateNewFrame;
        private System.Windows.Forms.Button button_ExportAmination;
        private System.Windows.Forms.Button button_DeleteFrame;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Image;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Amination;

    }
}

