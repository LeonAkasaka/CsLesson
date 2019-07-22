using System;

namespace Skills
{
    /// <summary>
    /// スキルツリー内のスキル解放パネル。
    /// </summary>
    public abstract class SkillNode
    {
        /// <summary>
        /// スキル。
        /// </summary>
        public SkillMaster Skill { get; }

        /// <summary>
        /// 子スキル解放パネル。
        /// </summary>
        public abstract SkillNode[] Children { get; }

        /// <summary>
        /// 解放済みスキルかどうか。
        /// true なら解放済み、そうでなければ未開放。
        /// </summary>
        public bool IsOpened { get; protected set; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="skill">スキル。</param>
        /// <param name="children">子スキル解放パネル。</param>
        public SkillNode(SkillMaster skill)
        {
            Skill = skill ?? throw new ArgumentNullException(nameof(skill));
        }

        /// <summary>
        /// このスキル解放パネルを開けるかどうか。
        /// </summary>
        /// <returns>このスキル解放パネルを開ければ true。そうでなければ false。</returns>
        public abstract bool CanOpen();

        /// <summary>
        /// このスキル解放パネルを開く。
        /// </summary>
        /// <remarks>
        /// スキル解放パネルを開けない場合は <see cref="InvalidOperationException"/> 例外が発生する。
        /// </remarks>
        public abstract void Open();
    }
}