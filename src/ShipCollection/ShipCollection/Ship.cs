using Newtonsoft.Json;
using System.IO;

namespace ShipCollection
{
    /// <summary>
    /// 艦船を表す。
    /// </summary>
    public class Ship
    {
        /// <summary>
        /// この艦船を識別する一意な値。
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// この艦船を改造した結果となる艦船 ID。
        /// 改造できない場合は 0 または null。
        /// </summary>
        /// <remarks>
        /// ゲームのルールとして、艦船はアップグレードすることができるものとする。これを「改造」と呼ぶ。
        /// この船を改造すると、結果として <see cref="AfterShip"/> が指す ID の艦船に変化する。
        /// </remarks>
        public int? AfterShip { get; set; }

        /// <summary>
        /// この艦船の名前。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// この艦船の種類を指す <see cref="ShipType.Id"/> に対応する値。
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// この艦船の名前の読み。
        /// </summary>
        public string Yomi { get; set; }

        private static Ship[] _ships;
        public static Ship[] LoadAll()
        {
            if (_ships == null)
            {
                var json = File.ReadAllText("Ships.json");
                _ships = JsonConvert.DeserializeObject<Ship[]>(json);
            }

            return _ships;
        }
    }
}
