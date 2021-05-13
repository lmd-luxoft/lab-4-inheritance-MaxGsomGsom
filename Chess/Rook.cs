// Copyright 2021 Russian Post
// This source code is Russian Post Confidential Proprietary.
// This software is protected by copyright. All rights and titles are reserved.
// You shall not use, copy, distribute, modify, decompile, disassemble or reverse engineer the software.
// Otherwise this violation would be treated by law and would be subject to legal prosecution.
// Legal use of the software provides receipt of a license from the right holder only.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public sealed class Rook: ChessFigure
    {
        public Rook(string currentCoord): base(FigureType.ROOK, currentCoord) { }

        public override bool Move(string nextCoord)
        {
            return nextCoord[0] >= 'A'
                   && nextCoord[0] <= 'H'
                   && nextCoord[1] >= '1'
                   && nextCoord[1] <= '8'
                   && (nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1])
                   && (nextCoord[0] != currentCoord[0] || nextCoord[1] != currentCoord[1]);
        }
    }
}
