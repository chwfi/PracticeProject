using System;
using System.Collections.Generic;
using UnityEngine;

public class ListTest : MonoBehaviour
{
    List<string> FruitList = new List<string>(4);

    private void Awake()
    {
        FruitList[0] = "Banana";
        FruitList[1] = "Apple";
        FruitList[2] = "Orange";
        FruitList[3] = "Lemon";
    }
}
