using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Example
{
    public virtual void Print()
    {
        Debug.Log("Example Print");
    }
}

// Example Ŭ������ ��� �޴´�.
class SubExample : Example
{
    // Print �Լ� ������ (sealed�� ���̻� �����Ǹ� ����)
    public sealed override void Print()
    {
        Debug.Log("SubExample Print");
    }
}

// SubExample Ŭ������ ��� �޴´�.
class SubExample2 : SubExample
{
    //public override void Print()
    //{
    //    Debug.Log("SubExample2 Print");
    //}
}