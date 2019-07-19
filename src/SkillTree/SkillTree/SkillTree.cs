using System;
using System.Collections.Generic;

namespace Skills
{
    /// <summary>
    /// スキルツリー。
    /// </summary>
    public class SkillTree
    {
        /// <summary>
        /// スキル解放ポイント。
        /// </summary>
        public int SkillPoint { get; private set; }

        /// <summary>
        /// ルートスキルパネル。
        /// </summary>
        public SkillNode RootSkill { get; }

        /// <summary>
        /// このスキルツリー内のスキル解放パネルの数。
        /// </summary>
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// 解放済みスキル一覧。
        /// </summary>
        public IEnumerable<SkillMaster> OpenedSkills
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// スキル解放パネルを検索する。
        /// </summary>
        /// <param name="skill"></param>
        /// <returns></returns>
        public SkillNode FindNode(SkillMaster skill)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// スキル解放パネルを検索する。
        /// </summary>
        /// <param name="skill"></param>
        /// <returns></returns>
        public IEnumerable<SkillNode> FindNodes(SkillMaster skill)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 指定のスキル解放パネルを開けるかどうか。
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool CanOpen(SkillNode node)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 指定のスキル解放パネルを開く。
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public IEnumerable<SkillNode> Open(SkillNode node)
        {
            throw new NotImplementedException();
        }
    }
}
