using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour
{
    public float speed = 5f;
    public int level;
    private void Start()
    {
        level = ButtonScript.level;
        switch (level) {
            case 1:
                speed = 5f;
                break;
            case 2:
                speed = 20f;
                break;
            case 3:
                speed = 25f;
                break;
            default:
                speed = 5f;
                break;

        }
    }
    


    private void Update()
    {
        transform.Translate(-Vector2.right * speed * Time.deltaTime);
        if(transform.position.x <= -12)
        {
            Destroy(gameObject);
        }
    }

    
}
