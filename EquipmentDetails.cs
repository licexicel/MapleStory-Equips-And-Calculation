using System.Collections.Generic;

public class EquipmentDetails
{
    //名稱   
    public string Name { get; set; }
    //裝備等級    
    public int Level { get; set; }
    //1.裝備編號 1060713 106指第06個部位 中間07指第七個套裝效果(99是幸運道具) 結尾13指套裝的第幾個部位
    //2.無套裝效果則僅有3碼 101 表示這件裝備的部位  
    //1.Equip's Index = 1060713 106 means Sixth Equip Type / 07 means Seventh Sets effect(99 is Lucky Equip) / 13 means thirteenth Equip of the Set
    //2.Equip without Set Effect would only Has Three Code 101 means its Equip Type
    public string Index { get; set; }
    
    //基本屬性 裝備本身能有的 Basic State
    #region 基本屬性

    public int STR { get; set; }
    
    public int DEX { get; set; }
    
    public int INT { get; set; }
    
    public int LUK { get; set; }
    
    public int MaxHP { get; set; }
    
    public int MaxMP { get; set; }
    //墜飾才有的%數 Pendant Only
    public int HPPercent { get; set; }
    //墜飾才有的%數 Pendant Only
    public int MPPercent { get; set; }
    
    public int PAtk { get; set; }
    
    public int MAtk { get; set; }
    
    public int Def { get; set; }
    
    public int BossDamage { get; set; }
    
    public int Ignore { get; set; }
    //惡殺專屬  DemonSlayer Only
    public int DF { get; set; }
    //是否為全職業通用 如滅龍 紫翼系列   
    //In Star Enhance, some Equip Increase Job State only but Exist Universal Equip that Increase All States 
    public bool Universal { get; set; }
    //有套裝效果 預設有套裝效果    
    public bool hasSet { get; set; }
    //能上星火
    public bool hasFlame { get; set; }
    //能上捲 特例僅1個 vip胸章    
    public bool hasScroll { get; set; }
    //能上潛能  
    public bool hasPotential { get; set; }
    //能上星   
    public bool hasStar { get; set; }
    //卷軸    
    public int TotalScroll { get; set; }
    
    public int CurrentScroll { get; set; }
    
    public int Golden { get; set; }
    
    public int Platnium { get; set; }


    #endregion 基本屬性

    #region 星力屬性 StarEnhancement
    //星數    
    public int Star{ get; set; }
    
    public int StarSTR{ get; set; }
    
    public int StarDEX{ get; set; }
    
    public int StarINT{ get; set; }
    
    public int StarLUK{ get; set; }
    
    public int StarMaxHP{ get; set; }
    
    public int StarMaxMP{ get; set; }
    
    public int StarPAtk{ get; set; }
    
    public int StarMAtk{ get; set; }
    
    public int StarDef{ get; set; }


    #endregion 星力屬性

    #region 卷軸屬性 Scroll
    //個人處理方式，僅供參考
    //My work, for reference. you may do much better!
    //Scroll Index 
    //1極電  2Red 3X 4V 5黑 6榮耀 榮耀額外處理 
    // 7 = 100% STR /  8 = 70% STR /  9 = 30% STR / 10 = 100% DEX / 11 = 70% DEX / 12 = 30% DEX 
    //13 = 100% INT / 14 = 70% INT / 15 = 30% INT / 16 = 100% LUK / 17 = 70% LUK / 18 = 30% LUK
    //19 = 100% HP  / 20 = 70% HP  / 21 = 30% HP 
    //22 = 15% STR  / 23 = 15% DEX / 24 = 15% INT / 25 = 15% LUK  / 29 = 15% HP (15%為武器限定)
    //26 = 100%     / 27 = 70%     / 28 = 30% (手套限定+攻)
    public List<int> ScrollList{ get; set; }
    
    public int ScrollSTR{ get; set; }
    
    public int ScrollDEX{ get; set; }
    
    public int ScrollINT{ get; set; }
    
    public int ScrollLUK{ get; set; }
    
    public int ScrollMaxHP{ get; set; }
    
    public int ScrollPAtk{ get; set; }
    
    public int ScrollMAtk{ get; set; }
    
    public int ScrollDef{ get; set; }

    #endregion 卷軸屬性

    #region 星火屬性 Flame
    //綠字星火
    //Flame States (Green States)
    public int FlameSTR{ get; set; }
    
    public int FlameDEX{ get; set; }
    
    public int FlameINT{ get; set; }
    
    public int FlameLUK{ get; set; }
    
    public int FlameMaxHP{ get; set; }
    
    public int FlameMaxMP{ get; set; }
    
    public int FlamePAtk{ get; set; }
    
    public int FlameMAtk{ get; set; }
    
    public int FlameAllstate{ get; set; }
    
    public int FlameTotalDamage{ get; set; }
    
    public int FlameBossDamage{ get; set; }

    #endregion 星火屬性

    #region 浮動屬性 Float
    //裝備自帶的藍字
    //Equip Float States(Blue States)
    public int FloatSTR{ get; set; }
    
    public int FloatDEX{ get; set; }
    
    public int FloatINT{ get; set; }
    
    public int FloatLUK{ get; set; }
    
    public int FloatPAtk{ get; set; }
    
    public int FloatMAtk{ get; set; }

    #endregion 浮動屬性

    #region 最終屬性 FinalState
    //計算完裝備後，將最終屬性彙整至此
    //After Calculation, Store all States to Final States
    public int FinalSTR{ get; set; }
    
    public int FinalDEX{ get; set; }
    
    public int FinalINT{ get; set; }
    
    public int FinalLUK{ get; set; }
    
    public int FinalMaxHP{ get; set; }
    
    public int FinalMaxMP{ get; set; }
    
    public int FinalHPPercent{ get; set; }
    
    public int FinalMPPercent{ get; set; }
    
    public int FinalPAtk{ get; set; }
    
    public int FinalMAtk{ get; set; }
    
    public int FinalDef{ get; set; }
    
    public int FinalAllstate{ get; set; }
    
    public int FinalBossDamage{ get; set; }
    
    public int FinalIgnore{ get; set; }
    
    public int FinalTotalDamage{ get; set; }

    #endregion 最終屬性

    #region 潛能 Potential
    //規劃中
    //On Schedule, Not sure Type
    //潛能 Potential
    public int POne;
    public int PTwo;
    public int PThree;
    //附加潛能 Addition Potential
    public int APOne;
    public int APTwo;
    public int APThree;
    #endregion 潛能

    public EquipmentDetails()
    {
        STR = 0;
        DEX = 0;
        INT = 0;
        LUK = 0;
        MaxHP = 0;
        MaxMP = 0;
        HPPercent = 0;
        MPPercent = 0;
        PAtk = 0;
        MAtk = 0;
        Def = 0;
        BossDamage = 0;
        Ignore = 0;
        FlameAllstate = 0;
        FlameTotalDamage = 0;      
        DF = 0;
        TotalScroll = 0;
        CurrentScroll = 0;
        Golden = 0;
        Platnium = 0;
        Universal = false;
        hasSet = true;
        hasFlame = true;
        hasScroll = true;
        hasPotential = true;
        hasStar = true;
        ScrollList = new List<int>();
        
    }
   
    //共503件 Total: 503 Equips 
    
