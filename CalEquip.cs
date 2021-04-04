using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CalEquip 
{
    //Step 1
    #region 初始化裝備(Remove StarEnhance&Scroll)

    public static void InitEquip(EquipmentDetails Equip)
    {
        #region Remove StarEnhance

        Equip.StarSTR = 0;
        Equip.StarDEX = 0;
        Equip.StarINT = 0;
        Equip.StarLUK = 0;
        Equip.StarMaxHP = 0;
        Equip.StarMaxMP = 0;
        Equip.StarPAtk = 0;
        Equip.StarMAtk = 0;
        Equip.StarDef = 0;

        #endregion Remove StarEnhance

        #region Remove Scroll

        Equip.ScrollSTR = 0;
        Equip.ScrollDEX = 0;
        Equip.ScrollINT = 0;
        Equip.ScrollLUK = 0;
        Equip.ScrollMaxHP = 0;
        Equip.ScrollPAtk = 0;
        Equip.ScrollMAtk = 0;
        Equip.ScrollDef = 0;

        #endregion Remove Scroll
      
    }

    #endregion 初始化裝備(去掉Final&StarEnhance)

    //Step 2
    #region 計算卷軸 Cal Scroll
    /// <summary>
    /// 計算卷軸的加成，並儲存到自身卷軸加成部分
    /// </summary>
    /// <param name="Equip">要計算的裝備</param>
    /// <param name="JobType">劍/法/弓/盜/海 | Warrior/Magician/Archer/Theif/Pirate</param>
    private static void CalEquipScroll(EquipmentDetails Equip, int JobType)
    {
        //咒文卷軸記數 Spell Trace Counter
        int SpellTraceCount = 0;
        //裝備部位 EquipType
        int EquipType = int.Parse(Equip.Index.Substring(1,2));
        
        foreach (var scroll in Equip.ScrollList)
        {
            switch (EquipType)
            {

                #region 1: 防具 + 肩飾  Armor + ShoulderPad
                //特別注意:4次強化會有額外1攻 Notice: Spell Trace Add 1 Atk After Fourth Enhance
                case 10://帽子 Hat
                case 13://套服 Overall/Suit
                case 14://上衣 Top
                case 15://褲子 Down
                case 16://鞋子 Shoe
                case 18://肩飾 ShoulderPad
                case 24://披風 Cape

                    #region 咒文處理 Spell Trace
                    if (scroll > 6)//代表咒文系卷軸
                    {
                        SpellTraceCount++;
                    }
                    if (SpellTraceCount == 4)
                    {
                        switch (JobType)
                        {
                            case 0:
                            case 2:
                            case 3:
                            case 4:
                                Equip.ScrollPAtk += 1;
                                break;
                            case 1://法師 Magician
                                Equip.ScrollMAtk += 1;
                                break;
                        }

                    }
                    #endregion 咒文處理

                    switch (JobType)
                    {
                        case 0://劍士 完整版先保留
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollPAtk += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollPAtk += 5;
                                    break;
                                case 3://X
                                    Equip.ScrollPAtk += 7;
                                    break;
                                case 4://V
                                    Equip.ScrollPAtk += 8;
                                    break;
                                case 5://黑
                                    Equip.ScrollPAtk += 9;
                                    Equip.ScrollSTR += 2;
                                    Equip.ScrollDEX += 2;
                                    Equip.ScrollINT += 2;
                                    Equip.ScrollLUK += 2;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文

                                #region STR
                                case 7://100 STR
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 1;
                                        Equip.ScrollMaxHP += 5;
                                        Equip.ScrollDef += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollMaxHP += 20;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 3;
                                    }
                                    break;
                                case 8://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollMaxHP += 15;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollMaxHP += 40;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 4;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 5;
                                    }
                                    break;
                                case 9://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 5;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 7;
                                        Equip.ScrollMaxHP += 120;
                                        Equip.ScrollDef += 10;
                                    }
                                    break;

                                #endregion STR 

                                #region DEX
                                case 10://100 DEX
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 1;
                                        Equip.ScrollMaxHP += 5;
                                        Equip.ScrollDef += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollMaxHP += 20;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 3;
                                    }
                                    break;
                                case 11://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollMaxHP += 15;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollMaxHP += 40;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 4;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 5;
                                    }
                                    break;
                                case 12://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 5;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 7;
                                        Equip.ScrollMaxHP += 120;
                                        Equip.ScrollDef += 10;
                                    }
                                    break;

                                #endregion DEX 

                                #region INT
                                case 13://100 INT
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollINT += 1;
                                        Equip.ScrollMaxHP += 5;
                                        Equip.ScrollDef += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollINT += 2;
                                        Equip.ScrollMaxHP += 20;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollINT += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 3;
                                    }
                                    break;
                                case 14://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollINT += 2;
                                        Equip.ScrollMaxHP += 15;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollINT += 3;
                                        Equip.ScrollMaxHP += 40;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollINT += 4;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 5;
                                    }
                                    break;
                                case 15://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollINT += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollINT += 5;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollINT += 7;
                                        Equip.ScrollMaxHP += 120;
                                        Equip.ScrollDef += 10;
                                    }
                                    break;

                                #endregion INT 

                                #region LUK
                                case 16://100 LUK
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 1;
                                        Equip.ScrollMaxHP += 5;
                                        Equip.ScrollDef += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 2;
                                        Equip.ScrollMaxHP += 20;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 3;
                                    }
                                    break;
                                case 17://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 2;
                                        Equip.ScrollMaxHP += 15;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 3;
                                        Equip.ScrollMaxHP += 40;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 4;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 5;
                                    }
                                    break;
                                case 18://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 5;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 7;
                                        Equip.ScrollMaxHP += 120;
                                        Equip.ScrollDef += 10;
                                    }
                                    break;

                                #endregion LUK 

                                #region MaxHP
                                case 19://100 MaxHP
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollMaxHP += 55;
                                        Equip.ScrollDef += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollMaxHP += 120;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollMaxHP += 180;
                                        Equip.ScrollDef += 3;
                                    }
                                    break;
                                case 20://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollMaxHP += 115;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollMaxHP += 190;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollMaxHP += 270;
                                        Equip.ScrollDef += 5;
                                    }
                                    break;
                                case 21://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollMaxHP += 180;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollMaxHP += 320;
                                        Equip.ScrollDef += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollMaxHP += 470;
                                        Equip.ScrollDef += 10;
                                    }
                                    break;

                                #endregion MaxHP 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;
                        case 1://法師
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollMAtk += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollMAtk += 5;
                                    break;
                                case 3://X
                                    Equip.ScrollMAtk += 7;
                                    break;
                                case 4://V
                                    Equip.ScrollMAtk += 8;
                                    break;
                                case 5://黑
                                    Equip.ScrollMAtk += 9;
                                    Equip.ScrollSTR += 2;
                                    Equip.ScrollDEX += 2;
                                    Equip.ScrollINT += 2;
                                    Equip.ScrollLUK += 2;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文                         

                                #region INT
                                case 13://100 INT
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollINT += 1;
                                        Equip.ScrollMaxHP += 5;
                                        Equip.ScrollDef += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollINT += 2;
                                        Equip.ScrollMaxHP += 20;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollINT += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 3;
                                    }
                                    break;
                                case 14://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollINT += 2;
                                        Equip.ScrollMaxHP += 15;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollINT += 3;
                                        Equip.ScrollMaxHP += 40;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollINT += 4;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 5;
                                    }
                                    break;
                                case 15://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollINT += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollINT += 5;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollINT += 7;
                                        Equip.ScrollMaxHP += 120;
                                        Equip.ScrollDef += 10;
                                    }
                                    break;

                                #endregion INT 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;
                        case 2://弓箭手
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollPAtk += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollPAtk += 5;
                                    break;
                                case 3://X
                                    Equip.ScrollPAtk += 7;
                                    break;
                                case 4://V
                                    Equip.ScrollPAtk += 8;
                                    break;
                                case 5://黑
                                    Equip.ScrollPAtk += 9;
                                    Equip.ScrollSTR += 2;
                                    Equip.ScrollDEX += 2;
                                    Equip.ScrollINT += 2;
                                    Equip.ScrollLUK += 2;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文

                                #region DEX
                                case 10://100 DEX
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 1;
                                        Equip.ScrollMaxHP += 5;
                                        Equip.ScrollDef += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollMaxHP += 20;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 3;
                                    }
                                    break;
                                case 11://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollMaxHP += 15;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollMaxHP += 40;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 4;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 5;
                                    }
                                    break;
                                case 12://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 5;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 7;
                                        Equip.ScrollMaxHP += 120;
                                        Equip.ScrollDef += 10;
                                    }
                                    break;

                                #endregion DEX 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;
                        case 3://盜賊
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollPAtk += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollPAtk += 5;
                                    break;
                                case 3://X
                                    Equip.ScrollPAtk += 7;
                                    break;
                                case 4://V
                                    Equip.ScrollPAtk += 8;
                                    break;
                                case 5://黑
                                    Equip.ScrollPAtk += 9;
                                    Equip.ScrollSTR += 2;
                                    Equip.ScrollDEX += 2;
                                    Equip.ScrollINT += 2;
                                    Equip.ScrollLUK += 2;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文

                                #region STR
                                case 7://100 STR
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 1;
                                        Equip.ScrollMaxHP += 5;
                                        Equip.ScrollDef += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollMaxHP += 20;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 3;
                                    }
                                    break;
                                case 8://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollMaxHP += 15;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollMaxHP += 40;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 4;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 5;
                                    }
                                    break;
                                case 9://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 5;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 7;
                                        Equip.ScrollMaxHP += 120;
                                        Equip.ScrollDef += 10;
                                    }
                                    break;

                                #endregion STR 

                                #region DEX
                                case 10://100 DEX
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 1;
                                        Equip.ScrollMaxHP += 5;
                                        Equip.ScrollDef += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollMaxHP += 20;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 3;
                                    }
                                    break;
                                case 11://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollMaxHP += 15;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollMaxHP += 40;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 4;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 5;
                                    }
                                    break;
                                case 12://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 5;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 7;
                                        Equip.ScrollMaxHP += 120;
                                        Equip.ScrollDef += 10;
                                    }
                                    break;

                                #endregion DEX 

                                #region LUK
                                case 16://100 LUK
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 1;
                                        Equip.ScrollMaxHP += 5;
                                        Equip.ScrollDef += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 2;
                                        Equip.ScrollMaxHP += 20;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 3;
                                    }
                                    break;
                                case 17://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 2;
                                        Equip.ScrollMaxHP += 15;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 3;
                                        Equip.ScrollMaxHP += 40;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 4;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 5;
                                    }
                                    break;
                                case 18://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 5;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 7;
                                        Equip.ScrollMaxHP += 120;
                                        Equip.ScrollDef += 10;
                                    }
                                    break;

                                #endregion LUK 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;
                        case 4://海盜
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollPAtk += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollPAtk += 5;
                                    break;
                                case 3://X
                                    Equip.ScrollPAtk += 7;
                                    break;
                                case 4://V
                                    Equip.ScrollPAtk += 8;
                                    break;
                                case 5://黑
                                    Equip.ScrollPAtk += 9;
                                    Equip.ScrollSTR += 2;
                                    Equip.ScrollDEX += 2;
                                    Equip.ScrollINT += 2;
                                    Equip.ScrollLUK += 2;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文

                                #region STR
                                case 7://100 STR
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 1;
                                        Equip.ScrollMaxHP += 5;
                                        Equip.ScrollDef += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollMaxHP += 20;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 3;
                                    }
                                    break;
                                case 8://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollMaxHP += 15;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollMaxHP += 40;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 4;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 5;
                                    }
                                    break;
                                case 9://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 5;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 7;
                                        Equip.ScrollMaxHP += 120;
                                        Equip.ScrollDef += 10;
                                    }
                                    break;

                                #endregion STR 

                                #region DEX
                                case 10://100 DEX
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 1;
                                        Equip.ScrollMaxHP += 5;
                                        Equip.ScrollDef += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollMaxHP += 20;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 3;
                                    }
                                    break;
                                case 11://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollMaxHP += 15;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollMaxHP += 40;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 4;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 5;
                                    }
                                    break;
                                case 12://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 5;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 7;
                                        Equip.ScrollMaxHP += 120;
                                        Equip.ScrollDef += 10;
                                    }
                                    break;

                                #endregion DEX 

                                #region LUK
                                case 16://100 LUK
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 1;
                                        Equip.ScrollMaxHP += 5;
                                        Equip.ScrollDef += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 2;
                                        Equip.ScrollMaxHP += 20;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 3;
                                    }
                                    break;
                                case 17://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 2;
                                        Equip.ScrollMaxHP += 15;
                                        Equip.ScrollDef += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 3;
                                        Equip.ScrollMaxHP += 40;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 4;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 5;
                                    }
                                    break;
                                case 18://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 3;
                                        Equip.ScrollMaxHP += 30;
                                        Equip.ScrollDef += 4;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 5;
                                        Equip.ScrollMaxHP += 70;
                                        Equip.ScrollDef += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 7;
                                        Equip.ScrollMaxHP += 120;
                                        Equip.ScrollDef += 10;
                                    }
                                    break;

                                #endregion LUK 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;

                    }
                    break;
                #endregion 1 : 防具 + 肩飾

                #region 2: 戒/墜/腰/臉/眼/耳 不加HP 飾品類別 Accessory         
                case 1://戒
                case 6://墜
                case 9://腰
                case 11://臉
                case 12://眼
                case 17://耳
                    switch (JobType)
                    {
                        case 0://劍士 完整版先保留
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollPAtk += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollPAtk += 5;
                                    break;
                                case 3://X
                                    Equip.ScrollPAtk += 7;
                                    break;
                                case 4://V
                                    Equip.ScrollPAtk += 8;
                                    break;
                                case 5://黑
                                    Equip.ScrollPAtk += 9;
                                    Equip.ScrollSTR += 2;
                                    Equip.ScrollDEX += 2;
                                    Equip.ScrollINT += 2;
                                    Equip.ScrollLUK += 2;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文

                                #region STR
                                case 7://100 STR
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 1;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 2;
                                    }
                                    break;
                                case 8://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 3;
                                    }
                                    break;
                                case 9://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 5;
                                    }
                                    break;

                                #endregion STR 

                                #region MaxHP
                                case 19://100 MaxHP
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollMaxHP += 50;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollMaxHP += 50;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollMaxHP += 100;
                                    }
                                    break;
                                case 20://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollMaxHP += 100;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollMaxHP += 100;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollMaxHP += 150;
                                    }
                                    break;
                                case 21://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollMaxHP += 150;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollMaxHP += 200;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollMaxHP += 250;
                                    }
                                    break;

                                #endregion MaxHP 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;
                        case 1://法師
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollMAtk += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollMAtk += 5;
                                    break;
                                case 3://X
                                    Equip.ScrollMAtk += 7;
                                    break;
                                case 4://V
                                    Equip.ScrollMAtk += 8;
                                    break;
                                case 5://黑
                                    Equip.ScrollMAtk += 9;
                                    Equip.ScrollSTR += 2;
                                    Equip.ScrollDEX += 2;
                                    Equip.ScrollINT += 2;
                                    Equip.ScrollLUK += 2;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文                         

                                #region INT
                                case 13://100 INT
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollINT += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollINT += 1;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollINT += 2;
                                    }
                                    break;
                                case 14://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollINT += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollINT += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollINT += 3;
                                    }
                                    break;
                                case 15://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollINT += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollINT += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollINT += 5;
                                    }
                                    break;

                                #endregion INT 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;
                        case 2://弓箭手
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollPAtk += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollPAtk += 5;
                                    break;
                                case 3://X
                                    Equip.ScrollPAtk += 7;
                                    break;
                                case 4://V
                                    Equip.ScrollPAtk += 8;
                                    break;
                                case 5://黑
                                    Equip.ScrollPAtk += 9;
                                    Equip.ScrollSTR += 2;
                                    Equip.ScrollDEX += 2;
                                    Equip.ScrollINT += 2;
                                    Equip.ScrollLUK += 2;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文

                                #region DEX
                                case 10://100 DEX
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 1;

                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 1;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 2;
                                    }
                                    break;
                                case 11://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 3;
                                    }
                                    break;
                                case 12://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 5;
                                    }
                                    break;

                                #endregion DEX 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;
                        case 3://盜賊
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollPAtk += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollPAtk += 5;
                                    break;
                                case 3://X
                                    Equip.ScrollPAtk += 7;
                                    break;
                                case 4://V
                                    Equip.ScrollPAtk += 8;
                                    break;
                                case 5://黑
                                    Equip.ScrollPAtk += 9;
                                    Equip.ScrollSTR += 2;
                                    Equip.ScrollDEX += 2;
                                    Equip.ScrollINT += 2;
                                    Equip.ScrollLUK += 2;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文

                                #region STR
                                case 7://100 STR
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 1;

                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 1;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 2;
                                    }
                                    break;
                                case 8://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 3;
                                    }
                                    break;
                                case 9://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 5;
                                    }
                                    break;

                                #endregion STR 

                                #region DEX
                                case 10://100 DEX
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 1;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 2;
                                    }
                                    break;
                                case 11://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 3;
                                    }
                                    break;
                                case 12://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 5;
                                    }
                                    break;

                                #endregion DEX 

                                #region LUK
                                case 16://100 LUK
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 1;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 2;
                                    }
                                    break;
                                case 17://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 2;

                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 3;
                                    }
                                    break;
                                case 18://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 5;
                                    }
                                    break;

                                #endregion LUK 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;
                        case 4://海盜
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollPAtk += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollPAtk += 5;
                                    break;
                                case 3://X
                                    Equip.ScrollPAtk += 7;
                                    break;
                                case 4://V
                                    Equip.ScrollPAtk += 8;
                                    break;
                                case 5://黑
                                    Equip.ScrollPAtk += 9;
                                    Equip.ScrollSTR += 2;
                                    Equip.ScrollDEX += 2;
                                    Equip.ScrollINT += 2;
                                    Equip.ScrollLUK += 2;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文

                                #region STR
                                case 7://100 STR
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 1;

                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 1;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 2;
                                    }
                                    break;
                                case 8://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 3;
                                    }
                                    break;
                                case 9://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 5;
                                    }
                                    break;

                                #endregion STR 

                                #region DEX
                                case 10://100 DEX
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 1;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 2;
                                    }
                                    break;
                                case 11://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 3;
                                    }
                                    break;
                                case 12://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 5;
                                    }
                                    break;

                                #endregion DEX 

                                #region LUK
                                case 16://100 LUK
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 1;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 2;
                                    }
                                    break;
                                case 17://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 2;

                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 3;
                                    }
                                    break;
                                case 18://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 4;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 5;
                                    }
                                    break;

                                #endregion LUK 

                                #endregion 咒文
                                default:

                                    break;
                            }
                            break;

                    }
                    break;
                #endregion 2 : 戒/墜/腰/耳/眼/臉 不加HP 飾品類別

                #region 3: 手套 +攻 Gloves
                case 19:
                    switch (JobType)
                    {
                        case 0:
                        case 2:
                        case 3:
                        case 4:
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollPAtk += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollPAtk += 5;
                                    break;
                                case 3://X
                                    Equip.ScrollPAtk += 7;
                                    break;
                                case 4://V
                                    Equip.ScrollPAtk += 8;
                                    break;
                                case 5://黑
                                    Equip.ScrollPAtk += 9;
                                    Equip.ScrollSTR += 2;
                                    Equip.ScrollDEX += 2;
                                    Equip.ScrollINT += 2;
                                    Equip.ScrollLUK += 2;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                case 26:
                                    Equip.ScrollPAtk += 1;
                                    break;
                                case 27:
                                    Equip.ScrollPAtk += 2;
                                    break;
                                case 28:
                                    Equip.ScrollPAtk += 3;
                                    break;
                            }
                            break;
                        case 1:
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollMAtk += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollMAtk += 5;
                                    break;
                                case 3://X
                                    Equip.ScrollMAtk += 7;
                                    break;
                                case 4://V
                                    Equip.ScrollMAtk += 8;
                                    break;
                                case 5://黑
                                    Equip.ScrollMAtk += 9;
                                    Equip.ScrollSTR += 2;
                                    Equip.ScrollDEX += 2;
                                    Equip.ScrollINT += 2;
                                    Equip.ScrollLUK += 2;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文
                                case 26:
                                    Equip.ScrollMAtk += 1;
                                    break;
                                case 27:
                                    Equip.ScrollMAtk += 2;
                                    break;
                                case 28:
                                    Equip.ScrollMAtk += 3;
                                    break;
                                #endregion 咒文
                            }
                            break;
                    }
                    break;
                #endregion 3: 手套 +攻

                #region 4: 武器 100/70/30/15 Weapons
                case 8:
                    switch (JobType)
                    {
                        case 0://劍士 
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollPAtk += 9;
                                    Equip.ScrollSTR += 4;
                                    Equip.ScrollDEX += 4;
                                    Equip.ScrollINT += 4;
                                    Equip.ScrollLUK += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollPAtk += 10;
                                    Equip.ScrollSTR += 8;
                                    Equip.ScrollDEX += 8;
                                    Equip.ScrollINT += 8;
                                    Equip.ScrollLUK += 8;
                                    break;
                                case 3://X
                                    Equip.ScrollPAtk += 12;
                                    Equip.ScrollSTR += 10;
                                    Equip.ScrollDEX += 10;
                                    Equip.ScrollINT += 10;
                                    Equip.ScrollLUK += 10;
                                    break;
                                case 4://V
                                    Equip.ScrollPAtk += 13;
                                    Equip.ScrollSTR += 11;
                                    Equip.ScrollDEX += 11;
                                    Equip.ScrollINT += 11;
                                    Equip.ScrollLUK += 11;
                                    break;
                                case 5://黑
                                    Equip.ScrollPAtk += 14;
                                    Equip.ScrollSTR += 14;
                                    Equip.ScrollDEX += 14;
                                    Equip.ScrollINT += 14;
                                    Equip.ScrollLUK += 14;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文

                                #region STR
                                case 7://100 STR
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    break;
                                case 8://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    break;
                                case 9://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    break;
                                case 22://15
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 4;
                                        Equip.ScrollPAtk += 9;
                                    }
                                    break;

                                #endregion STR 

                                #region MaxHP
                                case 19://100 MaxHP
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollMaxHP += 50;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    break;
                                case 20://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollMaxHP += 50;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollMaxHP += 100;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    break;
                                case 21://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollMaxHP += 50;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollMaxHP += 100;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollMaxHP += 150;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    break;
                                case 29://15
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollMaxHP += 100;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollMaxHP += 150;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollMaxHP += 200;
                                        Equip.ScrollPAtk += 9;
                                    }
                                    break;

                                #endregion MaxHP 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;
                        case 1://法師
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollMAtk += 9;
                                    Equip.ScrollSTR += 4;
                                    Equip.ScrollDEX += 4;
                                    Equip.ScrollINT += 4;
                                    Equip.ScrollLUK += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollMAtk += 10;
                                    Equip.ScrollSTR += 8;
                                    Equip.ScrollDEX += 8;
                                    Equip.ScrollINT += 8;
                                    Equip.ScrollLUK += 8;
                                    break;
                                case 3://X
                                    Equip.ScrollMAtk += 12;
                                    Equip.ScrollSTR += 10;
                                    Equip.ScrollDEX += 10;
                                    Equip.ScrollINT += 10;
                                    Equip.ScrollLUK += 10;
                                    break;
                                case 4://V
                                    Equip.ScrollMAtk += 13;
                                    Equip.ScrollSTR += 11;
                                    Equip.ScrollDEX += 11;
                                    Equip.ScrollINT += 11;
                                    Equip.ScrollLUK += 11;
                                    break;
                                case 5://黑
                                    Equip.ScrollMAtk += 14;
                                    Equip.ScrollSTR += 14;
                                    Equip.ScrollDEX += 14;
                                    Equip.ScrollINT += 14;
                                    Equip.ScrollLUK += 14;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文                         

                                #region INT
                                case 13://100 INT
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollMAtk += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollMAtk += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollINT += 1;
                                        Equip.ScrollMAtk += 3;
                                    }
                                    break;
                                case 14://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollMAtk += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollINT += 1;
                                        Equip.ScrollMAtk += 3;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollINT += 2;
                                        Equip.ScrollMAtk += 5;
                                    }
                                    break;
                                case 15://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollINT += 1;
                                        Equip.ScrollMAtk += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollINT += 2;
                                        Equip.ScrollMAtk += 5;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollINT += 3;
                                        Equip.ScrollMAtk += 7;
                                    }
                                    break;
                                case 24://15
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollINT += 2;
                                        Equip.ScrollMAtk += 5;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollINT += 3;
                                        Equip.ScrollMAtk += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollINT += 4;
                                        Equip.ScrollMAtk += 9;
                                    }
                                    break;

                                #endregion INT 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;
                        case 2://弓箭手
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollPAtk += 9;
                                    Equip.ScrollSTR += 4;
                                    Equip.ScrollDEX += 4;
                                    Equip.ScrollINT += 4;
                                    Equip.ScrollLUK += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollPAtk += 10;
                                    Equip.ScrollSTR += 8;
                                    Equip.ScrollDEX += 8;
                                    Equip.ScrollINT += 8;
                                    Equip.ScrollLUK += 8;
                                    break;
                                case 3://X
                                    Equip.ScrollPAtk += 12;
                                    Equip.ScrollSTR += 10;
                                    Equip.ScrollDEX += 10;
                                    Equip.ScrollINT += 10;
                                    Equip.ScrollLUK += 10;
                                    break;
                                case 4://V
                                    Equip.ScrollPAtk += 13;
                                    Equip.ScrollSTR += 11;
                                    Equip.ScrollDEX += 11;
                                    Equip.ScrollINT += 11;
                                    Equip.ScrollLUK += 11;
                                    break;
                                case 5://黑
                                    Equip.ScrollPAtk += 14;
                                    Equip.ScrollSTR += 14;
                                    Equip.ScrollDEX += 14;
                                    Equip.ScrollINT += 14;
                                    Equip.ScrollLUK += 14;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文

                                #region DEX
                                case 10://100 DEX
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    break;
                                case 11://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    break;
                                case 12://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    break;
                                case 23://15
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 4;
                                        Equip.ScrollPAtk += 9;
                                    }
                                    break;

                                #endregion DEX 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;
                        case 3://盜賊
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollPAtk += 9;
                                    Equip.ScrollSTR += 4;
                                    Equip.ScrollDEX += 4;
                                    Equip.ScrollINT += 4;
                                    Equip.ScrollLUK += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollPAtk += 10;
                                    Equip.ScrollSTR += 8;
                                    Equip.ScrollDEX += 8;
                                    Equip.ScrollINT += 8;
                                    Equip.ScrollLUK += 8;
                                    break;
                                case 3://X
                                    Equip.ScrollPAtk += 12;
                                    Equip.ScrollSTR += 10;
                                    Equip.ScrollDEX += 10;
                                    Equip.ScrollINT += 10;
                                    Equip.ScrollLUK += 10;
                                    break;
                                case 4://V
                                    Equip.ScrollPAtk += 13;
                                    Equip.ScrollSTR += 11;
                                    Equip.ScrollDEX += 11;
                                    Equip.ScrollINT += 11;
                                    Equip.ScrollLUK += 11;
                                    break;
                                case 5://黑
                                    Equip.ScrollPAtk += 14;
                                    Equip.ScrollSTR += 14;
                                    Equip.ScrollDEX += 14;
                                    Equip.ScrollINT += 14;
                                    Equip.ScrollLUK += 14;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文

                                #region STR
                                case 7://100 STR
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    break;
                                case 8://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    break;
                                case 9://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    break;
                                case 22://15
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 4;
                                        Equip.ScrollPAtk += 9;
                                    }
                                    break;

                                #endregion STR 

                                #region DEX
                                case 10://100 DEX
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    break;
                                case 11://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    break;
                                case 12://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    break;
                                case 23://15
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 4;
                                        Equip.ScrollPAtk += 9;
                                    }
                                    break;

                                #endregion DEX 

                                #region LUK
                                case 16://100 LUK
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    break;
                                case 17://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    break;
                                case 18://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    break;
                                case 25://15
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 4;
                                        Equip.ScrollPAtk += 9;
                                    }
                                    break;

                                #endregion LUK 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;
                        case 4://海盜
                            switch (scroll)
                            {
                                #region 艾比卷軸
                                case 1://極電
                                    Equip.ScrollPAtk += 9;
                                    Equip.ScrollSTR += 4;
                                    Equip.ScrollDEX += 4;
                                    Equip.ScrollINT += 4;
                                    Equip.ScrollLUK += 4;
                                    break;
                                case 2://Red
                                    Equip.ScrollPAtk += 10;
                                    Equip.ScrollSTR += 8;
                                    Equip.ScrollDEX += 8;
                                    Equip.ScrollINT += 8;
                                    Equip.ScrollLUK += 8;
                                    break;
                                case 3://X
                                    Equip.ScrollPAtk += 12;
                                    Equip.ScrollSTR += 10;
                                    Equip.ScrollDEX += 10;
                                    Equip.ScrollINT += 10;
                                    Equip.ScrollLUK += 10;
                                    break;
                                case 4://V
                                    Equip.ScrollPAtk += 13;
                                    Equip.ScrollSTR += 11;
                                    Equip.ScrollDEX += 11;
                                    Equip.ScrollINT += 11;
                                    Equip.ScrollLUK += 11;
                                    break;
                                case 5://黑
                                    Equip.ScrollPAtk += 14;
                                    Equip.ScrollSTR += 14;
                                    Equip.ScrollDEX += 14;
                                    Equip.ScrollINT += 14;
                                    Equip.ScrollLUK += 14;
                                    break;
                                case 6://榮耀
                                    break;
                                #endregion 艾比卷

                                #region 咒文

                                #region STR
                                case 7://100 STR
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    break;
                                case 8://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    break;
                                case 9://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    break;
                                case 22://15
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollSTR += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollSTR += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollSTR += 4;
                                        Equip.ScrollPAtk += 9;
                                    }
                                    break;

                                #endregion STR 

                                #region DEX
                                case 10://100 DEX
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    break;
                                case 11://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    break;
                                case 12://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    break;
                                case 23://15
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollDEX += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollDEX += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollDEX += 4;
                                        Equip.ScrollPAtk += 9;
                                    }
                                    break;

                                #endregion DEX 

                                #region LUK
                                case 16://100 LUK
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 1;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    break;
                                case 17://70
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollPAtk += 2;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    break;
                                case 18://30
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 1;
                                        Equip.ScrollPAtk += 3;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    break;
                                case 25://15
                                    if (Equip.Level < 75)
                                    {
                                        Equip.ScrollLUK += 2;
                                        Equip.ScrollPAtk += 5;
                                    }
                                    else if (Equip.Level > 74 && Equip.Level < 115)
                                    {
                                        Equip.ScrollLUK += 3;
                                        Equip.ScrollPAtk += 7;
                                    }
                                    else if (Equip.Level > 114)
                                    {
                                        Equip.ScrollLUK += 4;
                                        Equip.ScrollPAtk += 9;
                                    }
                                    break;

                                #endregion LUK 

                                #endregion 咒文

                                default:

                                    break;
                            }
                            break;

                    }

                    break;


                    #endregion

            }
        }
    }

    #endregion 計算卷軸

    //Step 3
    #region Final統整目前資訊 Consolidate All States
    /// <summary>
    ///  彙整基礎+浮動+卷軸到Final(會影響星力強化的數值)
    /// </summary>
    /// <param name="Equip">要計算的裝備</param>
    private static void AddToFinalState(EquipmentDetails Equip)
    {
        Equip.FinalSTR = Equip.STR + Equip.FloatSTR + Equip.ScrollSTR;
        Equip.FinalDEX = Equip.DEX + Equip.FloatDEX + Equip.ScrollDEX;
        Equip.FinalINT = Equip.INT + Equip.FloatINT + Equip.ScrollINT;
        Equip.FinalLUK = Equip.LUK + Equip.FloatLUK + Equip.ScrollLUK;
        Equip.FinalMaxHP = Equip.MaxHP + Equip.ScrollMaxHP;
        Equip.FinalMaxMP = Equip.MaxMP;
        Equip.FinalPAtk = Equip.PAtk + Equip.FloatPAtk + Equip.ScrollPAtk;
        Equip.FinalMAtk = Equip.MAtk + Equip.FloatMAtk + Equip.ScrollMAtk;
        Equip.FinalDef = Equip.Def + Equip.ScrollDef;
    }

    #endregion 計算浮動

    //Step 4 
    #region 星力計算 Cal Star Enhance

    private static void CalStarEnhance(EquipmentDetails Equip, int JobType)
    {
        //裝備部位
        int EquipType = int.Parse(Equip.Index.Substring(1, 2));
        switch (EquipType)
        {

            #region 全職業通用部位
            case 1://戒指
            case 6://墜飾
            case 9://腰帶
            case 11://臉飾 前15星不加HP
            case 12://眼飾 前15星不加HP
            case 17://耳飾 前15星不加HP
                for (int i = 1; i <= Equip.Star; i++)
                {
                    //防禦力固定加5%
                    Equip.FinalDef = Equip.Def + Equip.StarDef;
                    Equip.StarDef += (int)Math.Floor(Equip.FinalDef * 0.05);

                    switch (i)
                    {

                        #region 1~15星 普通幅度

                        #region 1星

                        case 1:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 5 : 0;
                            Equip.StarSTR += 2;
                            Equip.StarDEX += 2;
                            Equip.StarINT += 2;
                            Equip.StarLUK += 2;
                            break;

                        #endregion 1星

                        #region 2星

                        case 2:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 5 : 0;
                            Equip.StarSTR += 2;
                            Equip.StarDEX += 2;
                            Equip.StarINT += 2;
                            Equip.StarLUK += 2;
                            break;

                        #endregion 2星

                        #region 3星

                        case 3:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 5 : 0;
                            Equip.StarSTR += 2;
                            Equip.StarDEX += 2;
                            Equip.StarINT += 2;
                            Equip.StarLUK += 2;
                            break;

                        #endregion 3星

                        #region 4星

                        case 4:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 10 : 0;
                            Equip.StarSTR += 2;
                            Equip.StarDEX += 2;
                            Equip.StarINT += 2;
                            Equip.StarLUK += 2;
                            break;

                        #endregion 4星

                        #region 5星

                        case 5:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 10 : 0;
                            Equip.StarSTR += 2;
                            Equip.StarDEX += 2;
                            Equip.StarINT += 2;
                            Equip.StarLUK += 2;
                            break;

                        #endregion 5星

                        #region 6星

                        case 6:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 15 : 0;
                            Equip.StarSTR += 3;
                            Equip.StarDEX += 3;
                            Equip.StarINT += 3;
                            Equip.StarLUK += 3;
                            break;

                        #endregion 6星

                        #region 7星

                        case 7:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 15 : 0;
                            Equip.StarSTR += 3;
                            Equip.StarDEX += 3;
                            Equip.StarINT += 3;
                            Equip.StarLUK += 3;
                            break;

                        #endregion 7星

                        #region 8星

                        case 8:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 20 : 0;
                            Equip.StarSTR += 3;
                            Equip.StarDEX += 3;
                            Equip.StarINT += 3;
                            Equip.StarLUK += 3;
                            break;

                        #endregion 8星

                        #region 9星

                        case 9:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 20 : 0;
                            Equip.StarSTR += 3;
                            Equip.StarDEX += 3;
                            Equip.StarINT += 3;
                            Equip.StarLUK += 3;
                            break;

                        #endregion 9星

                        #region 10星

                        case 10:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 25 : 0;
                            Equip.StarSTR += 3;
                            Equip.StarDEX += 3;
                            Equip.StarINT += 3;
                            Equip.StarLUK += 3;
                            break;

                        #endregion 10星

                        #region 11星

                        case 11:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 25 : 0;
                            Equip.StarSTR += 3;
                            Equip.StarDEX += 3;
                            Equip.StarINT += 3;
                            Equip.StarLUK += 3;
                            break;

                        #endregion 11星

                        #region 12星

                        case 12:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 25 : 0;
                            Equip.StarSTR += 3;
                            Equip.StarDEX += 3;
                            Equip.StarINT += 3;
                            Equip.StarLUK += 3;
                            break;

                        #endregion 12星

                        #region 13星

                        case 13:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 25 : 0;
                            Equip.StarSTR += 3;
                            Equip.StarDEX += 3;
                            Equip.StarINT += 3;
                            Equip.StarLUK += 3;
                            break;

                        #endregion 13星

                        #region 14星

                        case 14:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 25 : 0;
                            Equip.StarSTR += 3;
                            Equip.StarDEX += 3;
                            Equip.StarINT += 3;
                            Equip.StarLUK += 3;
                            break;

                        #endregion 14星

                        #region 15星

                        case 15:
                            Equip.StarMaxHP += (EquipType != 11 && EquipType != 12 && EquipType != 17) ? 25 : 0;
                            Equip.StarSTR += 3;
                            Equip.StarDEX += 3;
                            Equip.StarINT += 3;
                            Equip.StarLUK += 3;
                            break;

                        #endregion 15星

                        #endregion 1~15星 普通幅度

                        #region 16~22星 開始加攻擊力

                        #region 16星

                        case 16:
                            //判斷一次，後續不用
                            Equip.FinalSTR = Equip.STR + Equip.ScrollSTR + Equip.StarSTR + Equip.FloatSTR;
                            Equip.FinalDEX = Equip.DEX + Equip.ScrollDEX + Equip.StarDEX + Equip.FloatDEX;
                            Equip.FinalINT = Equip.INT + Equip.ScrollINT + Equip.StarINT + Equip.FloatINT;
                            Equip.FinalLUK = Equip.LUK + Equip.ScrollLUK + Equip.StarLUK + Equip.FloatLUK;

                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += 7;
                                Equip.StarMAtk += 7;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 8;
                                Equip.StarMAtk += 8;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 9;
                                Equip.StarMAtk += 9;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 10;
                                Equip.StarMAtk += 10;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 12;
                                Equip.StarMAtk += 12;
                            }
                            break;

                        #endregion 16星

                        #region 17星

                        case 17:
                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += 8;
                                Equip.StarMAtk += 8;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 9;
                                Equip.StarMAtk += 9;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 10;
                                Equip.StarMAtk += 10;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 11;
                                Equip.StarMAtk += 11;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 13;
                                Equip.StarMAtk += 13;
                            }
                            break;

                        #endregion 17星

                        #region 18星

                        case 18:
                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += 9;
                                Equip.StarMAtk += 9;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 10;
                                Equip.StarMAtk += 10;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 11;
                                Equip.StarMAtk += 11;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 12;
                                Equip.StarMAtk += 12;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 14;
                                Equip.StarMAtk += 14;
                            }
                            break;

                        #endregion 18星

                        #region 19星

                        case 19:
                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += 10;
                                Equip.StarMAtk += 10;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 11;
                                Equip.StarMAtk += 11;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 12;
                                Equip.StarMAtk += 12;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 13;
                                Equip.StarMAtk += 13;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 15;
                                Equip.StarMAtk += 15;
                            }
                            break;

                        #endregion 19星

                        #region 20星

                        case 20:
                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += 11;
                                Equip.StarMAtk += 11;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 12;
                                Equip.StarMAtk += 12;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 13;
                                Equip.StarMAtk += 13;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 14;
                                Equip.StarMAtk += 14;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 16;
                                Equip.StarMAtk += 16;
                            }
                            break;

                        #endregion 20星

                        #region 21星

                        case 21:
                            if (Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 13;
                                Equip.StarMAtk += 13;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 14;
                                Equip.StarMAtk += 14;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 15;
                                Equip.StarMAtk += 15;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 17;
                                Equip.StarMAtk += 17;
                            }
                            break;

                        #endregion 21星

                        #region 22星

                        case 22:
                            if (Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 15;
                                Equip.StarMAtk += 15;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 16;
                                Equip.StarMAtk += 16;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 17;
                                Equip.StarMAtk += 17;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 19;
                                Equip.StarMAtk += 19;
                            }
                            break;

                        #endregion 22星

                        #endregion 16~22星 開始加攻擊力

                        #region 23~25星 只剩攻擊力加成

                        #region 23星

                        case 23:

                            if (Equip.Level < 150)
                            {
                                Equip.StarPAtk += 17;
                                Equip.StarMAtk += 17;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarPAtk += 18;
                                Equip.StarMAtk += 18;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarPAtk += 19;
                                Equip.StarMAtk += 19;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarPAtk += 21;
                                Equip.StarMAtk += 21;
                            }
                            break;

                        #endregion 23星

                        #region 24星

                        case 24:

                            if (Equip.Level < 150)
                            {
                                Equip.StarPAtk += 19;
                                Equip.StarMAtk += 19;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarPAtk += 20;
                                Equip.StarMAtk += 20;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarPAtk += 21;
                                Equip.StarMAtk += 21;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarPAtk += 23;
                                Equip.StarMAtk += 23;
                            }
                            break;

                        #endregion 24星

                        #region 25星

                        case 25:
                            if (Equip.Level < 150)
                            {
                                Equip.StarPAtk += 21;
                                Equip.StarMAtk += 21;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarPAtk += 22;
                                Equip.StarMAtk += 22;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarPAtk += 23;
                                Equip.StarMAtk += 23;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarPAtk += 25;
                                Equip.StarMAtk += 25;
                            }
                            break;

                            #endregion 25星

                        #endregion 23~25星 只剩攻擊力加成

                    }

                }
                break;
            #endregion 全職業通用部位
            
            #region 武器
            case 8: 
                for (int i = 1; i <= Equip.Star; i++)
                {
                    //攻擊力持續影響
                    Equip.FinalPAtk = Equip.PAtk + Equip.ScrollPAtk + Equip.StarPAtk + Equip.FloatPAtk;
                    Equip.FinalMAtk = Equip.MAtk + Equip.ScrollMAtk + Equip.StarMAtk + Equip.FloatMAtk;

                    switch (i)
                    {

                        #region 1~15星 受卷軸素質影響

                        #region 1星

                        case 1:

                            Equip.StarMaxHP += 5;
                            Equip.StarMaxMP += 5;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 2;
                                    Equip.StarDEX += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 2;
                                    Equip.StarLUK += 2;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 2;
                                    Equip.StarLUK += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 2;
                                    Equip.StarDEX += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 1星

                        #region 2星

                        case 2:
                            Equip.StarMaxHP += 5;
                            Equip.StarMaxMP += 5;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 2;
                                    Equip.StarDEX += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 2;
                                    Equip.StarLUK += 2;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 2;
                                    Equip.StarLUK += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 2;
                                    Equip.StarDEX += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 2星

                        #region 3星

                        case 3:
                            Equip.StarMaxHP += 5;
                            Equip.StarMaxMP += 5;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 2;
                                    Equip.StarDEX += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 2;
                                    Equip.StarLUK += 2;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 2;
                                    Equip.StarLUK += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 2;
                                    Equip.StarDEX += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 3星

                        #region 4星

                        case 4:
                            Equip.StarMaxHP += 10;
                            Equip.StarMaxMP += 10;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 2;
                                    Equip.StarDEX += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 2;
                                    Equip.StarLUK += 2;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 2;
                                    Equip.StarLUK += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 2;
                                    Equip.StarDEX += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 4星

                        #region 5星

                        case 5:
                            Equip.StarMaxHP += 10;
                            Equip.StarMaxMP += 10;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 2;
                                    Equip.StarDEX += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 2;
                                    Equip.StarLUK += 2;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 2;
                                    Equip.StarLUK += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 2;
                                    Equip.StarDEX += 2;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 5星

                        #region 6星

                        case 6:
                            Equip.StarMaxHP += 15;
                            Equip.StarMaxMP += 15;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 6星

                        #region 7星

                        case 7:
                            Equip.StarMaxHP += 15;
                            Equip.StarMaxMP += 15;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 7星

                        #region 8星

                        case 8:
                            Equip.StarMaxHP += 20;
                            Equip.StarMaxMP += 20;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 8星

                        #region 9星

                        case 9:
                            Equip.StarMaxHP += 20;
                            Equip.StarMaxMP += 20;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 9星

                        #region 10星

                        case 10:
                            Equip.StarMaxHP += 25;
                            Equip.StarMaxMP += 25;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 10星

                        #region 11星

                        case 11:
                            Equip.StarMaxHP += 25;
                            Equip.StarMaxMP += 25;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 11星

                        #region 12星

                        case 12:
                            Equip.StarMaxHP += 25;
                            Equip.StarMaxMP += 25;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 12星

                        #region 13星

                        case 13:
                            Equip.StarMaxHP += 25;
                            Equip.StarMaxMP += 25;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 13星

                        #region 14星

                        case 14:
                            Equip.StarMaxHP += 25;
                            Equip.StarMaxMP += 25;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 14星

                        #region 15星

                        case 15:
                            Equip.StarMaxHP += 25;
                            Equip.StarMaxMP += 25;
                            switch (JobType)
                            {
                                case 0://劍士
                                case 2://弓箭手
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 1://法師
                                    Equip.StarINT += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarMAtk += (1 + (int)Math.Floor((Equip.FinalMAtk) / 50m));
                                    break;
                                case 3://盜賊
                                    Equip.StarDEX += 3;
                                    Equip.StarLUK += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                                case 4://海盜
                                    Equip.StarSTR += 3;
                                    Equip.StarDEX += 3;
                                    Equip.StarPAtk += (1 + (int)Math.Floor((Equip.FinalPAtk) / 50m));
                                    break;
                            }
                            break;

                        #endregion 15星

                        #endregion 1~15星 受卷軸素質影響

                        #region 16~22星 開始加攻擊力

                        #region 16星

                        case 16:
                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 6 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 6 : 0;

                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 7 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 7 : 0;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 8 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 8 : 0;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 9 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 9 : 0;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 13 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 13 : 0;
                            }
                            break;

                        #endregion 16星

                        #region 17星

                        case 17:
                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 7 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 7 : 0;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 8 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 8 : 0;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 9 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 9 : 0;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 9 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 9 : 0;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 13 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 13 : 0;
                            }
                            break;

                        #endregion 17星

                        #region 18星

                        case 18:
                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 7 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 7 : 0;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 8 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 8 : 0;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 9 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 9 : 0;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 10 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 10 : 0;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 14 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 14 : 0;
                            }
                            break;

                        #endregion 18星

                        #region 19星

                        case 19:
                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 8 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 8 : 0;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 9 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 9 : 0;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 10 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 10 : 0;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 11 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 11 : 0;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 14 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 14 : 0;
                            }
                            break;

                        #endregion 19星

                        #region 20星

                        case 20:
                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 9 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 9 : 0;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 10 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 10 : 0;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 11 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 11 : 0;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 12 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 12 : 0;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 15 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 15 : 0;
                            }
                            break;

                        #endregion 20星

                        #region 21星

                        case 21:
                            if (Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 11 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 11 : 0;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 12 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 12 : 0;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 13 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 13 : 0;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 16 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 16 : 0;
                            }
                            break;

                        #endregion 21星

                        #region 22星

                        case 22:
                            if (Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 12 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 12 : 0;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 13 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 13 : 0;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 14 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 14 : 0;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.StarSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.StarDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.StarINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.StarLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 17 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 17 : 0;
                            }
                            break;

                        #endregion 22星

                        #endregion 16~22星 開始加攻擊力

                        #region 23~25星 只剩攻擊力加成

                        #region 23星

                        case 23:
                            if (Equip.Level < 150)
                            {
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 30 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 30 : 0;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 31 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 31 : 0;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 32 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 32 : 0;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 34 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 34 : 0;
                            }
                            break;

                        #endregion 23星

                        #region 24星

                        case 24: //爆炸成長
                            if (Equip.Level < 150)
                            {
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 31 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 31 : 0;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 32 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 32 : 0;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 33 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 33 : 0;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 35 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 35 : 0;
                            }
                            break;

                        #endregion 24星

                        #region 25星

                        case 25:
                            if (Equip.Level < 150)
                            {
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 32 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 32 : 0;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 33 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 33 : 0;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 34 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 34 : 0;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarPAtk += Equip.FinalPAtk != 0 ? 36 : 0;
                                Equip.StarMAtk += Equip.FinalMAtk != 0 ? 36 : 0;
                            }
                            break;

                            #endregion 25星

                        #endregion 23~25星 只剩攻擊力加成

                    }
                }
                break;

            #endregion 武器
            
            #region 各職業限定主/副屬加成
            case 10://帽子
            case 13://套服
            case 14://上衣
            case 15://褲子
            case 16://鞋子 前15星不加HP
            case 18://肩飾
            case 19://手套 前15星不加HP 手套會額外加攻擊
            case 24://披風
                for (int i = 1; i <= Equip.Star; i++)
                {
                    //防禦力固定加5%
                    Equip.FinalDef = Equip.Def + Equip.StarDef;
                    Equip.StarDef += (int)Math.Floor(Equip.FinalDef * 0.05);
                               
                    switch (i)
                    {
                        #region #region 1~15星 普通幅度

                        #region 1星

                        case 1:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 5 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 2;
                                Equip.StarDEX += 2;
                                Equip.StarINT += 2;
                                Equip.StarLUK += 2;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 2;
                                        Equip.StarDEX += 2;
                                        break;
                                    case 1:
                                        Equip.StarINT += 2;
                                        Equip.StarLUK += 2;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 2;
                                        Equip.StarLUK += 2;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 2;
                                        Equip.StarDEX += 2;
                                        break;
                                }
                            }
                            break;

                        #endregion 1星

                        #region 2星

                        case 2:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 5 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 2;
                                Equip.StarDEX += 2;
                                Equip.StarINT += 2;
                                Equip.StarLUK += 2;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 2;
                                        Equip.StarDEX += 2;
                                        break;
                                    case 1:
                                        Equip.StarINT += 2;
                                        Equip.StarLUK += 2;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 2;
                                        Equip.StarLUK += 2;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 2;
                                        Equip.StarDEX += 2;
                                        break;
                                }
                            }
                            break;

                        #endregion 2星

                        #region 3星

                        case 3:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 5 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 2;
                                Equip.StarDEX += 2;
                                Equip.StarINT += 2;
                                Equip.StarLUK += 2;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 2;
                                        Equip.StarDEX += 2;
                                        break;
                                    case 1:
                                        Equip.StarINT += 2;
                                        Equip.StarLUK += 2;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 2;
                                        Equip.StarLUK += 2;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 2;
                                        Equip.StarDEX += 2;
                                        break;
                                }
                            }
                            break;

                        #endregion 3星

                        #region 4星

                        case 4:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 10 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 2;
                                Equip.StarDEX += 2;
                                Equip.StarINT += 2;
                                Equip.StarLUK += 2;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 2;
                                        Equip.StarDEX += 2;
                                        break;
                                    case 1:
                                        Equip.StarINT += 2;
                                        Equip.StarLUK += 2;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 2;
                                        Equip.StarLUK += 2;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 2;
                                        Equip.StarDEX += 2;
                                        break;
                                }
                            }
                            break;

                        #endregion 4星

                        #region 5星

                        case 5:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 10 : 0;
                            //手套額外加攻擊
                            Equip.StarPAtk += (Equip.FinalPAtk != 0 && EquipType == 19) ? 1 : 0;
                            Equip.StarMAtk += (Equip.FinalMAtk != 0 && EquipType == 14) ? 1 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 2;
                                Equip.StarDEX += 2;
                                Equip.StarINT += 2;
                                Equip.StarLUK += 2;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 2;
                                        Equip.StarDEX += 2;
                                        break;
                                    case 1:
                                        Equip.StarINT += 2;
                                        Equip.StarLUK += 2;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 2;
                                        Equip.StarLUK += 2;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 2;
                                        Equip.StarDEX += 2;
                                        break;
                                }
                            }
                            break;

                        #endregion 5星

                        #region 6星

                        case 6:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 15 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 3;
                                Equip.StarDEX += 3;
                                Equip.StarINT += 3;
                                Equip.StarLUK += 3;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                    case 1:
                                        Equip.StarINT += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                }
                            }
                            break;

                        #endregion 6星

                        #region 7星

                        case 7:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 15 : 0;
                            //手套額外加攻擊
                            Equip.StarPAtk += (Equip.FinalPAtk != 0 && EquipType == 19) ? 1 : 0;
                            Equip.StarMAtk += (Equip.FinalMAtk != 0 && EquipType == 14) ? 1 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 3;
                                Equip.StarDEX += 3;
                                Equip.StarINT += 3;
                                Equip.StarLUK += 3;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                    case 1:
                                        Equip.StarINT += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                }
                            }
                            break;

                        #endregion 7星

                        #region 8星

                        case 8:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 20 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 3;
                                Equip.StarDEX += 3;
                                Equip.StarINT += 3;
                                Equip.StarLUK += 3;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                    case 1:
                                        Equip.StarINT += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                }
                            }
                            break;

                        #endregion 8星

                        #region 9星

                        case 9:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 20 : 0;
                            //手套額外加攻擊
                            Equip.StarPAtk += (Equip.FinalPAtk != 0 && EquipType == 19) ? 1 : 0;
                            Equip.StarMAtk += (Equip.FinalMAtk != 0 && EquipType == 14) ? 1 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 3;
                                Equip.StarDEX += 3;
                                Equip.StarINT += 3;
                                Equip.StarLUK += 3;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                    case 1:
                                        Equip.StarINT += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                }
                            }
                            break;

                        #endregion 9星

                        #region 10星

                        case 10:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 25 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 3;
                                Equip.StarDEX += 3;
                                Equip.StarINT += 3;
                                Equip.StarLUK += 3;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                    case 1:
                                        Equip.StarINT += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                }
                            }
                            break;

                        #endregion 10星

                        #region 11星

                        case 11:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 25 : 0;
                            //手套額外加攻擊
                            Equip.StarPAtk += (Equip.FinalPAtk != 0 && EquipType == 19) ? 1 : 0;
                            Equip.StarMAtk += (Equip.FinalMAtk != 0 && EquipType == 14) ? 1 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 3;
                                Equip.StarDEX += 3;
                                Equip.StarINT += 3;
                                Equip.StarLUK += 3;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                    case 1:
                                        Equip.StarINT += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                }
                            }
                            break;

                        #endregion 11星

                        #region 12星

                        case 12:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 25 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 3;
                                Equip.StarDEX += 3;
                                Equip.StarINT += 3;
                                Equip.StarLUK += 3;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                    case 1:
                                        Equip.StarINT += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                }
                            }
                            break;

                        #endregion 12星

                        #region 13星

                        case 13:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 25 : 0;
                            //手套額外加攻擊
                            Equip.StarPAtk += (Equip.FinalPAtk != 0 && EquipType == 19) ? 1 : 0;
                            Equip.StarMAtk += (Equip.FinalMAtk != 0 && EquipType == 14) ? 1 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 3;
                                Equip.StarDEX += 3;
                                Equip.StarINT += 3;
                                Equip.StarLUK += 3;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                    case 1:
                                        Equip.StarINT += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                }
                            }
                            break;

                        #endregion 13星

                        #region 14星

                        case 14:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 25 : 0;
                            //手套額外加攻擊
                            Equip.StarPAtk += (Equip.FinalPAtk != 0 && EquipType == 19) ? 1 : 0;
                            Equip.StarMAtk += (Equip.FinalMAtk != 0 && EquipType == 14) ? 1 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 3;
                                Equip.StarDEX += 3;
                                Equip.StarINT += 3;
                                Equip.StarLUK += 3;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                    case 1:
                                        Equip.StarINT += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                }
                            }
                            break;

                        #endregion 14星

                        #region 15星

                        case 15:
                            Equip.StarMaxHP += (EquipType != 16 && EquipType != 19) ? 25 : 0;
                            //手套額外加攻擊
                            Equip.StarPAtk += (Equip.FinalPAtk != 0 && EquipType == 19) ? 1 : 0;
                            Equip.StarMAtk += (Equip.FinalMAtk != 0 && EquipType == 14) ? 1 : 0;
                            if (Equip.Universal)
                            {
                                Equip.StarSTR += 3;
                                Equip.StarDEX += 3;
                                Equip.StarINT += 3;
                                Equip.StarLUK += 3;
                            }
                            else
                            {
                                switch (JobType)
                                {
                                    case 0:
                                    case 2:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                    case 1:
                                        Equip.StarINT += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 3:
                                        Equip.StarDEX += 3;
                                        Equip.StarLUK += 3;
                                        break;
                                    case 4:
                                        Equip.StarSTR += 3;
                                        Equip.StarDEX += 3;
                                        break;
                                }
                            }
                            break;

                        #endregion 15星

                        #endregion #region 1~15星 普通幅度

                        #region 16~22星 開始加攻擊力

                        #region 16星

                        case 16:
                            //判斷一次，後續不用
                            Equip.FinalSTR = Equip.STR + Equip.ScrollSTR + Equip.StarSTR + Equip.FloatSTR;
                            Equip.FinalDEX = Equip.DEX + Equip.ScrollDEX + Equip.StarDEX + Equip.FloatDEX;
                            Equip.FinalINT = Equip.INT + Equip.ScrollINT + Equip.StarINT + Equip.FloatINT;
                            Equip.FinalLUK = Equip.LUK + Equip.ScrollLUK + Equip.StarLUK + Equip.FloatLUK;

                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += 7;
                                Equip.StarMAtk += 7;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 8;
                                Equip.StarMAtk += 8;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 9;
                                Equip.StarMAtk += 9;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 10;
                                Equip.StarMAtk += 10;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 12;
                                Equip.StarMAtk += 12;
                            }
                            break;

                        #endregion 16星

                        #region 17星

                        case 17:
                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += 8;
                                Equip.StarMAtk += 8;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 9;
                                Equip.StarMAtk += 9;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 10;
                                Equip.StarMAtk += 10;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 11;
                                Equip.StarMAtk += 11;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 13;
                                Equip.StarMAtk += 13;
                            }
                            break;

                        #endregion 17星

                        #region 18星

                        case 18:
                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += 9;
                                Equip.StarMAtk += 9;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 10;
                                Equip.StarMAtk += 10;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 11;
                                Equip.StarMAtk += 11;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 12;
                                Equip.StarMAtk += 12;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 14;
                                Equip.StarMAtk += 14;
                            }
                            break;

                        #endregion 18星

                        #region 19星

                        case 19:
                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += 10;
                                Equip.StarMAtk += 10;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 11;
                                Equip.StarMAtk += 11;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 12;
                                Equip.StarMAtk += 12;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 13;
                                Equip.StarMAtk += 13;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 15;
                                Equip.StarMAtk += 15;
                            }
                            break;

                        #endregion 19星

                        #region 20星

                        case 20:
                            if (Equip.Level < 138)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 7 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 7 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 7 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 7 : 0;
                                Equip.StarPAtk += 11;
                                Equip.StarMAtk += 11;
                            }
                            else if (Equip.Level > 137 && Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 12;
                                Equip.StarMAtk += 12;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 13;
                                Equip.StarMAtk += 13;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 14;
                                Equip.StarMAtk += 14;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 16;
                                Equip.StarMAtk += 16;
                            }
                            break;

                        #endregion 20星

                        #region 21星

                        case 21:
                            if (Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 13;
                                Equip.StarMAtk += 13;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 14;
                                Equip.StarMAtk += 14;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 15;
                                Equip.StarMAtk += 15;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 17;
                                Equip.StarMAtk += 17;
                            }
                            break;

                        #endregion 21星

                        #region 22星

                        case 22:
                            if (Equip.Level < 150)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 9 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 9 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 9 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 9 : 0;
                                Equip.StarPAtk += 15;
                                Equip.StarMAtk += 15;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 11 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 11 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 11 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 11 : 0;
                                Equip.StarPAtk += 16;
                                Equip.StarMAtk += 16;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 13 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 13 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 13 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 13 : 0;
                                Equip.StarPAtk += 17;
                                Equip.StarMAtk += 17;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarSTR += Equip.FinalSTR != 0 ? 15 : 0;
                                Equip.StarDEX += Equip.FinalDEX != 0 ? 15 : 0;
                                Equip.StarINT += Equip.FinalINT != 0 ? 15 : 0;
                                Equip.StarLUK += Equip.FinalLUK != 0 ? 15 : 0;
                                Equip.StarPAtk += 19;
                                Equip.StarMAtk += 19;
                            }
                            break;

                        #endregion 22星

                        #endregion 16~22星 開始加攻擊力

                        #region 23~25星 只剩攻擊力加成

                        #region 23星

                        case 23:
                            if (Equip.Level < 150)
                            {
                                Equip.StarPAtk += 17;
                                Equip.StarMAtk += 17;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarPAtk += 18;
                                Equip.StarMAtk += 18;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarPAtk += 19;
                                Equip.StarMAtk += 19;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarPAtk += 21;
                                Equip.StarMAtk += 21;
                            }
                            break;

                        #endregion 23星

                        #region 24星

                        case 24:
                            if (Equip.Level < 150)
                            {
                                Equip.StarPAtk += 19;
                                Equip.StarMAtk += 19;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarPAtk += 20;
                                Equip.StarMAtk += 20;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarPAtk += 21;
                                Equip.StarMAtk += 21;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarPAtk += 23;
                                Equip.StarMAtk += 23;
                            }
                            break;

                        #endregion 24星

                        #region 25星

                        case 25:
                            if (Equip.Level < 150)
                            {
                                Equip.StarPAtk += 21;
                                Equip.StarMAtk += 21;
                            }
                            else if (Equip.Level > 149 && Equip.Level < 160)
                            {
                                Equip.StarPAtk += 22;
                                Equip.StarMAtk += 22;
                            }
                            else if (Equip.Level > 159 && Equip.Level < 200)
                            {
                                Equip.StarPAtk += 23;
                                Equip.StarMAtk += 23;
                            }
                            else if (Equip.Level == 200)
                            {
                                Equip.StarPAtk += 25;
                                Equip.StarMAtk += 25;
                            }
                            break;

                            #endregion 25星

                        #endregion 23~25星 只剩攻擊力加成

                    }

                }
                break;

                #endregion 各職業限定主/副屬加成

        }

    }
    #endregion 星力計算

    //Step 5
    #region 完整計算 Cal
    public static EquipmentDetails CalEquipFullState(EquipmentDetails Equip , int JobType)
    {
        //初始化裝備
        InitEquip(Equip);
        //計算卷軸
        CalEquipScroll(Equip, JobType);
        //Final統整目前資訊
        AddToFinalState(Equip);
        //計算星力加成
        CalStarEnhance(Equip, JobType);
        return Equip;
    }
    #endregion 完整計算

}
