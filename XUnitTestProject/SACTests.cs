using Xunit;
using EVETrader.Api.Controllers;
using Moq;
using EVETrader.Core.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using EVETrader.Api.ViewModel;
using EVETrader.Core.Model;
using System.Collections.Generic;

namespace XUnitTestProject
{

    public class SACTests
    {
        private readonly IMapper autoMapper;

        public SACTests()
        {
            var test = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new EntityMapper());
            });
            this.autoMapper = test.CreateMapper();
        }


        [Fact]
        public void TestSACGetSalesOrder()
        {
            var userTestRep = new Mock<IUserRepository>();
            var salesOrderTestRep = new SalesOrderTestRepository();

            SalesOrdersController obj = new SalesOrdersController(autoMapper, salesOrderTestRep, userTestRep.Object);

            var result = obj.GetSalesOrder(1).Result;
            var okObjectResult = result as OkObjectResult;
            Assert.NotNull(okObjectResult);

            var model = okObjectResult.Value as EVETrader.Api.ViewModel.SalesOrder;
            Assert.NotNull(model);

            var actual = model.Destination;
            var expected = 10;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSACDeleteSalesOrder()
        {
            var userTestRep = new Mock<IUserRepository>();
            var salesOrderTestRep = new SalesOrderTestRepository();

            SalesOrdersController obj = new SalesOrdersController(autoMapper, salesOrderTestRep, userTestRep.Object);

            var whatever = obj.GetSalesOrder(1).Result;
            var okObjectResult2 = whatever as OkObjectResult;
            Assert.NotNull(whatever);

            var result = obj.DeleteSalesOrder(1).Result;
            var okObjectResult = result as OkObjectResult;
            Assert.NotNull(okObjectResult);

            var model = okObjectResult.Value as EVETrader.Api.ViewModel.SalesOrder;
            Assert.NotNull(model);


            var whatever2 = obj.GetSalesOrder(1).Result;
            var notFoundObject = whatever2 as NotFoundResult;
            Assert.NotNull(notFoundObject);
        }

        [Fact]
        public void TestSACGetAllSaleOrders()
        {
            var userTestRep = new Mock<IUserRepository>();
            var salesOrderTestRep = new SalesOrderTestRepository();

            SalesOrdersController obj = new SalesOrdersController(autoMapper, salesOrderTestRep, userTestRep.Object);

            var result = obj.GetSalesOrdersAsync().Result;
            Assert.NotEmpty(result);
        }

        [Fact]
        public void TestSACUpdate()
        {
            var userTestRep = new Mock<IUserRepository>();
            var salesOrderTestRep = new SalesOrderTestRepository();

            SalesOrdersController obj = new SalesOrdersController(autoMapper, salesOrderTestRep, userTestRep.Object);

            EVETrader.Api.ViewModel.SalesOrder updateObj = new EVETrader.Api.ViewModel.SalesOrder()
            {
                Id = 1,
                BuyerID = 1001,
                TraderID = 1010,
                Destination = 10,
                Published = true,
                Tip = 5,
            };

            var result = obj.PutSalesOrder(1, updateObj);
            Assert.Same(updateObj, result);
            //UPDATE NOT IMPLEMENTED
        }

        [Fact]
        public async void TestSACCreate()
        {
            var userTestRep = new Mock<IUserRepository>();
            var salesOrderTestRep = new SalesOrderTestRepository();

            SalesOrdersController obj = new SalesOrdersController(autoMapper, salesOrderTestRep, userTestRep.Object);

            EVETrader.Api.ViewModel.SalesOrder createdObj = new EVETrader.Api.ViewModel.SalesOrder()
            {
                Id = 999,
                BuyerID = 1001,
                TraderID = 1010,
                Destination = 10,
                Published = true,
                Tip = 5,
            };

            var result = await obj.PostSalesOrder(createdObj);
            var test = result as CreatedAtActionResult;
            Assert.NotNull(test);

            var model = test.Value as EVETrader.Api.ViewModel.SalesOrder;
            Assert.NotNull(model);

            Assert.Equal(createdObj.Destination, model.Destination);

            var result2 = await salesOrderTestRep.GetAsync(createdObj.Id);
            Assert.Equal(createdObj.Id, result2.Id);
            
        }
    }
}
