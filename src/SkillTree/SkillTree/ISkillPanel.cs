using System;

namespace Skills
{
    /// <summary>
    /// スキルツリー内のスキル解放パネル。
    /// </summary>
    public interface ISkillPanel
    {
        /// <summary>
        /// スキル。
        /// </summary>
        SkillMaster Skill { get; }

        /// <summary>
        /// 子スキル解放パネル。
        /// </summary>
        ISkillPanel[] Children { get; }

        /// <summary>
        /// 解放済みスキルかどうか。
        /// true なら解放済み、そうでなければ未開放。
        /// </summary>
        bool IsOpened { get; }

        /// <summary>
        /// このスキル解放パネルを開けるかどうか。
        /// </summary>
        /// <returns>このスキル解放パネルを開ければ true。そうでなければ false。</returns>
        bool CanOpen();

        /// <summary>
        /// このスキル解放パネルを開く。
        /// </summary>
        /// <remarks>
        /// スキル解放パネルを開けない場合は <see cref="InvalidOperationException"/> 例外が発生する。
        /// </remarks>
        void Open();
    }
}
