using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMonster : MonoBehaviour
{
    public abstract void Skill(); //���� ������ �ڿ� abstract ���̱�
}

public class Goblin : BaseMonster
{
    public override void Skill()
    {
        //��� ������ ��ų ����
    }
}

public class Slime : BaseMonster
{
    public override void Skill()
    {
        //������ ������ ��ų ����
    }
}