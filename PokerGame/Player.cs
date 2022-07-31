using System;
using System.Collections.Generic;
using System.Text;

namespace PokerGame
{
    /// <summary>
    /// 玩家
    /// </summary>
    internal class Player
    {
        /// <summary>
        /// 玩家名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 手上的牌
        /// </summary>
        public Poker[] Cards { get; set; }
    }
}
