using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2DAminationEditor
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// 帧链表
        /// </summary>
        LinkedList<Image> FramesList = new LinkedList<Image>();
        /// <summary>
        /// 当前帧索引
        /// </summary>
        int CurrentFrameIndex = 0;
        public FormMain()
        {
            InitializeComponent();
            setToolBoxEnable(false);
        }
        /// <summary>
        /// 组件点击事件响应
        /// </summary>
        /// <param name="toolBox"></param>
        /// <param name="args"></param>
        void ToolBoxClickEventHandler(object toolBox, EventArgs args)
        {
            if (toolBox.Equals(button_CreateNewAmination)) btn_CreateAmination_Click();
            else if (toolBox.Equals(button_PreFrame)) btn_PreFrame_Click();
            else if (toolBox.Equals(button_NextFrame)) btn_NextFrame_Click();
            else if (toolBox.Equals(button_CreateNewFrame)) btn_CreateNewFrame_Click();
            else if (toolBox.Equals(button_DeleteFrame)) btn_DeleteFrame_Click();
            else if (toolBox.Equals(button_ExportAmination)) btn_ExportAmination_Click();
        }
        /// <summary>
        /// 创建新动画
        /// </summary>
        void btn_CreateAmination_Click()
        {
            pictureBox_Main.Image = null;
            FramesList = new LinkedList<Image>();
            CurrentFrameIndex = 0;
            label_FramePage.Text = "0/0";
            int width = int.Parse(numericUpDown_Width.Value.ToString());
            int height = int.Parse(numericUpDown_Height.Value.ToString());
            pictureBox_Main.SetBounds(pictureBox_Main.Location.X, pictureBox_Main.Location.Y, width, height);
        }
        /// <summary>
        /// 前一帧
        /// </summary>
        void btn_PreFrame_Click()
        {
            if (CurrentFrameIndex < 2) return;
            --CurrentFrameIndex;
            pictureBox_Main.Image = FramesList.ElementAt(CurrentFrameIndex - 1);
            label_FramePage.Text = CurrentFrameIndex + "/" + FramesList.Count;
            if (CurrentFrameIndex < 2) button_PreFrame.Enabled = false;
            if (CurrentFrameIndex < FramesList.Count) button_NextFrame.Enabled = true;
        }
        /// <summary>
        /// 下一帧
        /// </summary>
        void btn_NextFrame_Click()
        {
            if (CurrentFrameIndex >= FramesList.Count) return;
            ++CurrentFrameIndex;
            pictureBox_Main.Image = FramesList.ElementAt(CurrentFrameIndex - 1);
            label_FramePage.Text = CurrentFrameIndex + "/" + FramesList.Count;
            if (CurrentFrameIndex > 1) button_PreFrame.Enabled = true;
            if (CurrentFrameIndex >= FramesList.Count) button_NextFrame.Enabled = false;
        }
        /// <summary>
        /// 新建帧
        /// </summary>
        void btn_CreateNewFrame_Click()
        {
            if (openFileDialog_Image.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Main.Image = new Bitmap(pictureBox_Main.Width, pictureBox_Main.Height);
                Graphics snap = Graphics.FromImage(pictureBox_Main.Image);
                Image tempImage = Image.FromFile(openFileDialog_Image.FileName);
                snap.DrawImage(tempImage, new Rectangle(0, 0, pictureBox_Main.Width, pictureBox_Main.Height), 
                    new Rectangle(0, 0, tempImage.Width, tempImage.Height), GraphicsUnit.Pixel);
                FramesList.AddLast(pictureBox_Main.Image);
                ++CurrentFrameIndex;
                label_FramePage.Text = CurrentFrameIndex + "/" + FramesList.Count;
                if (CurrentFrameIndex > 1) button_PreFrame.Enabled = true;
                if (CurrentFrameIndex >= FramesList.Count) button_NextFrame.Enabled = false;
                if (FramesList.Count > 0) button_DeleteFrame.Enabled = true;
            }
        }
        /// <summary>
        /// 删除当前帧
        /// </summary>
        void btn_DeleteFrame_Click()
        {
            if (FramesList.Count <= 0) return;
            FramesList.Remove(FramesList.ElementAt(CurrentFrameIndex - 1));
            if(CurrentFrameIndex > FramesList.Count)--CurrentFrameIndex;
            if (FramesList.Count <= 0)
            {
                button_DeleteFrame.Enabled = false;
                pictureBox_Main.Image = null;
            }
            else
            {
                pictureBox_Main.Image = FramesList.ElementAt(CurrentFrameIndex - 1);
            }
            label_FramePage.Text = CurrentFrameIndex + "/" + FramesList.Count;
            if (CurrentFrameIndex < 2) button_PreFrame.Enabled = false;
            if (CurrentFrameIndex >= FramesList.Count) button_NextFrame.Enabled = false;
        }
        /// <summary>
        /// 导出动画
        /// </summary>
        void btn_ExportAmination_Click()
        {
            if (saveFileDialog_Amination.ShowDialog() == DialogResult.OK)
            {
                Bitmap AminationExported = new Bitmap(pictureBox_Main.Width, pictureBox_Main.Height * FramesList.Count);
                Graphics snap = Graphics.FromImage(AminationExported);
                for (int i = 0; i < FramesList.Count; i++)
                {
                    snap.DrawImage(FramesList.ElementAt(i), new Rectangle(0, i * pictureBox_Main.Height, pictureBox_Main.Width, pictureBox_Main.Height),
                        new Rectangle(0, 0, FramesList.ElementAt(i).Width, FramesList.ElementAt(i).Height), GraphicsUnit.Pixel);
                }
                AminationExported.Save(saveFileDialog_Amination.FileName);
            }
        }
        /// <summary>
        /// 设置组件可用性
        /// </summary>
        /// <param name="enable"></param>
        void setToolBoxEnable(bool enable)
        {
            button_NextFrame.Enabled = enable;
            button_PreFrame.Enabled = enable;
            button_DeleteFrame.Enabled = enable;
        }
    }
}
