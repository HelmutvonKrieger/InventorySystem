using Code.ScriptableObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Code
{
    public static class PlayerManager
    {
        private static int _playerHealth;
        private static int _playerMana;
        private static int _playerStamina;

        public static int PlayerMaxHealth;
        public static int PlayerMaxMana;
        public static int PlayerMaxStamina;

        public static string PlayerName { get; set; }
        public static int PlayerCurrentHealth
        {
            get => _playerHealth;
            set => setPlayerHealth(value);
        }

        public static int PlayerCurrentMana
        {
            get => _playerMana;
            set => setPlayerMana(value);
        }

        public static int PlayerCurrentStamina
        {
            get => _playerStamina;
            set => setPlayerStamina(value);
        }
        public static Dictionary<string, Item> PlayerCurrentInventory { get; set; }

        #region Public Methods

        public static void ModifyPlayerHealth(int amount)
        {
            setPlayerHealth(amount);
        }

        public static void ModifyPlayerMana(int amount)
        {
            setPlayerMana(amount);
        }

        public static void ModifyPlayerStamina(int amount)
        {
            setPlayerStamina(amount);
        }

        #endregion Public Methods

        #region Private Methods

        private static void setPlayerHealth(int amount)
        {
            if (amount + _playerHealth >= PlayerMaxHealth)
            {
                _playerHealth = PlayerMaxHealth;
                return;
            }

            if (amount + _playerHealth <= 0)
            {
                _playerHealth = 0;
                return;
            }

            _playerHealth = _playerHealth + amount;
        }

        private static void setPlayerMana(int amount)
        {
            if (amount + _playerMana >= PlayerMaxMana)
            {
                _playerMana = PlayerMaxMana;
                return;
            }

            if (amount + _playerMana <= 0)
            {
                _playerMana = 0;
                return;
            }

            _playerMana = _playerMana + amount;
        }

        private static void setPlayerStamina(int amount)
        {
            if (amount + _playerStamina >= PlayerMaxStamina)
            {
                _playerStamina = PlayerMaxStamina;
                return;
            }

            if (amount + _playerStamina <= 0)
            {
                _playerStamina = 0;
                return;
            }

            _playerStamina = _playerStamina + amount;
        }

        #endregion Private Methods
    }
}
