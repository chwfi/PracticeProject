using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMonster : MonoBehaviour
{
    public abstract void Skill(); //접근 지정자 뒤에 abstract 붙이기
}

public class Goblin : BaseMonster
{
    public override void Skill()
    {
        //고블린 고유의 스킬 구현
    }
}

public class Slime : BaseMonster
{
    public override void Skill()
    {
        //슬라임 고유의 스킬 구현
    }
}