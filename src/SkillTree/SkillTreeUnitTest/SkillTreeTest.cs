using Skills;
using System;
using System.Collections.Generic;
using Xunit;

namespace SkillTreeUnitTest
{
    public class SkillTreeTest
    {
        public static SkillMaster[] Masters { get; } = new SkillMaster[]
        {
            new EnhancementSkillMaster(1, 20, ParamaterType.Vocal, 7),
            new EnhancementSkillMaster(2, 30, ParamaterType.Vocal, 7),
            new EnhancementSkillMaster(3, 40, ParamaterType.Vocal, 7),

            new EnhancementSkillMaster(11, 20, ParamaterType.Dance, 7),
            new EnhancementSkillMaster(12, 30, ParamaterType.Dance, 7),
            new EnhancementSkillMaster(13, 40, ParamaterType.Dance, 7),

            new EnhancementSkillMaster(21, 20, ParamaterType.Visual, 7),
            new EnhancementSkillMaster(22, 30, ParamaterType.Visual, 7),
            new EnhancementSkillMaster(23, 40, ParamaterType.Visual, 7),

            new LimitReleaseSkillMaster(31, 50, ParamaterType.Vocal, 50),
            new LimitReleaseSkillMaster(32, 50, ParamaterType.Vocal, 100),
            new LimitReleaseSkillMaster(33, 50, ParamaterType.Vocal, 200),

            new LimitReleaseSkillMaster(41, 50, ParamaterType.Dance, 50),
            new LimitReleaseSkillMaster(42, 50, ParamaterType.Dance, 100),
            new LimitReleaseSkillMaster(43, 50, ParamaterType.Dance, 200),

            new LimitReleaseSkillMaster(51, 50, ParamaterType.Visual, 50),
            new LimitReleaseSkillMaster(52, 50, ParamaterType.Visual, 100),
            new LimitReleaseSkillMaster(53, 50, ParamaterType.Visual, 200),

            new ActiveSkillMaster(101, "ほわっとスマイル", 30),
            new ActiveSkillMaster(102, "ほわっとスマイル+", 50),
        };

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
