using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
{
    [SerializeField] private float currentHealth = 100;
    public Slider slider;
    void Start()
    {
        float currentHealth;
    }

    private void Update()
    {
        slider.value = currentHealth;
        if (currentHealth > 0)
        {
            currentHealth = currentHealth - 0.05f;
        }
        if (currentHealth <= 0)
        {
            currentHealth = 100f;
        }
    }
    private void Hit()
    {
        currentHealth = currentHealth - 20f;
    }


   
}
