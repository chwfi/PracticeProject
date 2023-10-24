using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HashTableTest : MonoBehaviour
{
    private void Start()
    {
        Hashtable table = new Hashtable();

        table.Add("���", "apple");
        table.Add("�丶��", "tomato");
        table["����"] = "potato";

        foreach (object obj in table.Keys)
        {
            Debug.Log($"{obj} : {table[obj]}");  
        }
    }
}
