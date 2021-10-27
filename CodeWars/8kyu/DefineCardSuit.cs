/*
https://www.codewars.com/kata/5a360620f28b82a711000047/

8 kyu
Define a card suit

You get any card as an argument. Your task is to return a suit of this card.

Our deck (is preloaded):

deck = ['2♣','3♣','4♣','5♣','6♣','7♣','8♣','9♣','10♣','J♣','Q♣','K♣','A♣',
        '2♦','3♦','4♦','5♦','6♦','7♦','8♦','9♦','10♦','J♦','Q♦','K♦','A♦',
        '2♥','3♥','4♥','5♥','6♥','7♥','8♥','9♥','10♥','J♥','Q♥','K♥','A♥',
        '2♠','3♠','4♠','5♠','6♠','7♠','8♠','9♠','10♠','J♠','Q♠','K♠','A♠'];
        
('3♣') -> return 'clubs'
('3♦') -> return 'diamonds'
('3♥') -> return 'hearts'
('3♠') -> return 'spades'
*/

using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace CodeWars
{
    public static class DefineCardSuit
    {
        public static readonly string[] Deck =
        {
            "2♣", "3♣", "4♣", "5♣", "6♣", "7♣", "8♣", "9♣", "10♣", "J♣", "Q♣", "K♣", "A♣",
            "2♦", "3♦", "4♦", "5♦", "6♦", "7♦", "8♦", "9♦", "10♦", "J♦", "Q♦", "K♦", "A♦",
            "2♥", "3♥", "4♥", "5♥", "6♥", "7♥", "8♥", "9♥", "10♥", "J♥", "Q♥", "K♥", "A♥",
            "2♠", "3♠", "4♠", "5♠", "6♠", "7♠", "8♠", "9♠", "10♠", "J♠", "Q♠", "K♠", "A♠"
        };

        public static string DefineSuit(string card)
        {
            // return card[^1] switch
            // {
            //     '♣' => "clubs",
            //     '♦' => "diamonds",
            //     '♥' => "hearts",
            //     '♠' => "spades",
            //     _ => throw new ArgumentException()
            // };


            // return card.Contains('♥') ? "hearts" :
            //     card.Contains('♦') ? "diamonds" :
            //     card.Contains('♣') ? "clubs" : "spades";

            // return new Dictionary<char, string>()
            // {
            //     { '♣', "clubs" },
            //     { '♦', "diamonds" },
            //     { '♥', "hearts" },
            //     { '♠', "spades" }
            // }[card[^1]];

            // return card.Last() switch
            return card[^1] switch
            {
                '♣' => "clubs",
                '♦' => "diamonds",
                '♥' => "hearts",
                _ => "spades"
            };
        }
    }
}