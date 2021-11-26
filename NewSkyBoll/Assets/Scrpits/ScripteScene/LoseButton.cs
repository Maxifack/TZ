using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseButton : MonoBehaviour
{
    public void LoseMenu(string name) {

        switch (name) {
            case "ButtonRestart":
                Debug.Log("Restart");
                SceneManager.LoadScene(1);
                break;
            case "ButtonEditLevel":
                Debug.Log("EditLevel");
                SceneManager.LoadScene(2);
                break;
        }

    }

}
