// Copyright 2021 Russian Post
// This source code is Russian Post Confidential Proprietary.
// This software is protected by copyright. All rights and titles are reserved.
// You shall not use, copy, distribute, modify, decompile, disassemble or reverse engineer the software.
// Otherwise this violation would be treated by law and would be subject to legal prosecution.
// Legal use of the software provides receipt of a license from the right holder only.

using System;

namespace Chess
{
    public sealed class Knight: ChessFigure
    {
        public Knight(string currentCoord): base(FigureType.KNIGHT, currentCoord) { }

        public override bool Move(string nextCoord)
        {
            if (nextCoord[0] < 'A' || nextCoord[0] > 'H' || nextCoord[1] < '1' || nextCoord[1] > '8')
                return false;

            var dx = Math.Abs(nextCoord[0] - currentCoord[0]);
            var dy = Math.Abs(nextCoord[1] - currentCoord[1]);
            return dx == 1 && dy == 2 || dx == 2 && dy == 1;
        }
    }
}
