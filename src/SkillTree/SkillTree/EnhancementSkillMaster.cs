namespace Skills
{
    /// <summary>
    /// パラメーター強化スキルマスター。
    /// </summary>
    public class EnhancementSkillMaster : SkillMaster
    {
        /// <summary>
        /// 強化対象のパラメーター。
        /// </summary>
        public ParamaterType ParamaterType { get; }

        /// <summary>
        /// 強化率。
        /// </summary>
        public double Value { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="cost"></param>
        /// <param name="type"></param>
        /// <param name="value"></param>
        public EnhancementSkillMaster(int id, int cost, ParamaterType type, double value) : base(id, $"{type}{(int)(value * 100)}%", cost)
        {
            ParamaterType = type;
            Value = value;
        }
    }
}
