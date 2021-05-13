// Copyright 2021 Russian Post
// This source code is Russian Post Confidential Proprietary.
// This software is protected by copyright. All rights and titles are reserved.
// You shall not use, copy, distribute, modify, decompile, disassemble or reverse engineer the software.
// Otherwise this violation would be treated by law and would be subject to legal prosecution.
// Legal use of the software provides receipt of a license from the right holder only.

// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;

namespace Chess
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void RookShouldBeCorrectMove()
        {
            ChessFigure figure = new Rook("E2");
            Assert.AreEqual(true,figure.Move("C2"));
        }
        [Test]
        public void RookShouldBeIncorrectMove()
        {
            ChessFigure figure = new Rook("E2");
            Assert.AreEqual(false,figure.Move("C5"));
        }
        [Test]
        public void KnightShouldBeCorrectMove()
        {
            ChessFigure figure = new Knight("B1");
            Assert.AreEqual(true,figure.Move("C3"));
        }
        [Test]
        public void KnightShouldBeIncorrectMove()
        {
            ChessFigure figure = new Knight("B1");
            Assert.AreEqual(false,figure.Move("C5"));
        }
        [Test]
        public void BishopShouldBeCorrectMove()
        {
            ChessFigure figure = new Bishop("C1");
            Assert.AreEqual(true,figure.Move("E3"));
        }
        [Test]
        public void BishopShouldBeIncorrectMove()
        {
            ChessFigure figure = new Bishop( "C1");
            Assert.AreEqual(false,figure.Move("C3"));
        }
        [Test]
        public void PawnShouldBeCorrectMove0()
        {
            ChessFigure figure = new Pawn("E2");
            Assert.AreEqual(true,figure.Move("E3"));
        }
        [Test]
        public void PawnShouldBeCorrectMove1()
        {
            ChessFigure figure = new Pawn("E2");
            Assert.AreEqual(true,figure.Move("E4"));
        }
        [Test]
        public void PawnShouldBeCorrectMove2()
        {
            ChessFigure figure = new Pawn("E4");
            Assert.AreEqual(true,figure.Move("E5"));
        }   
        [Test]
        public void PawnShouldBeIncorrectMove()
        {
            ChessFigure figure = new Pawn("E2");
            Assert.AreEqual(false,figure.Move("C5"));
        }
        [Test]
        public void KingShouldBeCorrectMove()
        {
            ChessFigure figure = new King("E1");
            Assert.AreEqual(true,figure.Move("E2"));
        }
        [Test]
        public void KingShouldBeIncorrectMove()
        {
            ChessFigure figure = new King("E1");
            Assert.AreEqual(false,figure.Move("E8"));
        }
        [Test]
        public void QueenShouldBeCorrectMoveVertical()
        {
            ChessFigure figure = new Queen("D1");
            Assert.AreEqual(true,figure.Move("D8"));
        }
        [Test]
        public void QueenShouldBeCorrectMoveDiagonal()
        {
            ChessFigure figure = new Queen("D1");
            Assert.AreEqual(true,figure.Move("H5"));
        }
        [Test]
        public void QueenShouldBeIncorrectMove()
        {
            ChessFigure figure = new Queen("D1");
            Assert.AreEqual(false,figure.Move("E3"));
        }
    }
}
