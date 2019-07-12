using System;
using System.Collections.Generic;
using TimeCalc;
using Xunit;

namespace TimeCalcUnitTest
{
    public class ActivityPointUnitTest
    {
        public static IEnumerable<object[]> GetTotalRecoveryIntervalTestData
        {
            get
            {
                yield return new object[] { new ActivityPoint(0, 0, TimeSpan.Zero), TimeSpan.Zero };
            }
        }

        [Theory]
        [MemberData(nameof(GetTotalRecoveryIntervalTestData))]
        public void GetTotalRecoveryIntervalTest(ActivityPoint pt, TimeSpan expected)
        {
            var actual = pt.GetTotalRecoveryInterval();
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetMaxRevoveryTimeTest()
        {

        }
    }
}
