using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Code.ScriptableObjects;

public class TestPlayer : MonoBehaviour
{
    private int _playerHealth;
    private int _playerMana;
    private int _playerStamina;

    [SerializeField] public InventorySystem InventorySystem;
    [SerializeField] public int MaxPlayerHealth = 100;
    [SerializeField] public int MaxPlayerMana = 100;
    [SerializeField] public int MaxPlayerStamina = 100;

    [SerializeField] public StatusBar HealthBar;
    [SerializeField] public StatusBar ManaBar;
    [SerializeField] public StatusBar StaminaBar;

    [SerializeField] public int PlayerHealth { 
        get => _playerHealth; 
        set => setPlayerHealth(value);
    }

    [SerializeField] public int PlayerMana {
        get => _playerMana;
        set => setPlayerMana(value);
    }

    [SerializeField] public int PlayerStamina
    {
        get => _playerStamina;
        set => setPlayerStamina(value);
    }

    // Start is called before the first frame update
    void Start()
    {
        _playerHealth = MaxPlayerHealth;
        _playerMana = MaxPlayerMana;
        _playerStamina = MaxPlayerStamina;

        Debug.LogWarning($"Starting health is {PlayerHealth}");
        Debug.LogWarning($"Starting mana is {PlayerMana}");
        Debug.LogWarning($"Starting stamina is {PlayerStamina}");
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.NewValue = PlayerHealth;
        ManaBar.NewValue = PlayerMana;
        StaminaBar.NewValue = PlayerStamina;

        //InvokeRepeating("RechargeMana", 2F, 1F);
    }

    #region Public Methods

    public void DamagePlayer()
    {
        modifyPlayerHealth(-20);
        return;
    }

    public void UseHealthPotion()
    {
        modifyPlayerHealth(30);
        return;
    }

    public void CastSpell()
    {
        modifyPlayerMana(-30);
        return;
    }

    #endregion Public Methods

    #region Private Methods

    #region Modify Stats

    private void modifyPlayerHealth(int amount)
    {
        setPlayerHealth(amount);
    }

    private void modifyPlayerMana(int amount)
    {
        setPlayerMana(amount);
    }

    private void modifyPlayerStamina(int amount)
    {
        setPlayerStamina(amount);
    }

    #endregion Modify Stats

    #region Set Stats
    private void setPlayerHealth(int amount)
    {
        if (amount + _playerHealth >= MaxPlayerHealth)
        {
            _playerHealth = MaxPlayerHealth;
            return;
        }

        if (amount + _playerHealth <= 0)
        {
            _playerHealth = 0;
            return;
        }

        _playerHealth = _playerHealth + amount;
    }

    private void setPlayerMana(int amount)
    {
        if (amount + _playerMana >= MaxPlayerMana)
        {
            _playerMana = MaxPlayerMana;
            return;
        }

        if (amount + _playerMana <= 0)
        {
            _playerMana = 0;
            return;
        }

        _playerMana = _playerMana + amount;
    }

    private void setPlayerStamina(int amount)
    {
        if (amount + _playerMana >= MaxPlayerMana)
        {
            _playerMana = MaxPlayerMana;
            return;
        }

        if (amount + _playerMana <= 0)
        {
            _playerMana = 0;
            return;
        }

        _playerMana = _playerMana + amount;
    }

    #endregion Set Stats

    //private void RechargeMana()
    //{
    //    modifyPlayerMana(1);
    //}

    #endregion Private Methods
}
