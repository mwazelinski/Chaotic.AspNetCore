using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Chaotic.AspNetCore.Test
{
    public class ChaoticMiddlewareTests
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, 2 + 2);
        }
    }
}
