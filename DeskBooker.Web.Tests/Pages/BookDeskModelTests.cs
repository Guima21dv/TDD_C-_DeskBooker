using DeskBooker.Core.Domain;
using DeskBooker.Core.Processor;
using DeskBooker.Web.Pages;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xunit;

namespace DeskBooker.Web.Tests.Pages
{
    public class BookDeskModelTests
    {
        [Fact]
        public void ShouldCallBookDeskMethodOfProcessor()
        {
            //Arange
            var processorMock = new Mock<IDeskBookingRequestProcessor>();

            var bookDeskModel = new BookDeskModel(processorMock.Object)
            {
                DeskBookingRequest = new DeskBookingRequest()
            };
            //Act
            bookDeskModel.OnPost();

            //Assert
            processorMock.Verify(x => x.BookDesk(bookDeskModel.DeskBookingRequest),
                Times.Once);

        }
    }
}