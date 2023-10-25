using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Flyable
{
    bool OnFlyMode();
    bool OffFlyMode();
    void Fly();
}

public interface Transparentable
{
    bool OnTransparent();
    bool OffTransparent();
}

public interface Teleportable
{
    bool OnTeleport();
    bool OffTeleport();
}

public abstract class BaseHero : MonoBehaviour
{
    public virtual void Move()
    {
        //�⺻���� ������ ����
    }
    public virtual void Run()
    {
        //�⺻���� �޸��� ����
    }
    public virtual void PunchAttack()
    {
        //�⺻���� ��ġ ���� ����
    }
}

public class FlyHero : BaseHero, Flyable
{
    public bool OffFlyMode()
    {
        //���� ��� ����
        throw new System.NotImplementedException();
    }

    public bool OnFlyMode()
    {
        throw new System.NotImplementedException();
    }

    public override void Move()
    {
        base.Move();   
    }

    public override void PunchAttack()
    {
        base.PunchAttack();
    }

    public override void Run()
    {
        base.Run();
    }

    public void Fly()
    {
        
    }
}
