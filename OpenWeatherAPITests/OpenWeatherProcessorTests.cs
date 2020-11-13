using OpenWeatherAPI;
using System;
using Xunit;

namespace OpenWeatherAPITests
{
    public class OpenWeatherProcessorTests : IDisposable
    {
        OpenWeatherProcessor _sut = new OpenWeatherProcessor();
        [Fact]
        public void GetOneCallAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            // Arrange

            // Act     
            
            // Assert
            Assert.IsType<ArgumentException>(_sut.GetOneCallAsync().Exception.InnerException);
        }
        [Fact]
        public void GetCurrentWeatherAsync_IfApiKeyEmptyOrNull_ThrowArgumentException()
        {
            // Arrange

            // Act     

            // Assert
            Assert.IsType<ArgumentException>(_sut.GetCurrentWeatherAsync().Exception.InnerException);
        }
        [Fact]
        public void GetOneCallAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
            // Arrange

            // Act       

            // Assert
            Assert.IsType<ArgumentException>(_sut.GetOneCallAsync().Exception.InnerException);
        }
        [Fact]
        public void GetCurrentWeatherAsync_IfApiHelperNotInitialized_ThrowArgumentException()
        {
            // Arrange

            // Act       

            // Assert
            Assert.IsType<ArgumentException>(_sut.GetCurrentWeatherAsync().Exception.InnerException);
        }
        public void Dispose()
        {

        }
    }
}
