using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2DAminationDemo.GameObject
{
    class GameObjectFactory
    {
        /// <summary>
        /// 创建游戏角色
        /// </summary>
        /// <returns></returns>
        public static GameRole CreateGameRole()
        {
            return new GameRole();
        }
    }
}
