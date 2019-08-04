﻿using System;
using System.Collections.Generic;

namespace Checkers
{
    public class Board
    {
        private List<Checker> _checkers;

        public Board()
        {
            _checkers = new List<Checker>();
            for (int r = 0; r < 3; r++)
            {
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.White, r, (r + 1) % 2 + i);
                    _checkers.Add(c);
                }
                for (int i = 0; i < 8; i += 2)
                {
                    Checker c = new Checker(Color.Black, 5 + r, (r) % 2 + i);
                    _checkers.Add(c);
                }
            }
        }

        public Checker GetChecker(Position pos)
        {
            Checker found = null;
            foreach (Checker checker in _checkers)
            {
                if (pos.Equals(checker.Position))
                {
                    found = checker;
                    break;
                }
            }
            return found;
        }

        public void RemoveChecker(Checker checker)
        {
            foreach (Checker item in _checkers)
            {
                if (item.Equals(checker))
                {
                    _checkers.Remove(item);
                    break;
                }
            }
        }

        public void MoveChecker(Checker checker, Position dest)
        {
            _checkers.Remove(checker);
            checker.Position = dest;
            _checkers.Add(checker);
        }

        public void Draw()
        {
            string[][] grid = new string[8][];
            for (int r = 0; r < 8; r++)
            {
                grid[r] = new string[8];
                for (int c = 0; c < 8; c++)
                {
                    grid[r][c] = " ";
                }
            }
            foreach (Checker c in _checkers)
            {
                grid[c.Position.Row][c.Position.Column] = c.Symbol;
            }

            Console.WriteLine("  0 1 2 3 4 5 6 7");
            for (int r = 0; r < 8; r++)
            {
                Console.Write(r);
                for (int c = 0; c < 8; c++)
                {
                    Console.Write($" {grid[r][c]}");
                }
                Console.WriteLine();
            }
        }

        public int CountCheckers(Color color)
        {
            int count = 0;
            foreach (Checker checker in _checkers)
            {
                if (checker.PlayerColor == color)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
