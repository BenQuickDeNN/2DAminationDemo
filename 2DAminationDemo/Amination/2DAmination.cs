using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _2DAminationDemo.Amination
{
    /// <summary>
    /// 2D动画，用PictureBox组件实现
    /// </summary>
    class _2DAmination : PictureBox
    {
        /// <summary>
        /// 创建新动画
        /// </summary>
        /// <param name="sourceImage">素材源</param>
        /// <param name="frameSize">帧大小</param>
        public _2DAmination(Image sourceImage, Size frameSize)
        {
            this.BackColor = Color.Transparent;// 设置背景透明
            this.Width = frameSize.Width;
            this.Height = frameSize.Height;
            initializeImageArray(sourceImage, frameSize);
        }
        /// <summary>
        /// 构建动画图片组
        /// </summary>
        /// <param name="sourceImage">素材源</param>
        /// <param name="frameSize">帧大小</param>
        void initializeImageArray(Image sourceImage, Size frameSize)
        {
            int frame_count = sourceImage.Height / frameSize.Height;
            _ImageArray = new Bitmap[frame_count];
            Graphics snap = null;
            for (int i = 0; i < frame_count; i++)
            {
                _ImageArray[i] = new Bitmap(frameSize.Width, frameSize.Height);
                snap = Graphics.FromImage(_ImageArray[i]);
                /* 裁剪图片 */
                snap.DrawImage(sourceImage, 0, 0, new Rectangle(0, i * frameSize.Height, frameSize.Width, frameSize.Height), GraphicsUnit.Pixel);
            }
        }
        /// <summary>
        /// 播放动画线程
        /// </summary>
        Thread thread_play;
        /// <summary>
        /// 执行播放
        /// </summary>
        void playAminationThread()
        {
            for (int i = 0; i < _ImageArray.Length; i++)
            {
                this.Image = _ImageArray[i];
                //Application.DoEvents();
                Thread.Sleep(_FrameInterval);
            }
        }
        
        /// <summary>
        /// 播放动画
        /// </summary>
        public void Play()
        {
            thread_play = new Thread(playAminationThread);
            thread_play.Start();
        }
         
        /// <summary>
        /// 组成动画的图片组
        /// </summary>
        Bitmap[] _ImageArray;
        /// <summary>
        /// 组成动画的图片组
        /// </summary>
        public Bitmap[] ImageArray
        {
            get
            {
                return _ImageArray;
            }
        }
        /// <summary>
        /// 帧间隔时间(ms)
        /// </summary>
        int _FrameInterval = 40;
        /// <summary>
        /// 帧间隔时间(ms)
        /// </summary>
        public int FrameInterval
        {
            get
            {
                return _FrameInterval;
            }
            set
            {
                if (value <= 0) _FrameInterval = 40;
                else _FrameInterval = value;
            }
        }
        /// <summary>
        /// 帧图片大小(px)
        /// </summary>
        Size _FrameSize;
        /// <summary>
        /// 帧图片大小(px)
        /// </summary>
        public Size FrameSize
        {
            get
            {
                return _FrameSize;
            }
        }
    }
}
