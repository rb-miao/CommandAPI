using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests:IDisposable
    {
        Command testCommand;
        public CommandTests()
        {
            testCommand = new Command
            {
            HowTo = "Do something",
            Platform = "Some platform",
            CommandLine = "Some commandline"
            };
        }
        public void Dispose()
        {
            testCommand=null;
        }
        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange
            
            //Act
            testCommand.HowTo="Execute Unit Tests";

            //Assert
            Assert.Equal("Execute Unit Tests",testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            //Arrange
           
            //Act
            testCommand.Platform="Dot net";

            //Assert
            Assert.Equal("Dot net",testCommand.Platform);
            
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            //Arrange
            
            //Act
            testCommand.CommandLine="Dot run";

            //Assert
            Assert.Equal("Dot run",testCommand.CommandLine);
        }
    }
}