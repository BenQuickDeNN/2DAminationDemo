using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _2DAminationDemo.Amination
{
    /// <summary>
    /// 动画工厂
    /// </summary>
    class AminationFactory
    {
        /// <summary>
        /// 创建2D动画
        /// </summary>
        /// <param name="sourceImage">素材源</param>
        /// <param name="frameSize">帧大小</param>
        /// <returns></returns>
        public static _2DAmination Create2DAmination(Image sourceImage, Size frameSize)
        {
            return new _2DAmination(sourceImage, frameSize);
        }
    }
}
