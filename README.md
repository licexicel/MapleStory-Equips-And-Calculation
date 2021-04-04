# MapleStory-Equips-And-Calculation

整理新楓之谷主流的裝備數據&計算方式。

目前共採計503件不重複裝備，

之後會推出整合全身裝備的計算系統。

這個資料結構會沿用下去，

以後可以輸出json看各位想對裝備做什麼處理都行。

有關新楓之谷的資訊統整，

請參閱我製作的APP

https://play.google.com/store/apps/details?id=com.licexicel.MapleAssist

[Guide]

This is an intergration of equip's details and calculataion for TMS,

you can use whatever you want. 

With 503 Common Equips in it.

A total Equip Set calculation System is on schedule,

the data structure will not change in the near future.

You can find latest information and calculation from my app,

https://play.google.com/store/apps/details?id=com.licexicel.MapleAssist


This repo contains two scripts

1.CalEquip.cs

For calculations.

With scroll, flame, star, float Values.

Steps are show by order in script.

Or More Details on 

https://strategywiki.org/wiki/MapleStory/Spell_Trace_and_Star_Force


2.EquipmentDetails.cs

503 Equips' Details with Class EquipmentDetails.

In EquipmentDetails,

it storage all the information of an equip.


Some Special Parameter

1.EquipType

  Correspond to Equip shown in MapleStory,
  
  From left to right, From up to down.
  
  1 ~ 4 = Ring
  
  5 = Pocket
  
  6 ~ 7 = Pendant
  
  8 = Weapon
  
  9 = Belt
  
  10 = Hat
  
  11 = Face
  
  12 = Eye
  
  13 = Overall
  
  14 = Top
  
  15 = Down
  
  16 = Shoe 
  
  17 = Ear
  
  18 = ShoulderPad
  
  19 = Gloves
  
  20 = Emblem
  
  21 = Badge
  
  22 = Medals
  
  23 = SubWeapon
  
  24 = Cape
  
  25 = Heart
  
  
2.JobType

  Means five type of class
  
  * I Set Xenon as Thief
  
  * You can change its type by modifing its equip's Index
  
  0 = Warrior
  
  1 = Magician
  
  2 = Bowman
  
  3 = Thief
  
  4 = Pirate
  
  
3.EquipmentDetails.Index

  Would be use in future calculating Set effects.
  
  Index of each equip.
  
  (* Different equips may have same Index!)
  
  For Example
  
  Index = "1081807"
  
  A. 108 means Eighth Equip Type / 18 means Eighteen Sets effect(99 is Lucky Equip) / 07 means Seventh Equip of the Set.
  
  B. Equip without Set Effect would only Has Three Code. 101 means its Equip Type is ring.
   
   
4.ScrollList

  Scroll Type is set as "int" Type
  
  Type 1~6 is TMS Only
  
  // 1 = 極電     /  2 =  Red    /  3 =  X      /  4 =  V       /  5 = 究極的黑暗 /　6 = Honor(榮耀) Honor is not in this calculation. 
  
  // 7 = 100% STR /  8 = 70% STR /  9 = 30% STR / 10 = 100% DEX / 11 = 70% DEX / 12 = 30% DEX 
  
  //13 = 100% INT / 14 = 70% INT / 15 = 30% INT / 16 = 100% LUK / 17 = 70% LUK / 18 = 30% LUK
  
  //19 = 100% HP  / 20 = 70% HP  / 21 = 30% HP 
  
  //22 = 15% STR  / 23 = 15% DEX / 24 = 15% INT / 25 = 15% LUK  / 29 = 15% HP (22 ~29 Weapons Only)
  
  //26 = 100%     / 27 = 70%     / 28 = 30% (26~28 Gloves Only)
    
