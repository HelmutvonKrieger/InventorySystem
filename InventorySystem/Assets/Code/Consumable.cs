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
        [SerializeField] public int UseCount;
        private int _useCount { get => UseCount; set => UseCount = value; }

        Consumable(string name, string description, int maxStacks, int useCount)
        {
            ItemName = name;
            ItemDescription = description;
            ItemMaxStacks = maxStacks;
            UseCount = useCount;
        }
    }
}
