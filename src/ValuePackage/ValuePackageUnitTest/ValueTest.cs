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
            for(var i = 0; i < 1000 ; i++) 
            {
                var s1 = (short)random.Next(short.MinValue, short.MinValue);
                var s2 = (short)random.Next(short.MinValue, short.MinValue);
                var value = Value.Pack(s1, s2);
                var result = Value.UnpackToShort(value);
                Assert.Equal((s1, s2), result);
            }
        }
    }
}
