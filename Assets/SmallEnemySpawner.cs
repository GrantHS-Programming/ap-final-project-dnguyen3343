using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject smallEnemyPrefab;


    [SerializeField]
    private float smallEnemyInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy)

    }
    public int whichRow()
    {
        int thisRow = (int) ((Math.Random()*3)+1);
        return thisRow;
    }
    public int leftOrRight()
    {
        int x = (int) ((Math.Random()*2));
        return x;
    }
    public vector3 spawnCoords()
    {
        Vector3 coords = new Vector3();
        int thisRow = whichRow();
        int fromWhere = leftOrRight();
        float x;
        float y;
        float z;

        if (thisRow == 1)
        {
            x = -0.75f;  
            z = -5f; 
        }
        else if (thisRow == 2)
        {
            x = 1.25f;
            z = -7f;
        }
        else
        {
            x = 3.25f;
            z = -9f;
        }
        if (fromWhere == 0)
        {
            y = -9f;
        }
        else 
        {
            y = 9f;
        }



        return (x,y,z);
    }
}
