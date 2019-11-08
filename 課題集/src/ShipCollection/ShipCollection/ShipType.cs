using Newtonsoft.Json;
using System.IO;

namespace ShipCollection
{
    /// <summary>
    /// 艦種を表す。
    /// </summary>
    public class ShipType
    {
        /// <summary>
        /// 艦種を識別する一意な値です。
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 艦船の種類を表す名前です。
        /// </summary>
        public string Name { get; set; }

        private static ShipType[] _shipTypes;
        public static ShipType[] LoadAll()
        {
            if (_shipTypes == null)
            {
                var json = File.ReadAllText("ShipTypes.json");
                _shipTypes = JsonConvert.DeserializeObject<ShipType[]>(json);
            }
            return _shipTypes;
        }
    }
}
