using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
