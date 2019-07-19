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
        /// 解放済みスキルかどうか。
        /// true なら解放済み、そうでなければ未開放。
        /// </summary>
        public bool IsOpened { get; private set; }

        /// <summary>
        /// 子スキル解放パネル。
        /// </summary>
        public SkillNode[] Children { get; }

        /// <summary>
        /// スキルを解放する。
        /// </summary>
        public void Open() => IsOpened = true;
    }
}