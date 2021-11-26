using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AllScore : MonoBehaviour
{

    public PlayerLose scriptPlayerLose;
    public static int countHighTry;
    public static int countLongTime;
    public float time = 1f;
    public bool keyLose;
    
    private int level;

    private void Start()
    {
        level = ButtonScript.level;
        switch (level) {
            case 1:
                time = 1f;
                break;
            case 2:
                time = 0.5f;
                break;
            case 3:
                time = 0.1f;
                break;
            default:
                time = 1f;
                break;

        }
        countHighTry++;
        StartCoroutine(Count());
    }

    private void Update()
    {
        keyLose = scriptPlayerLose.key_lose;
    }

    IEnumerator Count() {
        while (!keyLose)
        {
            yield return new WaitForSeconds(time);
            countLongTime++;
            scriptPlayerLose.score.text = countLongTime.ToString();
        }
        scriptPlayerLose.txtLose[0].text += countLongTime.ToString();
        countLongTime = 0;
        scriptPlayerLose.txtLose[1].text += countHighTry.ToString();
        StopCoroutine(Count());
    }



}
