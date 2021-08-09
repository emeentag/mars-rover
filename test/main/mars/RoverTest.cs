using System;
using Moq;
using NUnit.Framework;
using Mars;

namespace test
{
    public class RoverTest
    {
        private Rover rover;

        [SetUp]
        public void Setup()
        {
            Point p = new Point(5, 5);
            Position position = new Position(p, Direction.N);
            Plateau plateau = new Plateau(p);
            rover = new Rover(position, plateau);
        }

        [Test]
        public void Move_Should_Return_1_3_N()
        {
            // given
            Position p = new Position(new Point(1, 2), Direction.N);
            rover.Position = p;

            // when
            rover.Move("LMLMLMLMM");

            // then
            Assert.AreEqual("1 3 N", rover.ToString());
        }

        [Test]
        public void Move_Should_Return_2_2_N()
        {
            // given
            Position p = new Position(new Point(0, 0), Direction.N);
            rover.Position = p;

            // when
            rover.Move("MMRMML");

            // then
            Assert.AreEqual("2 2 N", rover.ToString());
        }

        [Test]
        public void Move_Should_Return_Minus2_Minus2_S()
        {
            // given
            Position p = new Position(new Point(0, 0), Direction.S);
            rover.Position = p;

            // when
            rover.Move("MMRMML");

            // then
            Assert.AreEqual("-2 -2 S", rover.ToString());
        }

        [Test]
        public void Move_Should_Throw_ArgumentException_When_Movement_Not_Valid()
        {
            // given
            String message = "NotValidMessage";

            // then
            Assert.Throws<ArgumentException>(() => rover.Move(message));
        }
    }
}