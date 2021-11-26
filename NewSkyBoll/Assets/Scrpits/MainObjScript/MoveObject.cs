using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private Rigidbody2D rb;
    public  float force;
    public PlayerLose scriptPlayerLose;
    [SerializeField]
    private bool key;
    private bool keyLose;
    

    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        scriptPlayerLose = GetComponent<PlayerLose>();
        StartCoroutine(ForceUp());
    }

    IEnumerator ForceUp() {
        while (!keyLose) {
            yield return new WaitForSeconds(15f);
            force += 0.05f;
        }
        StopCoroutine(ForceUp());
    } 
  
    public void ClickDown() {
        key = true;
    }

    public void ClickUp()
    {
        key = false;
    }

    private void Update()
    {
        keyLose = scriptPlayerLose.key_lose;
    }
    public void FixedUpdate()
    {
        if (key) {
            rb.AddForce(Vector2.up * force, ForceMode2D.Impulse);
        }
    }



}
