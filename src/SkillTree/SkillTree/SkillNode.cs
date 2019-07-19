using System;
using System.Collections.Generic;

namespace Skills
{
    /// <summary>
    /// スキルツリー内のスキル解放パネル。
    /// </summary>
    public class SkillNode
    {
        /// <summary>
        /// スキル。
        /// </summary>
        public SkillMaster Skill { get; }

        /// <summary>
        /// 子スキル解放パネル。
        /// </summary>
        public SkillNode[] Children { get; }

        /// <summary>
        /// 解放済みスキルかどうか。
        /// true なら解放済み、そうでなければ未開放。
        /// </summary>
        public bool IsOpened { get; private set; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="skill">スキル。</param>
        /// <param name="children">子スキル解放パネル。</param>
        public SkillNode(SkillMaster skill, SkillNode[] children)
        {
            Skill = skill ?? throw new ArgumentNullException(nameof(skill));
            Children = children ?? throw new ArgumentNullException(nameof(children));
        }

        /// <summary>
        /// スキルを解放する。
        /// </summary>
        public void Open() => IsOpened = true;
    }
}