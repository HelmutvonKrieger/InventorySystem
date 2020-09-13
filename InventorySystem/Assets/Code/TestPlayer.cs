using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Code.ScriptableObjects;
using System.Linq;
using Assets.Code;

public class TestPlayer : MonoBehaviour
{ 
    [SerializeField] public InventorySystem InventorySystem;
    [SerializeField] public int PlayerMaxHealth = 100;
    [SerializeField] public int PlayerMaxMana = 100;
    [SerializeField] public int PlayerMaxStamina = 100;

    [SerializeField] public StatusBar HealthBar;
    [SerializeField] public StatusBar ManaBar;
    [SerializeField] public StatusBar StaminaBar;

    [SerializeField] public int PlayerHealth;
    [SerializeField] public int PlayerMana;
    [SerializeField] public int PlayerStamina;

    // Start is called before the first frame update
    void Start()
    {
        PlayerHealth = PlayerMaxHealth;
        PlayerMana = PlayerMaxMana;
        PlayerStamina = PlayerMaxStamina;

        SetPlayerState();
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.NewValue = PlayerManager.PlayerCurrentHealth;
        ManaBar.NewValue = PlayerManager.PlayerCurrentMana;
        StaminaBar.NewValue = PlayerManager.PlayerCurrentStamina;
    }

    #region Public Methods

    public void DamagePlayer()
    {
        PlayerManager.ModifyPlayerHealth(-20);
        return;
    }

    public void UseHealthPotion()
    {
        PlayerManager.ModifyPlayerHealth(15);
        return;
    }

    public void CastSpell()
    {
        PlayerManager.ModifyPlayerMana(-30);
        return;
    }

    public void UseManaPotion()
    {
        PlayerManager.ModifyPlayerMana(15);
        return;
    }

    public void AddItem()
    {
        Consumable staminaPot = ScriptableObject.CreateInstance<Consumable>();
        staminaPot.ItemName = "Stamina Potion";
        staminaPot.ItemDescription = "Consume to restore 15 SP";
        staminaPot.ItemCurrentCount = 6;
        staminaPot.ItemSprite = Resources.Load<Sprite>("PotionIconsAdd_19");

        PlayerManager.AddItemToInventory(staminaPot);
    }

    public void SetPlayerState()
    {
        PlayerManager.PlayerName = "Doug";
        PlayerManager.PlayerMaxHealth = PlayerMaxHealth;
        PlayerManager.PlayerMaxMana = PlayerMaxMana;
        PlayerManager.PlayerMaxStamina = PlayerMaxStamina;
        PlayerManager.PlayerCurrentHealth = PlayerHealth;
        PlayerManager.PlayerCurrentMana = PlayerMana;
        PlayerManager.PlayerCurrentStamina = PlayerStamina;
        //PlayerManager.PlayerCurrentInventory = InventorySystem.InventoryItemDict;
    }

    public void TestGetPlayerState()
    {
        Debug.Log($"Player state: " +
            $"\nName: {PlayerManager.PlayerName}" +
            $"\nHP: {PlayerManager.PlayerCurrentHealth}" +
            $"\nMP: {PlayerManager.PlayerCurrentMana}" +
            $"\nSP: {PlayerManager.PlayerCurrentStamina}" +
            $"\nInventory: {PlayerManager.PlayerCurrentInventory}");
    }

    #endregion Public Methods

    #region Private Methods

    #endregion Private Methods
}
