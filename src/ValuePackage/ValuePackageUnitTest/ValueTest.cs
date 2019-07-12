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

            // �e�X�g�Ń����_���g���̗ǂ��Ȃ�����
            // ���}���A�y���������̂œK���Ȓl�g���B
            for (var i = 0; i < 1000; i++)
            {
                var s1 = (short)random.Next(short.MinValue, short.MinValue);
                var s2 = (short)random.Next(short.MinValue, short.MinValue);
                var value = Value.Pack(s1, s2);
                var result = Value.UnpackToShort(value);
                Assert.Equal((s1, s2), result);
            }
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