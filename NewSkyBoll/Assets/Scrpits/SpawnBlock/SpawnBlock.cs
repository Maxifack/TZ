using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    public GameObject block;
    public PlayerLose scriptPlayerLose;
    private bool keyLose;
    private int level;
    private float timeRange;
    

    private void Start()
    {
        level = ButtonScript.level;
        StartCoroutine(Spawn());
    }

    private void Update()
    {
        keyLose = scriptPlayerLose.key_lose;
    }
    IEnumerator Spawn() {
        while (!keyLose) {
            yield return new WaitForSeconds(TimeSpawn());
            Instantiate(block, new Vector2(block.transform.position.x, pozY()), Quaternion.identity);
            
        }
        StopCoroutine(Spawn());

    }

    private float TimeSpawn() {                   //Метод рандомное время спавна блока!!!
        switch (level)
        {
            case 1:
                 timeRange = Random.Range(1, 5);
                break;
            case 2:
                 timeRange = Random.Range(1, 3);
                break;
            case 3:
                 timeRange = Random.Range(1, 3);
                break;
            default:
                timeRange = Random.Range(1, 5);
                break;

        }
        return timeRange; 
    }

    private float pozY() {                         //Метод по рандомной позиции блока!!!
        float range = Random.Range(0,3);
        Debug.Log(range);
        if (range == 0)
        {
            return 2f;
        }
        else if (range == 1)
        {
            return -2f;
        }
        else {
            return 0f;
        }
    }

}
