using System;
using System.Linq;

namespace Skills
{
    /// <summary>
    /// スキルツリー生成用のデータ。
    /// </summary>
    public class SkillTreeData
    {
        /// <summary>
        /// このノードの <see cref="SkillMaster.Id"/> に対応する値。
        /// </summary>
        public int SkillMasterId { get; }

        /// <summary>
        /// 子ノードの <see cref="SkillMaster.Id"/> に対応する値の一覧。
        /// </summary>
        public SkillTreeData[] Children { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="skillMasterId">スキルID。</param>
        public SkillTreeData(int skillMasterId) : this(skillMasterId, Array.Empty<int>())
        {
        }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="skillMasterId">スキルID。</param>
        /// <param name="children">子ノードのスキルID一覧。</param>
        public SkillTreeData(int skillMasterId, params int[] children) : this(skillMasterId, children.Select(x => new SkillTreeData(x)).ToArray())
        {
        }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="skillMasterId">スキルID。</param>
        /// <param name="children">子ノードの一覧。</param>
        public SkillTreeData(int skillMasterId, params SkillTreeData[] children)
        {
            SkillMasterId = skillMasterId;
            Children = children ?? throw new ArgumentNullException(nameof(children));
        }
    }
}
