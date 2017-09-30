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
        int CurrentFrameIndex = 1;
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
        }
        /// <summary>
        /// 创建新动画
        /// </summary>
        void btn_CreateAmination_Click()
        {
            pictureBox_Main.Image = null;
            FramesList = new LinkedList<Image>();
            FramesList.AddLast(pictureBox_Main.Image);
            CurrentFrameIndex = 1;
            label_FramePage.Text = "1/1";
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
            pictureBox_Main.Image = null;
            FramesList.AddLast(pictureBox_Main.Image);
            ++CurrentFrameIndex;
            label_FramePage.Text = CurrentFrameIndex + "/" + FramesList.Count;
            if (CurrentFrameIndex > 1) button_PreFrame.Enabled = true;
            if (CurrentFrameIndex >= FramesList.Count) button_NextFrame.Enabled = false;
            if (FramesList.Count > 1) button_DeleteFrame.Enabled = true;
        }
        /// <summary>
        /// 导入图片
        /// </summary>
        void btn_ImportImage_Click()
        {
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
