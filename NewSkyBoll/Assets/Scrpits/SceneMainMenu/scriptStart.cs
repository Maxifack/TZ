using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptStart : MonoBehaviour
{

    public void Menu(string name) {

        switch (name) {
            case "ButtonStart":
                SceneManager.LoadScene(1);
                break;
            case "ButtonEditLevel":
                SceneManager.LoadScene(2);
                break;
        }


    }
}
