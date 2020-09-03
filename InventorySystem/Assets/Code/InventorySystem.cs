using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Code.ScriptableObjects;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] public int NumInventorySpaces = 0;

    public List<Item> InventoryItemList;

    private int _numInventorySpaces { get => NumInventorySpaces; set => NumInventorySpaces = value; }
}
