using LoginMVC.Controllers;
using LoginMVC.Models;
using LoginMVC.UnitTests.Mocks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace LoginMVC.UnitTests
{
    public class LoginTest
    {
        [Fact]
        public void Should_Get_All_Users()
        {
            //Arrange
            var mockLoginService = new MockLoginService().MockGetAll(new List<LoginModel>());

            var controller = new LoginController(mockLoginService.Object);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsAssignableFrom<ViewResult>(result);
        }

    }
}
