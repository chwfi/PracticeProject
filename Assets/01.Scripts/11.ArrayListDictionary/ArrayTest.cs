using System;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    string[] FruitArray = new string[4] { "Banana", "Apple", "Orange", "Lemon" };

    private void Start()
    {
        Array.Resize(ref FruitArray, 5);

        FruitArray[4] = "Mango";
    }
}
