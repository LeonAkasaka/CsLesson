using System;
using ValuePackage;
using Xunit;

namespace ValuePackageUnitTest
{
    public class ValueTest
    {
        [Fact]
        public void PackShortTest()
        {
            var random = new Random();

            // テストでランダム使うの良くないけど
            // 取り急ぎ、楽をしたいので適当な値使う。
            for (var i = 0; i < 1000; i++)
            {
                var s1 = (short)random.Next(short.MinValue, short.MaxValue);
                var s2 = (short)random.Next(short.MinValue, short.MaxValue);
                var value = Value.Pack(s1, s2);
                var result = Value.UnpackToShort(value);
                Assert.Equal((s1, s2), result);
            }

            // 最小値と最大値でテスト。
            var minValue = Value.Pack(short.MinValue, short.MinValue);
            var minResult = Value.UnpackToShort(minValue);
            Assert.Equal((short.MinValue, short.MinValue), minResult);

            var maxValue = Value.Pack(short.MaxValue, short.MaxValue);
            var maxResult = Value.UnpackToShort(maxValue);
            Assert.Equal((short.MaxValue, short.MaxValue), maxResult);
        }

        [Fact]
        public void PackBoolTest()
        {
            var max = 27;
            var random = new Random();
            for (var i = 0; i < max; i++)
            {
                var values = new bool[i];
                for (var k = 0; k < values.Length; k++)
                {
                    values[k] = random.NextDouble() < 0.5 ? true : false;
                }

                var value = Value.Pack(values);
                var result = Value.UnpackToBools(value);
                Assert.Equal(values, result);
            }
        }

        [Fact]
        private static void PackBoolNullTest()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Value.Pack((bool[])null);
                ;
            });
        }
    }
}
