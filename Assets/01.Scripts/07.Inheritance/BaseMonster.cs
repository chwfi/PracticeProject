using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMonster : MonoBehaviour
{
    private float _speed = 5;
    public float Speed => _speed;

    private float _atkPower = 10;
    public float AtkPower => _atkPower; 
}

public class Goblin : BaseMonster
{
    public void DebugSpeed()
    {
        Debug.Log(Speed);
    }
}

public class Slime : BaseMonster
{
    public void DebugAtk()
    {
        Debug.Log(AtkPower);
    }
}