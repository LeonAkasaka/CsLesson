using System;

namespace Skills
{
    /// <summary>
    /// スキルマスター。
    /// </summary>
    public class SkillMaster
    {
        /// <summary>
        /// スキルID。
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// スキル名。
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// このスキルの取得に消費するスキル解放ポイント。
        /// </summary>
        public int Cost { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="id">スキルID。</param>
        /// <param name="name">スキル名。</param>
        /// <param name="cost">消費するスキル解放ポイント。</param>
        public SkillMaster(int id, string name, int cost)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Cost = cost;
        }
    }
}
