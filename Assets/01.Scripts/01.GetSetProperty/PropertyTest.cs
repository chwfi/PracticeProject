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
        //Age = 10; //������Ƽ�� get�� �����س����� �б� ���� ������Ƽ�� �ȴ�.
        //�� ���¿����� ���� ������ ���� ����.
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