using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Change_Scene : MonoBehaviour
{
    private string ActiveScene;

private void OnTriggerEnter2D(Collider2D collision) {
    Debug.Log("test");
  if (collision.gameObject.CompareTag("Finish")){
   
   ActiveScene = SceneManager.GetActiveScene().name;
        switch (ActiveScene)
        {
            case "First_Level":
            {
                Debug.Log("test");
                SceneManager.LoadScene("Second_Level");
                break;
            }
            case "Second_Level":
            {
                SceneManager.LoadScene("Third_Level");
                break;
            }
            case "Third_Level":
            {
                SceneManager.LoadScene("Forth_Level");
                break;
            }
            case "Forth_Level":
            {
                SceneManager.LoadScene("Epilogue");
                break;
            }
        }
    }  
}
}
