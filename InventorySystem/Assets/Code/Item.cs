using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Item", menuName = "CyStar/ScriptableObjects/Item", order = 0)]

    public class Item : ScriptableObject
    {
        private string _itemName;
        private string _itemDescription;
        private int _itemMaxStacks;

        [SerializeField] public string ItemName { get => _itemName; set => _itemName = value; }
        [SerializeField] public string ItemDescription { get => _itemDescription; set => _itemDescription = value; }
        [SerializeField] public int ItemMaxStacks { get => _itemMaxStacks; set => _itemMaxStacks = value; }


    }
}


