using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whoIsThePlayer : MonoBehaviour
{
   public int currentPlayerId = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("1"))
        {
            currentPlayerId = 1;
        }
        else if(Input.GetKeyDown("2"))
        {
            currentPlayerId = 2;
        }
        else if(Input.GetKeyDown("3"))
        {
            currentPlayerId = 3;
        }
        else if(Input.GetKeyDown("4"))
        {
            currentPlayerId = 4;
        }
        else if(Input.GetKeyDown("5"))
        {
            currentPlayerId = 5;
        }


        if (currentPlayerId == 1)
        {
            transform.position = new Vector2(-7f,-4f);
        }
        else if (currentPlayerId == 2)
        {
            transform.position = new Vector2(-3.5f,-4f);
        }
        else if (currentPlayerId == 3)
        {
            transform.position = new Vector2(0f,-4f);
        }
        else if (currentPlayerId == 4)
        {
            transform.position = new Vector2(3.5f,-4f);
        }
        else if (currentPlayerId == 5)
        {
            transform.position = new Vector2(7f,-4f);
        }
    }
}
