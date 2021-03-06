﻿using System;
using KatlaSport.DataAccess.ProductStoreHive;
using KatlaSport.Services.HiveManagement;
using Moq;
using Xunit;

namespace KatlaSport.Services.Tests.HiveManagement
{
    public class HiveServiceTests
    {
        [Fact]
        public void Ctor_UserContextIsNull_ArgumentNullExceptionThrown()
        {
            var userContext = new Mock<IUserContext>();
            var exception = Assert.Throws<ArgumentNullException>(() => new HiveService(null, userContext.Object));

            Assert.Equal(typeof(ArgumentNullException), exception.GetType());
        }

        [Fact]
        public void Ctor_ContextIsNull_ArgumentNullExceptionThrown()
        {
            var context = new Mock<IProductStoreHiveContext>();
            var exception = Assert.Throws<ArgumentNullException>(() => new HiveService(context.Object, null));

            Assert.Equal(typeof(ArgumentNullException), exception.GetType());
        }
    }
}
