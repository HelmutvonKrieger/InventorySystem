using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {
    
    [SerializeField] private TextMeshProUGUI itemNameText;
    [SerializeField] private TextMeshProUGUI itemCountText;
    [SerializeField] private Image itemImage;

    public void SetItemInformation(string itemName, string itemCount, Sprite imageSprite = null ) {
        itemNameText.text = itemName;
        itemCountText.text = itemCount;
        if (imageSprite != null) {
            itemImage.sprite = imageSprite;
        }
    }
}
