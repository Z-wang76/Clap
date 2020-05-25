using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayerState
{
    private int hp;
    private int mp;

    public PlayerState()
    {
        hp = 5;
        mp = 0;
    }

    public void SetHp(int i)
    {
        hp += i;
    }

    public void SetMp(int i)
    {
        mp += i;
    }

    public int GetHp()
    {
        return hp;
    }

    public int GetMp()
    {
        return mp;
    }
}
