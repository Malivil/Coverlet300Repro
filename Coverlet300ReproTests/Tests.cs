using Coverlet300Repro;
using System;
using Xunit;

namespace Coverlet300ReproTests
{
    public class Tests
    {
        [Fact]
        public void ToStringTest()
        {
            // Arrange
            var target = new ToStringData();

            // Act
            var result = target.ToString();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public void MultiLineConstructorTest()
        {
            // Arrange
            var data = Guid.NewGuid().ToString();
            var target = new MultiLineConstructor(data);

            // Act
            var result = target.Data;

            // Assert
            Assert.Equal(data, result);
        }

        [Fact]
        public void SwitchPatternTest_One()
        {
            // Arrange
            var target = new SwitchPattern(Number.One);

            // Act
            var result = target.Value;

            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void SwitchPatternTest_Unknown()
        {
            // Arrange
            var target = new SwitchPattern((Number)(-1));

            // Act
            var result = target.Value;

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void MultiLineAssignmentTest_Unknown()
        {
            // Arrange
            var target = new MultiLineAssignment();

            // Act
            var result = target.Value;

            // Assert
            Assert.Equal(2 / 3.0f, result);
        }
    }
}
