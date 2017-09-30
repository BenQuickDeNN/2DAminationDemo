using _2DAminationDemo.Amination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace _2DAminationDemo.GameObject
{
    /// <summary>
    /// 游戏角色类
    /// </summary>
    class GameRole : Panel
    {
        /// <summary>
        /// 角色移动方向
        /// </summary>
        public enum MoveDirection
        {
            IDLE = 0,
            LEFT = 1,
            UP = 2,
            RIGHT = 3,
            DOWN = 4
        }
        /// <summary>
        /// 移动速度(px / frame)
        /// </summary>
        int _MoveSpeed = 5;
        /// <summary>
        /// 移动速度(px / frame)
        /// </summary>
        public int MoveSpeed
        {
            get
            {
                return _MoveSpeed;
            }
            set
            {
                if (value >= 0) _MoveSpeed = value;
            }
        }
        /// <summary>
        /// 当前移动方向
        /// </summary>
        MoveDirection NowDirection = MoveDirection.IDLE;
        /// <summary>
        /// 移动线程
        /// </summary>
        Thread thread_move;
        /// <summary>
        /// 帧数量
        /// </summary>
        int FrameLength;
        /// <summary>
        /// 帧间隔
        /// </summary>
        int FrameInterval;
        /// <summary>
        /// 运行移动线程
        /// </summary>
        void playMoveThread()
        {
            
            for (int i = 0; i < FrameLength; i++)
            {
                _AminationPlaying.Invoke(new MethodInvoker(delegate
                {
                    switch (NowDirection)
                    {
                        case MoveDirection.IDLE:
                            break;
                        case MoveDirection.LEFT:
                            this.SetBounds(this.Location.X - MoveSpeed, this.Location.Y, this.Width, this.Height);
                            break;
                        case MoveDirection.UP:
                            this.SetBounds(this.Location.X, this.Location.Y - MoveSpeed, this.Width, this.Height);
                            break;
                        case MoveDirection.RIGHT:
                            this.SetBounds(this.Location.X + MoveSpeed, this.Location.Y, this.Width, this.Height);
                            break;
                        case MoveDirection.DOWN:
                            this.SetBounds(this.Location.X, this.Location.Y + MoveSpeed, this.Width, this.Height);
                            break;
                        default:
                            break;
                    }
                }));
                Thread.Sleep(FrameInterval);
            }
        }
        /// <summary>
        /// 移动
        /// </summary>
        /// <param name="direction">方向</param>
        public void Move(MoveDirection direction)
        {
            NowDirection = direction;
            switch (direction)
            {
                case MoveDirection.IDLE:
                    _AminationPlaying = _AminationIdle;
                    break;
                case MoveDirection.LEFT:
                    _AminationPlaying = _AminationMoveLeft;
                    break;
                case MoveDirection.UP:
                    _AminationPlaying = _AminationMoveUp;
                    break;
                case MoveDirection.RIGHT:
                    _AminationPlaying = _AminationMoveRight;
                    break;
                case MoveDirection.DOWN:
                    _AminationPlaying = _AminationMoveDown;
                    break;
                default:
                    _AminationPlaying = _AminationIdle;
                    break;
            }
            this.Controls.Clear();
            this.Controls.Add(_AminationPlaying);
            _AminationPlaying.Visible = true;
            FrameLength = _AminationPlaying.ImageArray.Length;
            FrameInterval = _AminationPlaying.FrameInterval;
            _AminationPlaying.Play();
            thread_move = new Thread(playMoveThread);
            thread_move.Start();
        }
        /// <summary>
        /// 当前播放动画
        /// </summary>
        _2DAmination _AminationPlaying;
        /// <summary>
        /// 角色空闲时的动画
        /// </summary>
        _2DAmination _AminationIdle;
        /// <summary>
        /// 角色空闲时的动画
        /// </summary>
        public _2DAmination AminationIdle
        {
            get
            {
                return _AminationIdle;
            }
            set
            {
                _AminationIdle = value;
            }
        }
        /// <summary>
        /// 角色向左移动的动画
        /// </summary>
        _2DAmination _AminationMoveLeft;
        /// <summary>
        /// 角色向左移动的动画
        /// </summary>
        public _2DAmination AminationMoveLeft
        {
            get
            {
                return _AminationMoveLeft;
            }
            set
            {
                _AminationMoveLeft = value;
            }
        }
        /// <summary>
        /// 角色向上移动的动画
        /// </summary>
        _2DAmination _AminationMoveUp;
        /// <summary>
        /// 角色向上移动的动画
        /// </summary>
        public _2DAmination AminationMoveUp
        {
            get
            {
                return _AminationMoveUp;
            }
            set
            {
                _AminationMoveUp = value;
            }
        }
        /// <summary>
        /// 角色向右移动的动画
        /// </summary>
        _2DAmination _AminationMoveRight;
        /// <summary>
        /// 角色向右移动的动画
        /// </summary>
        public _2DAmination AminationMoveRight
        {
            get
            {
                return _AminationMoveRight;
            }
            set
            {
                _AminationMoveRight = value;
            }
        }
        /// <summary>
        /// 角色向下移动的动画
        /// </summary>
        _2DAmination _AminationMoveDown;
        /// <summary>
        /// 角色向下移动的动画
        /// </summary>
        public _2DAmination AminationMoveDown
        {
            get
            {
                return _AminationMoveDown;
            }
            set
            {
                _AminationMoveDown = value;
            }
        }
    }
}
