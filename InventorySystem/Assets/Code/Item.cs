using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Item", menuName = "CyStar/ScriptableObjects/Item", order = 0)]

    public class Item : ScriptableObject
    {
        [SerializeField] public string ItemName;
        [SerializeField] public string ItemDescription;
        [SerializeField] public int ItemMaxStacks;

        private string _itemName { get => ItemName; set => ItemName = value; }
        private string _itemDescription { get => ItemDescription; set => ItemDescription = value; }
        private int _itemMaxStacks { get => ItemMaxStacks; set => ItemMaxStacks = value; }
    }
}


