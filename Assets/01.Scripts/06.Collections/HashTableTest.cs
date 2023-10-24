using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTableTest : MonoBehaviour
{
    private void Start()
    {
        Hashtable table = new Hashtable();

        table.Add("사과", "apple");
        table.Add("토마토", "tomato");
        table["감자"] = "potato";

        foreach (object obj in table.Keys)
        {
            Debug.Log($"{obj} : {table[obj]}");  
        }
    }
}
