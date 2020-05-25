using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//所有技能
public class Skills
{
    //能量恢复
    private Mana_Skill mana1 = new Mana_Skill(0, 1);

    //攻击
    private Attack_Skill att1 = new Attack_Skill(1, 1);

    //防御
    private Defend_Skill def1 = new Defend_Skill(0, 1);

    //各技能List
    private List<Mana_Skill> manaSkills = new List<Mana_Skill>();
    private List<Attack_Skill> attSkills = new List<Attack_Skill>();
    private List<Defend_Skill> defSkills = new List<Defend_Skill>();

    public Skills()
    {
        manaSkills.Add(mana1);

        attSkills.Add(att1);

        defSkills.Add(def1);
    }

    public List<Mana_Skill> getManaSkills()
    {
        return manaSkills;
    }

    public List<Attack_Skill> getAttackSkills()
    {
        return attSkills;
    }

    public List<Defend_Skill> getDefendSkills()
    {
        return defSkills;
    }


}
