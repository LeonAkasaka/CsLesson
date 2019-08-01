using System;
using System.Linq;

namespace Skills
{
    /// <summary>
    /// スキルノード。
    /// </summary>
    public class SkillNode
    {
        /// <summary>
        /// このノードの <see cref="SkillMaster.Id"/> に対応する値。
        /// </summary>
        public int SkillMasterId { get; }

        /// <summary>
        /// 子スキルノード。
        /// </summary>
        public SkillNode[] Children { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="skillMasterId">スキルID。</param>
        public SkillNode(int skillMasterId) : this(skillMasterId, Array.Empty<SkillNode>())
        {

        }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="skillMasterId">スキルID。</param>
        /// <param name="children">子ノードのスキルID一覧。</param>
        public SkillNode(int skillMasterId, params int[] children) : this(skillMasterId, children.Select(x => new SkillNode(x)).ToArray())
        {
        }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="skillMasterId">スキルID。</param>
        /// <param name="children">子スキルノードの一覧。</param>
        public SkillNode(int skillMasterId, params SkillNode[] children)
        {
            SkillMasterId = skillMasterId;
            Children = children ?? throw new ArgumentNullException(nameof(children));
        }
    }
}