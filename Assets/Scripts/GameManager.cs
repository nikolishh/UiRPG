using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Button toggleShieldButton;

    // Define colors
    public Color shieldOnColor = Color.green;
    public Color shieldOffColor = Color.white;

    void Start()
    {
        UpdateShieldButtonColor(); // sync on start
    }

    public void ToggleShield()
    {
        player.ToggleShield();
        UpdateShieldButtonColor();
    }

    public void UpdateShieldButtonColor()
    {
        ColorBlock cb = toggleShieldButton.colors;
        cb.normalColor = player.shieldActive ? shieldOnColor : shieldOffColor;
        toggleShieldButton.colors = cb;
    }
}

