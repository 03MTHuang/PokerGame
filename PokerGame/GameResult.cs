using System;
using System.Collections.Generic;
using System.Text;

namespace PokerGame
{
    /// <summary>
    /// 遊戲結果
    /// </summary>
    internal class GameResult
    {
        /// <summary>
        /// 獲勝者
        /// </summary>
        public Player Winner { get; set; }

        /// <summary>
        /// 最大的牌
        /// </summary>
        public Poker HighCard { get; set; }
    }
}
