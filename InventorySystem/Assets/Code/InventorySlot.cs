using Assets.Code;
using Code.ScriptableObjects;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour, IPointerClickHandler {
    
    [SerializeField] private TextMeshProUGUI itemNameText;
    [SerializeField] private TextMeshProUGUI itemCountText;
    [SerializeField] private Sprite itemImage;

    private Item item;

    public void SetItem(Item inventoryItem)
    {
        item = inventoryItem;
        SetItemDisplayInformation();
    }

    private void SetItemDisplayInformation() {
        itemNameText.text = item.ItemName;
        itemCountText.text = item.ItemCurrentCount.ToString();
        if (item.ItemSprite != null) {
            itemImage = item.ItemSprite;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
        if (item.GetType() == typeof(Consumable))
        {
            if (item.ItemCurrentCount > 0)
            {
                item.ItemCurrentCount--;
                itemCountText.text = item.ItemCurrentCount.ToString();
                switch (item.ItemName)
                {
                    case "Health Potion":
                        PlayerManager.ModifyPlayerHealth(15);
                        break;
                    case "Mana Potion":
                        PlayerManager.ModifyPlayerMana(15);
                        break;
                    default:
                        Debug.Log("Unknown consumable");
                        break;
                }
                Debug.Log($"Used one {item.ItemName}");
            }
            else
            {
                Debug.Log($"No availabe {item.ItemName}");
                return;
            }
        }
        else if (item.GetType() == typeof(Gear))
        {
            Debug.Log("Is gear");
        }
    }
}
