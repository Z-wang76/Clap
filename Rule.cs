using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UI;

public class Rule : MonoBehaviour
{
    //角色数据
    private PlayerState playerState;            //状态
    private PlayerOperate playerOper;           //操作

    //技能
    private Skills skills;

    //计时器，控制回合操作时间和结算时间
    private Text timer;         //计时器UI
    private float operTime;    //操作总时间
    private float showTime;     //结算时间

    //状态栏
    private Text p1Hp;
    private Text p1Mp;
    private Text p2Hp;
    private Text p2Mp;

    //操作面板
    private GameObject operPanel;

    //结算控制器
    private int attack;     //0未结算，1已结算

    private void Awake()
    {
        playerState = new PlayerState();
        playerOper = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerOperate>();

        skills = new Skills();

        p1Hp = GameObject.FindGameObjectWithTag("P1hp").GetComponent<Text>();
        p1Mp = GameObject.FindGameObjectWithTag("P1mp").GetComponent<Text>();
        p2Hp = GameObject.FindGameObjectWithTag("P2hp").GetComponent<Text>();
        p2Mp = GameObject.FindGameObjectWithTag("P2mp").GetComponent<Text>();

        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Text>();

        operPanel = GameObject.FindGameObjectWithTag("Operate");
    }

    private void Start()
    {
        operTime = 5;   //5s操作时间
        showTime = 3;   //3s结算时间
        attack = 0;     //未结算
    }

    private void Update()
    {
        //回合计时器
        Timer();

        //更新状态栏
        UpdateState();

    }

    //回合
    private void Timer()
    {
        if(operTime > 5)
        {
            operTime = 5;
            timer.text = Mathf.CeilToInt(operTime).ToString();
        }
        if(operTime <= 5 && operTime > 0)   //操作时间
        {
            operPanel.SetActive(true);
            operTime -= Time.deltaTime;
            timer.text = Mathf.CeilToInt(operTime).ToString();
        }
        if(operTime <= 0)
        {
            timer.enabled = false;
            if(showTime > 3)
            {
                showTime = 3;
            }
            if(showTime <= 3 && showTime > 0)   //结算时间
            {
                operPanel.SetActive(false);
                Attack(playerOper.GetSkill(), playerOper.GetIndex());   //结算
                showTime -= Time.deltaTime;
            }
            if(showTime <= 0)
            {
                operTime = 5;
                showTime = 3;
                attack = 0;
                timer.enabled = true;
            }
        }
    }

    //结算
    private void Attack(int skill, int index)
    {
        if(attack == 0)
        {
            if (skill == 0)
            {
                playerState.SetMp(skills.getManaSkills()[index].getPoint());
            }

            attack++;
        }
        
    }

    private void UpdateState()
    {
        p1Hp.text = "Hp: " + playerState.GetHp().ToString();
        p1Mp.text = "Mp: " + playerState.GetMp().ToString();
    }



}
