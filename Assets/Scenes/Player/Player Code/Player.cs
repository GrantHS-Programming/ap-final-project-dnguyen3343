using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private PlayerData data;

    private int maxHealth;
    private int currentHealth;
    private int damage;
    private int burstNumber;
    private int maxCapacity;
    private double firingSpeed;
    private string weapon;


    // Start is called before the first frame update
    void Start()
    {
        maxHealth = data.hp;
        currentHealth = data.hp;
        damage = data.damage;
        burstNumber = data.burstNumber;
        maxCapacity = data.maxCapacity;
        firingSpeed = data.firingSpeed;
        weapon = data.weapon;
    
    }

}
