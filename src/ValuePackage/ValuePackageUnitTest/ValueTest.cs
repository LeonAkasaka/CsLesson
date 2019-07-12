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
