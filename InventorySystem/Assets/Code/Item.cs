using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Code.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Item", menuName = "CyStar/ScriptableObjects/Item", order = 0)]

    public class Item : ScriptableObject
    {

        [SerializeField] public Sprite ItemSprite;
        [SerializeField] public string ItemName;
        [SerializeField] public string ItemDescription;
        [SerializeField] public int ItemMaxCount;
        [SerializeField] public int ItemCurrentCount;

        public void DisplayItemDescription()
        {
            Debug.Log(ItemDescription);
        }
    }
}


