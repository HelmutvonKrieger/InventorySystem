using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Code.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Item", menuName = "CyStar/ScriptableObjects/Consumable", order = 0)]

    public class Consumable : Item
    {
        [SerializeField] public int UseCount;
        public int RestoreValue;

        public Consumable(string name, string description, int maxCount, int currentCount, int restoreValue, int useCount)
        {
            ItemName = name;
            ItemDescription = description;
            ItemMaxCount = maxCount;
            ItemCurrentCount = currentCount;
            RestoreValue = restoreValue;
            UseCount = useCount;
        }

        public void DoTheThing()
        {
            Debug.LogWarning("I did the thing");
        }
    }
}