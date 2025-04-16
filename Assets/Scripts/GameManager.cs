using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text playerHealthText;
    public TMP_Text EnemyHealthText;
    public TMP_Text weaponText;
    public Button attackButton;
    public Button healButton;
    public Button toggleShieldButton;
    public Button changeWeaponButton;

    private Player player;
    private Enemy currentEnemy;

    private List<Weapon> weapons = new List<Weapon>();
    private int currentWeaponIndex = 0;

    void Start()
    {
        player = new Player();

        weapons.Add(new Sword());
        weapons.Add(new Axe());
        weapons.Add(new Staff());

        player.currentWeapon = weapons[currentWeaponIndex];

        currentEnemy = new Enemy();

        UpdateUI();
    }

    public void OnAttackPressed()
    {
        player.Attack(currentEnemy);

        if (!currentEnemy.IsAlive())
        {
            currentEnemy = new Enemy(); // respawn
        }
        else
        {
            currentEnemy.Attack(player);
        }

        UpdateUI();
    }

    public void OnHealPressed()
    {
        player.Heal(30);
        UpdateUI();
    }

    public void OnToggleShieldPressed()
    {
        player.ToggleShield();
        UpdateUI();
    }

    public void OnChangeWeaponPressed()
    {
        currentWeaponIndex = (currentWeaponIndex + 1) % weapons.Count;
        player.currentWeapon = weapons[currentWeaponIndex];
        UpdateUI();
    }

    void UpdateUI()
    {
        playerHealthText.text = $"Your health: {player.GetHealth()}";
        weaponText.text = $"Weapon: {player.currentWeapon.weaponName}";
    }
}

