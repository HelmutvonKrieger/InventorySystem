using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    [SerializeField] public InventorySystem InventorySystem;
    [SerializeField] public int MaxPlayerHealth = 100;
    [SerializeField] public int MaxPlayerMana = 100;

    [SerializeField] public int PlayerHealth { 
        get => _playerHealth; 
        set => setPlayerHealth(value);
    }

    [SerializeField] public int PlayerMana {
        get => _playerMana;
        set => setPlayerMana(value);
    }

    private int _playerHealth;
    private int _playerMana;

    // Start is called before the first frame update
    void Start()
    {
        _playerHealth = MaxPlayerHealth;
        _playerMana = MaxPlayerMana;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void modifyPlayerHealth(int amount)
    {
        PlayerHealth += amount;
    }

    private void modifyPlayerMana(int amount)
    {
        PlayerMana += amount;
    }

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
}
