using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOperate : MonoBehaviour
{

    private int skill;
    private int index;
    
    public void Mana0()
    {
        skill = 0;
        index = 0;
    }
    
    
    
    public int GetSkill()
    {
        return skill;
    }

    public int GetIndex()
    {
        return index;
    }
}
