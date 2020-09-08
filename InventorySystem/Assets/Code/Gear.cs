using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Code.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Item", menuName = "CyStar/ScriptableObjects/Gear", order = 0)]

    public class Gear : Item
    {
        [SerializeField] public int Durability;

        public Gear(string name, string description, int durability)
        {
            ItemName = name;
            ItemDescription = description;
            Durability = durability;
        }
    }
}

