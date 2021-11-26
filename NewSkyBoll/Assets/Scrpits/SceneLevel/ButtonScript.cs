using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public static int level;
    public Image[] buttonImage;
    
    public void Menu(int number) {
       
        
        
        switch (number) {
            case 1:
                level = 1;
                buttonImage[0].color = Color.red;
                buttonImage[1].color = Color.white;
                buttonImage[2].color = Color.white;
                break;
            case 2:
                level = 2;

                buttonImage[0].color = Color.white;
                buttonImage[1].color = Color.red;
                buttonImage[2].color = Color.white;
                break;
            case 3:

                buttonImage[0].color = Color.white;
                buttonImage[1].color = Color.white;
                buttonImage[2].color = Color.red;
                level = 3;
                break;
            case 4:
                SceneManager.LoadScene(1);
                break;
            
        }
    
    }



}
