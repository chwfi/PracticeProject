using UnityEngine;

public class PropertyTest : MonoBehaviour
{
    private int age;

    public int Age
    {
        get => 5;
    }

    private void Start()
    {
        print(Age);
        //Age = 10; //프로퍼티에 get만 설정해놓으면 읽기 전용 프로퍼티가 된다.
        //이 상태에서는 값을 설정할 수가 없다.
    }

    //public int Age 
    //{
    //    get { return age; }
    //    set 
    //    {
    //        age = value;
    //        PlusAge(value);

    //        if (value < 1)
    //        {
    //            //...
    //        }
    //        else if (value > 10)
    //        {
    //            //...
    //        }
    //    }
    //}

    //void PlusAge(int age)
    //{
    //    age++;
    //}
}