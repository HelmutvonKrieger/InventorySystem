using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Code.ScriptableObjects;

namespace Code.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Item", menuName = "CyStar/ScriptableObjects/GearItem", order = 0)]

    public class Gear : Item
    {
        [SerializeField] public int Durability { get; set; }
        private int _durability;

        Gear(string name, string description, int maxStacks, int durability)
        {
            ItemName = name;
            ItemDescription = description;
            ItemMaxStacks = maxStacks;
            Durability = durability;
        }
    }
}
