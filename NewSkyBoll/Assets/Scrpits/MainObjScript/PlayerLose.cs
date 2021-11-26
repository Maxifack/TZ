using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLose : MonoBehaviour
{
    public Image backGround;
    public Text txtPlayerLose;
    public Text[] txtLose;
    public Button[] buttonLose;
    public Button buttonUp;
    public bool key_lose;
    public Text score;
    private void Start()
    {
        backGround.enabled = false;
        txtPlayerLose.enabled = false;
        score.enabled = true;
        buttonUp.gameObject.SetActive(true);
        key_lose = false;
        for (int i = 0; i < buttonLose.Length; i++)
        {
            buttonLose[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < txtLose.Length; i++)
        {
            txtLose[i].enabled = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        backGround.enabled = true;
        txtPlayerLose.enabled = true;
        buttonUp.gameObject.SetActive(false);
        score.enabled = false;
        key_lose = true;

        for (int i = 0; i < buttonLose.Length; i++) {
            buttonLose[i].gameObject.SetActive(true);
        }

        for (int i = 0; i < txtLose.Length; i++)
        {
            txtLose[i].enabled = true;
        }

        

        Destroy(gameObject);
    }
}
