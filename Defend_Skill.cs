using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//防御类技能
public class Defend_Skill
{
    private int cost;
    private int point;

    public Defend_Skill(int c, int p)
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
