using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Mocking;

namespace TestApp.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        private VideoService _service;
        private Mock<IFileReader> _mockFileReader;
        private Mock<IVideoRepository> _mockVideoRepository;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockVideoRepository = new Mock<IVideoRepository>();
            _service = new VideoService(_mockFileReader.Object, _mockVideoRepository.Object);
        }

        [Test]
        public void ReadVideoTitle_EmptyString_ReturnErrorMessage()
        {

            _mockFileReader.Setup(fr => fr.Read(It.IsAny<string>())).Returns("");
            
            var result = _service.ReadVideoTitle();
            
            Assert.That(result, Does.Contain("Error").IgnoreCase);
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_AllVideoProcessed_ReturnEmptyString()
        {
            _mockVideoRepository.Setup(r => r.GetUnprocessedVideo()).Returns(new List<Video>());

            var result = _service.GetUnprocessedVideosAsCsv();

            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_AFewUnproceessedVideo_ReturnStringWithId()
        {
            _mockVideoRepository.Setup(r => r.GetUnprocessedVideo())
                .Returns(new List<Video>
                {
                    new Video { Id = 1 }, new Video { Id = 2 }, new Video { Id = 3 }
                });

            var result = _service.GetUnprocessedVideosAsCsv();

            Assert.That(result, Is.EqualTo("1,2,3"));
        }
        






        //[Test]
        //public void ReadVideoTitle_EmptyString_ReturnErrorMessage()
        //{
        //    var mock = new Mock<IFileReader>();
        //    mock.Setup(fr => fr.Read("video.txt")).Returns("");
        //    var service = new VideoService(mock.Object);

        //    var result = _service.ReadVideoTitle();

        //    Assert.That(result, Does.Contain("Error").IgnoreCase);
        //}


        //[Test]
        //public void ReadFideoTitle_EmptyString_ReturnErrorMessage()
        //{
        //    var service = new VideoService(new FakeFileReader());

        //    var result = service.ReadVideoTitle();

        //    Assert.That(result, Does.Contain("Error").IgnoreCase);
        //}
    }
}
