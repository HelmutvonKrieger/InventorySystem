using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using Code.ScriptableObjects;
using UnityEngine.UIElements;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] public int NumInventorySpaces;
    [SerializeField] public Dictionary<string, Item> InventoryItemDict;
    [SerializeField] public TMP_Dropdown InventoryDropdown;

    [SerializeField] private GameObject inventorySlotPrefab;
    [SerializeField] private Transform inventoryContentTransform;


    [SerializeField] private List<InventorySlot> inventory;

    void Start()
    {
        Consumable healthPot = ScriptableObject.CreateInstance<Consumable>() ;
        healthPot.ItemName = "Health Potion";
        healthPot.ItemDescription = "Consume to restore 15 HP";
        //healthPot.ItemSprite = 

        Consumable manaPot = ScriptableObject.CreateInstance<Consumable>();
        manaPot.ItemName = "Mana Potion";
        manaPot.ItemDescription = "Consume to restore 15 MP";

        Gear ironSword = ScriptableObject.CreateInstance<Gear>();
        ironSword.ItemName = "Iron Sword";
        ironSword.ItemDescription = "A slightly rusty sword that has seen better days";

        InventoryItemDict = new Dictionary<string, Item>()
        {
            { "Health Potion", healthPot },
            { "Mana Potion", manaPot },
            { "Sword", ironSword }
        };

        InventoryDropdown.ClearOptions();
        InventoryDropdown.AddOptions(InventoryItemDict.Keys.ToList());
        InventoryDropdown.onValueChanged.AddListener(DropdownValueChanged);
        
        // Initialize variables
        inventory = new List<InventorySlot>();

        if (inventorySlotPrefab == null || inventoryContentTransform == null) {
            Debug.Log("[InventorySystem] the inventoryslotprefab or the inventory transform is null");
            return;
        }

        foreach (var inventorySlotItem in InventoryItemDict) {
            var item = Instantiate(inventorySlotPrefab, inventoryContentTransform);
            var itemSlot = item.GetComponent<InventorySlot>();
            
            itemSlot.SetItemInformation(inventorySlotItem.Value.ItemName, inventorySlotItem.Value.ItemCurrentCount.ToString(), inventorySlotItem.Value.ItemSprite);

            inventory.Add(itemSlot);
        }
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
