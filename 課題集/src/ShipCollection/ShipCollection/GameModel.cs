using System;

namespace ShipCollection
{
    /// <summary>
    /// 艦隊をコレクションする感じのゲームを想定。
    /// </summary>
    public class GameModel
    {
        /// <summary>
        /// 艦船マスター一覧。
        /// </summary>
        public Ship[] Ships { get; }

        /// <summary>
        /// 艦種マスター一覧。
        /// </summary>
        public ShipType[] ShipTypes { get; }

        /// <summary>
        /// コンストラクター。
        /// </summary>
        public GameModel()
        {
            Ships = Ship.LoadAll();
            ShipTypes = ShipType.LoadAll();
        }

        /// <summary>
        /// 指定 ID に対応する <see cref="Ship"/> オブジェクトを取得する。
        /// </summary>
        /// <param name="id"><see cref="Ship.Id"/>に対応する値。</param>
        /// <returns>ID に一致する <see cref="Ship"/> オブジェクト。存在しなければ null。</returns>
        public Ship GetShip(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 指定 ID に対応する <see cref="ShipType"/> オブジェクトを取得する。
        /// </summary>
        /// <param name="id"><see cref="ShipType.Id"/>に対応する値。</param>
        /// <returns>ID に一致する <see cref="ShipType"/> オブジェクト。存在しなければ null。</returns>
        public ShipType GetShipType(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 指定艦船の艦種を取得する。
        /// </summary>
        /// <param name="ship">艦船。</param>
        /// <returns>艦船の艦種を表す <see cref="ShipType"/> オブジェクト。存在しなければ null。</returns>
        public ShipType GetShipType(Ship ship)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 指定艦種の艦船を全て取得する。
        /// </summary>
        /// <param name="type">艦種。</param>
        /// <returns>艦種が <paramref name="type"/> に一致する艦船一覧。</returns>
        public Ship[] GetShips(ShipType type)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 改造艦を取得する。
        /// </summary>
        /// <param name="ship">改造する艦船。</param>
        /// <returns>改造後の艦船。改造できなければ null。</returns>
        public Ship GetAfterShip(Ship ship)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 全ての改造艦を取得する。
        /// </summary>
        /// <remarks>
        /// 改造後の艦船がさらに改造できる場合、その全てを辿って配列で返す。（例: 千歳・千代田）
        /// 改造後の船が循環した場合、最初に循環した時点で辿るのを停止する。（例: 赤城）
        /// </remarks>
        /// <param name="ship">改造する艦船。</param>
        /// <returns>全ての改造後の艦船。</returns>
        public Ship[] GetAfterShips(Ship ship)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 改造前の船を取得する。
        /// </summary>
        /// <remarks>
        /// 改造が循環する艦船の場合、<see cref="GetRootShip(Ship)" /> から最初にこの艦船に到達する艦船。
        /// 例: 翔鶴 -> 翔鶴改 -> 翔鶴改二 <-> 翔鶴改二甲
        /// <paramref name="ship"/> が翔鶴改二の場合、戻り値は翔鶴改。
        /// </remarks>
        /// <param name="ship">改造前の艦船。</param>
        /// <returns>改造前の艦船。存在しなければ null。</returns>
        public Ship GetBeforeShip(Ship ship)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 全ての改造前の船を取得する。
        /// </summary>
        /// <param name="ship">改造前の艦船。</param>
        /// <returns>すべての改造前の艦船。存在しなければ null。</returns>
        public Ship[] GetBeforeShips(Ship ship)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 未改造状態の最初の艦船を取得する。
        /// </summary>
        /// <remarks>
        /// <paramref name="ship"/> が未改造の艦船の場合、それを返す。
        /// </remarks>
        /// <param name="ship">改造後の艦船。</param>
        /// <returns>ルート艦船。</returns>
        public Ship GetRootShip(Ship ship)
        {
            throw new NotImplementedException();
        }
    }
}
