using _2DAminationDemo.Amination;
using _2DAminationDemo.GameController;
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
            this.KeyPreview = true;
            //test2DAmination();
            //testGameRole();
            
            testController1();
            //testController2();
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
            testObject.SetBounds(200, 150, 100, 200);
            this.Controls.Add(testObject);
            testObject.MoveSpeed = 5;
           
            testObject.AminationMoveRight = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\walk_sekelon.amin2d"), new Size(100, 200));
            testObject.AminationMoveRight.FrameInterval = 60;
            testObject.AminationMoveLeft = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\walk_sekelon_l.amin2d"), new Size(100, 200));
            testObject.AminationMoveLeft.FrameInterval = 60;
            testObject.AminationIdle = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\walk_sekelon_idle.amin2d"), new Size(100, 200));
            testObject.AminationIdle.FrameInterval = 60;
            testObject.Move(GameRole.MoveDirection.RIGHT);
        }
        /// <summary>
        /// 测试控制器1
        /// </summary>
        void testController1()
        {
            GameRole testObject = GameObjectFactory.CreateGameRole();
            testObject.SetBounds(200, 300, 100, 200);
            this.Controls.Add(testObject);
            testObject.MoveSpeed = 10;

            testObject.AminationMoveUp = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\walk_sekelon.amin2d"), new Size(100, 200));
            testObject.AminationMoveUp.FrameInterval = 80;
            testObject.AminationMoveRight = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\walk_sekelon.amin2d"), new Size(100, 200));
            testObject.AminationMoveRight.FrameInterval = 80;
            testObject.AminationMoveDown = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\walk_sekelon_l.amin2d"), new Size(100, 200));
            testObject.AminationMoveDown.FrameInterval = 80;
            testObject.AminationMoveLeft = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\walk_sekelon_l.amin2d"), new Size(100, 200));
            testObject.AminationMoveLeft.FrameInterval = 80;
            testObject.AminationIdle = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\walk_sekelon_idle.amin2d"), new Size(100, 200));
            testObject.AminationIdle.FrameInterval = 80;

            RoleController testController = new RoleController();
            testController.Role = testObject;
            testController.SetDefaultAction(testController.Role.BeIdle);
            testController.SetKeyPressAction(Keys.A, testController.Role.MoveLeft);
            testController.SetKeyPressAction(Keys.D, testController.Role.MoveRight);
            testController.SetKeyPressAction(Keys.W, testController.Role.MoveUp);
            testController.SetKeyPressAction(Keys.S, testController.Role.MoveDown);
            this.KeyDown += testController.KeyDownEventHandler;
        }
        /// <summary>
        /// 测试控制器2
        /// </summary>
        void testController2()
        {
            GameRole testObject = GameObjectFactory.CreateGameRole();
            testObject.SetBounds(200, 160, 100, 200);
            this.Controls.Add(testObject);
            testObject.MoveSpeed = 10;

            testObject.AminationMoveRight = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\walk_sekelon.amin2d"), new Size(100, 200));
            testObject.AminationMoveRight.FrameInterval = 80;
            testObject.AminationMoveLeft = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\walk_sekelon_l.amin2d"), new Size(100, 200));
            testObject.AminationMoveLeft.FrameInterval = 80;
            testObject.AminationIdle = AminationFactory.Create2DAmination(Image.FromFile(@"E:\图片\walk_sekelon_idle.amin2d"), new Size(100, 200));
            testObject.AminationIdle.FrameInterval = 80;

            RoleController testController = new RoleController();
            testController.Role = testObject;
            testController.SetDefaultAction(testController.Role.BeIdle);
            testController.SetKeyPressAction(Keys.Left, testController.Role.MoveLeft);
            testController.SetKeyPressAction(Keys.Right, testController.Role.MoveRight);
            this.KeyDown += testController.KeyDownEventHandler;

        }
        /// <summary>
        /// 窗体关闭事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
