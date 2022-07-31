using System;
using System.Collections.Generic;
using System.Text;

namespace PokerGame
{
    /// <summary>
    /// 撲克牌
    /// </summary>
    internal class Poker
    {
        public Poker(string card)
        {
            Card = card;
            No = ChangeToNo(card);
        }

        /// <summary>
        /// 花色 + 數字
        /// </summary>
        public string Card { get; set; }

        /// <summary>
        /// 牌的編號
        /// </summary>
        public int No { get; set; }

        /// <summary>
        /// C(clubs, 梅花）、D(diamonds, 方塊)、H(hearts, 紅心)、S(spades, 黑桃)
        /// </summary>
        private char[] _flowerArray = { 'C', 'D', 'H', 'S' };

        /// <summary>
        /// 數字
        /// </summary>
        private char[] _numberArray 
            = { 'A', '2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K' };

        /// <summary>
        /// 將花色轉成編號
        /// </summary>
        /// <param name="flower"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private int ChangeToNo(string flower)
        {
            throw new NotImplementedException();
        }
    }
}
