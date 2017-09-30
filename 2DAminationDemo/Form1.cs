using _2DAminationDemo.Amination;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _2DAminationDemo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 测试动画
        /// </summary>
        void test2DAmination()
        {
            _2DAmination testAmination = AminationFactory.Create2DAmination(null, new Size());
            testAmination.SetBounds(100, 100, testAmination.Width, testAmination.Height);
        }
    }
}
