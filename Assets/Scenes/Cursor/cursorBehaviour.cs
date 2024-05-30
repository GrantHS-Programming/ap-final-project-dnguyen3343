using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorBehaviour : MonoBehaviour
{
    [SerializeField]
    private Texture2D cursorTexture;

    [SerializeField]
    private Texture2D cursorShootingTexture;

    private Vector2 cursorHotspot;
    public bool shootingOn;
    // Start is called before the first frame update
    void Start()
    {
        cursorHotspot = new Vector2(cursorTexture.width/2,cursorTexture.height/2);
        Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.Auto);
    }
    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Cursor.SetCursor(cursorShootingTexture, cursorHotspot, CursorMode.Auto);
            shootingOn = true;
        }
        else 
        {
            Cursor.SetCursor(cursorTexture, cursorHotspot, CursorMode.Auto);   
            shootingOn = false;
        }
    }
}
