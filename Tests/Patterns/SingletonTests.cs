using Learning.DesignPatterns.Console.Patterns;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Learning.DesignPatterns.Console.Tests.Patterns
{
    [TestClass]
    public class SingletonTests
    {
        [TestInitialize]
        public void Setup()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_ReturnsNonNullSingletonInstance_ValidSingletonClass()
        {
            //Arrange
            //Act 
            //Assert
            Assert.IsNotNull(Singleton.Instance);
        }
    }
}
