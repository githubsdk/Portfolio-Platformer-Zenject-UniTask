using System;
using UnityEngine;
using Scripts.Model.Data.Properties;

namespace Scripts.Model.Data
{
    [Serializable]
    public class PlayerData
    {
        [SerializeField] private InventoryData _inventory;

        public IntProperty Hp = new IntProperty();
        public FloatProperty Fuel = new FloatProperty();
        public PerksData Perks = new PerksData();
        public LevelData Levels = new LevelData();
        public InventoryData Inventory => _inventory;

        public PlayerData Clone()
        {
            string json = JsonUtility.ToJson(this);
            return JsonUtility.FromJson<PlayerData>(json);
        }
    }
}