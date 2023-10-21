using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int items = 0;
    private string collision_tag = "";
    [SerializeField] private TMP_Text itemsText;

   private void OnTriggerEnter2D(Collider2D collision) {
    collision_tag = collision.gameObject.tag;
    switch (collision_tag)
    {
        case "Leg":
           { 
            Destroy(collision.gameObject);
            items++;
            Debug.Log("Items: " + items);
            itemsText.text = "Items: " + items;
            if (gameObject.tag == "One leg")
            {
                gameObject.tag = "two legs";
            }
            else
            {
            gameObject.tag = "One leg";
            }
            Debug.Log(collision.gameObject);
            break;
            }
        case "Arm":
           { 
            Destroy(collision.gameObject);
            items++;
            Debug.Log("Items: " + items);
            itemsText.text = "Items: " + items;
            if (gameObject.tag == "One arm")
            {
                gameObject.tag = "Two arms";
            }
            else
            {
            gameObject.tag = "One arm";
            }
            Debug.Log(collision.gameObject);
            break;
            }


    }
   }
}
