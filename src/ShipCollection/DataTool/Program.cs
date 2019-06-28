using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ShipCollection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataTool
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("data.json");
            var json = (JObject)JsonConvert.DeserializeObject(text);
            var root = json["api_data"];

            var outputPath = Path.Combine("..", "..", "..", "..", "ShipCollection");

            var shipTypes = root["api_mst_stype"].Select(x => new ShipType()
            {
                Id = x["api_id"].ToObject<int>(),
                Name = x["api_name"].ToString()
            }).ToArray();
            var shipTypesJsonPath = Path.Combine(outputPath, "ShipTypes.json");
            // File.WriteAllText(shipTypesJsonPath, JsonConvert.SerializeObject(shipTypes));

            var ships = root["api_mst_ship"].Select(x => new Ship()
            {
                Id = x["api_id"].ToObject<int>(),
                Name = x["api_name"].ToString(),
                Yomi = x["api_yomi"].ToString(),
                Type = x["api_stype"].ToObject<int>(),
                AfterShip = x["api_aftershipid"]?.ToObject<int>()
            }).Where(x => x.AfterShip != null).ToArray();
            var shipsJsonPath = Path.Combine(outputPath, "Ships.json");
            // File.WriteAllText(shipsJsonPath, JsonConvert.SerializeObject(ships));

            WriteGetRootShipTestData(ships, shipTypes);
        }

        static void WriteGetShipTypeShipTestData(Ship[] ships, ShipType[] shipTypes)
        {
            foreach (var s in ships)
            {
                var type = shipTypes.First(x => x.Id == s.Type);
                Console.WriteLine($"yield return new object[] {{ {s.Id}, {type.Id} }};");
            }
        }

        static void WriteGetShipsTestData(Ship[] ships, ShipType[] shipTypes)
        {
            foreach (var t in shipTypes)
            {
                var ids  = ships.Where(x => x.Type == t.Id).Select(x => x.Id);
                Console.WriteLine($"yield return new object[] {{ {t.Id}, new int[] {{ {string.Join(',', ids)} }} }};");
            }
        }

        static void WriteGetAfterShipTestData(Ship[] ships, ShipType[] shipTypes)
        {
            foreach (var s in ships)
            {
                var afterShip = ships.FirstOrDefault(x => x.Id == s.AfterShip);
                Console.WriteLine($"yield return new object[] {{ {s.Id}, {afterShip?.Id.ToString() ?? "null"} }};");
            }
        }

        static void WriteGetAfterShipsTestData(Ship[] ships, ShipType[] shipTypes)
        {
            foreach (var s in ships)
            {
                var list = new List<int>();
                var current = s;
                while (true)
                {
                    var afterShip = ships.FirstOrDefault(x => x.Id == current.AfterShip);
                    if(afterShip == null || list.Contains(afterShip.Id)) { break; }
                    list.Add(afterShip.Id);
                    current = afterShip;
                }

                Console.WriteLine($"yield return new object[] {{ {s.Id}, new int[] {{ {string.Join(',', list)} }} }};");
            }
        }

        static void WriteGetBeforeShipTestData(Ship[] ships, ShipType[] shipTypes)
        {
            foreach (var s in ships)
            {
                var beforeShips = ships.Where(x => x.AfterShip == s.Id).ToArray();
                if (beforeShips.Length == 0)
                {
                    Console.WriteLine($"yield return new object[] {{ {s.Id}, null }};");
                }
                else if (beforeShips.Length == 1)
                {
                    Console.WriteLine($"yield return new object[] {{ {s.Id}, {beforeShips[0].Id.ToString() ?? "null"} }};");
                }
                else
                {
                    Ship beforeShip = null;
                    foreach (var bs in beforeShips)
                    {
                        var list = new List<Ship>();
                        var currentShip = bs;
                        while (true)
                        {
                            currentShip = ships.FirstOrDefault(x => x.AfterShip == currentShip.Id);
                            if (list.Contains(currentShip)) { break; } // 循環した
                            else if(currentShip == null) // ルートまで到達した
                            {
                                beforeShip = bs;
                                break;
                            } 
                            list.Add(currentShip);
                        }
                        if (beforeShip != null) { break; }
                    }

                    Console.WriteLine($"yield return new object[] {{ {s.Id}, {beforeShip.Id.ToString() ?? "null"} }};");
                }
            }
        }

        static void WriteGetBeforeShipsTestData(Ship[] ships, ShipType[] shipTypes)
        {
            Ship[] GetBeforeShips(Ship ship, Ship[] inner)
            {
                var beforeShips = ships.Where(x => x.AfterShip == ship.Id).ToArray();
                if (beforeShips.Length == 0 || beforeShips.Intersect(inner).Any())
                {
                    return Array.Empty<Ship>();
                }
                var next = inner.Concat(beforeShips).ToArray();
                return beforeShips.Concat(beforeShips.SelectMany(x => GetBeforeShips(x, next))).Distinct().ToArray();
            }

            foreach (var s in ships)
            {
                var ids = GetBeforeShips(s, Array.Empty<Ship>()).Select(x => x.Id);
                Console.WriteLine($"yield return new object[] {{ {s.Id}, new int[] {{ {string.Join(',', ids)} }} }};");
            }
        }

        static void WriteGetRootShipTestData(Ship[] ships, ShipType[] shipTypes)
        {
            foreach(var s in ships)
            {
                var beforeShips = ships.Where(x => x.AfterShip == s.Id).ToArray();
                if (beforeShips.Length == 0)
                {
                    Console.WriteLine($"yield return new object[] {{ {s.Id}, {s.Id} }};"); // 自分がルート
                }
                else
                {
                    Ship rootShip = null;
                    foreach (var bs in beforeShips)
                    {
                        var list = new List<Ship>();
                        var currentShip = bs;
                        while (true)
                        {
                            var before = ships.FirstOrDefault(x => x.AfterShip == currentShip.Id);
                            if (list.Contains(before)) { break; } // 循環した
                            else if (before == null) // ルートまで到達した
                            {
                                rootShip = currentShip;
                                break;
                            }
                            list.Add(before);
                            currentShip = before;
                        }
                        if (rootShip != null) { break; }
                    }

                    Console.WriteLine($"yield return new object[] {{ {s.Id}, {rootShip.Id} }};");
                }
            }
        }
    }
}
