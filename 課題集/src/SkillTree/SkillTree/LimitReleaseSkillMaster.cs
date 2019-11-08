namespace Skills
{
    /// <summary>
    /// 上限解放スキルマスター。
    /// </summary>
    public class LimitReleaseSkillMaster : SkillMaster
    {
        /// <summary>
        /// 上限解放するパラメーター。
        /// </summary>
        public ParamaterType ParamaterType { get; }

        /// <summary>
        /// 上限に加算する値。
        /// </summary>
        public int Value { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cost"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public LimitReleaseSkillMaster(int id, int cost, ParamaterType type, int value) : base(id, $"{type}上限+{value}UP", cost)
        {
            ParamaterType = type;
            Value = value;
        }
    }
}
