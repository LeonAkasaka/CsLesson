using Skills;
using System;
using System.Collections.Generic;
using Xunit;

namespace SkillTreeUnitTest
{
    public class SkillTreeTest
    {
        public static SkillMaster[] Masters { get; }

        public static IEnumerable<object[]> GetCountTestData
        {
            get
            {
                var m = Masters[0];
                yield return new object[] { new SkillTree(new SkillNode(m)), 0 };
            }
        }

        [Theory]
        [MemberData(nameof(GetCountTestData))]
        public void CountTest(SkillTree tree, int expected)
        {
            Assert.Equal(expected, tree.Count);
        }

        [Fact]
        public void OpenedSkillsTest()
        {

        }

        [Fact]
        public void FindNodeTest()
        {

        }

        [Fact]
        public void FindNodesTest()
        {

        }

        [Fact]
        public void CanOpenTest()
        {

        }

        [Fact]
        public void OpenTest()
        {

        }
    }
}
