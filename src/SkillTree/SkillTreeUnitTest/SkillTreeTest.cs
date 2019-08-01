using Skills;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [Fact]
        public void CtorTest()
        {
            // null 例外
            Assert.Throws<ArgumentNullException>(() => new SkillTree(null, null));
            Assert.Throws<ArgumentNullException>(() => new SkillTree(null, Masters));
            Assert.Throws<ArgumentNullException>(() => new SkillTree(new SkillNode(1), null));

            // 存在しない ID を指定した。
            Assert.Throws<ArgumentException>(() => new SkillTree(new SkillNode(0), Masters));

            var id = Masters[0].Id;
            var i = new SkillTree(new SkillNode(id), Masters);
            Assert.Equal(id, i.RootSkill.Skill.Id);
        }

        public static IEnumerable<object[]> GetCountTestData
        {
            get
            {
                var ids = Masters.Select(x => x.Id).ToArray();
                yield return new object[] { new SkillTree(new SkillNode(ids[0]), Masters), 1 };
                yield return new object[] { new SkillTree(new SkillNode(ids[0], ids[1]), Masters), 2 };
                yield return new object[] { new SkillTree(new SkillNode(ids[0], ids[1], ids[2]), Masters), 3 };


                yield return new object[]
                {
                    new SkillTree(
                        new SkillNode(ids[0],
                            new SkillNode(ids[1]),
                            new SkillNode(ids[2])
                        ), Masters
                    ), 3
                };

                yield return new object[]
                {
                    new SkillTree(
                        new SkillNode(ids[0],
                            new SkillNode(ids[1], ids[2], ids[3]),
                            new SkillNode(ids[4], ids[5])
                        ), Masters
                    ), 6
                };
            }
        }

        [Theory]
        [MemberData(nameof(GetCountTestData))]
        public void CountTest(SkillTree tree, int expected)
        {
            Assert.Equal(expected, tree.Count);
        }

        public static IEnumerable<object[]> GetOpenedSkillsTestData
        {
            get
            {
                yield return new object[] { };
            }
        }

        [Theory]
        [MemberData(nameof(GetOpenedSkillsTestData))]
        public void OpenedSkillsTest(SkillTree tree, SkillMaster[] expected)
        {

        }

        public static IEnumerable<object[]> GetFindNodesTestData
        {
            get
            {
                yield return new object[] { };
            }
        }

        [Theory]
        [MemberData(nameof(GetFindNodesTestData))]
        public void FindNodesTest(SkillTree tree, SkillNode[] expected)
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
