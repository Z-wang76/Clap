using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//魔法恢复类技能
public class Mana_Skill
{
    private int cost;
    private int point;

    public Mana_Skill(int c,int p)
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
