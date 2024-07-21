using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DevLevelControl : MonoBehaviour
{
    public LevelMeneger levelMeneger;
    public TMPro.TextMeshProUGUI levelText;

    public TextMeshProUGUI levelName;
    public void DropDownList()
    {
        switch (levelName.text)
        {
            case "Bölüm 1":
                Level1();
                break;
            case "Bölüm 2":
                Level2();
                break;
            case "Bölüm 3":
                Level3();
                break;
            case "Bölüm 4":
                Level4();
                break;
            case "Bölüm 5":
                Level5();
                break;
            case "Bölüm 6":
                Level6();
                break;
            case "Bölüm 7":
                Level7();
                break;
            case "Bölüm 8":
                Level8();
                break;
            case "Bölüm 9":
                Level9();
                break;
            case "Bölüm 10":
                Level10();
                break;
            case "Bölüm 11":
                Level11();
                break;
            case "Bölüm 12":
                Level12();
                break;
            case "Bölüm 13":
                Level13();
                break;
            case "Bölüm 14":
                Level14();
                break;
            case "Bölüm 15":
                Level15();
                break;
            case "Bölüm 16":
                Level16();
                break;
            case "Bölüm 17":
                Level17();
                break;
            case "Bölüm 18":
                Level18();
                break;
            case "Bölüm 19":
                Level19();
                break;
            case "Bölüm 20":
                Level20();
                break;
            case "Bölüm 21":
                Level21();
                break;
            case "Bölüm 22":
                Level22();
                break;
            case "Bölüm 23":
                Level23();
                break;
            
            
        }
    }
    public void Level1()
   {
       LevelMeneger.levelStatus = LevelStatus.Level1;
       levelText.text = "Bölüm 1";
   }
   public void Level2()
   {
       LevelMeneger.levelStatus = LevelStatus.Level2;
       levelText.text = "Bölüm 2";
   }
   public void Level3()
   {
       LevelMeneger.levelStatus = LevelStatus.Level3;
       levelText.text = "Bölüm 3";
   }
   public void Level4()
   {
       LevelMeneger.levelStatus = LevelStatus.Level4;
       levelText.text = "Bölüm 4";
   }
   public void Level5()
   {
       LevelMeneger.levelStatus = LevelStatus.Level5;
       levelText.text = "Bölüm 5";
   }
   public void Level6()
   {
       LevelMeneger.levelStatus = LevelStatus.Level6;
       levelText.text = "Bölüm 6";
   }
   public void Level7()
   {
       LevelMeneger.levelStatus = LevelStatus.Level7;
       levelText.text = "Bölüm 7";
   }
   public void Level8()
   {
       LevelMeneger.levelStatus = LevelStatus.Level8;
       levelText.text = "Bölüm 8";
   }
   public void Level9()
   {
       LevelMeneger.levelStatus = LevelStatus.Level9;
       levelText.text = "Bölüm 9";
   }
   public void Level10()
   {
       LevelMeneger.levelStatus = LevelStatus.Level10;
       levelText.text = "Bölüm 10";
   }
   public void Level11()
   {
       LevelMeneger.levelStatus = LevelStatus.Level11;
       levelText.text = "Bölüm 11";
   }
   public void Level12()
   {
       LevelMeneger.levelStatus = LevelStatus.Level12;
       levelText.text = "Bölüm 12";
   }
   public void Level13()
   {
       LevelMeneger.levelStatus = LevelStatus.Level13;
       levelText.text = "Bölüm 13";
   }
   public void Level14()
   {
       LevelMeneger.levelStatus = LevelStatus.Level14;
       levelText.text = "Bölüm 14";
   }
   public void Level15()
   {
       LevelMeneger.levelStatus = LevelStatus.Level15;
       levelText.text = "Bölüm 15";
   }
   public void Level16()
   {
       LevelMeneger.levelStatus = LevelStatus.Level16;
       levelText.text = "Bölüm 16";
   }
   public void Level17()
   {
       LevelMeneger.levelStatus = LevelStatus.Level17;
       levelText.text = "Bölüm 17";
   }
   public void Level18()
   {
       LevelMeneger.levelStatus = LevelStatus.Level18;
       levelText.text = "Bölüm 18";
   }
   public void Level19()
   {
       LevelMeneger.levelStatus = LevelStatus.Level19;
       levelText.text = "Bölüm 19";
   }
   public void Level20()
   {
       LevelMeneger.levelStatus = LevelStatus.Level20;
       levelText.text = "Bölüm 20";
   }
   public void Level21()
   {
       LevelMeneger.levelStatus = LevelStatus.Level21;
       levelText.text = "Bölüm 21";
   }
   public void Level22()
   {
       LevelMeneger.levelStatus = LevelStatus.Level22;
       levelText.text = "Bölüm 22";
   }
   public void Level23()
   {
       LevelMeneger.levelStatus = LevelStatus.Level23;
       levelText.text = "Bölüm 23";
   }
   
}
