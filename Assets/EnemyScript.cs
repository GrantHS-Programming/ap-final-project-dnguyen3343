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
private Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
        chosenLocation = 0;
        maxHealth = data.hp;
        currentHealth = data.hp;
        damage = data.damage;
        speed = data.speed; 
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(chosenLocation);
        if (transform.position.x == chosenLocation){ 
            chosenLocation = Random.Range(-8f,8f);
        }
        target = new Vector2(chosenLocation, transform.position.y);
        transform.position = Vector2.MoveTowards(transform.position, (target) ,speed *Time.deltaTime);
        
    }
}
