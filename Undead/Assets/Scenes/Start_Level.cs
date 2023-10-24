using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Level : MonoBehaviour
{
    // Start is called before the first frame update
   public void Playgame()
   {
    SceneManager.LoadScene("First_Level");
   }
   public void Exit_Game()
   {
    Application.Quit();
   }
}
