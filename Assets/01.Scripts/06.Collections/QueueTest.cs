using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueTest : MonoBehaviour
{
    private void Start()
    {
        Queue queue = new Queue();

        queue.Enqueue("one");
        queue.Enqueue("two");
        queue.Enqueue("three");
        queue.Enqueue("four");

        while (queue.Count > 0)
        {
            Debug.Log(queue.Dequeue());
        }
    }
}
