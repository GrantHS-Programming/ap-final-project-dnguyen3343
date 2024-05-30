using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCursor : MonoBehaviour
{
    [SerializeField]
    private turretData data;

    private float turnAngle;
    public bool isBurstActive = false;
    public bool isThisThePlayer = false;
    private int poisitionNumber;
    private int currentPlayerId;

    // Start is called before the first frame update
    void Start()
    {
        poisitionNumber = data.poisitionNumber;
    }

    // Update is called once per frame
    void Update()
    {
        if (isBurstActive || isThisThePlayer)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
            transform.up = direction;
        }
        if (currentPlayerId == data.poisitionNumber)
        {
            isThisThePlayer = true;
        }
        else 
        {
            isThisThePlayer =false;
        }

    }
}
