using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumEnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject mediumEnemyPrefab;


    [SerializeField]
    private float mediumEnemyInterval = 14f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(mediumEnemyInterval,mediumEnemyPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        Vector3 temp = new Vector3();
        temp = spawnCoords();
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(temp.x,temp.y,temp.z),Quaternion.identity);
        StartCoroutine(spawnEnemy(interval,enemy));
    }

   public int whichRow()
    {
        int thisRow = (int) ((Random.Range(1,4)));
        return thisRow;
    }
    public int leftOrRight()
    {
        int x = (int) ((Random.Range(0,2)));
        return x;
    }
    public Vector3 spawnCoords()
    {
        int thisRow = whichRow();
        int fromWhere = leftOrRight();
        float x;
        float y;
        float z;

        if (thisRow == 1)
        {
            y = -0.5f;  
            z = 5f; 
        }
        else if (thisRow == 2)
        {
            y = 1.5f;
            z = 7f;
        }
        else
        {
            y = 3.5f;
            z = 9f;
        }
        if (fromWhere == 0)
        {
            x = -9f;
        }
        else 
        {
            x = 9f;
        }
        Vector3 coords = new Vector3(x,y,z);



        return coords;
    }
}
