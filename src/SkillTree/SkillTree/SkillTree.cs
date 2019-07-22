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
        public int SkillPoint { get; set; }

        /// <summary>
        /// ルートスキルパネル。
        /// </summary>
        public SkillNode RootSkill { get;  }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="data">スキルツリー生成データ。</param>
        /// <param name="masters">スキルマスター一覧。</param>
        public SkillTree(SkillTreeData data, SkillMaster[] masters)
        {
            throw new NotImplementedException();
        }

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
    }
}
