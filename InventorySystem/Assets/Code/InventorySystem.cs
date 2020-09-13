using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using Code.ScriptableObjects;
using UnityEngine.UIElements;
using Assets.Code;

public class InventorySystem : MonoBehaviour
{
    [SerializeField] public int NumInventorySpaces;
    [SerializeField] public Dictionary<string, Item> InventoryItemDict;

    [SerializeField] private GameObject inventorySlotPrefab;
    [SerializeField] private Transform inventoryContentTransform;

    [SerializeField] private List<InventorySlot> inventory;

    void Start()
    {
        CreateInventoryItemList();
        PopulateInventory();
    }

    private void CreateInventoryItemList()
    {
        Consumable healthPot = ScriptableObject.CreateInstance<Consumable>();
        healthPot.ItemName = "Health Potion";
        healthPot.ItemDescription = "Consume to restore 15 HP";
        healthPot.ItemCurrentCount = 6;
        healthPot.ItemSprite = Resources.Load<Sprite>("PotionIconsAdd_17");

        Consumable manaPot = ScriptableObject.CreateInstance<Consumable>();
        manaPot.ItemName = "Mana Potion";
        manaPot.ItemDescription = "Consume to restore 15 MP";
        manaPot.ItemCurrentCount = 6;
        manaPot.ItemSprite = Resources.Load<Sprite>("PotionIconsAdd_18");

        Gear ironSword = ScriptableObject.CreateInstance<Gear>();
        ironSword.ItemName = "Iron Sword";
        ironSword.ItemDescription = "A slightly rusty sword that has seen better days";
        ironSword.ItemCurrentCount = 1;
        ironSword.ItemSprite = Resources.Load<Sprite>("swnt_01");

        InventoryItemDict = new Dictionary<string, Item>()
        {
            { "Health Potion", healthPot },
            { "Mana Potion", manaPot },
            { "Sword", ironSword }
        };

        PlayerManager.PlayerCurrentInventory = InventoryItemDict;
    }

    private void PopulateInventory()
    {
        // Initialize variables
        inventory = new List<InventorySlot>();

        if (inventorySlotPrefab == null || inventoryContentTransform == null)
        {
            Debug.Log("[InventorySystem] the inventoryslotprefab or the inventory transform is null");
            return;
        }

        foreach (var inventorySlotItem in InventoryItemDict)
        {
            if (inventorySlotItem.Value.ItemCurrentCount > 0)
            {
                var item = Instantiate(inventorySlotPrefab, inventoryContentTransform);
                var itemSlot = item.GetComponent<InventorySlot>();

                itemSlot.SetItem(inventorySlotItem.Value);

                inventory.Add(itemSlot);
            }
        }
    }

    void Update()
    {
        if (PlayerManager.PlayerCurrentInventory != null && PlayerManager.PlayerCurrentInventory != InventoryItemDict)
        {
            
        }
    }
}
