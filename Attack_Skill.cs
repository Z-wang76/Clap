using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//攻击类技能
public class Attack_Skill
{
    private int cost;
    private int point;

    public Attack_Skill(int c, int p)
    {
        this.cost = c;
        this.point = p;
    }

    public int getCost()
    {
        return cost;
    }

    public int getPoint()
    {
        return point;
    }
}
