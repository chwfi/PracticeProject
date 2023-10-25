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

// Example 클래스를 상속 받는다.
class SubExample : Example
{
    // Print 함수 재정의 (sealed로 더이상 재정의를 금지)
    public sealed override void Print()
    {
        Debug.Log("SubExample Print");
    }
}

// SubExample 클래스를 상속 받는다.
class SubExample2 : SubExample
{
    //public override void Print()
    //{
    //    Debug.Log("SubExample2 Print");
    //}
}