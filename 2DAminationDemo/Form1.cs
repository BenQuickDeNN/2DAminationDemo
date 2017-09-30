using _2DAminationDemo.Amination;
using _2DAminationDemo.GameObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _2DAminationDemo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            test2DAmination();
            testGameRole();
        }
        /// <summary>
        /// 测试动画
        /// </summary>
        void test2DAmination()
        {
            _2DAmination[] testAminations = new _2DAmination[5];
            for (int i = 0; i < testAminations.Length; i++)
            {
                testAminations[i] = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\amin2d" + ((i % 2) + 1) + ".amin2d"), new Size(50, 50));
                testAminations[i].SetBounds(100 * (i + 1), 100, testAminations[i].Width, testAminations[i].Height);
                testAminations[i].FrameInterval = 1000;
                this.Controls.Add(testAminations[i]);
                testAminations[i].Play();
            }
        }
        /// <summary>
        /// 测试游戏对象
        /// </summary>
        void testGameRole()
        {
            GameRole testObject = GameObjectFactory.CreateGameRole();
            testObject.SetBounds(200, 200, 50, 50);
            this.Controls.Add(testObject);
            testObject.MoveSpeed = 20;
            testObject.AminationIdle = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\amin2d1.amin2d"), new Size(50, 50));
            testObject.AminationIdle.FrameInterval = 1000;
            testObject.AminationMoveRight = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\amin2d2.amin2d"), new Size(50, 50));
            testObject.AminationMoveRight.FrameInterval = 1000;
            testObject.Move(GameRole.MoveDirection.RIGHT);
        }
    }
}
