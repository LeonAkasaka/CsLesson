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
                yield return new object[] { new ActivityPoint(0, 1, TimeSpan.FromMinutes(1)), TimeSpan.FromMinutes(1) };
                yield return new object[] { new ActivityPoint(0, 10, TimeSpan.FromMinutes(1)), TimeSpan.FromMinutes(10) };
                yield return new object[] { new ActivityPoint(0, 10, TimeSpan.Zero), TimeSpan.Zero };
                yield return new object[] { new ActivityPoint(30, 50, TimeSpan.FromMinutes(1)), TimeSpan.FromMinutes(20) };
                yield return new object[] { new ActivityPoint(150, 100, TimeSpan.FromMinutes(1)), TimeSpan.Zero };
                yield return new object[] { new ActivityPoint(10, 70, TimeSpan.FromSeconds(1)), TimeSpan.FromMinutes(1) };
                yield return new object[] { new ActivityPoint(10, 10, TimeSpan.FromSeconds(1)), TimeSpan.Zero };
                yield return new object[] { new ActivityPoint(0, 10, TimeSpan.FromSeconds(-1)), TimeSpan.FromSeconds(-10) };
                yield return new object[] { new ActivityPoint(100, 250, TimeSpan.FromTicks(3)), TimeSpan.FromTicks(450) };
            }
        }

        [Theory]
        [MemberData(nameof(GetTotalRecoveryIntervalTestData))]
        public void GetTotalRecoveryIntervalTest(ActivityPoint pt, TimeSpan expected)
        {
            var actual = pt.GetTotalRecoveryInterval();
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> GetMaxRevoveryTimeTestData
        {
            get
            {
                var now = DateTimeOffset.Now;
                yield return new object[] { new ActivityPoint(0, 0, TimeSpan.Zero), now, now };
                yield return new object[] { new ActivityPoint(0, 1, TimeSpan.FromMinutes(1)), now, now.AddMinutes(1) };
                yield return new object[] { new ActivityPoint(0, 10, TimeSpan.FromMinutes(1)), now, now.AddMinutes(10) };
                yield return new object[] { new ActivityPoint(30, 54, TimeSpan.FromHours(1)), now, now.AddDays(1) };
                yield return new object[] { new ActivityPoint(100, 100, TimeSpan.FromHours(1)), now, now };
            }
        }

        [Theory]
        [MemberData(nameof(GetMaxRevoveryTimeTestData))]
        public void GetMaxRevoveryTimeTest(ActivityPoint pt, DateTimeOffset now, DateTimeOffset expected)
        {
            var actual = pt.GetMaxRevoveryTime(now);
            Assert.Equal(expected, actual);
        }
    }
}