    //戒指 Ring ID:101 14件 完成新規範&資料驗證 2021.4.4   
    #region 戒指
    public static EquipmentDetails GetRing(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 希拉的憤怒
            case 1:
                ED.Name = "希拉的憤怒";
                ED.Level = 100;
                ED.Index = "101";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.PAtk = 25;
                ED.TotalScroll = 1;
                ED.hasSet = false;
                ED.hasFlame = false;             
                break;
            #endregion 希拉的憤怒

            #region 森之守護者
            case 2:
                ED.Name = "森之守護者";
                ED.Level = 100;
                ED.Index = "101";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.PAtk = 22;
                ED.MAtk = 22;
                ED.TotalScroll = 1;
                ED.hasSet = false;
                ED.hasFlame = false;             
                break;
            #endregion 森之守護者

            #region 梅格耐斯的憤怒
            case 3:
                ED.Name = "梅格耐斯的憤怒";
                ED.Level = 100;
                ED.Index = "101";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.MAtk = 25;
                ED.TotalScroll = 1;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
            #endregion 梅格耐斯的憤怒

            #region 骷顱頭戒指
            case 4:
                ED.Name = "骷顱頭戒指";
                ED.Level = 100;
                ED.Index = "101";
                ED.STR = 12;
                ED.DEX = 12;
                ED.INT = 12;
                ED.LUK = 12;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.PAtk = 20;
                ED.MAtk = 20;
                ED.TotalScroll = 1;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
            #endregion 骷顱頭戒指

            #region 新星戒指
            case 5:
                ED.Name = "新星戒指";
                ED.Level = 100;
                ED.Index = "101";
                ED.STR = 25;
                ED.DEX = 25;
                ED.INT = 25;
                ED.LUK = 25;
                ED.MaxHP = 200;
                ED.MaxMP = 200;
                ED.PAtk = 25;
                ED.MAtk = 25;
                ED.TotalScroll = 1;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
            #endregion 新星戒指

            #region 銀花戒指
            case 6:
                ED.Name = "銀花戒指";
                ED.Level = 110;
                ED.Index = "1012107";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.TotalScroll = 2;
                ED.hasFlame = false;
                break;
            #endregion 銀花戒指

            #region 真˙降魔的十字旅團的戒指
            case 7:
                ED.Name = "真˙降魔的十字旅團的戒指";
                ED.Level = 110;
                ED.Index = "101";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.Def = 65;
                ED.TotalScroll = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
            #endregion 真˙降魔的十字旅團的戒指

            #region 黑扉戒指
            //其實有套裝效果 但是其他部位沒放進來啦~
            case 8:
                ED.Name = "黑扉戒指";
                ED.Level = 120;
                ED.Index = "101";
                ED.STR = 7;
                ED.DEX = 7;
                ED.INT = 7;
                ED.LUK = 7;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.Def = 60;
                ED.TotalScroll = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
            #endregion 黑扉戒指

            #region 初級培羅德戒指
            case 9:
                ED.Name = "初級培羅德戒指";
                ED.Level = 120;
                ED.Index = "1012204";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.MaxHP = 50;
                ED.MaxMP = 50;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.Def = 50;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
            #endregion 初級培羅德戒指

            #region 頂級培羅德戒指
            case 10:
                ED.Name = "頂級培羅德戒指";
                ED.Level = 150;
                ED.Index = "1012504";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.MaxHP = 250;
                ED.MaxMP = 250;
                ED.PAtk = 8;
                ED.MAtk = 8;
                ED.Def = 150;
                ED.TotalScroll = 6;
                ED.hasFlame = false;
                break;
            #endregion 頂級培羅德戒指

            #region 天上的氣息
            case 11:
                ED.Name = "天上的氣息";
                ED.Level = 150;
                ED.Index = "101";
                ED.STR = 25;
                ED.DEX = 25;
                ED.INT = 25;
                ED.LUK = 25;
                ED.MaxHP = 200;
                ED.MaxMP = 200;
                ED.PAtk = 25;
                ED.MAtk = 25;
                ED.TotalScroll = 1;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
            #endregion 天上的氣息

            #region 魔性的戒指
            case 12:
                ED.Name = "魔性的戒指";
                ED.Level = 155;
                ED.Index = "101";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.TotalScroll = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
            #endregion 魔性的戒指

            #region 強力的魔性戒指
            case 13:
                ED.Name = "強力的魔性戒指";
                ED.Level = 160;
                ED.Index = "101";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.MaxHP = 800;
                ED.MaxMP = 800;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.TotalScroll = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
            #endregion 強力的魔性戒指

            #region 巨大的恐怖
            case 14:
                ED.Name = "巨大的恐怖";
                ED.Level = 200;
                ED.Index = "1012608";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.MaxHP = 250;
                ED.MaxMP = 250;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.TotalScroll = 2;
                ED.hasFlame = false;
                break;
            #endregion 巨大的恐怖

        }
        return ED;
    }
    #endregion 戒指

    //口袋 Pocket ID:105 7件 完成新規範&資料驗證 2021.4.4  
    #region 口袋
    public static EquipmentDetails GetPocket(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 時間逆行
            case 1:
                ED.Name = "時間逆行";
                ED.Level = 0;
                ED.Index = "105";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.MaxHP = 0;
                ED.MaxMP = 0;
                ED.PAtk = 12;
                ED.MAtk = 12;
                ED.hasSet = false;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion 時間逆行

            #region 粉紅聖杯
            case 2:
                ED.Name = "粉紅聖杯";
                ED.Level = 140;
                ED.Index = "1052116";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.MaxHP = 50;
                ED.MaxMP = 50;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion 粉紅聖杯

            #region 查˙克羅斯
            case 3:
                ED.Name = "查˙克羅斯";
                ED.Level = 160;
                ED.Index = "105";
                ED.STR = 9;
                ED.DEX = 9;
                ED.INT = 9;
                ED.LUK = 9;
                ED.MaxMP = 300;
                ED.PAtk = 9;
                ED.MAtk = 9;
                ED.hasSet = false;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion 查˙克羅斯

            #region 受詛咒的赤魔導書
            case 4:
                ED.Name = "受詛咒的赤魔導書";
                ED.Level = 160;
                ED.Index = "1052609";
                ED.STR = 20;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.MaxHP = 100;
                ED.MaxMP = 100;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion 受詛咒的赤魔導書

            #region 受詛咒的綠魔導書
            case 5:
                ED.Name = "受詛咒的綠魔導書";
                ED.Level = 160;
                ED.Index = "1052609";
                ED.STR = 10;
                ED.DEX = 20;
                ED.INT = 10;
                ED.LUK = 10;
                ED.MaxHP = 100;
                ED.MaxMP = 100;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion 受詛咒的綠魔導書

            #region 受詛咒的青魔導書
            case 6:
                ED.Name = "受詛咒的青魔導書";
                ED.Level = 160;
                ED.Index = "1052609";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 20;
                ED.LUK = 10;
                ED.MaxHP = 100;
                ED.MaxMP = 100;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion 受詛咒的青魔導書

            #region 受詛咒的黃魔導書
            case 7:
                ED.Name = "受詛咒的黃魔導書";
                ED.Level = 160;
                ED.Index = "1052609";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 20;
                ED.MaxHP = 100;
                ED.MaxMP = 100;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion 受詛咒的黃魔導書

        }
        return ED;
    }
    #endregion 口袋

    //墜飾 Pendant ID:106 8件 完成新規範&資料驗證 2021.4.4  
    #region 墜飾
    public static EquipmentDetails GetPendant(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 混沌闇黑龍王的項鍊
            case 1:
                ED.Name = "混沌闇黑龍王的項鍊";
                ED.Level = 120;
                ED.Index = "1062111";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.HPPercent = 10;
                ED.MPPercent = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.Def = 140;
                ED.TotalScroll = 3;               
                break;
            #endregion 混沌闇黑龍王項鍊

            #region 初級培羅德烙印墜飾
            case 2:
                ED.Name = "初級培羅德烙印墜飾";
                ED.Level = 120;
                ED.Index = "1062202";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.MaxHP = 200;
                ED.MaxMP = 200;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.Def = 100;
                ED.TotalScroll = 3;
                break;
            #endregion 初級培羅德烙印墜飾

            #region 支配者墜飾
            case 3:
                ED.Name = "支配者墜飾";
                ED.Level = 140;
                ED.Index = "1062113";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.HPPercent = 10;
                ED.MPPercent = 10;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.Def = 100;
                ED.TotalScroll = 5;
                break;
            #endregion 支配者墜飾

            #region 死神的項鍊
            case 4:
                ED.Name = "死神的項鍊";
                ED.Level = 144;
                ED.Index = "106";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.TotalScroll = 11;
                ED.hasSet = false;
                break;
            #endregion 死神項鍊

            #region 神秘墜飾
            case 5:
                ED.Name = "神秘墜飾";
                ED.Level = 150;
                ED.Index = "1062703";
                ED.STR = 30;
                ED.DEX = 30;
                ED.INT = 30;
                ED.LUK = 30;
                ED.MaxHP = 300;
                ED.MaxMP = 300;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.Def = 50;
                ED.TotalScroll = 6;
                break;
            #endregion 神秘墜飾

            #region 頂級培羅德烙印墜飾
            case 6:
                ED.Name = "頂級培羅德烙印墜飾";
                ED.Level = 150;
                ED.Index = "1062502";
                ED.STR = 28;
                ED.DEX = 28;
                ED.INT = 28;
                ED.LUK = 28;
                ED.MaxHP = 300;
                ED.MaxMP = 300;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.Def = 100;
                ED.TotalScroll = 6;
                break;
            #endregion 頂級培羅德烙印墜飾

            #region 強力的魔性首飾
            case 7:
                ED.Name = "強力的魔性首飾";
                ED.Level = 160;
                ED.Index = "106";
                ED.STR = 35;
                ED.DEX = 35;
                ED.INT = 35;
                ED.LUK = 35;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.TotalScroll = 3;
                ED.hasSet = false;
                break;
            #endregion 強力的魔性首飾

            #region 苦痛的根源
            case 8:
                ED.Name = "苦痛的根源";
                ED.Level = 160;
                ED.Index = "1062605";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.HPPercent = 5;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.Def = 200;
                ED.TotalScroll = 5;
                break;
            #endregion 苦痛的根源

        }
        return ED;
    }
    #endregion 墜飾

    //武器 Weapon ID:108 163件(已扣除重複) 完成新規範&資料驗證 2021.4.4
    #region 武器類 (185件)

    #region 冒險家 - 劍士 41件 (含重複的共52件)

    #region 英雄 (17件 4 5 4 4)
    public static EquipmentDetails GetHeroWeapon(int Type, int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Type)
        {

            #region 單手劍
            case 1:
                switch (Index)
                {
                    #region 烏特卡勒德軍刀
                    case 1:
                        ED.Name = "烏特卡勒德軍刀";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 118;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德軍刀

                    #region 夫尼爾長青劍
                    case 2:
                        ED.Name = "夫尼爾長青劍";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 164;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾長青劍

                    #region 航海師軍刀
                    case 3:
                        ED.Name = "航海師軍刀";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 197;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師軍刀

                    #region 神秘冥界幽靈長劍
                    case 4:
                        ED.Name = "神秘冥界幽靈長劍";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 283;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 神秘冥界幽靈長劍

                }
                break;
            #endregion 單手劍

            #region 雙手劍
            case 2:
                //被詛咒的凱薩利恩 解放的凱薩利恩 rb頂武
                switch (Index)
                {
                    #region 烏特卡勒德雙手劍
                    case 1:
                        ED.Name = "烏特卡勒德雙手劍";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 122;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德雙手劍

                    #region 夫尼爾佩尼坦西亞重劍
                    case 2:
                        ED.Name = "夫尼爾佩尼坦西亞重劍";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 171;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾佩尼坦西亞重劍

                    #region 琉德的劍
                    case 3:
                        ED.Name = "琉德的劍";
                        ED.Level = 150;
                        ED.Index = "108";
                        ED.STR = 45;
                        ED.DEX = 35;
                        ED.PAtk = 165;
                        ED.BossDamage = 10;
                        ED.Ignore = 10;
                        ED.TotalScroll = 6;
                        ED.hasSet = false;
                        break;
                    #endregion 琉德的劍

                    #region 航海師重劍
                    case 4:
                        ED.Name = "航海師重劍";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 205;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師重劍

                    #region 神秘冥界幽靈雙手劍
                    case 5:
                        ED.Name = "神秘冥界幽靈雙手劍";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 295;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 神秘冥界幽靈雙手劍

                }
                break;
            #endregion 雙手劍

            #region 單手斧
            case 3:
                switch (Index)
                {
                    #region 烏特卡勒德之斧
                    case 1:
                        ED.Name = "烏特卡勒德之斧";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 118;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德之斧

                    #region 夫尼爾雙刃斧
                    case 2:
                        ED.Name = "夫尼爾雙刃斧";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 164;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾雙刃斧

                    #region 航海師雙刃斧
                    case 3:
                        ED.Name = "航海師雙刃斧";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 197;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師雙刃斧

                    #region 神秘冥界幽靈之斧
                    case 4:
                        ED.Name = "神秘冥界幽靈之斧";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 283;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 神秘冥界幽靈之斧

                }
                break;
            #endregion 單手斧

            #region 雙手斧
            case 4:
                switch (Index)
                {
                    #region 烏特卡勒德雙手戰斧
                    case 1:
                        ED.Name = "烏特卡勒德雙手戰斧";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 124;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德雙手戰斧

                    #region 夫尼爾戰鬥重斧
                    case 2:
                        ED.Name = "夫尼爾戰鬥重斧";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 171;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾戰鬥重斧

                    #region 航海師戰斧
                    case 3:
                        ED.Name = "航海師戰斧";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 205;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師戰斧

                    #region 神秘冥界幽靈雙手斧
                    case 4:
                        ED.Name = "神秘冥界幽靈雙手斧";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 295;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 神秘冥界幽靈雙手斧

                }
                break;
                #endregion 雙手斧

        }
        return ED;
    }
    #endregion 英雄

    #region 聖騎士 (17件 4 5 4 4)  old 10件(已扣掉重複 原21件)
    public static EquipmentDetails GetPaladinWeapon(int Type, int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Type)
        {
            #region 單手劍
            case 1:
                switch (Index)
                {
                    #region 烏特卡勒德軍刀
                    case 1:
                        ED.Name = "烏特卡勒德軍刀";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 118;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德軍刀

                    #region 夫尼爾長青劍
                    case 2:
                        ED.Name = "夫尼爾長青劍";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 164;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾長青劍

                    #region 航海師軍刀
                    case 3:
                        ED.Name = "航海師軍刀";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 197;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師軍刀

                    #region 神秘冥界幽靈長劍
                    case 4:
                        ED.Name = "神秘冥界幽靈長劍";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 283;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 神秘冥界幽靈長劍

                }
                break;
            #endregion 單手劍

            #region 雙手劍
            case 2:
                //被詛咒的凱薩利恩 解放的凱薩利恩 rb頂武
                switch (Index)
                {
                    #region 烏特卡勒德雙手劍
                    case 1:
                        ED.Name = "烏特卡勒德雙手劍";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 122;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德雙手劍

                    #region 夫尼爾佩尼坦西亞重劍
                    case 2:
                        ED.Name = "夫尼爾佩尼坦西亞重劍";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 171;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾佩尼坦西亞重劍

                    #region 琉德的劍
                    case 3:
                        ED.Name = "琉德的劍";
                        ED.Level = 150;
                        ED.Index = "108";
                        ED.STR = 45;
                        ED.DEX = 35;
                        ED.PAtk = 165;
                        ED.BossDamage = 10;
                        ED.Ignore = 10;
                        ED.TotalScroll = 6;
                        ED.hasSet = false;
                        break;
                    #endregion 琉德的劍

                    #region 航海師重劍
                    case 4:
                        ED.Name = "航海師重劍";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 205;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師重劍

                    #region 神秘冥界幽靈雙手劍
                    case 5:
                        ED.Name = "神秘冥界幽靈雙手劍";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 295;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 神秘冥界幽靈雙手劍

                }
                break;
            #endregion 雙手劍

            #region 單手棍(錘)
            case 3:
                switch (Index)
                {
                    #region 烏特卡勒德之錘
                    case 1:
                        ED.Name = "烏特卡勒德之錘";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 118;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德之錘

                    #region 夫尼爾哥帝爾斯之錘
                    case 2:
                        ED.Name = "夫尼爾哥帝爾斯之錘";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 164;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾哥帝爾斯之錘

                    #region 航海師十字錘
                    case 3:
                        ED.Name = "航海師十字錘";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 197;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師十字錘

                    #region 神秘冥界幽靈之錘
                    case 4:
                        ED.Name = "神秘冥界幽靈之錘";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 283;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 神秘冥界幽靈之錘

                }
                break;
            #endregion 單手錘

            #region 雙手棍(錘)
            case 4:
                switch (Index)
                {
                    #region 烏特卡勒德雙手錘
                    case 1:
                        ED.Name = "烏特卡勒德雙手錘";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 124;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德雙手錘

                    #region 夫尼爾閃雷之錘
                    case 2:
                        ED.Name = "夫尼爾閃雷之錘";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 171;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾閃雷之錘

                    #region 航海師戰錘
                    case 3:
                        ED.Name = "航海師戰錘";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 205;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師戰錘

                    #region 神秘冥界幽靈雙手錘
                    case 4:
                        ED.Name = "神秘冥界幽靈雙手錘";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 295;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 神秘冥界幽靈雙手錘

                }
                break;
                #endregion 雙手錘

        }
        return ED;
    }
    #endregion 聖騎士

    #region 黑騎士 (8件 4+4)
    public static EquipmentDetails GetDarkKnightWeapon(int Type, int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Type)
        {
            #region 槍
            case 1:
                switch (Index)
                {
                    #region 烏特卡勒德之槍
                    case 1:
                        ED.Name = "烏特卡勒德之槍";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 124;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德之槍

                    #region 夫尼爾光翼之槍
                    case 2:
                        ED.Name = "夫尼爾光翼之槍";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 171;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾光翼之槍

                    #region 航海師穿刺槍
                    case 3:
                        ED.Name = "航海師穿刺槍";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 205;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師穿刺槍

                    #region 神秘冥界幽靈之槍
                    case 4:
                        ED.Name = "神秘冥界幽靈之槍";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 295;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 神秘冥界幽靈之槍

                }
                break;
            #endregion 槍

            #region 矛
            case 2:
                switch (Index)
                {
                    #region 烏特卡勒德飛翔斧
                    case 1:
                        ED.Name = "烏特卡勒德飛翔斧";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 122;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德飛翔斧

                    #region 夫尼爾月之長矛
                    case 2:
                        ED.Name = "夫尼爾月之長矛";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 153;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾月之長矛

                    #region 航海師戰戟
                    case 3:
                        ED.Name = "航海師戰戟";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 184;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師戰戟

                    #region 神秘冥界幽靈之矛
                    case 4:
                        ED.Name = "神秘冥界幽靈之矛";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 264;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 神秘冥界幽靈之矛

                }
                break;
                #endregion 矛

        }
        return ED;
    }
    #endregion 黑騎士

    #endregion 冒險家  - 劍士
    
    #region 冒險家 - 法師 & 烈焰巫師 & 龍魔導士 (8件 4+4)
    public static EquipmentDetails GetMagicainWeapon(int Type, int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Type)
        {
            #region 長杖
            case 1:
                switch (Index)
                {
                    #region 烏特卡勒德長杖
                    case 1:
                        ED.Name = "烏特卡勒德長杖";
                        ED.Level = 140;
                        ED.Index = "1080206";
                        ED.PAtk = 98;
                        ED.MAtk = 155;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德長杖

                    #region 夫尼爾魔法長杖
                    case 2:
                        ED.Name = "夫尼爾魔法長杖";
                        ED.Level = 150;
                        ED.Index = "1080704";
                        ED.INT = 40;
                        ED.LUK = 40;
                        ED.PAtk = 126;
                        ED.MAtk = 204;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾魔法長杖

                    #region 航海師文字長杖
                    case 3:
                        ED.Name = "航海師文字長杖";
                        ED.Level = 160;
                        ED.Index = "1081207";
                        ED.INT = 60;
                        ED.LUK = 60;
                        ED.PAtk = 151;
                        ED.MAtk = 245;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師文字長杖

                    #region 神秘冥界幽靈長杖
                    case 4:
                        ED.Name = "神秘冥界幽靈長杖";
                        ED.Level = 200;
                        ED.Index = "1081707";
                        ED.INT = 100;
                        ED.LUK = 100;
                        ED.PAtk = 218;
                        ED.MAtk = 353;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 神秘冥界幽靈長杖

                }
                break;
            #endregion 長杖

            #region 短杖
            case 2:
                switch (Index)
                {
                    #region 烏特卡勒德短杖
                    case 1:
                        ED.Name = "烏特卡勒德短杖";
                        ED.Level = 140;
                        ED.Index = "1080206";
                        ED.PAtk = 93;
                        ED.MAtk = 153;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德短杖

                    #region 夫尼爾魔之短杖
                    case 2:
                        ED.Name = "夫尼爾魔之短杖";
                        ED.Level = 150;
                        ED.Index = "1080704";
                        ED.INT = 40;
                        ED.LUK = 40;
                        ED.PAtk = 119;
                        ED.MAtk = 201;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾魔之短杖
                 
                    #region 航海師文字短杖
                    case 3:
                        ED.Name = "航海師文字短杖";
                        ED.Level = 160;
                        ED.Index = "1081207";
                        ED.INT = 60;
                        ED.LUK = 60;
                        ED.PAtk = 143;
                        ED.MAtk = 241;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師文字短杖

                    #region 神秘冥界幽靈短杖
                    case 4:
                        ED.Name = "神秘冥界幽靈短杖";
                        ED.Level = 200;
                        ED.Index = "1081707";
                        ED.INT = 100;
                        ED.LUK = 100;
                        ED.PAtk = 206;
                        ED.MAtk = 347;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 神秘冥界幽靈短杖

                }
                break;
                #endregion 短杖

        }
        return ED;
    }
    #endregion 冒險家 - 法師 & 烈焰巫師
    
    #region 冒險家 - 箭神 & 破風使者 (4件)
    public static EquipmentDetails GetBowMasterWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德之弓
            case 1:
                ED.Name = "烏特卡勒德之弓";
                ED.Level = 140;
                ED.Index = "1080306";
                ED.PAtk = 115;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德之弓

            #region 夫尼爾風之長弓
            case 2:
                ED.Name = "夫尼爾風之長弓";
                ED.Level = 150;
                ED.Index = "1080804";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 160;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾風之長弓

            #region 航海師混合弓
            case 3:
                ED.Name = "夫尼爾風之長弓";
                ED.Level = 160;
                ED.Index = "1081307";
                ED.STR = 60;
                ED.DEX = 60;
                ED.PAtk = 192;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師混合弓

            #region 神秘冥界幽靈之弓
            case 4:
                ED.Name = "神秘冥界幽靈之弓";
                ED.Level = 200;
                ED.Index = "1081807";
                ED.STR = 100;
                ED.DEX = 100;
                ED.PAtk = 276;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈之弓

        }
        return ED;
    }
    #endregion 冒險家 - 箭神 & 破風使者
    
    #region 冒險家 - 神射手 & 狂豹獵人 (4件)
    public static EquipmentDetails GetMarksManWeapon(int Index)
    {
        //Type One Only: Crossbow
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德十字弓
            case 1:
                ED.Name = "烏特卡勒德十字弓";
                ED.Level = 140;
                ED.Index = "1080306";
                ED.PAtk = 118;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德十字弓

            #region 夫尼爾風之翼強弓
            case 2:
                ED.Name = "夫尼爾風之翼強弓";
                ED.Level = 150;
                ED.Index = "1080804";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 164;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾風之翼強弓

            #region 航海師強弩
            case 3:
                ED.Name = "航海師強弩";
                ED.Level = 160;
                ED.Index = "1081307";
                ED.STR = 60;
                ED.DEX = 60;
                ED.PAtk = 197;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師強弩

            #region 神秘冥界幽靈十字弓
            case 4:
                ED.Name = "神秘冥界幽靈十字弓";
                ED.Level = 200;
                ED.Index = "1081807";
                ED.STR = 100;
                ED.DEX = 100;
                ED.PAtk = 283;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈十字弓

        }
        return ED;
    }
    #endregion 冒險家 - 神射手 & 狂豹獵人
    
    #region 冒險家 - 開拓者 (4件)
    public static EquipmentDetails GetPathfinderWeapon(int Index)
    {
        //Type One Only: AncientBow
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德古代之弓
            case 1:
                ED.Name = "烏特卡勒德古代之弓";
                ED.Level = 140;
                ED.Index = "1080306";
                ED.PAtk = 115;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德古代之弓

            #region 夫尼爾古代之弓
            case 2:
                ED.Name = "夫尼爾古代之弓";
                ED.Level = 150;
                ED.Index = "1080804";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 160;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾古代之弓

            #region 航海師古代之弓
            case 3:
                ED.Name = "航海師古代之弓";
                ED.Level = 160;
                ED.Index = "1081307";
                ED.STR = 60;
                ED.DEX = 60;
                ED.PAtk = 192;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師古代之弓

            #region 神秘冥界幽靈古代之弓
            case 4:
                ED.Name = "神秘冥界幽靈古代之弓";
                ED.Level = 200;
                ED.Index = "1081807";
                ED.STR = 100;
                ED.DEX = 100;
                ED.PAtk = 276;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈古代之弓

        }
        return ED;
    }
    #endregion 冒險家 - 開拓者
    
    #region 冒險家 - 盜賊 - 夜使者 & 暗夜行者 (4件)
    public static EquipmentDetails GetNightLordWeapon(int Index)
    {
        //Type One Only: Claw
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德鬥拳
            case 1:
                ED.Name = "烏特卡勒德鬥拳";
                ED.Level = 140;
                ED.Index = "1080406";
                ED.LUK = 10;
                ED.PAtk = 62;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德鬥拳

            #region 夫尼爾風險拳套
            case 2:
                ED.Name = "夫尼爾風險拳套";
                ED.Level = 150;
                ED.Index = "1080904";
                ED.LUK = 40;
                ED.DEX = 40;
                ED.PAtk = 86;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾風險拳套

            #region 航海師復仇拳套
            case 3:
                ED.Name = "航海師復仇拳套";
                ED.Level = 160;
                ED.Index = "1081407";
                ED.LUK = 60;
                ED.DEX = 60;
                ED.PAtk = 103;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師復仇拳套

            #region 神秘冥界幽靈鬥拳
            case 4:
                ED.Name = "神秘冥界幽靈鬥拳";
                ED.Level = 200;
                ED.Index = "1081907";
                ED.LUK = 100;
                ED.DEX = 100;
                ED.PAtk = 149;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈鬥拳

        }
        return ED;
    }
    #endregion 冒險家 - 盜賊 - 夜使者 & 暗夜行者
    
    #region 冒險家 - 盜賊 - 暗影神偷 + 影武者 (4件)
    public static EquipmentDetails GetShadowerWeapon(int Index)
    {
        //Type One Only: Dagger
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德短刀
            case 1:
                ED.Name = "烏特卡勒德短刀";
                ED.Level = 140;
                ED.Index = "1080406";
                ED.PAtk = 115;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德短刀

            #region 夫尼爾大馬士革短刀
            case 2:
                ED.Name = "夫尼爾大馬士革短刀";
                ED.Level = 150;
                ED.Index = "1080904";
                ED.LUK = 40;
                ED.DEX = 40;
                ED.PAtk = 160;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾大馬士革短刀

            #region 航海師短刀
            case 3:
                ED.Name = "航海師短刀";
                ED.Level = 160;
                ED.Index = "1081407";
                ED.LUK = 60;
                ED.DEX = 60;
                ED.PAtk = 192;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師短刀

            #region 神秘冥界幽靈短刀
            case 4:
                ED.Name = "神秘冥界幽靈短刀";
                ED.Level = 200;
                ED.Index = "1081907";
                ED.LUK = 100;
                ED.DEX = 100;
                ED.PAtk = 276;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈短刀

        }
        return ED;
    }
    #endregion 冒險家 - 盜賊 - 暗影神偷 + 影武者
    
    #region 冒險家 - 海盜 - 拳霸 & 閃雷悍將 & 隱月 & 亞克 (4件)
    public static EquipmentDetails GetBuccaneerWeapon(int Index)
    {
        //Type One Only: Knuckle 指虎
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德之爪
            case 1:
                ED.Name = "烏特卡勒德之爪";
                ED.Level = 140;
                ED.Index = "1080506";
                ED.PAtk = 90;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德之爪

            #region 夫尼爾芬里爾爪
            case 2:
                ED.Name = "夫尼爾芬里爾爪";
                ED.Level = 150;
                ED.Index = "1081004";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 128;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾芬里爾爪

            #region 航海師指虎
            case 3:
                ED.Name = "航海師指虎";
                ED.Level = 160;
                ED.Index = "1081507";
                ED.LUK = 60;
                ED.DEX = 60;
                ED.PAtk = 154;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師指虎

            #region 神秘冥界幽靈之爪
            case 4:
                ED.Name = "神秘冥界幽靈之爪";
                ED.Level = 200;
                ED.Index = "1082007";
                ED.LUK = 100;
                ED.DEX = 100;
                ED.PAtk = 221;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈之爪

        }
        return ED;
    }
    #endregion 冒險家 - 海盜 - 拳霸 & 閃雷悍將 & 隱月

    #region 冒險家 - 海盜 - 槍神 & 機甲戰神 (4件)
    public static EquipmentDetails GetCorsairWeapon(int Index)
    {
        //Gun 火槍
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德火槍
            case 1:
                ED.Name = "烏特卡勒德火槍";
                ED.Level = 140;
                ED.Index = "1080506";
                ED.PAtk = 90;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德火槍

            #region 夫尼爾轉輪手槍
            case 2:
                ED.Name = "夫尼爾轉輪手槍";
                ED.Level = 150;
                ED.Index = "1081004";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 125;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾轉輪手槍

            #region 航海師手槍
            case 3:
                ED.Name = "航海師手槍";
                ED.Level = 160;
                ED.Index = "1081507";
                ED.LUK = 60;
                ED.DEX = 60;
                ED.PAtk = 150;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師手槍

            #region 神秘冥界幽靈火槍
            case 4:
                ED.Name = "神秘冥界幽靈火槍";
                ED.Level = 200;
                ED.Index = "1082007";
                ED.LUK = 100;
                ED.DEX = 100;
                ED.PAtk = 216;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈火槍

        }
        return ED;
    }
    #endregion 冒險家 - 海盜 - 槍神 & 蒼龍俠客 & 機甲戰神

    #region 冒險家 - 海盜 - 重砲指揮官 (4件)
    public static EquipmentDetails GetCannonShooterWeapon(int Index)
    {
        //HandCannon 加農砲
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德加農砲
            case 1:
                ED.Name = "烏特卡勒德加農砲";
                ED.Level = 140;
                ED.Index = "1080506";
                ED.PAtk = 122;
                ED.Def = 140;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德加農砲

            #region 夫尼爾加農火砲
            case 2:
                ED.Name = "夫尼爾加農火砲";
                ED.Level = 150;
                ED.Index = "1081004";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 175;
                ED.Def = 121;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾加農火砲

            #region 航海師加農火砲
            case 3:
                ED.Name = "航海師加農火砲";
                ED.Level = 160;
                ED.Index = "1081507";
                ED.LUK = 60;
                ED.DEX = 60;
                ED.PAtk = 210;
                ED.Def = 160;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師加農火砲

            #region 神秘冥界幽靈加農砲
            case 4:
                ED.Name = "神秘冥界幽靈加農砲";
                ED.Level = 200;
                ED.Index = "1082007";
                ED.LUK = 100;
                ED.DEX = 100;
                ED.PAtk = 302;
                ED.Def = 200;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈加農砲

        }
        return ED;
    }
    #endregion 冒險家 - 海盜 - 重砲指揮官
    
    #region 皇家 - 米哈逸 (4件)
    public static EquipmentDetails GetMihileWeapon(int Index)
    {
        //單手劍
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德軍刀
            case 1:
                ED.Name = "烏特卡勒德軍刀";
                ED.Level = 140;
                ED.Index = "1080106";
                ED.PAtk = 118;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德軍刀

            #region 夫尼爾長青劍
            case 2:
                ED.Name = "夫尼爾長青劍";
                ED.Level = 150;
                ED.Index = "1080604";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 164;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾長青劍

            #region 航海師軍刀
            case 3:
                ED.Name = "航海師軍刀";
                ED.Level = 160;
                ED.Index = "1081107";
                ED.STR = 60;
                ED.DEX = 60;
                ED.PAtk = 197;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師軍刀

            #region 神秘冥界幽靈長劍
            case 4:
                ED.Name = "神秘冥界幽靈長劍";
                ED.Level = 200;
                ED.Index = "1081607";
                ED.STR = 100;
                ED.DEX = 100;
                ED.PAtk = 283;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈長劍

        }
        return ED;
    }
    #endregion 皇家 - 米哈逸
    
    #region 皇家 - 聖魂劍士 (9件 4+5)
    public static EquipmentDetails GetDawnWarriorWeapon(int Type, int Index)
    {
        //Type: 單手劍 雙手劍
        EquipmentDetails ED = new EquipmentDetails();
        switch (Type)
        {
            #region 單手劍
            case 1:
                switch (Index)
                {
                    #region 烏特卡勒德軍刀
                    case 1:
                        ED.Name = "烏特卡勒德軍刀";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 118;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德軍刀

                    #region 夫尼爾長青劍
                    case 2:
                        ED.Name = "夫尼爾長青劍";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 164;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾長青劍

                    #region 航海師軍刀
                    case 3:
                        ED.Name = "航海師軍刀";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 197;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師軍刀

                    #region 神秘冥界幽靈長劍
                    case 4:
                        ED.Name = "神秘冥界幽靈長劍";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 283;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 神秘冥界幽靈長劍

                }
                break;
            #endregion 單手劍

            #region 雙手劍
            case 2:
                //被詛咒的凱薩利恩 解放的凱薩利恩 rb頂武
                switch (Index)
                {
                    #region 烏特卡勒德雙手劍
                    case 1:
                        ED.Name = "烏特卡勒德雙手劍";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 122;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德雙手劍

                    #region 夫尼爾佩尼坦西亞重劍
                    case 2:
                        ED.Name = "夫尼爾佩尼坦西亞重劍";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 171;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾佩尼坦西亞重劍

                    #region 琉德的劍
                    case 3:
                        ED.Name = "琉德的劍";
                        ED.Level = 150;
                        ED.Index = "108";
                        ED.STR = 45;
                        ED.DEX = 35;
                        ED.PAtk = 165;
                        ED.BossDamage = 10;
                        ED.Ignore = 10;
                        ED.TotalScroll = 6;
                        ED.hasSet = false;
                        break;
                    #endregion 琉德的劍

                    #region 航海師重劍
                    case 4:
                        ED.Name = "航海師重劍";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 205;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師重劍

                    #region 神秘冥界幽靈雙手劍
                    case 5:
                        ED.Name = "神秘冥界幽靈雙手劍";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 295;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 神秘冥界幽靈雙手劍

                }
                break;
                #endregion 雙手劍

        }
        return ED;
    }
    #endregion 皇家 - 聖魂劍士
    
    #region 英雄團 - 狂狼勇士 (4件)
    public static EquipmentDetails GetAranWeapon(int Index)
    {
        //Polearm 矛
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德飛翔斧
            case 1:
                ED.Name = "烏特卡勒德飛翔斧";
                ED.Level = 140;
                ED.Index = "1080106";
                ED.PAtk = 122;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德飛翔斧

            #region 夫尼爾月之長矛
            case 2:
                ED.Name = "夫尼爾月之長矛";
                ED.Level = 150;
                ED.Index = "1080604";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 153;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾月之長矛

            #region 航海師戰戟
            case 3:
                ED.Name = "航海師戰戟";
                ED.Level = 160;
                ED.Index = "1081107";
                ED.STR = 60;
                ED.DEX = 60;
                ED.PAtk = 184;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師戰戟

            #region 神秘冥界幽靈之矛
            case 4:
                ED.Name = "神秘冥界幽靈之矛";
                ED.Level = 200;
                ED.Index = "1081607";
                ED.STR = 100;
                ED.DEX = 100;
                ED.PAtk = 264;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈之矛

        }
        return ED;
    }
    #endregion 英雄團 - 狂狼勇士
    
    #region 英雄團 - 夜光 (4件)
    public static EquipmentDetails GetLuminousWeapon(int Index)
    {
        //ShiningRod 閃亮克魯
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德閃耀之杖
            case 1:
                ED.Name = "烏特卡勒德閃耀之杖";
                ED.Level = 140;
                ED.Index = "1080206";
                ED.PAtk = 93;
                ED.MAtk = 153;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德閃耀之杖

            #region 夫尼爾魔法克魯
            case 2:
                ED.Name = "夫尼爾魔法克魯";
                ED.Level = 150;
                ED.Index = "1080704";
                ED.INT = 40;
                ED.LUK = 40;
                ED.PAtk = 119;
                ED.MAtk = 201;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾魔法克魯

            #region 航海師閃耀之杖
            case 3:
                ED.Name = "航海師閃耀之杖";
                ED.Level = 160;
                ED.Index = "1081207";
                ED.INT = 60;
                ED.LUK = 60;
                ED.PAtk = 143;
                ED.MAtk = 241;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師閃耀之杖

            #region 神秘冥界幽靈閃耀之杖
            case 4:
                ED.Name = "神秘冥界幽靈閃耀之杖";
                ED.Level = 200;
                ED.Index = "1081707";
                ED.INT = 100;
                ED.LUK = 100;
                ED.PAtk = 206;
                ED.MAtk = 347;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈閃耀之杖

        }
        return ED;
    }
    #endregion 英雄團 - 夜光
    
    #region 英雄團 - 精靈遊俠 (4件)
    public static EquipmentDetails GetMercedesWeapon(int Index)
    {
        //DualBowguns 雙弩槍
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德雙弩槍
            case 1:
                ED.Name = "烏特卡勒德雙弩槍";
                ED.Level = 140;
                ED.Index = "1080306";
                ED.PAtk = 115;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德雙弩槍

            #region 夫尼爾雙風之翼
            case 2:
                ED.Name = "夫尼爾雙風之翼";
                ED.Level = 150;
                ED.Index = "1080804";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 160;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾雙風之翼

            #region 航海師雙弩槍
            case 3:
                ED.Name = "航海師雙弩槍";
                ED.Level = 160;
                ED.Index = "1081307";
                ED.STR = 60;
                ED.DEX = 60;
                ED.PAtk = 192;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師雙弩槍

            #region 神秘冥界幽靈雙弩槍
            case 4:
                ED.Name = "神秘冥界幽靈雙弩槍";
                ED.Level = 200;
                ED.Index = "1081807";
                ED.STR = 100;
                ED.DEX = 100;
                ED.PAtk = 276;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈雙弩槍

        }
        return ED;
    }
    #endregion 英雄團 - 精靈遊俠
    
    #region 英雄團 - 幻影俠盜 (4件)
    public static EquipmentDetails GetPhantomWeapon(int Index)
    {
        //Cane 手杖
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德手杖
            case 1:
                ED.Name = "烏特卡勒德手杖";
                ED.Level = 140;
                ED.Index = "1080406";
                ED.PAtk = 118;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德手杖

            #region 夫尼爾清澈手杖
            case 2:
                ED.Name = "夫尼爾清澈手杖";
                ED.Level = 150;
                ED.Index = "1080904";
                ED.LUK = 40;
                ED.DEX = 40;
                ED.PAtk = 164;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾清澈手杖

            #region 航海師手杖
            case 3:
                ED.Name = "航海師手杖";
                ED.Level = 160;
                ED.Index = "1081407";
                ED.LUK = 60;
                ED.DEX = 60;
                ED.PAtk = 197;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師手杖

            #region 神秘冥界幽靈手杖
            case 4:
                ED.Name = "神秘冥界幽靈手杖";
                ED.Level = 200;
                ED.Index = "1081907";
                ED.LUK = 100;
                ED.DEX = 100;
                ED.PAtk = 283;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈手杖

        }
        return ED;
    }

    #endregion 英雄團 - 幻影俠盜
    
    #region 惡魔殺手 (8件 4+4)
    public static EquipmentDetails GetDemonSlayerWeapon(int Type, int Index)
    {
        //SingleBlunt  單手錘 / SingleAxe 單手斧
        EquipmentDetails ED = new EquipmentDetails();
        switch (Type)
        {
            #region 單手錘
            case 1:
                switch (Index)
                {
                    #region 烏特卡勒德之錘
                    case 1:
                        ED.Name = "烏特卡勒德之錘";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 118;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德之錘

                    #region 夫尼爾哥帝爾斯之錘
                    case 2:
                        ED.Name = "夫尼爾哥帝爾斯之錘";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 164;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾哥帝爾斯之錘

                    #region 航海師十字錘
                    case 3:
                        ED.Name = "航海師十字錘";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 197;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師十字錘

                    #region 神秘冥界幽靈之錘
                    case 4:
                        ED.Name = "神秘冥界幽靈之錘";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 283;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 神秘冥界幽靈之錘

                }
                break;
            #endregion 單手錘

            #region 單手斧
            case 2:
                switch (Index)
                {
                    #region 烏特卡勒德之斧
                    case 1:
                        ED.Name = "烏特卡勒德之斧";
                        ED.Level = 140;
                        ED.Index = "1080106";
                        ED.PAtk = 118;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 烏特卡勒德之斧

                    #region 夫尼爾雙刃斧
                    case 2:
                        ED.Name = "夫尼爾雙刃斧";
                        ED.Level = 150;
                        ED.Index = "1080604";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 164;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 夫尼爾雙刃斧

                    #region 航海師雙刃斧
                    case 3:
                        ED.Name = "航海師雙刃斧";
                        ED.Level = 160;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 197;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 航海師雙刃斧

                    #region 神秘冥界幽靈之斧
                    case 4:
                        ED.Name = "神秘冥界幽靈之錘";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 283;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 神秘冥界幽靈之斧

                }
                break;
                #endregion 單手斧

        }
        return ED;
    }
    #endregion 惡魔殺手
    
    #region 惡魔復仇者 (4件)
    public static EquipmentDetails GetDemonAvengerWeapon(int Index)
    {
        //Desperado 魔劍
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德魔劍
            case 1:
                ED.Name = "烏特卡勒德魔劍";
                ED.Level = 140;
                ED.Index = "1080106";
                ED.PAtk = 122;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德魔劍

            #region 夫尼爾死亡霸劍
            case 2:
                ED.Name = "夫尼爾死亡霸劍";
                ED.Level = 150;
                ED.Index = "1080604";
                ED.STR = 40;
                ED.MaxHP = 2000;
                ED.PAtk = 171;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾死亡霸劍

            #region 航海師死亡魔劍
            case 3:
                ED.Name = "航海師死亡魔劍";
                ED.Level = 160;
                ED.Index = "1081107";
                ED.STR = 60;
                ED.MaxHP = 2250;
                ED.PAtk = 205;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師死亡魔劍

            #region 神秘冥界幽靈魔劍
            case 4:
                ED.Name = "神秘冥界幽靈之錘";
                ED.Level = 200;
                ED.Index = "1081607";
                ED.STR = 100;
                ED.MaxHP = 2500;
                ED.PAtk = 295;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈魔劍

        }
        return ED;
    }
    #endregion 惡魔復仇者
    
    #region 爆拳槍神 (4件)
    public static EquipmentDetails GetBlasterWeapon(int Index)
    {
        //ArmCannon 重拳槍
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德重拳槍
            case 1:
                ED.Name = "烏特卡勒德重拳槍";
                ED.Level = 140;
                ED.Index = "1080106";
                ED.PAtk = 90;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德重拳槍

            #region 夫尼爾重拳槍
            case 2:
                ED.Name = "夫尼爾重拳槍";
                ED.Level = 150;
                ED.Index = "1080604";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 128;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾重拳槍

            #region 航海師重拳槍
            case 3:
                ED.Name = "航海師重拳槍";
                ED.Level = 160;
                ED.Index = "1081107";
                ED.STR = 60;
                ED.DEX = 60;
                ED.PAtk = 154;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師重拳槍

            #region 神秘冥界幽靈重拳槍
            case 4:
                ED.Name = "神秘冥界幽靈之錘";
                ED.Level = 200;
                ED.Index = "1081607";
                ED.STR = 100;
                ED.DEX = 100;
                ED.PAtk = 221;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈重拳槍

        }
        return ED;
    }
    #endregion 爆拳槍神
   
    #region 煉獄巫師 (4件)
    public static EquipmentDetails GetBattleMageWeapon(int Index)
    {
        //Staff 長杖
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德長杖
            case 1:
                ED.Name = "烏特卡勒德長杖";
                ED.Level = 140;
                ED.Index = "1080206";
                ED.PAtk = 98;
                ED.MAtk = 155;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德長杖

            #region 夫尼爾魔法長杖
            case 2:
                ED.Name = "夫尼爾魔法長杖";
                ED.Level = 150;
                ED.Index = "1080704";
                ED.INT = 40;
                ED.LUK = 40;
                ED.PAtk = 126;
                ED.MAtk = 204;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾魔法長杖

            #region 航海師文字長杖
            case 3:
                ED.Name = "航海師文字長杖";
                ED.Level = 160;
                ED.Index = "1081207";
                ED.INT = 60;
                ED.LUK = 60;
                ED.PAtk = 151;
                ED.MAtk = 245;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師文字長杖

            #region 神秘冥界幽靈長杖
            case 4:
                ED.Name = "神秘冥界幽靈長杖";
                ED.Level = 200;
                ED.Index = "1081707";
                ED.INT = 100;
                ED.LUK = 100;
                ED.PAtk = 218;
                ED.MAtk = 353;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈長杖

        }
        return ED;
    }

    #endregion 煉獄巫師
    //設定為盜賊
    #region 傑諾 (4件)
    public static EquipmentDetails GetXenonWeapon(int Index)
    {
        //WhipBlade 能量劍
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德能量劍
            case 1:
                ED.Name = "烏特卡勒德能量劍";
                ED.Level = 140;
                ED.Index = "1080406";
                ED.PAtk = 90;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德能量劍

            #region 夫尼爾光能量劍
            case 2:
                ED.Name = "夫尼爾光能量劍";
                ED.Level = 150;
                ED.Index = "1080904";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 128;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾光能量劍

            #region 航海師能量劍
            case 3:
                ED.Name = "航海師能量劍";
                ED.Level = 160;
                ED.Index = "1081407";
                ED.STR = 60;
                ED.DEX = 60;
                ED.PAtk = 154;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師能量劍

            #region 神秘冥界幽靈能量劍
            case 4:
                ED.Name = "神秘冥界幽靈能量劍";
                ED.Level = 200;
                ED.Index = "1081907";
                ED.STR = 100;
                ED.DEX = 100;
                ED.PAtk = 221;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈能量劍

        }
        return ED;
    }
    #endregion 傑諾
    
    #region 凱薩 (5件)
    public static EquipmentDetails GetKaiserWeapon(int Index)
    {
        //DoubleSword 雙手劍
        EquipmentDetails ED = new EquipmentDetails();    
        switch (Index)
        {
            #region 烏特卡勒德雙手劍
            case 1:
                ED.Name = "烏特卡勒德雙手劍";
                ED.Level = 140;
                ED.Index = "1080106";
                ED.PAtk = 122;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德雙手劍

            #region 夫尼爾佩尼坦西亞重劍
            case 2:
                ED.Name = "夫尼爾佩尼坦西亞重劍";
                ED.Level = 150;
                ED.Index = "1080604";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 171;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾佩尼坦西亞重劍

            #region 琉德的劍
            case 3:
                ED.Name = "琉德的劍";
                ED.Level = 150;
                ED.Index = "108";
                ED.STR = 45;
                ED.DEX = 35;
                ED.PAtk = 165;
                ED.BossDamage = 10;
                ED.Ignore = 10;
                ED.TotalScroll = 6;
                ED.hasSet = false;
                break;
            #endregion 琉德的劍

            #region 航海師重劍
            case 4:
                ED.Name = "航海師重劍";
                ED.Level = 160;
                ED.Index = "1081107";
                ED.STR = 60;
                ED.DEX = 60;
                ED.PAtk = 205;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師重劍

            #region 神秘冥界幽靈雙手劍
            case 5:
                ED.Name = "神秘冥界幽靈雙手劍";
                ED.Level = 200;
                ED.Index = "1081607";
                ED.STR = 100;
                ED.DEX = 100;
                ED.PAtk = 295;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈雙手劍

        }
        return ED;
    }
    #endregion 凱薩

    #region 天使破壞者 (4件)
    public static EquipmentDetails GetAngelicBusterWeapon(int Index)
    {
        //SoulShooter 靈魂射手
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德龍魂
            case 1:
                ED.Name = "烏特卡勒德龍魂";
                ED.Level = 140;
                ED.Index = "1080506";
                ED.PAtk = 92;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德龍魂

            #region 夫尼爾天使射手
            case 2:
                ED.Name = "夫尼爾天使射手";
                ED.Level = 150;
                ED.Index = "1081004";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 128;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾天使射手

            #region 航海師靈魂射手
            case 3:
                ED.Name = "航海師靈魂射手";
                ED.Level = 160;
                ED.Index = "1081507";
                ED.STR = 60;
                ED.DEX = 60;
                ED.PAtk = 154;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師靈魂射手

            #region 神秘冥界幽靈靈魂射手
            case 4:
                ED.Name = "神秘冥界幽靈靈魂射手";
                ED.Level = 200;
                ED.Index = "1082007";
                ED.STR = 100;
                ED.DEX = 100;
                ED.PAtk = 221;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈靈魂射手

        }
        return ED;
    }
    #endregion 天使破壞者
    
    #region 卡蒂娜 (4件)
    public static EquipmentDetails GetCadenaWeapon(int Index)
    {
        //Chain 鎖鏈
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德鎖鏈
            case 1:
                ED.Name = "烏特卡勒德鎖鏈";
                ED.Level = 140;
                ED.Index = "1080406";
                ED.PAtk = 115;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德鎖鏈

            #region 夫尼爾鎖鏈
            case 2:
                ED.Name = "夫尼爾鎖鏈";
                ED.Level = 150;
                ED.Index = "1080904";
                ED.LUK = 40;
                ED.INT = 40;
                ED.PAtk = 160;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾鎖鏈

            #region 航海師鎖鏈
            case 3:
                ED.Name = "航海師鎖鏈";
                ED.Level = 160;
                ED.Index = "1081407";
                ED.LUK = 60;
                ED.INT = 60;
                ED.PAtk = 192;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師鎖鏈

            #region 神秘冥界幽靈鎖鏈
            case 4:
                ED.Name = "神秘冥界幽靈鎖鏈";
                ED.Level = 200;
                ED.Index = "1081907";
                ED.LUK = 100;
                ED.INT = 100;
                ED.PAtk = 276;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈鎖鏈

        }
        return ED;
    }
    #endregion 卡蒂娜
    
    #region 阿戴爾 (4件)
    public static EquipmentDetails GetAdeleWeapon(int Index)
    {
        //Bladecaster 調節器
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德調節器
            case 1:
                ED.Name = "烏特卡勒德調節器";
                ED.Level = 140;
                ED.Index = "1080106";
                ED.PAtk = 122;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德調節器

            #region 夫尼爾調節器
            case 2:
                ED.Name = "夫尼爾調節器";
                ED.Level = 150;
                ED.Index = "1080604";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 171;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾調節器

            #region 航海師調節器
            case 3:
                ED.Name = "航海師調節器";
                ED.Level = 160;
                ED.Index = "1081107";
                ED.STR = 60;
                ED.DEX = 60;
                ED.PAtk = 205;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師調節器

            #region 神秘冥界幽靈調節器
            case 4:
                ED.Name = "神秘冥界幽靈調節器";
                ED.Level = 200;
                ED.Index = "1081607";
                ED.STR = 100;
                ED.DEX = 100;
                ED.PAtk = 295;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈調節器

        }
        return ED;
    }
    #endregion 阿戴爾
    
    #region 伊利恩 (4件)
    public static EquipmentDetails GetIlliumWeapon(int Index)
    {
        //LucentGauntlet 魔法護腕
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德魔法護腕
            case 1:
                ED.Name = "烏特卡勒德魔法護腕";
                ED.Level = 140;
                ED.Index = "1080206";
                ED.PAtk = 93;
                ED.MAtk = 153;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德魔法護腕

            #region 夫尼爾魔法護腕
            case 2:
                ED.Name = "夫尼爾魔法護腕";
                ED.Level = 150;
                ED.Index = "1080704";
                ED.INT = 40;
                ED.LUK = 40;
                ED.PAtk = 119;
                ED.MAtk = 201;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾魔法護腕

            #region 航海師魔法護腕
            case 3:
                ED.Name = "航海師魔法護腕";
                ED.Level = 160;
                ED.Index = "1081207";
                ED.INT = 60;
                ED.LUK = 60;
                ED.PAtk = 143;
                ED.MAtk = 241;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師魔法護腕

            #region 神秘冥界幽靈魔法護腕
            case 4:
                ED.Name = "神秘冥界幽靈魔法護腕";
                ED.Level = 200;
                ED.Index = "1081707";
                ED.INT = 100;
                ED.LUK = 100;
                ED.PAtk = 206;
                ED.MAtk = 347;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈魔法護腕

        }
        return ED;
    }
    #endregion 伊利恩
    
    #region 劍豪 (4件)
    public static EquipmentDetails GetHayatoWeapon(int Index)
    {
        //Katana 太刀
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德太刀
            case 1:
                ED.Name = "烏特卡勒德太刀";
                ED.Level = 140;
                ED.Index = "1080106";
                ED.PAtk = 118;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德太刀

            #region 夫尼爾太刀
            case 2:
                ED.Name = "夫尼爾太刀";
                ED.Level = 150;
                ED.Index = "1080604";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 164;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾太刀

            #region 航海師太刀
            case 3:
                ED.Name = "航海師太刀";
                ED.Level = 160;
                ED.Index = "1081107";
                ED.STR = 60;
                ED.DEX = 60;
                ED.PAtk = 197;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師太刀

            #region 神秘冥界幽靈刀
            case 4:
                ED.Name = "神秘冥界幽靈刀";
                ED.Level = 200;
                ED.Index = "1081607";
                ED.STR = 100;
                ED.DEX = 100;
                ED.PAtk = 283;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈刀

        }
        return ED;
    }
    #endregion 劍豪
    
    #region 陰陽師 (4件)
    public static EquipmentDetails GetKannaWeapon(int Index)
    {
        //Fan 扇子
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德扇子
            case 1:
                ED.Name = "烏特卡勒德扇子";
                ED.Level = 140;
                ED.Index = "1080206";
                ED.PAtk = 93;
                ED.MAtk = 115;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德扇子

            #region 夫尼爾扇子
            case 2:
                ED.Name = "夫尼爾扇子";
                ED.Level = 150;
                ED.Index = "1080704";
                ED.INT = 40;
                ED.LUK = 40;
                ED.PAtk = 126;
                ED.MAtk = 204;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾扇子       

            #region 航海師扇子
            case 3:
                ED.Name = "航海師扇子";
                ED.Level = 160;
                ED.Index = "1081207";
                ED.INT = 60;
                ED.LUK = 60;
                ED.PAtk = 143;
                ED.MAtk = 241;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師扇子

            #region 神秘冥界幽靈扇子
            case 4:
                ED.Name = "神秘冥界幽靈扇子";
                ED.Level = 200;
                ED.Index = "1081707";
                ED.INT = 100;
                ED.LUK = 100;
                ED.PAtk = 206;
                ED.MAtk = 347;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈扇子

        }
        return ED;
    }
    #endregion 陰陽師
    
    #region 神之子 (6件 3x2)
    public static EquipmentDetails GetZeroWeapon(int Type, int Index)
    {
        //Type One Only: 琉/璃
        EquipmentDetails ED = new EquipmentDetails();
        switch (Type)
        {
            #region 琉 女 
            case 1:
                switch (Index)
                {
                    #region 琉-7型
                    case 1:
                        ED.Name = "琉-7型";
                        ED.Level = 170;
                        ED.Index = "108";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 169;
                        ED.BossDamage = 30;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 琉-7型

                    #region 琉-8型
                    case 2:
                        ED.Name = "琉-8型";
                        ED.Level = 180;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 203;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 琉-8型

                    #region 琉-9型
                    case 3:
                        ED.Name = "琉-9型";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 293;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 琉-9型

                }
                break;
            #endregion 琉 女 

            #region 璃 男 
            case 2:
                switch (Index)
                {
                    #region 璃-7型
                    case 1:
                        ED.Name = "璃-7型";
                        ED.Level = 170;
                        ED.Index = "108";
                        ED.STR = 40;
                        ED.DEX = 40;
                        ED.PAtk = 173;
                        ED.Def = 150;
                        ED.BossDamage = 30;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 璃-7型

                    #region 璃-8型
                    case 2:
                        ED.Name = "璃-8型";
                        ED.Level = 180;
                        ED.Index = "1081107";
                        ED.STR = 60;
                        ED.DEX = 60;
                        ED.PAtk = 207;
                        ED.Def = 160;
                        ED.BossDamage = 30;
                        ED.Ignore = 10;
                        ED.TotalScroll = 8;
                        break;
                    #endregion 璃-8型

                    #region 璃-9型
                    case 3:
                        ED.Name = "璃-9型";
                        ED.Level = 200;
                        ED.Index = "1081607";
                        ED.STR = 100;
                        ED.DEX = 100;
                        ED.PAtk = 297;
                        ED.Def = 200;
                        ED.BossDamage = 30;
                        ED.Ignore = 20;
                        ED.TotalScroll = 8;
                        break;
                        #endregion 璃-9型

                }
                break;
                #endregion 璃 男 

        }
        return ED;
    }
    #endregion 神之子
    
    #region 幻獸師 (4件)
    public static EquipmentDetails GetBeastTamerWeapon(int Index)
    {
        //Scepter 幻獸棒
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德幻獸棒
            case 1:
                ED.Name = "烏特卡勒德幻獸棒";
                ED.Level = 140;
                ED.Index = "1080206";
                ED.PAtk = 93;
                ED.MAtk = 153;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德幻獸棒

            #region 夫尼爾北極星幻獸棒
            case 2:
                ED.Name = "夫尼爾北極星幻獸棒";
                ED.Level = 150;
                ED.Index = "1080704";
                ED.INT = 40;
                ED.LUK = 40;
                ED.PAtk = 119;
                ED.MAtk = 201;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾北極星幻獸棒

            #region 航海師幻獸棒
            case 3:
                ED.Name = "航海師幻獸棒";
                ED.Level = 160;
                ED.Index = "1081207";
                ED.INT = 60;
                ED.LUK = 60;
                ED.PAtk = 143;
                ED.MAtk = 241;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師幻獸棒

            #region 神秘冥界幽靈幻獸棒
            case 4:
                ED.Name = "神秘冥界幽靈幻獸棒";
                ED.Level = 200;
                ED.Index = "1081707";
                ED.INT = 100;
                ED.LUK = 100;
                ED.PAtk = 206;
                ED.MAtk = 347;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈幻獸棒

        }
        return ED;
    }
    #endregion 幻獸師
   
    #region 凱內西斯 (4件)
    public static EquipmentDetails GetKinesisWeapon(int Index)
    {
        //PsyLimiter 限制器
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德ESP限制器
            case 1:
                ED.Name = "烏特卡勒德ESP限制器";
                ED.Level = 140;
                ED.Index = "1080206";
                ED.PAtk = 93;
                ED.MAtk = 153;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德ESP限制器

            #region 夫尼爾ESP限制器
            case 2:
                ED.Name = "夫尼爾ESP限制器";
                ED.Level = 150;
                ED.Index = "1080704";
                ED.INT = 40;
                ED.LUK = 40;
                ED.PAtk = 119;
                ED.MAtk = 201;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾ESP限制器

            #region 航海師ESP限制器
            case 3:
                ED.Name = "航海師ESP限制器";
                ED.Level = 160;
                ED.Index = "1081207";
                ED.INT = 60;
                ED.LUK = 60;
                ED.PAtk = 143;
                ED.MAtk = 241;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師ESP限制器

            #region 神秘冥界幽靈ESP限制者
            case 4:
                ED.Name = "神秘冥界幽靈ESP限制者";
                ED.Level = 200;
                ED.Index = "1081707";
                ED.INT = 100;
                ED.LUK = 100;
                ED.PAtk = 206;
                ED.MAtk = 347;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈ESP限制者

        }
        return ED;
    }
    #endregion 凱內西斯

    #region 虎影 (4件)
    public static EquipmentDetails GetHoyoungWeapon(int Index)
    {
        //Type One Only: RitualFan 仙扇
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德仙扇
            case 1:
                ED.Name = "烏特卡勒德仙扇";
                ED.Level = 140;
                ED.Index = "1080406";
                ED.PAtk = 115;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德仙扇

            #region 夫尼爾仙扇
            case 2:
                ED.Name = "夫尼爾仙扇";
                ED.Level = 150;
                ED.Index = "1080904";
                ED.INT = 40;
                ED.LUK = 40;
                ED.PAtk = 160;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾仙扇

            #region 航海師仙扇
            case 3:
                ED.Name = "航海師仙扇";
                ED.Level = 160;
                ED.Index = "1081407";
                ED.INT = 60;
                ED.LUK = 60;
                ED.PAtk = 192;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師仙扇

            #region 神秘冥界幽靈仙扇
            case 4:
                ED.Name = "神秘冥界幽靈仙扇";
                ED.Level = 200;
                ED.Index = "1081907";
                ED.INT = 100;
                ED.LUK = 100;
                ED.PAtk = 276;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈仙扇

        }
        return ED;
    }
    #endregion 虎影

    #region 墨玄 (4件)
    public static EquipmentDetails GetMoXuanWeapon(int Index)
    {
        //Type One Only: WushuFist 武拳 (雙手武器)
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德武拳
            case 1:
                ED.Name = "烏特卡勒德武拳";
                ED.Level = 140;
                ED.Index = "1080506";
                ED.PAtk = 90;
                ED.TotalScroll = 8;
                break;
            #endregion 烏特卡勒德武拳

            #region 夫尼爾武拳
            case 2:
                ED.Name = "夫尼爾武拳";
                ED.Level = 150;
                ED.Index = "1081004";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 128;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 夫尼爾武拳

            #region 航海師武拳
            case 3:
                ED.Name = "航海師武拳";
                ED.Level = 160;
                ED.Index = "1081507";
                ED.STR = 60;
                ED.DEX = 60;
                ED.PAtk = 154;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 8;
                break;
            #endregion 航海師武拳

            #region 神秘冥界幽靈武拳
            case 4:
                ED.Name = "神秘冥界幽靈武拳";
                ED.Level = 200;
                ED.Index = "1082007";
                ED.STR = 100;
                ED.DEX = 100;
                ED.PAtk = 221;
                ED.BossDamage = 30;
                ED.Ignore = 20;
                ED.TotalScroll = 8;
                break;
                #endregion 神秘冥界幽靈武拳

        }
        return ED;
    }
    #endregion 墨玄

    #endregion 武器類

    //腰帶 Belt ID:109 7件 完成新規範&資料驗證 2021.4.4  
    #region 腰帶

    public static EquipmentDetails GetBelt(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 初級培羅德烙印腰帶
            case 1:
                ED.Name = "初級培羅德烙印腰帶";
                ED.Level = 120;
                ED.Index = "1092203";
                ED.STR = 8;
                ED.DEX = 8;
                ED.INT = 8;
                ED.LUK = 8;
                ED.MaxHP = 200;
                ED.MaxMP = 200;
                ED.Def = 100;
                ED.TotalScroll = 3;
                break;
            #endregion 初級培羅德烙印腰帶

            #region 中級培羅德烙印腰帶
            case 2:
                ED.Name = "中級培羅德烙印腰帶";
                ED.Level = 130;
                ED.Index = "1092303";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.MaxHP = 200;
                ED.MaxMP = 200;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 100;
                ED.TotalScroll = 3;
                break;
            #endregion 中級培羅德烙印腰帶

            #region 高級培羅德烙印腰帶
            case 3:
                ED.Name = "高級培羅德烙印腰帶";
                ED.Level = 140;
                ED.Index = "1092403";
                ED.STR = 30;
                ED.DEX = 30;
                ED.INT = 30;
                ED.LUK = 30;
                ED.MaxHP = 200;
                ED.MaxMP = 200;
                ED.PAtk = 20;
                ED.MAtk = 20;
                ED.Def = 100;
                ED.TotalScroll = 3;
                break;
            #endregion 高級培羅德烙印腰帶

            #region 金草花腰帶
            case 4:
                ED.Name = "金草花腰帶";
                ED.Level = 140;
                ED.Index = "1092114";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.PAtk = 1;
                ED.MAtk = 1;
                ED.Def = 150;
                ED.TotalScroll = 3;
                break;
            #endregion 金草花腰帶

            #region 頂級培羅德烙印腰帶
            case 6:
                ED.Name = "頂級培羅德烙印腰帶";
                ED.Level = 150;
                ED.Index = "1092503";
                ED.STR = 60;
                ED.DEX = 60;
                ED.INT = 60;
                ED.LUK = 60;
                ED.MaxHP = 200;
                ED.MaxMP = 200;
                ED.PAtk = 35;
                ED.MAtk = 35;
                ED.Def = 100;
                ED.TotalScroll = 3;
                break;
            #endregion 頂級培羅德烙印腰帶

            #region 神秘腰帶
            case 7:
                ED.Name = "神秘腰帶";
                ED.Level = 150;
                ED.Index = "1092701";
                ED.STR = 50;
                ED.DEX = 50;
                ED.INT = 50;
                ED.LUK = 50;
                ED.MaxHP = 250;
                ED.MaxMP = 250;
                ED.PAtk = 30;
                ED.MAtk = 30;
                ED.Def = 50;
                ED.TotalScroll = 3;
                break;
            #endregion 神秘腰帶

            #region 夢幻的腰帶
            case 8:
                ED.Name = "夢幻的腰帶";
                ED.Level = 200;
                ED.Index = "1092604";
                ED.STR = 50;
                ED.DEX = 50;
                ED.INT = 50;
                ED.LUK = 50;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.PAtk = 6;
                ED.MAtk = 6;
                ED.Def = 150;
                ED.TotalScroll = 3;
                break;
           #endregion 夢幻的腰帶

        }
        return ED;
    }

    #endregion 腰帶

    //帽子 Hat ID:110 21件(1+20 原25件重複4件) 完成新規範&資料驗證 2021.4.4  
    #region 帽子

    #region 劍士帽子
    public static EquipmentDetails GetWarriorHat(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛戰鬥頭盔
            case 1:
                ED.Name = "佩沙里洛戰鬥頭盔";
                ED.Level = 140;
                ED.Index = "1100101";
                ED.STR = 16;
                ED.DEX = 10;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.Def = 225;
                ED.TotalScroll = 9;
                break;
            #endregion 佩沙里洛戰鬥頭盔

            #region 高貴的戰士頭盔
            case 2:
                ED.Name = "高貴的戰士頭盔";
                ED.Level = 150;
                ED.Index = "1100601";
                ED.STR = 40;
                ED.DEX = 40;
                ED.MaxHP = 360;
                ED.MaxMP = 360;
                ED.PAtk = 2;
                ED.Def = 390;
                ED.Ignore = 10;
                ED.TotalScroll = 11;
                break;
            #endregion 高貴的戰士頭盔

            #region 航海師劍士頭盔
            case 3:
                ED.Name = "航海師劍士頭盔";
                ED.Level = 160;
                ED.Index = "1101101";
                ED.STR = 45;
                ED.DEX = 45;
                ED.PAtk = 3;
                ED.Def = 400;
                ED.Ignore = 10;
                ED.TotalScroll = 11;
                break;
            #endregion 航海師劍士頭盔

            #region 神秘冥界幽靈騎士帽
            case 4:
                ED.Name = "神秘冥界幽靈騎士帽";
                ED.Level = 200;
                ED.Index = "1101601";
                ED.STR = 65;
                ED.DEX = 65;
                ED.PAtk = 7;
                ED.Def = 600;
                ED.Ignore = 15;
                ED.TotalScroll = 11;
                break;
            #endregion 神秘冥界幽靈騎士帽

            #region 水瓶座冠
            case 5:
                ED.Name = "水瓶座冠";
                ED.Level = 150;
                ED.Index = "110";
                ED.STR = 1;
                ED.DEX = 1;
                ED.INT = 1;
                ED.LUK = 1;
                ED.PAtk = 1;
                ED.MAtk = 1;
                ED.TotalScroll = 22;
                ED.Universal = true;
                ED.hasSet = false;
                break;
            #endregion 水瓶座冠

        }
        return ED;
    }
    #endregion 劍士帽子

    #region 法師帽子
    public static EquipmentDetails GetMagicianHat(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛魔導士頭盔
            case 1:
                ED.Name = "佩沙里洛魔導士頭盔";
                ED.Level = 140;
                ED.Index = "1100201";
                ED.INT = 16;
                ED.LUK = 15;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.Def = 110;
                ED.TotalScroll = 9;
                break;
            #endregion 佩沙里洛魔導士頭盔

            #region 高貴的敦威治帽
            case 2:
                ED.Name = "高貴的敦威治帽";
                ED.Level = 150;
                ED.Index = "1100701";
                ED.INT = 40;
                ED.LUK = 40;
                ED.MaxHP = 360;
                ED.MaxMP = 360;
                ED.MAtk = 2;
                ED.Def = 180;
                ED.Ignore = 10;
                ED.TotalScroll = 11;
                break;
            #endregion 高貴的敦威治帽

            #region 航海師法師帽
            case 3:
                ED.Name = "航海師法師帽";
                ED.Level = 160;
                ED.Index = "1101201";
                ED.INT = 45;
                ED.LUK = 45;
                ED.MAtk = 3;
                ED.Def = 400;
                ED.Ignore = 10;
                ED.TotalScroll = 11;
                break;
            #endregion 航海師法師帽

            #region 神秘冥界幽靈魔法帽
            case 4:
                ED.Name = "神秘冥界幽靈魔法帽";
                ED.Level = 200;
                ED.Index = "1101701";
                ED.INT = 65;
                ED.LUK = 65;
                ED.MAtk = 7;
                ED.Def = 600;
                ED.Ignore = 15;
                ED.TotalScroll = 11;
                break;
            #endregion 神秘冥界幽靈魔法帽

            #region 水瓶座冠
            case 5:
                ED.Name = "水瓶座冠";
                ED.Level = 150;
                ED.Index = "110";
                ED.STR = 1;
                ED.DEX = 1;
                ED.INT = 1;
                ED.LUK = 1;
                ED.PAtk = 1;
                ED.MAtk = 1;
                ED.TotalScroll = 22;
                ED.Universal = true;
                ED.hasSet = false;
                break;
            #endregion 水瓶座冠

        }
        return ED;
    }
    #endregion 法師帽子

    #region 弓箭手帽子
    public static EquipmentDetails GetBowManHat(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛監視兵帽
            case 1:
                ED.Name = "佩沙里洛監視兵帽";
                ED.Level = 140;
                ED.Index = "1100301";
                ED.STR = 15;
                ED.DEX = 16;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.Def = 165;
                ED.TotalScroll = 9;
                break;
            #endregion 佩沙里洛監視兵頭帽

            #region 高貴的守護者貝雷帽
            case 2:
                ED.Name = "高貴的守護者貝雷帽";
                ED.Level = 150;
                ED.Index = "1100801";
                ED.STR = 40;
                ED.DEX = 40;
                ED.MaxHP = 360;
                ED.MaxMP = 360;
                ED.PAtk = 2;
                ED.Def = 300;
                ED.Ignore = 10;
                ED.TotalScroll = 11;
                break;
            #endregion 高貴的守護者貝雷帽

            #region 航海師弓箭手帽
            case 3:
                ED.Name = "航海師弓箭手帽";
                ED.Level = 160;
                ED.Index = "1101301";
                ED.STR = 45;
                ED.DEX = 45;
                ED.PAtk = 3;
                ED.Def = 400;
                ED.Ignore = 10;
                ED.TotalScroll = 11;
                break;
            #endregion 航海師弓箭手帽

            #region 神秘冥界幽靈弓手帽
            case 4:
                ED.Name = "神秘冥界幽靈弓手帽";
                ED.Level = 200;
                ED.Index = "1101801";
                ED.STR = 65;
                ED.DEX = 65;
                ED.PAtk = 7;
                ED.Def = 600;
                ED.Ignore = 15;
                ED.TotalScroll = 11;
                break;
            #endregion 神秘冥界幽靈弓手帽

            #region 水瓶座冠
            case 5:
                ED.Name = "水瓶座冠";
                ED.Level = 150;
                ED.Index = "110";
                ED.STR = 1;
                ED.DEX = 1;
                ED.INT = 1;
                ED.LUK = 1;
                ED.PAtk = 1;
                ED.MAtk = 1;
                ED.TotalScroll = 22;
                ED.Universal = true;
                ED.hasSet = false;
                break;
                #endregion 水瓶座冠

        }
        return ED;
    }
    #endregion 弓箭手帽子

    #region 盜賊帽子
    public static EquipmentDetails GetThiefHat(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛獵人帽
            case 1:
                ED.Name = "佩沙里洛獵人帽";
                ED.Level = 140;
                ED.Index = "1100401";
                ED.DEX = 15;
                ED.LUK = 15;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.Def = 165;
                ED.TotalScroll = 9;
                break;
            #endregion 佩沙里洛獵人帽

            #region 高貴的暗殺者頭套帽
            case 2:
                ED.Name = "高貴的暗殺者頭套帽";
                ED.Level = 150;
                ED.Index = "1100901";
                ED.DEX = 40;
                ED.LUK = 40;
                ED.MaxHP = 360;
                ED.MaxMP = 360;
                ED.PAtk = 2;
                ED.Def = 300;
                ED.Ignore = 10;
                ED.TotalScroll = 11;
                break;
            #endregion 高貴的暗殺者頭套帽

            #region 航海師盜賊帽
            case 3:
                ED.Name = "航海師盜賊帽";
                ED.Level = 160;
                ED.Index = "1101401";
                ED.DEX = 45;
                ED.LUK = 45;
                ED.PAtk = 3;
                ED.Def = 400;
                ED.Ignore = 10;
                ED.TotalScroll = 11;
                break;
            #endregion 航海師盜賊帽

            #region 神秘冥界幽靈小偷帽
            case 4:
                ED.Name = "神秘冥界幽靈小偷帽";
                ED.Level = 200;
                ED.Index = "1101901";
                ED.DEX = 65;
                ED.LUK = 65;
                ED.PAtk = 7;
                ED.Def = 600;
                ED.Ignore = 15;
                ED.TotalScroll = 11;
                break;
            #endregion 神秘冥界幽靈小偷帽

            #region 水瓶座冠
            case 5:
                ED.Name = "水瓶座冠";
                ED.Level = 150;
                ED.Index = "110";
                ED.STR = 1;
                ED.DEX = 1;
                ED.INT = 1;
                ED.LUK = 1;
                ED.PAtk = 1;
                ED.MAtk = 1;
                ED.TotalScroll = 22;
                ED.Universal = true;
                ED.hasSet = false;
                break;
            #endregion 水瓶座冠

        }
        return ED;
    }
    #endregion 盜賊帽子

    #region 海盜帽子
    public static EquipmentDetails GetPirateHat(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛船長帽
            case 1:
                ED.Name = "佩沙里洛船長帽";
                ED.Level = 140;
                ED.Index = "1100501";
                ED.STR = 15;
                ED.DEX = 15;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.Def = 165;
                ED.TotalScroll = 9;
                break;
            #endregion 佩沙里洛船長帽

            #region 高貴的漫遊者帽
            case 2:
                ED.Name = "高貴的漫遊者帽";
                ED.Level = 150;
                ED.Index = "1101001";
                ED.STR = 40;
                ED.DEX = 40;
                ED.MaxHP = 360;
                ED.MaxMP = 360;
                ED.PAtk = 2;
                ED.Def = 300;
                ED.Ignore = 10;
                ED.TotalScroll = 11;
                break;
            #endregion 高貴的漫遊者帽

            #region 航海師海盜帽
            case 3:
                ED.Name = "航海師海盜帽";
                ED.Level = 160;
                ED.Index = "1101501";
                ED.STR = 45;
                ED.DEX = 45;
                ED.PAtk = 3;
                ED.Def = 400;
                ED.Ignore = 10;
                ED.TotalScroll = 11;
                break;
            #endregion 航海師海盜帽

            #region 神秘冥界幽靈海盜帽
            case 4:
                ED.Name = "神秘冥界幽靈海盜帽";
                ED.Level = 200;
                ED.Index = "1102001";
                ED.STR = 65;
                ED.DEX = 65;
                ED.PAtk = 7;
                ED.Def = 600;
                ED.Ignore = 15;
                ED.TotalScroll = 11;
                break;
            #endregion 神秘冥界幽靈海盜帽

            #region 水瓶座冠
            case 5:
                ED.Name = "水瓶座冠";
                ED.Level = 150;
                ED.Index = "110";
                ED.STR = 1;
                ED.DEX = 1;
                ED.INT = 1;
                ED.LUK = 1;
                ED.PAtk = 1;
                ED.MAtk = 1;
                ED.TotalScroll = 22;
                ED.Universal = true;
                ED.hasSet = false;
                break;
                #endregion 水瓶座冠

        }
        return ED;
    }
    #endregion 海盜帽子

    #endregion 帽子

    //臉飾 Face ID:111 4件 完成新規範&資料驗證 2021.4.4  
    #region 臉飾
    public static EquipmentDetails GetFace(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 凝聚力量的結晶石
            case 1:
                ED.Name = "凝聚力量的結晶石";
                ED.Level = 110;
                ED.Index = "1112101";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.Def = 100;
                ED.TotalScroll = 5;
                break;
            #endregion 凝聚力量的結晶石

            #region 神秘紋身
            case 2:
                ED.Name = "神秘紋身";
                ED.Level = 150;
                ED.Index = "1112704";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.MaxHP = 200;
                ED.MaxMP = 200;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.Def = 120;
                ED.TotalScroll = 5;
                break;
            #endregion 神秘紋身

            #region 波賽頓紋身
            case 3:
                ED.Name = "波賽頓紋身";
                ED.Level = 160;
                ED.Index = "111";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.MaxHP = 120;
                ED.MaxMP = 120;
                ED.Def = 38;
                ED.TotalScroll = 5;
                ED.hasSet = false;
                break;
            #endregion 波賽頓紋身

            #region 口紅控制器標誌
            case 4:
                ED.Name = "口紅控制器標誌";
                ED.Level = 160;
                ED.Index = "1112601";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 200;
                ED.TotalScroll = 5;
                break;
                #endregion 口紅控制器標誌

        }
        return ED;
    }
    #endregion 臉飾

    //眼飾 Eyes ID:112 4件 完成新規範&資料驗證 2021.4.4  
    #region 眼飾
    public static EquipmentDetails GetEye(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 水中信紙眼飾
            case 1:
                ED.Name = "水中信紙眼飾";
                ED.Level = 100;
                ED.Index = "1122102";
                ED.STR = 6;
                ED.DEX = 6;
                ED.INT = 6;
                ED.LUK = 6;
                ED.PAtk = 1;
                ED.MAtk = 1;
                ED.Def = 100;
                ED.TotalScroll = 3;
                break;
            #endregion 水中信紙眼飾

            #region 神秘面具
            case 2:
                ED.Name = "神秘面具";
                ED.Level = 150;
                ED.Index = "1122705";
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.Def = 120;
                ED.TotalScroll = 3;
                break;
            #endregion 神秘面具

            #region 波賽頓眼鏡
            case 3:
                ED.Name = "波賽頓眼鏡";
                ED.Level = 160;
                ED.Index = "112";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.MaxHP = 240;
                ED.MaxMP = 240;
                ED.Def = 120;
                ED.TotalScroll = 5;
                ED.hasSet = false;
                break;
            #endregion 波賽頓眼鏡

            #region 附有魔力的眼罩
            case 4:
                ED.Name = "附有魔力的眼罩";
                ED.Level = 160;
                ED.Index = "1122602";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.Def = 300;
                ED.TotalScroll = 3;
                break;
                #endregion 附有魔力的眼罩

        }
        return ED;
    }
    #endregion 眼飾

    //套服 Overall/Suit ID:113 16件(1+15 原20件重複4件) 完成新規範&資料驗證 2021.4.4  
    #region 套服

    #region 劍士套服
    public static EquipmentDetails GetWarriorSuit(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛煉獄鎧甲
            case 1:
                ED.Name = "佩沙里洛煉獄鎧甲";
                ED.Level = 140;
                ED.Index = "1130102";
                ED.STR = 20;
                ED.DEX = 20;
                ED.PAtk = 1;
                ED.Def = 325;
                ED.TotalScroll = 10;
                break;
            #endregion 佩沙里洛煉獄鎧甲

            #region 航海師劍士套裝
            case 2:
                ED.Name = "航海師劍士套裝";
                ED.Level = 160;
                ED.Index = "1131102";
                ED.STR = 65;
                ED.DEX = 65;
                ED.PAtk = 5;
                ED.Def = 300;
                ED.TotalScroll = 12;
                break;
            #endregion 航海師劍士套裝

            #region 滅龍騎士盔甲
            case 3:
                ED.Name = "滅龍騎士盔甲";
                ED.Level = 170;
                ED.Index = "113";
                ED.STR = 100;
                ED.DEX = 100;
                ED.INT = 100;
                ED.LUK = 100;
                ED.HPPercent = 20;
                ED.MPPercent = 20;
                ED.PAtk = 200;
                ED.MAtk = 200;
                ED.Def = 500;
                ED.BossDamage = 30;
                ED.Ignore = 30;
                ED.TotalScroll = 10;
                ED.Universal = true;
                ED.hasSet = false;
                break;
            #endregion 滅龍騎士盔甲

            #region 神秘冥界幽靈騎士套裝
            case 4:
                ED.Name = "神秘冥界幽靈騎士套裝";
                ED.Level = 200;
                ED.Index = "1131602";
                ED.STR = 85;
                ED.DEX = 85;
                ED.PAtk = 9;
                ED.Def = 500;
                ED.Ignore = 10;
                ED.TotalScroll = 12;
                break;
                #endregion 神秘冥界幽靈騎士套裝

        }
        return ED;
    }
    #endregion 劍士套服

    #region 法師套服
    public static EquipmentDetails GetMagicianSuit(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛巫師長袍
            case 1:
                ED.Name = "佩沙里洛巫師長袍";
                ED.Level = 140;
                ED.Index = "1130202";
                ED.INT = 20;
                ED.LUK = 20;
                ED.MaxMP = 60;
                ED.MAtk = 1;
                ED.Def = 150;
                ED.TotalScroll = 10;
                break;
            #endregion 佩沙里洛巫師長袍

            #region 航海師法師套裝
            case 2:
                ED.Name = "航海師法師套裝";
                ED.Level = 160;
                ED.Index = "1131202";
                ED.INT = 65;
                ED.LUK = 65;
                ED.MAtk = 5;
                ED.Def = 300;
                ED.TotalScroll = 12;
                break;
            #endregion 航海師法師套裝

            #region 滅龍騎士盔甲
            case 3:
                ED.Name = "滅龍騎士盔甲";
                ED.Level = 170;
                ED.Index = "113";
                ED.STR = 100;
                ED.DEX = 100;
                ED.INT = 100;
                ED.LUK = 100;
                ED.HPPercent = 20;
                ED.MPPercent = 20;
                ED.PAtk = 200;
                ED.MAtk = 200;
                ED.Def = 500;
                ED.BossDamage = 30;
                ED.Ignore = 30;
                ED.TotalScroll = 10;
                ED.Universal = true;
                ED.hasSet = false;
                break;
            #endregion 滅龍騎士盔甲

            #region 神秘冥界幽靈魔導士套裝
            case 4:
                ED.Name = "神秘冥界幽靈魔導士套裝";
                ED.Level = 200;
                ED.Index = "1131702";
                ED.INT = 85;
                ED.LUK = 85;
                ED.MAtk = 9;
                ED.Def = 500;
                ED.Ignore = 10;
                ED.TotalScroll = 12;
                break;
                #endregion 神秘冥界幽靈魔導士套裝

        }
        return ED;
    }
    #endregion 法師套服

    #region 弓箭手套服
    public static EquipmentDetails GetBowManSuit(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛監視兵套裝
            case 1:
                ED.Name = "佩沙里洛監視兵套裝";
                ED.Level = 140;
                ED.Index = "1130302";
                ED.STR = 18;
                ED.DEX = 20;
                ED.PAtk = 1;
                ED.Def = 180;
                ED.TotalScroll = 10;
                break;
            #endregion 佩沙里洛監視兵套裝

            #region 航海師弓箭手套裝
            case 2:
                ED.Name = "航海師弓箭手套裝";
                ED.Level = 160;
                ED.Index = "1131302";
                ED.STR = 65;
                ED.DEX = 65;
                ED.PAtk = 5;
                ED.Def = 300;
                ED.TotalScroll = 12;
                break;
            #endregion 航海師弓箭手套裝

            #region 滅龍騎士盔甲
            case 3:
                ED.Name = "滅龍騎士盔甲";
                ED.Level = 170;
                ED.Index = "113";
                ED.STR = 100;
                ED.DEX = 100;
                ED.INT = 100;
                ED.LUK = 100;
                ED.HPPercent = 20;
                ED.MPPercent = 20;
                ED.PAtk = 200;
                ED.MAtk = 200;
                ED.Def = 500;
                ED.BossDamage = 30;
                ED.Ignore = 30;
                ED.TotalScroll = 10;
                ED.Universal = true;
                ED.hasSet = false;
                break;
            #endregion 滅龍騎士盔甲

            #region 神秘冥界幽靈弓手套裝
            case 4:
                ED.Name = "神秘冥界幽靈弓手套裝";
                ED.Level = 200;
                ED.Index = "1131802";
                ED.STR = 85;
                ED.DEX = 85;
                ED.PAtk = 9;
                ED.Def = 500;
                ED.Ignore = 10;
                ED.TotalScroll = 12;
                break;
                #endregion 神秘冥界幽靈弓手套裝

        }
        return ED;
    }
    #endregion 弓箭手套服

    #region 盜賊套服
    public static EquipmentDetails GetThiefSuit(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛獵人套服
            case 1:
                ED.Name = "佩沙里洛獵人套服";
                ED.Level = 140;
                ED.Index = "1130402";
                ED.DEX = 18;
                ED.LUK = 20;
                ED.PAtk = 1;
                ED.Def = 180;
                ED.TotalScroll = 10;
                break;
            #endregion 佩沙里洛獵人套服

            #region 航海師盜賊套裝
            case 2:
                ED.Name = "航海師盜賊套裝";
                ED.Level = 160;
                ED.Index = "1131402";
                ED.DEX = 65;
                ED.LUK = 65;
                ED.PAtk = 5;
                ED.Def = 300;
                ED.TotalScroll = 12;
                break;
            #endregion 航海師盜賊套裝

            #region 滅龍騎士盔甲
            case 3:
                ED.Name = "滅龍騎士盔甲";
                ED.Level = 170;
                ED.Index = "113";
                ED.STR = 100;
                ED.DEX = 100;
                ED.INT = 100;
                ED.LUK = 100;
                ED.HPPercent = 20;
                ED.MPPercent = 20;
                ED.PAtk = 200;
                ED.MAtk = 200;
                ED.Def = 500;
                ED.BossDamage = 30;
                ED.Ignore = 30;
                ED.TotalScroll = 10;
                ED.Universal = true;
                ED.hasSet = false;
                break;
            #endregion 滅龍騎士盔甲

            #region 神秘冥界幽靈小偷套裝
            case 4:
                ED.Name = "神秘冥界幽靈小偷套裝";
                ED.Level = 200;
                ED.Index = "1131902";
                ED.DEX = 85;
                ED.LUK = 85;
                ED.PAtk = 9;
                ED.Def = 500;
                ED.Ignore = 10;
                ED.TotalScroll = 12;
                break;
                #endregion 神秘冥界幽靈小偷套裝

        }
        return ED;
    }
    #endregion 盜賊套服

    #region 海盜套服
    public static EquipmentDetails GetPirateSuit(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛船長大衣
            case 1:
                ED.Name = "佩沙里洛船長大衣";
                ED.Level = 140;
                ED.Index = "1130502";
                ED.STR = 20;
                ED.DEX = 20;
                ED.PAtk = 1;
                ED.Def = 180;
                ED.TotalScroll = 10;
                break;
            #endregion 佩沙里洛船長大衣

            #region 航海師海盜套裝
            case 2:
                ED.Name = "航海師海盜套裝";
                ED.Level = 160;
                ED.Index = "1131502";
                ED.STR = 65;
                ED.DEX = 65;
                ED.PAtk = 5;
                ED.Def = 300;
                ED.TotalScroll = 12;
                break;
            #endregion 航海師海盜套裝

            #region 滅龍騎士盔甲
            case 3:
                ED.Name = "滅龍騎士盔甲";
                ED.Level = 170;
                ED.Index = "113";
                ED.STR = 100;
                ED.DEX = 100;
                ED.INT = 100;
                ED.LUK = 100;
                ED.HPPercent = 20;
                ED.MPPercent = 20;
                ED.PAtk = 200;
                ED.MAtk = 200;
                ED.Def = 500;
                ED.BossDamage = 30;
                ED.Ignore = 30;
                ED.TotalScroll = 10;
                ED.Universal = true;
                ED.hasSet = false;
                break;
            #endregion 滅龍騎士盔甲

            #region 神秘冥界幽靈海盜套裝
            case 4:
                ED.Name = "神秘冥界幽靈海盜套裝";
                ED.Level = 200;
                ED.Index = "1132002";
                ED.STR = 85;
                ED.DEX = 85;
                ED.PAtk = 9;
                ED.Def = 500;
                ED.Ignore = 10;
                ED.TotalScroll = 12;
                break;
                #endregion 神秘冥界幽靈海盜套裝

        }
        return ED;
    }
    #endregion 海盜套服

    #endregion 套服

    //上衣 Top ID:114 5件 完成新規範&資料驗證 2021.4.4
    #region 上衣

    #region 劍士上衣
    public static EquipmentDetails GetWarriorTop(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 鷹眼戰士盔甲
            case 1:
                ED.Name = "鷹眼戰士盔甲";
                ED.Level = 150;
                ED.Index = "1140602";
                ED.STR = 30;
                ED.DEX = 30;
                ED.PAtk = 2;
                ED.Def = 210;
                ED.Ignore = 5;
                ED.TotalScroll = 7;
                break;
                #endregion 鷹眼戰士盔甲

        }
        return ED;
    }
    #endregion 劍士上衣

    #region 法師上衣
    public static EquipmentDetails GetMagicianTop(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 鷹眼敦威治長袍
            case 1:
                ED.Name = "鷹眼敦威治長袍";
                ED.Level = 150;
                ED.Index = "1140702";
                ED.INT = 30;
                ED.LUK = 30;
                ED.MAtk = 2;
                ED.Def = 120;
                ED.Ignore = 5;
                ED.TotalScroll = 7;
                break;
                #endregion 鷹眼敦威治長袍

        }
        return ED;
    }
    #endregion 法師上衣

    #region 弓箭手上衣
    public static EquipmentDetails GetBowManTop(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 鷹眼守護者頭巾
            case 1:
                ED.Name = "鷹眼守護者頭巾";
                ED.Level = 150;
                ED.Index = "1140802";
                ED.STR = 30;
                ED.DEX = 30;
                ED.PAtk = 2;
                ED.Def = 135;
                ED.Ignore = 5;
                ED.TotalScroll = 7;
                break;
                #endregion 鷹眼守護者頭巾

        }
        return ED;
    }
    #endregion 弓箭手上衣

    #region 盜賊上衣
    public static EquipmentDetails GetThiefTop(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 鷹眼暗殺者T恤
            case 1:
                ED.Name = "鷹眼暗殺者T恤";
                ED.Level = 150;
                ED.Index = "1140902";
                ED.DEX = 30;
                ED.LUK = 30;
                ED.PAtk = 2;
                ED.Def = 135;
                ED.Ignore = 5;
                ED.TotalScroll = 7;
                break;
                #endregion 鷹眼暗殺者T恤

        }
        return ED;
    }
    #endregion 盜賊上衣

    #region 海盜上衣
    public static EquipmentDetails GetPirateTop(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 鷹眼漫遊者大衣
            case 1:
                ED.Name = "鷹眼漫遊者大衣";
                ED.Level = 150;
                ED.Index = "1141002";
                ED.STR = 30;
                ED.DEX = 30;
                ED.PAtk = 2;
                ED.Def = 135;
                ED.Ignore = 5;
                ED.TotalScroll = 7;
                break;
                #endregion 鷹眼漫遊者大衣

        }
        return ED;
    }
    #endregion 海盜上衣

    #endregion 上衣

    //褲子 Down ID:115 5件 完成新規範&資料驗證 2021.4.4
    #region 褲子

    #region 劍士褲子
    public static EquipmentDetails GetWarriorButtom(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃蜘蛛戰士褲
            case 1:
                ED.Name = "黃蜘蛛戰士褲";
                ED.Level = 150;
                ED.Index = "1150603";
                ED.STR = 30;
                ED.DEX = 30;
                ED.PAtk = 2;
                ED.Def = 210;
                ED.Ignore = 5;
                ED.TotalScroll = 7;
                break;
                #endregion 黃蜘蛛戰士褲

        }
        return ED;
    }
    #endregion 劍士褲子

    #region 法師褲子
    public static EquipmentDetails GetMagicianButtom(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃蜘蛛敦威治褲
            case 1:
                ED.Name = "黃蜘蛛敦威治褲";
                ED.Level = 150;
                ED.Index = "1150703";
                ED.INT = 30;
                ED.LUK = 30;
                ED.MAtk = 2;
                ED.Def = 120;
                ED.Ignore = 5;
                ED.TotalScroll = 7;
                break;
                #endregion 黃蜘蛛敦威治褲

        }
        return ED;
    }
    #endregion 法師褲子

    #region 弓箭手褲子
    public static EquipmentDetails GetBowManButtom(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃蜘蛛守護者褲
            case 1:
                ED.Name = "黃蜘蛛守護者褲";
                ED.Level = 150;
                ED.Index = "1150803";
                ED.STR = 30;
                ED.DEX = 30;
                ED.PAtk = 2;
                ED.Def = 135;
                ED.Ignore = 5;
                ED.TotalScroll = 7;
                break;
                #endregion 黃蜘蛛守護者褲

        }
        return ED;
    }
    #endregion 弓箭手褲子

    #region 盜賊褲子
    public static EquipmentDetails GetThiefButtom(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃蜘蛛暗殺者褲
            case 1:
                ED.Name = "黃蜘蛛暗殺者褲";
                ED.Level = 150;
                ED.Index = "1150903";
                ED.DEX = 30;
                ED.LUK = 30;
                ED.PAtk = 2;
                ED.Def = 135;
                ED.Ignore = 5;
                ED.TotalScroll = 7;
                break;
                #endregion 黃蜘蛛暗殺者褲

        }
        return ED;
    }
    #endregion 盜賊褲子

    #region 海盜褲子
    public static EquipmentDetails GetPirateButtom(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃蜘蛛漫遊者褲
            case 1:
                ED.Name = "黃蜘蛛漫遊者褲";
                ED.Level = 150;
                ED.Index = "1151003";
                ED.STR = 30;
                ED.DEX = 30;
                ED.PAtk = 2;
                ED.Def = 135;
                ED.Ignore = 5;
                ED.TotalScroll = 7;
                break;
                #endregion 黃蜘蛛漫遊者褲

        }
        return ED;
    }
    #endregion 海盜褲子

    #endregion 褲子

    //鞋子 Shoe ID:116 15件 完成新規範&資料驗證 2021.4.4
    #region 鞋子

    #region 劍士鞋子
    public static EquipmentDetails GetWarriorShoe(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛戰鬥靴
            case 1:
                ED.Name = "佩沙里洛戰鬥靴";
                ED.Level = 140;
                ED.Index = "1160103";
                ED.STR = 15;
                ED.DEX = 9;
                ED.PAtk = 1;
                ED.Def = 120;
                ED.TotalScroll = 6;
                break;
            #endregion 佩沙里洛戰鬥靴
           
            #region 航海師劍士鞋
            case 2:
                ED.Name = "航海師劍士鞋";
                ED.Level = 160;
                ED.Index = "1161103";
                ED.STR = 20;
                ED.DEX = 20;
                ED.PAtk = 5;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師劍士鞋

            #region 神秘冥界幽靈騎士鞋子
            case 3:
                ED.Name = "神秘冥界幽靈騎士鞋子";
                ED.Level = 200;
                ED.Index = "1161603";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 9;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
                #endregion 神秘冥界幽靈騎士鞋子

        }
        return ED;
    }
    #endregion 劍士鞋子

    #region 法師鞋子
    public static EquipmentDetails GetMagicianShoe(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛魔導士靴
            case 1:
                ED.Name = "佩沙里洛魔導士靴";
                ED.Level = 140;
                ED.Index = "1160203";
                ED.INT = 11;
                ED.LUK = 10;
                ED.MAtk = 1;
                ED.Def = 50;
                ED.TotalScroll = 6;
                break;
            #endregion 佩沙里洛魔導士靴
         
            #region 航海師法師鞋
            case 2:
                ED.Name = "航海師法師鞋";
                ED.Level = 160;
                ED.Index = "1161203";
                ED.INT = 20;
                ED.LUK = 20;
                ED.MAtk = 5;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師法師鞋

            #region 神秘冥界幽靈魔導士鞋子
            case 3:
                ED.Name = "神秘冥界幽靈魔導士鞋子";
                ED.Level = 200;
                ED.Index = "1161703";
                ED.INT = 40;
                ED.LUK = 40;
                ED.MAtk = 9;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
                #endregion 神秘冥界幽靈魔導士鞋子

        }
        return ED;
    }
    #endregion 法師鞋子

    #region 弓箭手鞋子
    public static EquipmentDetails GetBowManShoe(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛監視兵靴
            case 1:
                ED.Name = "佩沙里洛監視兵靴";
                ED.Level = 140;
                ED.Index = "1160303";
                ED.STR = 9;
                ED.DEX = 10;
                ED.PAtk = 1;
                ED.Def = 80;
                ED.TotalScroll = 6;
                break;
            #endregion 佩沙里洛監視兵靴
           
            #region 航海師弓箭手鞋
            case 2:
                ED.Name = "航海師弓箭手鞋";
                ED.Level = 160;
                ED.Index = "1161303";
                ED.STR = 20;
                ED.DEX = 20;
                ED.PAtk = 5;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師弓箭手鞋

            #region 神秘冥界幽靈弓手鞋子
            case 3:
                ED.Name = "神秘冥界幽靈弓手鞋子";
                ED.Level = 200;
                ED.Index = "1161803";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 9;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
                #endregion 神秘冥界幽靈弓手鞋子

        }
        return ED;
    }
    #endregion 弓箭手鞋子

    #region 盜賊鞋子
    public static EquipmentDetails GetThiefShoe(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛獵人靴
            case 1:
                ED.Name = "佩沙里洛獵人靴";
                ED.Level = 140;
                ED.Index = "1160403";
                ED.DEX = 10;
                ED.LUK = 10;
                ED.PAtk = 1;
                ED.Def = 80;
                ED.TotalScroll = 6;
                break;
            #endregion 佩沙里洛獵人靴
           
            #region 航海師盜賊鞋
            case 2:
                ED.Name = "航海師盜賊鞋";
                ED.Level = 160;
                ED.Index = "1161403";
                ED.DEX = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師盜賊鞋

            #region 神秘冥界幽靈小偷鞋子
            case 3:
                ED.Name = "神秘冥界幽靈小偷鞋子";
                ED.Level = 200;
                ED.Index = "1161903";
                ED.DEX = 40;
                ED.LUK = 40;
                ED.PAtk = 9;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
                #endregion 神秘冥界幽靈小偷鞋子

        }
        return ED;
    }
    #endregion 盜賊鞋子

    #region 海盜鞋子
    public static EquipmentDetails GetPirateShoe(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛船長靴
            case 1:
                ED.Name = "佩沙里洛船長靴";
                ED.Level = 140;
                ED.Index = "1160503";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 1;
                ED.Def = 80;
                ED.TotalScroll = 6;
                break;
            #endregion 佩沙里洛船長靴
          
            #region 航海師海盜鞋
            case 2:
                ED.Name = "航海師海盜鞋";
                ED.Level = 160;
                ED.Index = "1161503";
                ED.STR = 20;
                ED.DEX = 20;
                ED.PAtk = 5;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師海盜鞋

            #region 神秘冥界幽靈海盜鞋子
            case 3:
                ED.Name = "神秘冥界幽靈海盜鞋子";
                ED.Level = 200;
                ED.Index = "1162003";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 9;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
                #endregion 神秘冥界幽靈海盜鞋子

        }
        return ED;
    }
    #endregion 海盜鞋子

    #endregion 鞋子

    //耳飾 Ear ID:117 9件 完成新規範&資料驗證 2021.4.4
    #region 耳飾
    public static EquipmentDetails GetEar(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 被遺忘的神話耳環
            case 1:
                ED.Name = "被遺忘的神話耳環";
                ED.Level = 100;
                ED.Index = "117";
                ED.STR = 50;
                ED.DEX = 50;
                ED.INT = 50;
                ED.LUK = 50;
                ED.PAtk = 100;
                ED.MAtk = 100;
                ED.TotalScroll = 4;
                ED.hasSet = false;
                break;
            #endregion 被遺忘的神話耳環

            #region 初級培羅德耳環
            case 2:
                ED.Name = "初級培羅德耳環";
                ED.Level = 120;
                ED.Index = "1172201";
                ED.STR = 9;
                ED.DEX = 9;
                ED.INT = 9;
                ED.LUK = 9;
                ED.MaxHP = 80;
                ED.MaxMP = 80;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.Def = 100;
                ED.TotalScroll = 6;
                break;
            #endregion 初級培羅德耳環

            #region 中級培羅德耳環
            case 3:
                ED.Name = "中級培羅德耳環";
                ED.Level = 130;
                ED.Index = "1172301";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.MaxHP = 100;
                ED.MaxMP = 100;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.Def = 100;
                ED.TotalScroll = 6;
                break;
            #endregion 中級培羅德耳環

            #region 戴雅希杜斯耳環
            case 4:
                ED.Name = "戴雅希杜斯耳環";
                ED.Level = 130;
                ED.Index = "1172106";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.Def = 50;
                ED.TotalScroll = 6;
                break;
            #endregion 戴雅希杜斯耳環

            #region 紫翼耳環
            case 5:
                ED.Name = "紫翼耳環";
                ED.Level = 135;
                ED.Index = "11799";
                ED.STR = 6;
                ED.DEX = 6;
                ED.INT = 6;
                ED.LUK = 6;
                ED.MaxHP = 200;
                ED.MaxMP = 200;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.Def = 100;
                ED.TotalScroll = 6;
                ED.Universal = true;
                break;
            #endregion 紫翼耳環

            #region 高級培羅德耳環
            case 6:
                ED.Name = "高級培羅德耳環";
                ED.Level = 140;
                ED.Index = "1172401";
                ED.STR = 12;
                ED.DEX = 12;
                ED.INT = 12;
                ED.LUK = 12;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.PAtk = 6;
                ED.MAtk = 6;
                ED.Def = 100;
                ED.TotalScroll = 7;
                break;
            #endregion 高級培羅德耳環

            #region 頂級培羅德耳環
            case 7:
                ED.Name = "頂級培羅德耳環";
                ED.Level = 150;
                ED.Index = "1172501";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.MaxHP = 150;
                ED.MaxMP = 150;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 100;
                ED.TotalScroll = 7;
                break;
            #endregion 頂級培羅德耳環

            #region 神秘耳環
            case 8:
                ED.Name = "神秘耳環";
                ED.Level = 150;
                ED.Index = "1172702";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.MaxHP = 100;
                ED.MaxMP = 100;
                ED.PAtk = 8;
                ED.MAtk = 8;
                ED.Def = 50;
                ED.TotalScroll = 7;
                break;
            #endregion 神秘耳環

            #region 指揮官力量耳環
            case 9:
                ED.Name = "指揮官力量耳環";
                ED.Level = 200;
                ED.Index = "1172607";
                ED.STR = 7;
                ED.DEX = 7;
                ED.INT = 7;
                ED.LUK = 7;
                ED.MaxHP = 500;
                ED.MaxMP = 500;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.Def = 100;
                ED.TotalScroll = 6;
                break;
            #endregion 指揮官力量耳環

        }
        return ED;
    }
    #endregion 耳飾

    //肩飾 ShoulderPad ID:118 12件(2+10 原20件重複8件) 完成新規範&資料驗證 2021.4.4 
    #region 肩飾

    #region 劍士肩飾
    public static EquipmentDetails GetWarriorShoulder(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 皇家暗黑合金護肩
            case 1:
                ED.Name = "皇家暗黑合金護肩";
                ED.Level = 120;
                ED.Index = "1182115";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 6;
                ED.MAtk = 6;
                ED.Def = 100;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
            #endregion 皇家暗黑合金護肩

            #region 紫翼護肩
            case 2:
                ED.Name = "紫翼護肩";
                ED.Level = 135;
                ED.Index = "11899";
                ED.STR = 12;
                ED.DEX = 12;
                ED.INT = 12;
                ED.LUK = 12;
                ED.MaxHP = 400;
                ED.PAtk = 7;
                ED.MAtk = 7;
                ED.Def = 125;
                ED.TotalScroll = 1;
                ED.Universal = true;
                ED.hasFlame = false;
                break;
            #endregion 紫翼護肩

            #region 航海師劍士護肩
            case 3:
                ED.Name = "航海師劍士護肩";
                ED.Level = 160;
                ED.Index = "1181106";
                ED.STR = 14;
                ED.DEX = 14;
                ED.INT = 14;
                ED.LUK = 14;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 100;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
            #endregion 航海師劍士護肩

            #region 神秘冥界幽靈騎士護肩
            case 4:
                ED.Name = "神秘冥界幽靈騎士護肩";
                ED.Level = 200;
                ED.Index = "1181606";
                ED.STR = 35;
                ED.DEX = 35;
                ED.INT = 35;
                ED.LUK = 35;
                ED.PAtk = 20;
                ED.MAtk = 20;
                ED.Def = 300;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
                #endregion 神秘冥界幽靈騎士護肩

        }
        return ED;
    }
    #endregion 劍士肩飾

    #region 法師肩飾
    public static EquipmentDetails GetMagicianShoulder(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 皇家暗黑合金護肩
            case 1:
                ED.Name = "皇家暗黑合金護肩";
                ED.Level = 120;
                ED.Index = "1182115";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 6;
                ED.MAtk = 6;
                ED.Def = 100;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
            #endregion 皇家暗黑合金護肩

            #region 紫翼護肩
            case 2:
                ED.Name = "紫翼護肩";
                ED.Level = 135;
                ED.Index = "11899";
                ED.STR = 12;
                ED.DEX = 12;
                ED.INT = 12;
                ED.LUK = 12;
                ED.MaxHP = 400;
                ED.PAtk = 7;
                ED.MAtk = 7;
                ED.Def = 125;
                ED.TotalScroll = 1;
                ED.Universal = true;
                ED.hasFlame = false;
                break;
            #endregion 紫翼護肩

            #region 航海師法師護肩
            case 3:
                ED.Name = "航海師法師護肩";
                ED.Level = 160;
                ED.Index = "1181206";
                ED.STR = 14;
                ED.DEX = 14;
                ED.INT = 14;
                ED.LUK = 14;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 100;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
            #endregion 航海師法師護肩

            #region 神秘冥界幽靈魔法護肩
            case 4:
                ED.Name = "神秘冥界幽靈魔法護肩";
                ED.Level = 200;
                ED.Index = "1181706";
                ED.STR = 35;
                ED.DEX = 35;
                ED.INT = 35;
                ED.LUK = 35;
                ED.PAtk = 20;
                ED.MAtk = 20;
                ED.Def = 300;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
                #endregion 神秘冥界幽靈魔法護肩

        }
        return ED;
    }
    #endregion 法師肩飾

    #region 弓箭手肩飾
    public static EquipmentDetails GetBowManShoulder(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 皇家暗黑合金護肩
            case 1:
                ED.Name = "皇家暗黑合金護肩";
                ED.Level = 120;
                ED.Index = "1182115";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 6;
                ED.MAtk = 6;
                ED.Def = 100;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
            #endregion 皇家暗黑合金護肩

            #region 紫翼護肩
            case 2:
                ED.Name = "紫翼護肩";
                ED.Level = 135;
                ED.Index = "11899";
                ED.STR = 12;
                ED.DEX = 12;
                ED.INT = 12;
                ED.LUK = 12;
                ED.MaxHP = 400;
                ED.PAtk = 7;
                ED.MAtk = 7;
                ED.Def = 125;
                ED.TotalScroll = 1;
                ED.Universal = true;
                ED.hasFlame = false;
                break;
            #endregion 紫翼護肩

            #region 航海師弓箭手護肩
            case 3:
                ED.Name = "航海師弓箭手護肩";
                ED.Level = 160;
                ED.Index = "1181306";
                ED.STR = 14;
                ED.DEX = 14;
                ED.INT = 14;
                ED.LUK = 14;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 100;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
            #endregion 航海師弓箭手護肩

            #region 神秘冥界幽靈弓手護肩
            case 4:
                ED.Name = "神秘冥界幽靈弓手護肩";
                ED.Level = 200;
                ED.Index = "1181806";
                ED.STR = 35;
                ED.DEX = 35;
                ED.INT = 35;
                ED.LUK = 35;
                ED.PAtk = 20;
                ED.MAtk = 20;
                ED.Def = 300;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
                #endregion 神秘冥界幽靈弓手護肩

        }
        return ED;
    }
    #endregion 弓箭手肩飾

    #region 盜賊肩飾
    public static EquipmentDetails GetThiefShoulder(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 皇家暗黑合金護肩
            case 1:
                ED.Name = "皇家暗黑合金護肩";
                ED.Level = 120;
                ED.Index = "1182115";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 6;
                ED.MAtk = 6;
                ED.Def = 100;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
            #endregion 皇家暗黑合金護肩

            #region 紫翼護肩
            case 2:
                ED.Name = "紫翼護肩";
                ED.Level = 135;
                ED.Index = "11899";
                ED.STR = 12;
                ED.DEX = 12;
                ED.INT = 12;
                ED.LUK = 12;
                ED.MaxHP = 400;
                ED.PAtk = 7;
                ED.MAtk = 7;
                ED.Def = 125;
                ED.TotalScroll = 1;
                ED.Universal = true;
                ED.hasFlame = false;
                break;
            #endregion 紫翼護肩

            #region 航海師盜賊護肩
            case 3:
                ED.Name = "航海師盜賊護肩";
                ED.Level = 160;
                ED.Index = "1181406";
                ED.STR = 14;
                ED.DEX = 14;
                ED.INT = 14;
                ED.LUK = 14;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 100;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
            #endregion 航海師盜賊護肩

            #region 神秘冥界幽靈小偷護肩
            case 4:
                ED.Name = "神秘冥界幽靈小偷護肩";
                ED.Level = 200;
                ED.Index = "1181906";
                ED.STR = 35;
                ED.DEX = 35;
                ED.INT = 35;
                ED.LUK = 35;
                ED.PAtk = 20;
                ED.MAtk = 20;
                ED.Def = 300;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
                #endregion 神秘冥界幽靈小偷護肩

        }
        return ED;
    }
    #endregion 盜賊肩飾

    #region 海盜肩飾
    public static EquipmentDetails GetPirateShoulder(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 皇家暗黑合金護肩
            case 1:
                ED.Name = "皇家暗黑合金護肩";
                ED.Level = 120;
                ED.Index = "1182115";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 6;
                ED.MAtk = 6;
                ED.Def = 100;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
            #endregion 皇家暗黑合金護肩

            #region 紫翼護肩
            case 2:
                ED.Name = "紫翼護肩";
                ED.Level = 135;
                ED.Index = "11899";
                ED.STR = 12;
                ED.DEX = 12;
                ED.INT = 12;
                ED.LUK = 12;
                ED.MaxHP = 400;
                ED.PAtk = 7;
                ED.MAtk = 7;
                ED.Def = 125;
                ED.TotalScroll = 1;
                ED.Universal = true;
                ED.hasFlame = false;
                break;
            #endregion 紫翼護肩

            #region 航海師海盜護肩
            case 3:
                ED.Name = "航海師海盜護肩";
                ED.Level = 160;
                ED.Index = "1181506";
                ED.STR = 14;
                ED.DEX = 14;
                ED.INT = 14;
                ED.LUK = 14;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 100;
                ED.TotalScroll = 1;
                ED.hasFlame = false;
                break;
            #endregion 航海師海盜護肩

            #region 神秘冥界幽靈海盜護肩
            case 4:
                ED.Name = "神秘冥界幽靈海盜護肩";
                ED.Level = 200;
                ED.Index = "1182006";
                ED.STR = 35;
                ED.DEX = 35;
                ED.INT = 35;
                ED.LUK = 35;
                ED.PAtk = 20;
                ED.MAtk = 20;
                ED.Def = 300;
                ED.TotalScroll = 1;
                break;
                #endregion 神秘冥界幽靈海盜護肩

        }
        return ED;
    }
    #endregion 海盜肩飾

    #endregion 肩飾

    //手套 Gloves ID:119 15件 完成新規範&資料驗證 2021.4.4 
    #region 手套

    #region 劍士手套
    public static EquipmentDetails GetWarriorGloves(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {

            #region 佩沙里洛戰鬥手套
            case 1:
                ED.Name = "佩沙里洛戰鬥手套";
                ED.Level = 140;
                ED.Index = "1190104";
                ED.STR = 11;
                ED.DEX = 10;
                ED.MaxHP = 200;
                ED.PAtk = 2;
                ED.Def = 65;
                ED.TotalScroll = 6;
                break;
            #endregion 佩沙里洛戰鬥手套
          
            #region 航海師劍士手套
            case 2:
                ED.Name = "航海師劍士手套";
                ED.Level = 160;
                ED.Index = "1191104";
                ED.STR = 20;
                ED.DEX = 20;
                ED.PAtk = 5;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師劍士手套

            #region 神秘冥界幽靈騎士手套
            case 3:
                ED.Name = "神秘冥界幽靈騎士手套";
                ED.Level = 200;
                ED.Index = "1191604";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 9;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
                #endregion 神秘冥界幽靈騎士手套

        }
        return ED;
    }
    #endregion 劍士手套

    #region 法師手套
    public static EquipmentDetails GetMagicianGloves(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛魔導士手套
            case 1:
                ED.Name = "佩沙里洛魔導士手套";
                ED.Level = 140;
                ED.Index = "1190204";
                ED.INT = 11;
                ED.LUK = 11;
                ED.MaxHP = 200;
                ED.MAtk = 2;
                ED.Def = 40;
                ED.TotalScroll = 6;
                break;
            #endregion 佩沙里洛魔導士手套

            #region 航海師法師手套
            case 2:
                ED.Name = "航海師法師手套";
                ED.Level = 160;
                ED.Index = "1191204";
                ED.INT = 20;
                ED.LUK = 20;
                ED.MAtk = 5;
                ED.Def = 150;
                ED.Ignore = 10;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師法師手套

            #region 神秘冥界幽靈魔導士手套
            case 3:
                ED.Name = "神秘冥界幽靈魔導士手套";
                ED.Level = 200;
                ED.Index = "1191704";
                ED.INT = 40;
                ED.LUK = 40;
                ED.MAtk = 9;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
                #endregion 神秘冥界幽靈魔導士手套

        }
        return ED;
    }
    #endregion 法師手套

    #region 弓箭手手套
    public static EquipmentDetails GetBowManGloves(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛監視兵手套
            case 1:
                ED.Name = "佩沙里洛監視兵手套";
                ED.Level = 140;
                ED.Index = "1190304";
                ED.STR = 10;
                ED.DEX = 11;
                ED.MaxHP = 200;
                ED.PAtk = 2;
                ED.Def = 50;
                ED.TotalScroll = 6;
                break;
            #endregion 佩沙里洛監視兵手套

            #region 航海師弓箭手手套
            case 2:
                ED.Name = "航海師弓箭手手套";
                ED.Level = 160;
                ED.Index = "1191304";
                ED.STR = 20;
                ED.DEX = 20;
                ED.PAtk = 5;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師弓箭手手套

            #region 神秘冥界幽靈弓手手套
            case 3:
                ED.Name = "神秘冥界幽靈弓手手套";
                ED.Level = 200;
                ED.Index = "1191804";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 9;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
                #endregion 神秘冥界幽靈弓手手套

        }
        return ED;
    }
    #endregion 弓箭手手套

    #region 盜賊手套
    public static EquipmentDetails GetThiefGloves(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛獵人手套
            case 1:
                ED.Name = "佩沙里洛獵人手套";
                ED.Level = 140;
                ED.Index = "1190404";
                ED.DEX = 11;
                ED.LUK = 11;
                ED.MaxHP = 200;
                ED.PAtk = 2;
                ED.Def = 50;
                ED.TotalScroll = 6;
                break;
            #endregion 佩沙里洛獵人手套

            #region 航海師盜賊手套
            case 2:
                ED.Name = "航海師盜賊手套";
                ED.Level = 160;
                ED.Index = "1191404";
                ED.DEX = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師盜賊手套

            #region 神秘冥界幽靈小偷手套
            case 3:
                ED.Name = "神秘冥界幽靈小偷手套";
                ED.Level = 200;
                ED.Index = "1191904";
                ED.DEX = 40;
                ED.LUK = 40;
                ED.PAtk = 9;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
                #endregion 神秘冥界幽靈小偷手套

        }
        return ED;
    }
    #endregion 盜賊手套

    #region 海盜手套
    public static EquipmentDetails GetPirateGloves(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛船長手套
            case 1:
                ED.Name = "佩沙里洛船長手套";
                ED.Level = 140;
                ED.Index = "1190504";
                ED.STR = 11;
                ED.DEX = 11;
                ED.MaxHP = 220;
                ED.PAtk = 2;
                ED.Def = 50;
                ED.TotalScroll = 6;
                break;
            #endregion 佩沙里洛船長手套

            #region 航海師海盜手套
            case 2:
                ED.Name = "航海師海盜手套";
                ED.Level = 160;
                ED.Index = "1191504";
                ED.STR = 20;
                ED.DEX = 20;
                ED.PAtk = 5;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師海盜手套

            #region 神秘冥界幽靈海盜手套
            case 3:
                ED.Name = "神秘冥界幽靈海盜手套";
                ED.Level = 200;
                ED.Index = "1192004";
                ED.STR = 40;
                ED.DEX = 40;
                ED.PAtk = 9;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
                #endregion 神秘冥界幽靈海盜手套

        }
        return ED;
    }
    #endregion 海盜手套

    #endregion 手套

    //能源 Emblem ID:120 26件(7+19) 完成新規範&資料驗證 2021.4.4 
    #region 徽章/三武/能源

    #region 冒險家
    public static EquipmentDetails GetAdventureEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃金楓葉徽章
            case 1:
                ED.Name = "黃金楓葉徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 黃金楓葉徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 冒險家

    #region 皇家騎士團
    public static EquipmentDetails GetCygnusKnightEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃金西格諾斯徽章
            case 1:
                ED.Name = "黃金西格諾斯徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 黃金西格諾斯徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 皇家騎士團

    #region 英雄團
    public static EquipmentDetails GetHeroEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃金英雄徽章
            case 1:
                ED.Name = "黃金英雄徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 黃金英雄徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 英雄團

    #region 末日反抗軍
    public static EquipmentDetails GetResistanceEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃金末日反抗軍徽章
            case 1:
                ED.Name = "黃金末日反抗軍徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 黃金末日反抗軍徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 末日反抗軍

    #region 惡魔
    public static EquipmentDetails GetDemonEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃金惡魔徽章
            case 1:
                ED.Name = "黃金惡魔徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.MaxHP = 500;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 黃金惡魔徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 惡魔

    #region 傑諾
    public static EquipmentDetails GetXenonEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 混合之心
            case 1:
                ED.Name = "混合之心";
                ED.Level = 100;
                ED.Index = "120";
                ED.MaxHP = 300;
                ED.MaxMP = 100;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.Def = 300;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 混合之心

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 傑諾

    #region 凱薩
    public static EquipmentDetails GetKaiserEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 龍徽章
            case 1:
                ED.Name = "龍徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 龍徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 凱薩

    #region 天使破壞者
    public static EquipmentDetails GetAngelicBusterEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 天使M勳章
            case 1:
                ED.Name = "天使M勳章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.MaxHP = 400;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 天使M勳章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 天使破壞者

    #region 卡蒂娜
    public static EquipmentDetails GetCadenaEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 金古代徽章
            case 1:
                ED.Name = "金古代徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 金古代徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 卡蒂娜

    #region 阿戴爾
    public static EquipmentDetails GetAdeleEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃金騎士徽章
            case 1:
                ED.Name = "黃金騎士徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 黃金騎士徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 阿戴爾

    #region 伊利恩
    public static EquipmentDetails GetIlliumEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 金水晶徽章
            case 1:
                ED.Name = "金水晶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 金水晶徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 伊利恩

    #region 亞克
    public static EquipmentDetails GetArkEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃金深淵勇士徽章
            case 1:
                ED.Name = "黃金深淵勇士徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 黃金深淵勇士徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 亞克

    #region 劍豪
    public static EquipmentDetails GetHayatoEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃金月牙戟徽章
            case 1:
                ED.Name = "黃金月牙戟徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 黃金月牙戟徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 劍豪

    #region 陰陽師
    public static EquipmentDetails GetKannaEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃金花徽章
            case 1:
                ED.Name = "黃金花徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 黃金花徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 陰陽師

    #region 神之子
    public static EquipmentDetails GetZeroEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 永恆時間徽章
            case 1:
                ED.Name = "永恆時間徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 永恆時間徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 神之子

    #region 幻獸師
    public static EquipmentDetails GetBeastTamerEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃金森林徽章
            case 1:
                ED.Name = "黃金森林徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 黃金森林徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 幻獸師

    #region 凱內西斯
    public static EquipmentDetails GetKinesisEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃金凱內西斯徽章
            case 1:
                ED.Name = "黃金凱內西斯徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 黃金凱內西斯徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 凱內西斯

    #region 虎影
    public static EquipmentDetails GetHoyoungEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 金色天地人徽章
            case 1:
                ED.Name = "金色天地人徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 金色天地人徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 虎影

    #region 墨玄
    public static EquipmentDetails GetMoXuanEmblem(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 金色玄山派徽章 
            case 1:
                ED.Name = "金色玄山派徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 金色玄山派徽章

            #region 充溢的記憶徽章
            case 2:
                ED.Name = "充溢的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 充溢的記憶徽章

            #region 覺醒的記憶徽章
            case 3:
                ED.Name = "覺醒的記憶徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 150;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 覺醒的記憶徽章

            #region 真．楓心能源
            case 4:
                ED.Name = "真．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.PAtk = 4;
                ED.MAtk = 4;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真．楓心能源

            #region 狂．楓心能源
            case 5:
                ED.Name = "狂．楓心能源";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂．楓心能源

            #region 綠野仙蹤精通徽章
            case 6:
                ED.Name = "綠野仙蹤精通徽章";
                ED.Level = 140;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤精通徽章

            #region 綠野仙蹤大師徽章
            case 7:
                ED.Name = "綠野仙蹤大師徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠野仙蹤大師徽章

            #region 綠野仙蹤傳奇徽章
            case 8:
                ED.Name = "綠野仙蹤傳奇徽章";
                ED.Level = 100;
                ED.Index = "120";
                ED.STR = 20;
                ED.DEX = 20;
                ED.INT = 20;
                ED.LUK = 20;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 綠野仙蹤傳奇徽章

        }
        return ED;
    }
    #endregion 金色玄山派徽章

    #endregion 徽章/三武/能源

    //胸章 Badge ID:121 10件 完成新規範&資料驗證 2021.4.4 
    #region 胸章
    public static EquipmentDetails GetBadge(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 水晶溫杜斯胸章
            case 1:
                ED.Name = "水晶溫杜斯胸章";
                ED.Level = 130;
                ED.Index = "1212118";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion 水晶溫杜斯胸章

            #region 黑翼胸章
            case 2:
                ED.Name = "黑翼胸章";
                ED.Level = 10;
                ED.Index = "121";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.MaxHP = 300;
                ED.MaxMP = 300;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion 黑翼胸章

            #region MX-131
            case 3:
                ED.Name = "MX-131";
                ED.Level = 10;
                ED.Index = "121";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.MaxHP = 300;
                ED.MaxMP = 300;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion MX-131

            # region 創世的胸章
            case 4:
                ED.Name = "創世的胸章";
                ED.Level = 200;
                ED.Index = "1212606";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion MX-131

            #region VIP休菲凱曼的黃金胸章道具
            case 5:
                ED.Name = "VIP休菲凱曼的黃金胸章道具";
                ED.Level = 10;
                ED.Index = "121";
                ED.STR = 6;
                ED.DEX = 6;
                ED.INT = 6;
                ED.LUK = 6;
                ED.MaxHP = 200;
                ED.MaxMP = 200;
                ED.PAtk = 8;
                ED.MAtk = 8;
                ED.TotalScroll = 1;
                ED.Universal = true;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
            #endregion VIP休菲凱曼的黃金胸章道具

            #region VVIP休菲凱曼的黃金胸章道具
            case 6:
                ED.Name = "VVIP休菲凱曼的黃金胸章道具";
                ED.Level = 10;
                ED.Index = "121";
                ED.STR = 7;
                ED.DEX = 7;
                ED.INT = 7;
                ED.LUK = 7;
                ED.MaxHP = 200;
                ED.MaxMP = 200;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion VVIP休菲凱曼的黃金胸章道具

            #region 七日的胸章
            case 7:
                ED.Name = "七日的胸章";
                ED.Level = 100;
                ED.Index = "1212802";
                ED.STR = 7;
                ED.DEX = 7;
                ED.INT = 7;
                ED.LUK = 7;
                ED.PAtk = 7;
                ED.MAtk = 7;
                ED.Ignore = 10;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion 七日的胸章

            #region 傳說中的勇士胸章
            case 8:
                ED.Name = "傳說中的勇士胸章";
                ED.Level = 10;
                ED.Index = "121";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion 傳說中的勇士胸章

            #region 正義英雄的胸章
            case 9:
                ED.Name = "正義英雄的胸章";
                ED.Level = 10;
                ED.Index = "121";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.Def = 125;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
            #endregion 正義英雄的胸章

            #region RED紀念勇士的胸章
            case 10:
                ED.Name = "RED紀念勇士的胸章";
                ED.Level = 10;
                ED.Index = "121";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.MaxHP = 200;
                ED.MaxMP = 200;
                ED.PAtk = 10;
                ED.MAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasPotential = false;
                ED.hasStar = false;
                break;
                #endregion RED紀念勇士的胸章

        }
        return ED;
    }
    #endregion 胸章

    //勳章 Medals 由於數量過多，不做整理 Too Many Medals
    //改由玩家自行輸入 Work by yourself!

    //副武 SubWeapon ID:123 140件 完成新規範&資料驗證 2021.4.4 尚未處理陰陽師/神之子的問題
    #region 副武器
    //冒險家 59件 
    #region 冒險家

    #region 英雄 - 獎牌 4件
    public static EquipmentDetails GetHeroSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 普邱斯獎牌
            case 1:
                ED.Name = "普邱斯獎牌";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 普邱斯獎牌

            #region 進化普邱斯獎牌
            case 2:
                ED.Name = "進化普邱斯獎牌";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化普邱斯獎牌

            #region 楓之秘寶獎牌
            case 3:
                ED.Name = "楓之秘寶獎牌";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶獎牌

            #region 妖蝶姬之妖章
            case 4:
                ED.Name = "妖蝶姬之妖章";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之妖章

        }
        return ED;
    }
    #endregion 英雄 - 獎牌

    #region 聖騎士 - 念珠 4件
    public static EquipmentDetails GetPaladinSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 莊嚴念珠
            case 1:
                ED.Name = "莊嚴念珠";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 莊嚴念珠

            #region 進化莊嚴念珠
            case 2:
                ED.Name = "進化莊嚴念珠";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化莊嚴念珠

            #region 楓之秘寶念珠
            case 3:
                ED.Name = "楓之秘寶念珠";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶念珠

            #region 妖蝶姬之祈念珠
            case 4:
                ED.Name = "妖蝶姬之祈念珠";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之祈念珠

        }
        return ED;
    }
    #endregion 聖騎士 - 念珠

    #region 黑騎士 - 鎖鍊 4件
    public static EquipmentDetails GetDarkKnightSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 狂暴鎖鏈
            case 1:
                ED.Name = "狂暴鎖鏈";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂暴鎖鏈

            #region 進化狂暴鎖鏈
            case 2:
                ED.Name = "進化狂暴鎖鏈";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化狂暴鎖鏈

            #region 楓之谷寶物鎖鏈
            case 3:
                ED.Name = "楓之谷寶物鎖鏈";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之谷寶物鎖鏈

            #region 妖蝶姬之花鎖
            case 4:
                ED.Name = "妖蝶姬之花鎖";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之花鎖

        }
        return ED;
    }
    #endregion 黑騎士 - 鎖鍊 4件

    #region 火毒 - 魔法書 4件
    public static EquipmentDetails GetFirePosionArchMageSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 赤綠之書<終章>
            case 1:
                ED.Name = "赤綠之書<終章>";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 赤綠之書<終章>

            #region 進化赤綠之書<終章>
            case 2:
                ED.Name = "進化赤綠之書<終章>";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化赤綠之書<終章>

            #region 赤綠之書<楓之祕寶>
            case 3:
                ED.Name = "赤綠之書<楓之祕寶>";
                ED.Level = 110;
                ED.Index = "123";
                ED.INT = 9;
                ED.LUK = 9;
                ED.MAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 赤綠之書<楓之祕寶>

            #region 妖蝶姬之炎惑書
            case 4:
                ED.Name = "妖蝶姬之炎惑書";
                ED.Level = 140;
                ED.Index = "123";
                ED.INT = 14;
                ED.LUK = 14;
                ED.MAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之炎惑書

        }
        return ED;
    }
    #endregion 火毒 - 魔法書

    #region 冰雷 - 魔法書 4件
    public static EquipmentDetails GetLightingArchMageSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 青銀之書<終章>
            case 1:
                ED.Name = "青銀之書<終章>";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 青銀之書<終章>

            #region 進化青銀之書<終章>
            case 2:
                ED.Name = "進化青銀之書<終章>";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化青銀之書<終章>

            #region 青銀之書<楓之祕寶>
            case 3:
                ED.Name = "青銀之書<楓之祕寶>";
                ED.Level = 110;
                ED.Index = "123";
                ED.INT = 9;
                ED.LUK = 9;
                ED.MAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 青銀之書<楓之祕寶>

            #region 妖蝶姬之水豔書
            case 4:
                ED.Name = "妖蝶姬之水豔書";
                ED.Level = 140;
                ED.Index = "123";
                ED.INT = 14;
                ED.LUK = 14;
                ED.MAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之水豔書

        }
        return ED;
    }
    #endregion 冰雷 - 魔法書

    #region 主教 - 魔法書 4件
    public static EquipmentDetails GetBishopSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 白金之書<終章>
            case 1:
                ED.Name = "白金之書<終章>";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 白金之書<終章>

            #region 進化白金之書<終章>
            case 2:
                ED.Name = "進化白金之書<終章>";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化白金之書<終章>

            #region 白金之書<楓之祕寶>
            case 3:
                ED.Name = "白金之書<楓之祕寶>";
                ED.Level = 110;
                ED.Index = "123";
                ED.INT = 9;
                ED.LUK = 9;
                ED.MAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 白金之書<楓之祕寶>

            #region 妖蝶姬之金蠱書
            case 4:
                ED.Name = "妖蝶姬之金蠱書";
                ED.Level = 140;
                ED.Index = "123";
                ED.INT = 14;
                ED.LUK = 14;
                ED.MAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之金蠱書

        }
        return ED;
    }
    #endregion 主教 - 魔法書

    #region 箭神 - 箭羽 4件
    public static EquipmentDetails GetBowMasterSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 爆發羽毛
            case 1:
                ED.Name = "爆發羽毛";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 爆發羽毛

            #region 進化爆發羽毛
            case 2:
                ED.Name = "進化爆發羽毛";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化爆發羽毛

            #region 楓之秘寶羽毛
            case 3:
                ED.Name = "楓之秘寶羽毛";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶羽毛

            #region 妖蝶姬之魅翅
            case 4:
                ED.Name = "妖蝶姬之魅翅";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之魅翅

        }
        return ED;
    }
    #endregion 箭神 - 箭羽

    #region 神射手 - 弓箭指套 4件
    public static EquipmentDetails GetMarksManSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 全發命中
            case 1:
                ED.Name = "全發命中";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 全發命中

            #region 進化全發命中
            case 2:
                ED.Name = "進化全發命中";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化全發命中

            #region 楓之秘寶一發必中
            case 3:
                ED.Name = "楓之秘寶一發必中";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶一發必中

            #region 妖蝶姬之花戒
            case 4:
                ED.Name = "楓之秘寶一發必中";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之花戒

        }
        return ED;
    }
    #endregion 神射手 - 弓箭指套

    #region 開拓者 - 遺跡 2件 缺進化系統&楓之秘寶
    public static EquipmentDetails GetPathFinderSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 完美遺跡
            case 1:
                ED.Name = "完美遺跡";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 完美遺跡
       
            #region 不滅的遺跡
            case 2:
                ED.Name = "不滅的遺跡";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 不滅的遺跡

        }
        return ED;
    }
    #endregion 開拓者 - 遺跡

    #region 夜使者 - 符咒 4件
    public static EquipmentDetails GetNightLordSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 破斜部
            case 1:
                ED.Name = "破斜部";
                ED.Level = 100;
                ED.Index = "123";
                ED.LUK = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 破斜部

            #region 進化破斜部
            case 2:
                ED.Name = "進化破斜部";
                ED.Level = 100;
                ED.Index = "123";
                ED.LUK = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化破斜部

            #region 楓之秘寶破斜部
            case 3:
                ED.Name = "楓之秘寶破斜部";
                ED.Level = 110;
                ED.Index = "123";
                ED.LUK = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶破斜部

            #region 妖蝶姬之咒符
            case 4:
                ED.Name = "妖蝶姬之咒符";
                ED.Level = 140;
                ED.Index = "123";
                ED.LUK = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之咒符

        }
        return ED;
    }
    #endregion 夜使者 - 符咒

    #region 暗影神偷 - 短劍用劍套 4件
    public static EquipmentDetails GetShadowerSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 激烈暗影
            case 1:
                ED.Name = "激烈暗影";
                ED.Level = 100;
                ED.Index = "123";
                ED.LUK = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 激烈暗影

            #region 進化激烈暗影
            case 2:
                ED.Name = "進化激烈暗影";
                ED.Level = 100;
                ED.Index = "123";
                ED.LUK = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化激烈暗影

            #region 楓之秘寶暗影
            case 3:
                ED.Name = "楓之秘寶暗影";
                ED.Level = 110;
                ED.Index = "123";
                ED.LUK = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶暗影

            #region 妖蝶姬之紫鞘
            case 4:
                ED.Name = "妖蝶姬之紫鞘";
                ED.Level = 140;
                ED.Index = "123";
                ED.LUK = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之紫鞘

        }
        return ED;
    }
    #endregion 暗影神偷 - 短劍用劍套

    #region 影武者 - 雙刀 5件
    public static EquipmentDetails GetKataraSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 烏特卡勒德之劍
            case 1:
                ED.Name = "烏特卡勒德之劍";
                ED.Level = 140;
                ED.Index = "123";
                ED.PAtk = 63;
                ED.TotalScroll = 8;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
            #endregion 烏特卡勒德之劍

            #region 夫尼爾瞬稜雙刀
            case 2:
                ED.Name = "夫尼爾瞬稜雙刀";
                ED.Level = 150;
                ED.Index = "123";
                ED.LUK = 30;
                ED.PAtk = 81;
                ED.TotalScroll = 7;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
            #endregion 夫尼爾瞬稜雙刀

            #region 波賽頓雙刀
            case 3:
                ED.Name = "波賽頓雙刀";
                ED.Level = 160;
                ED.Index = "123";
                ED.MaxHP = 500;
                ED.PAtk = 86;
                ED.BossDamage = 30;
                ED.Ignore = 10;
                ED.TotalScroll = 7;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
            #endregion 波賽頓雙刀

            #region 航海師雙刀
            case 4:
                ED.Name = "航海師雙刀";
                ED.Level = 160;
                ED.Index = "123";
                ED.LUK = 40;
                ED.PAtk = 97;
                ED.TotalScroll = 8;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
            #endregion 航海師雙刀

            #region 神秘冥界幽靈之刃
            case 5:
                ED.Name = "神秘冥界幽靈之刃";
                ED.Level = 200;
                ED.Index = "123";
                ED.LUK = 65;
                ED.PAtk = 140;
                ED.TotalScroll = 8;
                ED.hasSet = false;
                ED.hasFlame = false;
                break;
                #endregion 神秘冥界幽靈之刃

        }
        return ED;
    }
    #endregion 影武者 - 雙刀

    #region 拳霸 - 盾牌護腕 4件
    public static EquipmentDetails GetBuccaneerSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 盾牌防禦
            case 1:
                ED.Name = "盾牌防禦";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 盾牌防禦

            #region 進化盾牌防禦
            case 2:
                ED.Name = "進化盾牌防禦";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化盾牌防禦

            #region 楓之秘寶盾牌防禦
            case 3:
                ED.Name = "楓之秘寶盾牌防禦";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶盾牌防禦

            #region 妖蝶姬之骸手鐲
            case 4:
                ED.Name = "妖蝶姬之骸手鐲";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之骸手鐲

        }
        return ED;
    }
    #endregion 拳霸 - 盾牌護腕

    #region 槍神 - 瞄準器 4件
    public static EquipmentDetails GetCorsairSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 獵鷹眼
            case 1:
                ED.Name = "獵鷹眼";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 獵鷹眼

            #region 進化高階獵鷹眼
            case 2:
                ED.Name = "進化高階獵鷹眼";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化高階獵鷹眼

            #region 楓之秘寶獵鷹眼
            case 3:
                ED.Name = "楓之秘寶獵鷹眼";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶獵鷹眼

            #region 妖蝶姬之照準器
            case 4:
                ED.Name = "妖蝶姬之照準器";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之照準器

        }
        return ED;
    }
    #endregion 槍神 - 瞄準器

    #region 重砲指揮官 - 火藥桶 4件
    public static EquipmentDetails GetCannonShooterSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 轟擊中心火
            case 1:
                ED.Name = "轟擊中心火";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 轟擊中心火

            #region 進化轟擊中心火
            case 2:
                ED.Name = "進化轟擊中心火";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化轟擊中心火

            #region 楓之秘寶中心火
            case 3:
                ED.Name = "楓之秘寶中心火";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶中心火

            #region 妖蝶姬之妖藥
            case 4:
                ED.Name = "妖蝶姬之妖藥";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之妖藥

        }
        return ED;
    }
    #endregion 重砲指揮官 - 火藥桶
    
    #endregion 冒險家
    //皇家 8件
    #region 皇家騎士團

    #region 米哈逸 - 靈魂盾牌 4件 成長型???
    public static EquipmentDetails GetMihileSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 正義之靈魂盾牌-尚未確認-成長型
            case 1:
                ED.Name = "正義之靈魂盾牌";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 12;
                ED.DEX = 12;
                ED.Def = 85;
                ED.MaxHP = 600;
                ED.MaxMP = 110;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 正義之靈魂盾牌-尚未確認-成長型

            #region 進化定義的靈魂盾牌-尚未確認
            case 2:
                ED.Name = "進化定義的靈魂盾牌";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 12;
                ED.DEX = 12;
                ED.MaxHP = 600;
                ED.MaxMP = 110;
                ED.Def = 85;
                ED.PAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化定義的靈魂盾牌-尚未確認

            #region 楓之秘寶靈魂盾牌
            case 3:
                ED.Name = "楓之秘寶靈魂盾牌";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 11;
                ED.DEX = 11;
                ED.MaxHP = 560;
                ED.MaxMP = 100;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶靈魂盾牌

            #region 名譽的靈魂盾牌
            case 4:
                ED.Name = "名譽的靈魂盾牌";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 18;
                ED.DEX = 18;
                ED.Def = 120;
                ED.MaxHP = 1000;
                ED.MaxMP = 200;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 名譽的靈魂盾牌

        }
        return ED;
    }
    #endregion 米哈逸 - 靈魂盾牌

    #region 皇家騎士團 - 寶石(通用) 4件
    public static EquipmentDetails GetCygnusKnightSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 耶雷弗的光輝
            case 1:
                ED.Name = "耶雷弗的光輝";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 3;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 耶雷弗的光輝

            #region 進化耶雷弗的光輝
            case 2:
                ED.Name = "進化耶雷弗的光輝";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 5;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化耶雷弗的光輝

            #region 楓之秘寶耶雷弗的光輝
            case 3:
                ED.Name = "楓之秘寶耶雷弗的光輝";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.INT = 9;
                ED.LUK = 9;
                ED.PAtk = 6;
                ED.MAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶耶雷弗的光輝

            #region 妖蝶姬之花寶石
            case 4:
                ED.Name = "妖蝶姬之花寶石";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.INT = 14;
                ED.LUK = 14;
                ED.PAtk = 9;
                ED.MAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之花寶石

        }
        return ED;
    }
    #endregion 皇家騎士團 - 寶石(通用)

    #endregion 皇家騎士團
    //英雄團 20件
    #region 英雄團

    #region 狂狼勇士 - 重錘 4件
    public static EquipmentDetails GetAranSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 天龍錘
            case 1:
                ED.Name = "天龍錘";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 天龍錘

            #region 進化天龍錘
            case 2:
                ED.Name = "進化天龍錘";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化天龍錘

            #region 楓之秘寶天龍錘
            case 3:
                ED.Name = "楓之秘寶天龍錘";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶天龍錘

            #region 濃姬的花無缺
            case 4:
                ED.Name = "濃姬的花無缺";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 濃姬的花無缺

        }
        return ED;
    }
    #endregion 狂狼勇士 - 重錘

    #region 龍魔導士 - 文件 4件
    public static EquipmentDetails GetEvanSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 龍使者的遺產
            case 1:
                ED.Name = "龍使者的遺產";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 龍使者的遺產

            #region 進化龍使者的遺產
            case 2:
                ED.Name = "進化龍使者的遺產";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化龍使者的遺產

            #region 楓之秘寶的遺產
            case 3:
                ED.Name = "楓之秘寶的遺產";
                ED.Level = 110;
                ED.Index = "123";
                ED.INT = 9;
                ED.LUK = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶的遺產

            #region 妖蝶姬之龍神記
            case 4:
                ED.Name = "妖蝶姬之龍神記";
                ED.Level = 140;
                ED.Index = "123";
                ED.INT = 14;
                ED.LUK = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之龍神記

        }
        return ED;
    }
    #endregion 龍魔導士 - 文件

    #region 夜光 - 夜光彈 3件 缺進化系統
    public static EquipmentDetails GetLuminousSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 卡勒馬彈
            case 1:
                ED.Name = "卡勒馬彈";
                ED.Level = 100;
                ED.Index = "123";
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 卡勒馬彈

            #region 進化系統-尚未確認
            //case 2:
            //    ED.Level = 100;
            //    ED.INT = 10;
            //    ED.LUK = 10;
            //    ED.PAtk = 5;
            //    break;
            #endregion 進化系統-尚未確認

            #region 楓之秘寶子彈
            case 2:
                ED.Name = "楓之秘寶子彈";
                ED.Level = 110;
                ED.Index = "123";
                ED.INT = 9;
                ED.LUK = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶子彈

            #region 妖蝶姬之魂珠
            case 3:
                ED.Name = "妖蝶姬之魂珠";
                ED.Level = 140;
                ED.Index = "123";
                ED.INT = 14;
                ED.LUK = 14;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之魂珠

        }
        return ED;
    }
    #endregion 夜光 - 夜光彈

    #region 精靈遊俠 - 魔法箭 3件 缺進化系統
    public static EquipmentDetails GetMercedesSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 無限的魔法箭
            case 1:
                ED.Name = "無限的魔法箭";
                ED.Level = 100;
                ED.Index = "123";
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 無限的魔法箭

            #region 進化系統-尚未確認
            //case 2:
            //    ED.Level = 100;
            //    ED.INT = 10;
            //    ED.LUK = 10;
            //    ED.PAtk = 5;
            //    break;
            #endregion 進化系統-尚未確認

            #region 楓之秘寶魔法箭
            case 2:
                ED.Name = "楓之秘寶魔法箭";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶魔法箭

            #region 妖蝶姬之咒式矢
            case 3:
                ED.Name = "妖蝶姬之咒式矢";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之咒式矢

        }
        return ED;
    }
    #endregion 精靈遊俠 - 魔法箭

    #region 幻影俠盜 - 卡牌 3件 缺進化系統
    public static EquipmentDetails GetPhantomSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 新者卡牌
            case 1:
                ED.Name = "新者卡牌";
                ED.Level = 100;
                ED.Index = "123";
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 新者卡牌

            #region 進化系統-尚未確認
            //case 2:
            //    ED.Level = 100;
            //    ED.INT = 10;
            //    ED.LUK = 10;
            //    ED.PAtk = 5;
            //    break;
            #endregion 進化系統-尚未確認

            #region 楓之秘寶卡牌
            case 2:
                ED.Name = "楓之秘寶卡牌";
                ED.Level = 110;
                ED.Index = "123";
                ED.DEX = 9;
                ED.LUK = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶卡牌

            #region 妖蝶姬之花牌
            case 3:
                ED.Name = "妖蝶姬之花牌";
                ED.Level = 140;
                ED.Index = "123";
                ED.DEX = 14;
                ED.LUK = 14;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之花牌

        }
        return ED;
    }
    #endregion 幻影俠盜 - 卡牌

    #region 隱月 - 狐狸寶珠 3件 缺進化系統
    public static EquipmentDetails GetShadeSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 金色狐狸珠子
            case 1:
                ED.Name = "金色狐狸珠子";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 新者卡牌

            #region 進化系統-尚未確認
            //case 2:
            //    ED.Level = 100;
            //    ED.INT = 10;
            //    ED.LUK = 10;
            //    ED.PAtk = 5;
            //    break;
            #endregion 進化系統-尚未確認

            #region 楓之秘寶狐狸珠子
            case 2:
                ED.Name = "楓之秘寶狐狸珠子";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶狐狸珠子

            #region 不滅的狐狸珠子
            case 3:
                ED.Name = "不滅的狐狸珠子";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 不滅的狐狸珠子

        }
        return ED;
    }
    #endregion 隱月 - 狐狸寶珠

    #endregion 英雄團
    //惡魔 6件
    #region 惡魔殺手 - 力量盾牌 3件 缺進化系統
    public static EquipmentDetails GetDemonSlayerSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 毀滅力量盾牌
            case 1:
                ED.Name = "毀滅力量盾牌";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.MaxHP = 560;
                ED.DF = 100;
                ED.Def = 81;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 毀滅力量盾牌

            #region 進化系統-尚未確認
            //case 2:
            //    ED.Level = 100;
            //    ED.INT = 10;
            //    ED.LUK = 10;
            //    ED.PAtk = 5;
            //    break;
            #endregion 進化系統-尚未確認

            #region 楓之秘寶力量之盾
            case 2:
                ED.Name = "楓之秘寶力量之盾";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 11;
                ED.DEX = 11;
                ED.MaxHP = 560;
                ED.DF = 100;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶力量之盾

            #region 妖蝶姬之咒楯
            case 3:
                ED.Name = "妖蝶姬之咒楯";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 17;
                ED.DEX = 17;
                ED.MaxHP = 968;
                ED.DF = 173;
                ED.Def = 140;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之咒楯

        }
        return ED;
    }
    #endregion 惡魔殺手 - 力量盾牌

    #region 惡魔復仇者 - 力量盾牌 3件 缺進化系統
    public static EquipmentDetails GetDemonAvengerSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 極限的力量之盾
            case 1:
                ED.Name = "極限的力量之盾";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 21;
                ED.MaxHP = 900;
                ED.Def = 105;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 極限的力量之盾

            #region 進化系統-尚未確認
            //case 2:
            //    ED.Level = 100;
            //    ED.INT = 10;
            //    ED.LUK = 10;
            //    ED.PAtk = 5;
            //    break;
            #endregion 進化系統-尚未確認

            #region 楓之秘寶力量之盾
            case 2:
                ED.Name = "楓之秘寶力量之盾";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 11;
                ED.DEX = 11;
                ED.MaxHP = 560;
                ED.MaxMP = 100;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之秘寶力量之盾

            #region 妖蝶姬之咒楯
            case 3:
                ED.Name = "妖蝶姬之咒楯";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 17;
                ED.MaxHP = 1168;
                ED.Def = 140;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之咒楯

        }
        return ED;
    }
    #endregion 惡魔復仇者 - 力量盾牌
    //末日 18件 至此551件
    #region 末日反抗軍

    #region 爆拳槍神 - 裝填 4件
    public static EquipmentDetails GetBlasterSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 爆發能力<3號>
            case 1:
                ED.Name = "爆發能力<3號>";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 爆發能力<3號>

            #region 進化爆發能力<3號>
            case 2:
                ED.Name = "進化爆發能力<3號>";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化爆發能力<3號>

            #region 楓之祕寶爆發能力
            case 3:
                ED.Name = "楓之祕寶爆發能力";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之祕寶爆發能力

            #region 妖蝶姬爆發能力
            case 4:
                ED.Name = "妖蝶姬爆發能力";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 15;
                ED.DEX = 15;
                ED.PAtk = 10;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬爆發能力

        }
        return ED;
    }
    #endregion 爆拳槍神 - 裝填

    #region 煉獄巫師 - 魔法珠子 4件
    public static EquipmentDetails GetBattleMageSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 極大球
            case 1:
                ED.Name = "極大球";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 極大球

            #region 進化極大球
            case 2:
                ED.Name = "進化極大球";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化極大球

            #region 楓之祕寶極大球
            case 3:
                ED.Name = "楓之祕寶極大球";
                ED.Level = 110;
                ED.Index = "123";
                ED.INT = 9;
                ED.LUK = 9;
                ED.MAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之祕寶極大球

            #region 妖蝶姬之咒玉
            case 4:
                ED.Name = "妖蝶姬之咒玉";
                ED.Level = 140;
                ED.Index = "123";
                ED.INT = 14;
                ED.LUK = 14;
                ED.MAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之咒玉

        }
        return ED;
    }
    #endregion 煉獄巫師 - 魔法珠子

    #region 狂豹獵人 - 火箭頭 4件
    public static EquipmentDetails GetWildHunterSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 狂野棒
            case 1:
                ED.Name = "狂野棒";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 狂野棒

            #region 進化狂野棒
            case 2:
                ED.Name = "進化狂野棒";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化狂野棒

            #region 楓之祕寶狂野棒
            case 3:
                ED.Name = "楓之祕寶狂野棒";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.PAtk = 6;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之祕寶狂野棒

            #region 妖蝶姬之鏃
            case 4:
                ED.Name = "妖蝶姬之鏃";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之鏃

        }
        return ED;
    }
    #endregion 狂豹獵人 - 火箭頭

    #region 傑諾 - 操縱桿 3件 缺進化系統
    public static EquipmentDetails GetXenonSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 八核心操縱桿  
            case 1:
                ED.Name = "八核心操縱桿";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 2;
                ED.DEX = 2;
                ED.INT = 2;
                ED.LUK = 2;
                ED.Def = 380;
                ED.MaxHP = 900;
                ED.MaxMP = 500;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 八核心操縱桿

            #region 進化八核心操縱桿 - 尚未確認
            //case 2:
            //    ED.Level = 100;
            //    ED.STR = 10;
            //    ED.DEX = 10;
            //    ED.PAtk = 5;
            //    break;
            #endregion 進化八核心操縱桿 - 尚未確認

            #region 楓之祕寶操縱桿
            case 2:
                ED.Name = "楓之祕寶操縱桿";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 3;
                ED.DEX = 3;
                ED.INT = 3;
                ED.LUK = 3;
                ED.Def = 390;
                ED.MaxMP = 450;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之祕寶操縱桿

            #region 妖蝶姬之控制器
            case 3:
                ED.Name = "妖蝶姬之控制器";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.Def = 550;
                ED.MaxHP = 600;
                ED.MaxMP = 600;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之控制器

        }
        return ED;
    }
    #endregion 傑諾 - 操縱桿

    #region 機甲戰神 - 連發槍 3件 缺進化系統
    public static EquipmentDetails GetMechanicSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 穿甲連發槍  
            case 1:
                ED.Name = "穿甲連發槍";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 穿甲連發槍

            #region 進化穿甲連發槍 - 尚未確認
            //case 2:
            //    ED.Level = 100;
            //    ED.STR = 10;
            //    ED.DEX = 10;
            //    ED.PAtk = 5;
            //    break;
            #endregion 進化穿甲連發槍 - 尚未確認

            #region 楓之祕寶連發槍
            case 2:
                ED.Name = "楓之祕寶連發槍";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之祕寶連發槍

            #region 妖蝶姬之魔彈
            case 3:
                ED.Name = "妖蝶姬之魔彈";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之魔彈

        }
        return ED;
    }
    #endregion 機甲戰神 - 連發槍

    #endregion #region 末日反抗軍
    //超新星 10件
    #region 超新星

    #region 凱薩 - 龍之精華 3件 缺進化系統
    public static EquipmentDetails GetKaiserSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 真理超新星的精華  
            case 1:
                ED.Name = "真理超新星的精華";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.Def = 30;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 真理超新星的精華

            #region 進化系統 - 尚未確認
            //case 2:
            //    ED.Level = 100;
            //    ED.STR = 10;
            //    ED.DEX = 10;
            //    ED.PAtk = 5;
            //    break;
            #endregion 進化系統 - 尚未確認

            #region 楓之祕寶精華
            case 2:
                ED.Name = "楓之祕寶精華";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.INT = 9;
                ED.LUK = 9;
                ED.Def = 40;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之祕寶精華

            #region 妖蝶姬之龍精華
            case 3:
                ED.Name = "妖蝶姬之龍精華";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.INT = 14;
                ED.LUK = 14;
                ED.Def = 52;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之龍精華

        }
        return ED;
    }
    #endregion 凱薩 - 龍之精華

    #region 天使破壞者 - 靈魂戒指 4件
    public static EquipmentDetails GetAngelicBusterSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 綠色靈魂之環    
            case 1:
                ED.Name = "綠色靈魂之環";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.Def = 300;
                ED.MaxHP = 900;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 綠色靈魂之環  

            #region 進化綠色靈魂之環  
            case 2:
                ED.Name = "進化綠色靈魂之環";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.INT = 10;
                ED.LUK = 10;
                ED.Def = 300;
                ED.MaxHP = 900;
                ED.PAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化綠色靈魂之環  

            #region 楓之祕寶靈魂之環
            case 3:
                ED.Name = "楓之祕寶靈魂之環";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 9;
                ED.DEX = 9;
                ED.INT = 9;
                ED.LUK = 9;
                ED.Def = 280;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之祕寶靈魂之環

            #region 妖蝶姬之魂戒
            case 4:
                ED.Name = "妖蝶姬之魂戒";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.INT = 14;
                ED.LUK = 14;
                ED.MaxHP = 1382;
                ED.Def = 475;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之魂戒

        }
        return ED;
    }
    #endregion 天使破壞者 - 靈魂戒指

    #region 卡蒂娜 - 發信器  3件 缺楓之秘寶
    public static EquipmentDetails GetCadenaSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 發信器 type:A  
            case 1:
                ED.Name = "發信器 type:A  ";
                ED.Level = 100;
                ED.Index = "123";
                ED.LUK = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 發信器 type:A  

            #region 進化發信器 type:A
            case 2:
                ED.Name = "進化發信器 type:A";
                ED.Level = 100;
                ED.Index = "123";
                ED.LUK = 10;
                ED.DEX = 10;
                ED.PAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化發信器 type:A

            #region 楓之祕寶 - 尚未確認
            //case 2:
            //    ED.Level = 110;
            //    ED.STR = 9;
            //    ED.DEX = 9;
            //    break;
            #endregion 楓之祕寶 - 尚未確認

            #region 濃姬發信器
            case 3:
                ED.Name = "濃姬發信器";
                ED.Level = 140;
                ED.Index = "123";
                ED.LUK = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 濃姬發信器

        }
        return ED;
    }
    #endregion 卡蒂娜 - 發信器

    #endregion 超新星
    //阿戴爾 2件
    #region 阿戴爾 - 手鐲  2件 缺進化系統&楓之秘寶
    public static EquipmentDetails GetAdeleSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 高貴手鐲  
            case 1:
                ED.Name = "高貴手鐲";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 高貴手鐲 
           
            #region 不滅的手鐲
            case 2:
                ED.Name = "不滅的手鐲";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 不滅的手鐲

        }
        return ED;
    }
    #endregion 阿戴爾 - 手鐲
    //伊利恩 2件
    #region 伊利恩 - 魔法翅膀  2件 缺進化系統&楓之秘寶
    public static EquipmentDetails GetIlliumSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 絕世魔法翅膀  
            case 1:
                ED.Name = "絕世魔法翅膀";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 絕世魔法翅膀 
                
            #region 不滅之翼
            case 2:
                ED.Name = "不滅之翼";
                ED.Level = 140;
                ED.Index = "123";
                ED.INT = 14;
                ED.LUK = 14;
                ED.MAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 不滅之翼

        }
        return ED;
    }
    #endregion 伊利恩 - 魔法翅膀
    //亞克 2件
    #region 亞克 - 深淵通行  2件 缺進化系統&楓之秘寶
    public static EquipmentDetails GetArkSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 終極通行券  
            case 1:
                ED.Name = "終極通行券";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 終極通行券 
         
            #region 紋櫻公主的通行證
            case 2:
                ED.Name = "紋櫻公主的通行證";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 紋櫻公主的通行證

        }
        return ED;
    }
    #endregion 亞克 - 深淵通行
    //劍豪 3件
    #region 劍豪 - 盾牌  3件 缺進化系統
    public static EquipmentDetails GetHayatoSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 青銅小太刀  
            case 1:
                ED.Name = "青銅小太刀";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 青銅小太刀 
          
            #region 楓之祕寶之刀
            case 2:
                ED.Name = "楓之祕寶之刀";
                ED.Level = 110;
                ED.Index = "123";
                ED.STR = 3;
                ED.PAtk = 2;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之祕寶 - 尚未確認

            #region 妖蝶姬之小太刀
            case 3:
                ED.Name = "妖蝶姬之小太刀";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 17;
                ED.DEX = 17;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之小太刀

        }
        return ED;
    }
    #endregion 劍豪 - 盾牌

    #region 陰陽師 - 由花狐拿第二把武器 特殊等待處理!!!!!!!!!!!!!!!!!!!!
    public static EquipmentDetails GetKannaSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        //switch (Index)
        //{
          

        //}
        return ED;
    }
    #endregion 劍豪 - 盾牌

    #region 神之子 - 琉/璃切換 尚未處理
    public static EquipmentDetails GetZeroSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        //switch (Index)
        //{
          

        //}
        return ED;
    }
    #endregion 神之子 - 琉/璃切換 尚未處理
    //幻獸師 4件
    #region 幻獸師 - 哨子  4件
    public static EquipmentDetails GetBeastTamerSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 大自然的密語  
            case 1:
                ED.Name = "大自然的密語";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 大自然的密語 

            #region 進化大自然的密語
            case 2:
                ED.Name = "進化大自然的密語";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.MAtk = 5;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 進化大自然的密語

            #region 楓之祕寶的密語
            case 3:
                ED.Name = "楓之祕寶的密語";
                ED.Level = 110;
                ED.Index = "123";
                ED.INT = 17;
                ED.LUK = 17;
                ED.MAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 楓之祕寶的密語

            #region 妖蝶姬之魔笛
            case 4:
                ED.Name = "妖蝶姬之魔笛";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 17;
                ED.DEX = 17;
                ED.PAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 妖蝶姬之魔笛

        }
        return ED;
    }
    #endregion 幻獸師 - 哨子
    //凱內西斯 2件
    #region 凱內西斯 - 西洋棋  2件 缺進化系統&楓之秘寶
    public static EquipmentDetails GetKinesisSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 西洋棋-女王  
            case 1:
                ED.Name = "西洋棋-女王";
                ED.Level = 100;
                ED.Index = "123";
                ED.INT = 10;
                ED.LUK = 10;
                ED.MAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 西洋棋-女王            

            #region 西洋棋-王將
            case 2:
                ED.Name = "西洋棋-王將";
                ED.Level = 140;
                ED.Index = "123";
                ED.INT = 14;
                ED.LUK = 14;
                ED.MAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 西洋棋-王將

        }
        return ED;
    }
    #endregion 凱內西斯 - 西洋棋
    //虎影 2件
    #region 虎影 - 扇墜  2件 缺進化系統&楓之秘寶
    public static EquipmentDetails GetHoyoungSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 月長石扇墜  
            case 1:
                ED.Name = "月長石扇墜";
                ED.Level = 100;
                ED.Index = "123";
                ED.DEX = 10;
                ED.LUK = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 月長石扇墜 

            #region 濃姬的扇墜
            case 2:
                ED.Name = "濃姬的扇墜";
                ED.Level = 140;
                ED.Index = "123";
                ED.DEX = 14;
                ED.LUK = 14;
                ED.MAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 濃姬的扇墜

        }
        return ED;
    }
    #endregion 虎影 - 扇墜
    //墨玄 2件
    #region 墨玄 - 拳環  2件 缺進化系統&楓之秘寶
    public static EquipmentDetails GetMoXuanSubWeapon(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 極拳拳環  
            case 1:
                ED.Name = "極拳拳環";
                ED.Level = 100;
                ED.Index = "123";
                ED.STR = 10;
                ED.DEX = 10;
                ED.PAtk = 3;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
            #endregion 極拳拳環 

            #region 濃姬拳環
            case 2:
                ED.Name = "濃姬拳環";
                ED.Level = 140;
                ED.Index = "123";
                ED.STR = 14;
                ED.DEX = 14;
                ED.MAtk = 9;
                ED.hasSet = false;
                ED.hasFlame = false;
                ED.hasScroll = false;
                ED.hasStar = false;
                break;
                #endregion 濃姬拳環

        }
        return ED;
    }
    #endregion 墨玄 - 拳環

    #endregion 副武器

    //披風 Cape ID:124 15件 完成新規範&資料驗證 2021.4.4 
    #region 披風 

    #region 劍士披風
    public static EquipmentDetails GetWarriorCape(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛戰鬥斗篷
            case 1:
                ED.Name = "佩沙里洛戰鬥斗篷";
                ED.Level = 140;
                ED.Index = "1240105";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 佩沙里洛戰鬥斗篷
            
            #region 航海師劍士斗篷
            case 2:
                ED.Name = "航海師劍士斗篷";
                ED.Level = 160;
                ED.Index = "1241105";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師劍士斗篷

            #region 神秘冥界幽靈騎士斗篷
            case 3:
                ED.Name = "神秘冥界幽靈騎士斗篷";
                ED.Level = 200;
                ED.Index = "1241605";
                ED.STR = 35;
                ED.DEX = 35;
                ED.INT = 35;
                ED.LUK = 35;
                ED.PAtk = 6;
                ED.MAtk = 6;
                ED.Def = 450;
                ED.TotalScroll = 7;
                break;
            #endregion 神秘冥界幽靈騎士斗篷

        }
        return ED;
    }
    #endregion 劍士披風

    #region 法師披風
    public static EquipmentDetails GetMagicianCape(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛魔導士斗篷
            case 1:
                ED.Name = "佩沙里洛魔導士斗篷";
                ED.Level = 140;
                ED.Index = "1240205";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 佩沙里洛魔導士斗篷

            #region 航海師法師斗篷
            case 2:
                ED.Name = "航海師法師斗篷";
                ED.Level = 160;
                ED.Index = "1241205";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師法師斗篷

            #region 神秘冥界幽靈魔法斗篷
            case 4:
                ED.Name = "神秘冥界幽靈魔法斗篷";
                ED.Level = 200;
                ED.Index = "1241705";
                ED.STR = 35;
                ED.DEX = 35;
                ED.INT = 35;
                ED.LUK = 35;
                ED.PAtk = 6;
                ED.MAtk = 6;
                ED.Def = 450;
                ED.TotalScroll = 7;
                break;
                #endregion 神秘冥界幽靈魔法斗篷

        }
        return ED;
    }
    #endregion 法師披風

    #region 弓箭手披風
    public static EquipmentDetails GetBowManCape(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛監視兵斗篷
            case 1:
                ED.Name = "佩沙里洛監視兵斗篷";
                ED.Level = 140;
                ED.Index = "1240305";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 佩沙里洛監視兵斗篷

            #region 航海師弓箭手斗篷
            case 2:
                ED.Name = "航海師弓箭手斗篷";
                ED.Level = 160;
                ED.Index = "1241305";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師弓箭手斗篷

            #region 神秘冥界幽靈弓手斗篷
            case 3:
                ED.Name = "神秘冥界幽靈弓手斗篷";
                ED.Level = 200;
                ED.Index = "1241805";
                ED.STR = 35;
                ED.DEX = 35;
                ED.INT = 35;
                ED.LUK = 35;
                ED.PAtk = 6;
                ED.MAtk = 6;
                ED.Def = 450;
                ED.TotalScroll = 7;
                break;
           #endregion 神秘冥界幽靈弓手斗篷

        }
        return ED;
    }
    #endregion 弓箭手披風

    #region 盜賊披風
    public static EquipmentDetails GetThiefCape(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛獵人斗篷
            case 1:
                ED.Name = "佩沙里洛獵人斗篷";
                ED.Level = 140;
                ED.Index = "1240405";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 佩沙里洛獵人斗篷

            #region 航海師盜賊披肩
            case 2:
                ED.Name = "航海師盜賊披肩";
                ED.Level = 160;
                ED.Index = "1241405";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師盜賊披肩

            #region 神秘冥界幽靈小偷斗篷
            case 3:
                ED.Name = "神秘冥界幽靈小偷斗篷";
                ED.Level = 200;
                ED.Index = "1241905";
                ED.STR = 35;
                ED.DEX = 35;
                ED.INT = 35;
                ED.LUK = 35;
                ED.PAtk = 6;
                ED.MAtk = 6;
                ED.Def = 450;
                ED.TotalScroll = 7;
                break;
            #endregion 神秘冥界幽靈小偷斗篷

        }
        return ED;
    }
    #endregion 盜賊披風

    #region 海盜披風
    public static EquipmentDetails GetPirateCape(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 佩沙里洛船長斗篷
            case 1:
                ED.Name = "佩沙里洛船長斗篷";
                ED.Level = 140;
                ED.Index = "1240505";
                ED.STR = 4;
                ED.DEX = 4;
                ED.INT = 4;
                ED.LUK = 4;
                ED.Def = 150;
                ED.TotalScroll = 7;
                break;
            #endregion 佩沙里洛船長斗篷

            #region 航海師海盜披肩
            case 2:
                ED.Name = "航海師海盜披肩";
                ED.Level = 160;
                ED.Index = "1241505";
                ED.STR = 15;
                ED.DEX = 15;
                ED.INT = 15;
                ED.LUK = 15;
                ED.PAtk = 2;
                ED.MAtk = 2;
                ED.Def = 250;
                ED.TotalScroll = 7;
                break;
            #endregion 航海師海盜披肩

            #region 神秘冥界幽靈海盜斗篷
            case 3:
                ED.Name = "神秘冥界幽靈海盜斗篷";
                ED.Level = 200;
                ED.Index = "1242005";
                ED.STR = 35;
                ED.DEX = 35;
                ED.INT = 35;
                ED.LUK = 35;
                ED.PAtk = 6;
                ED.MAtk = 6;
                ED.Def = 450;
                ED.TotalScroll = 7;
                break;
           #endregion 神秘冥界幽靈海盜斗篷

        }
        return ED;
    }
    #endregion 海盜披風

    #endregion 披風

    //心臟 Heart ID:125 7件 完成新規範&資料驗證 2021.4.4  
    #region 眼飾
    public static EquipmentDetails GetHeart(int Index)
    {
        EquipmentDetails ED = new EquipmentDetails();
        switch (Index)
        {
            #region 黃金愛心
            case 1:
                ED.Name = "黃金愛心";
                ED.Level = 30;
                ED.Index = "125";  
                ED.Def = 60;
                ED.TotalScroll = 3;
                ED.hasFlame = false;
                ED.hasSet = false;
                break;
            #endregion 黃金愛心

            #region 水晶愛心
            case 2:
                ED.Name = "水晶愛心";
                ED.Level = 30;
                ED.Index = "125";
                ED.Def = 60;
                ED.TotalScroll = 5;
                ED.hasFlame = false;
                ED.hasSet = false;
                break;
            #endregion 水晶愛心

            #region 鋰愛心
            case 3:
                ED.Name = "鋰愛心";
                ED.Level = 30;
                ED.Index = "125";
                ED.STR = 3;
                ED.DEX = 3;
                ED.INT = 3;
                ED.LUK = 3;
                ED.MaxHP = 50;
                ED.TotalScroll = 7;
                ED.hasFlame = false;
                ED.hasSet = false;
                break;
            #endregion 鋰愛心

            #region 妖精之心
            case 4:
                ED.Name = "妖精之心";
                ED.Level = 100;
                ED.Index = "125";
                ED.MaxHP = 100;
                ED.TotalScroll = 9;
                ED.hasFlame = false;
                ED.hasSet = false;
                break;
            #endregion 妖精之心

            #region 鈦之心
            case 5:
                ED.Name = "鈦之心";
                ED.Level = 100;
                ED.Index = "125";
                ED.STR = 3;
                ED.DEX = 3;
                ED.INT = 3;
                ED.LUK = 3;
                ED.MaxHP = 50;
                ED.TotalScroll = 9;
                ED.hasFlame = false;
                ED.hasSet = false;
                break;
            #endregion 鈦之心

            #region 女武神之心
            case 6:
                ED.Name = "女武神之心";
                ED.Level = 150;
                ED.Index = "125";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.MaxHP = 500;
                ED.TotalScroll = 10;
                ED.hasFlame = false;
                ED.hasSet = false;
                break;
            #endregion 女武神之心

            #region M-DAY機器心臟
            case 7:
                ED.Name = "M-DAY機器心臟";
                ED.Level = 160;
                ED.Index = "125";
                ED.STR = 5;
                ED.DEX = 5;
                ED.INT = 5;
                ED.LUK = 5;
                ED.MaxHP = 500;
                ED.TotalScroll = 11;
                ED.hasFlame = false;
                ED.hasSet = false;
                break;
            #endregion M-DAY機器心臟

        }
        return ED;
    }
    #endregion 心臟

}

