using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
[SerializeField]
private EnemyData data;

private float chosenLocation;
private int maxHealth;
private int currentHealth;
private int damage;
private float speed;
private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        chosenLocation = Random.Range(-8f,8f);
        target = new Vector3(chosenLocation, transform.position.y, transform.position.z);
        maxHealth = data.hp;
        currentHealth = data.hp;
        damage = data.damage;
        speed = data.speed; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target ,speed *Time.deltaTime);
        if (transform.position.x == chosenLocation){ 
            chosenLocation = Random.Range(-8f,8f);
            target = new Vector3(chosenLocation, transform.position.y, transform.position.z);
        }
    }

}