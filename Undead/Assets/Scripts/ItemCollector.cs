using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int items = 0;
    
    [SerializeField] private TMP_Text itemsText;

   private void OnTriggerEnter2D(Collider2D collision) {
    
    if (collision.gameObject.CompareTag("Item"))
    {
        Destroy(collision.gameObject);
        items++;
        Debug.Log("Items: " + items);
        itemsText.text = "Items: " + items;
    }
   }
}
