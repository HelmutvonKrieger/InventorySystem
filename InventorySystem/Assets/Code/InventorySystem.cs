using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using Code.ScriptableObjects;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] public int NumInventorySpaces;
    [SerializeField] public Dictionary<string, Item> InventoryItemDict;
    [SerializeField] public TMP_Dropdown InventoryDropdown;

    void Start()
    {
        Consumable healthPot = ScriptableObject.CreateInstance<Consumable>() ;
        healthPot.ItemName = "Health Potion";
        healthPot.ItemDescription = "Consume to restore 15 HP";

        Consumable manaPot = ScriptableObject.CreateInstance<Consumable>();
        healthPot.ItemName = "Mana Potion";
        healthPot.ItemDescription = "Consume to restore 15 MP";

        Gear ironSword = ScriptableObject.CreateInstance<Gear>();
        healthPot.ItemName = "Iron Sword";
        healthPot.ItemDescription = "A slightly rusty sword that has seen better days";

        InventoryItemDict = new Dictionary<string, Item>()
        {
            { "Health Potion", healthPot },
            { "Mana Potion", manaPot },
            { "Sword", ironSword }
        };

        InventoryDropdown.ClearOptions();
        InventoryDropdown.AddOptions(InventoryItemDict.Keys.ToList());
        InventoryDropdown.onValueChanged.AddListener(DropdownValueChanged);
    }

    private void DropdownValueChanged(int position)
    {
        Item item = InventoryItemDict.Values.ElementAt(position);
        Debug.Log($"{item.ItemName} : {item.ItemDescription}");
    }

    void Update()
    {

    }

    public Item GetInventoryItem(string itemName)
    {
        Item testItem = ScriptableObject.CreateInstance<Consumable>();
        testItem.ItemName = "Stamina Potion";
        testItem.ItemDescription = "Consume to restore 15 SP";
        return testItem;
    }
}
