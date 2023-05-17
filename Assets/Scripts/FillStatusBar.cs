using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FillStatusBar : MonoBehaviour
{
    public PlayerController player;
    public Image fillImage;
    private Slider slider;
    private TextMeshProUGUI healthText;
    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();  
        healthText = GetComponentInChildren<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float fillValue = player.currentHealth / player.maxHealth;
        slider.value = fillValue;
        healthText.text = "Health: " + player.currentHealth.ToString();
    }
}

  

