using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Health/Damage
    public int maxHealth = 100;
    public int currentHealth;
    //private DamagingObject dmgO;
    public int toxinDamage = 10;

    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
    /*
    public void takeDamage(int damage)
    {
        currentHealth -= damage;
    }*/

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "DamagingObject")
        {
            currentHealth -= toxinDamage;
            healthBar.SetHealth(currentHealth);

        }
    }
}
