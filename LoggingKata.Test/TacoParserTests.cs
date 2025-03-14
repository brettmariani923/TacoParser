using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldReturnNonNullObject()
        {
            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("33.671982,-85.826674,Taco Bell Annisto...", -85.826674)]
        [InlineData("34.324462,-86.503055,Taco Bell Ara...", -86.503055)]
        [InlineData("34.992219,-86.841402,Taco Bell Ardmore...", -86.841402)]
        [InlineData("34.795116,-86.97191,Taco Bell Athens...", -86.97191)]
        [InlineData("34.018008,-86.079099,Taco Bell Attall...", -86.079099)]
        //Add additional inline data. Refer to your CSV file.
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete the test with Arrange, Act, Assert steps below.
            //       Note: "line" string represents input data we will Parse 
            //       to extract the Longitude.  
            //       Each "line" from your .csv file
            //       represents a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse(line).Location.Longitude;

            //Assert
            Assert.Equal(actual, expected);

        }


        //TODO: Create a test called ShouldParseLatitude
        [Theory]
        [InlineData("33.671982,-85.826674,Taco Bell Annisto...", 33.671982)]
        [InlineData("34.324462,-86.503055,Taco Bell Ara...", 34.324462)]
        [InlineData("34.992219,-86.841402,Taco Bell Ardmore...", 34.992219)]
        [InlineData("34.795116,-86.97191,Taco Bell Athens...", 34.795116)]
        [InlineData("34.018008,-86.079099,Taco Bell Attall...", 34.018008)]
       public void ShouldParseLatitude(string line, double expected)
       {
        //Arrange
        var tacoParser = new TacoParser();

        //Act
        var actual = tacoParser.Parse(line).Location.Latitude;

        //Assert
        Assert.Equal(actual, expected);

       }
    }
}
