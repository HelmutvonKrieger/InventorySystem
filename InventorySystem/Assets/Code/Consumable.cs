using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Code.ScriptableObjects;

namespace Code.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Item", menuName = "CyStar/ScriptableObjects/ConsumableItem", order = 0)]

    public class Consumable : Item
    {
        [SerializeField] public int UseCount { get => _useCount; set => _useCount = value; }
        private int _useCount;

        Consumable(string name, string description, int maxStacks, int useCount)
        {
            ItemName = name;
            ItemDescription = description;
            ItemMaxStacks = maxStacks;
            UseCount = useCount;
        }
    }
}
