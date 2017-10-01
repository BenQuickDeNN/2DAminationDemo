using System;
using System.Collections.Generic;
using System.Drawing;
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
            GameRole Role = new GameRole();
            Role.BackColor = Color.Transparent;
            Role.MoveLength = 8;
            Role.MoveSpeed = 4;
            return Role;
        }
    }
}
