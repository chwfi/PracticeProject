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
        //기본적인 움직임 구현
    }
    public virtual void Run()
    {
        //기본적인 달리기 구현
    }
    public virtual void PunchAttack()
    {
        //기본적인 펀치 공격 구현
    }
}

public class FlyHero : BaseHero, Flyable
{
    public bool OffFlyMode()
    {
        //비행 모드 구현
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
