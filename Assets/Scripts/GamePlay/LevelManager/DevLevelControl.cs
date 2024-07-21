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
        levelMeneger.levelStatus = LevelStatus.Level1;
        levelText.text = "Bölüm 1";
    }

    public void Level2()
    {
        levelMeneger.levelStatus = LevelStatus.Level2;
        levelText.text = "Bölüm 2";
    }

    public void Level3()
    {
        levelMeneger.levelStatus = LevelStatus.Level3;
        levelText.text = "Bölüm 3";
    }

    public void Level4()
    {
        levelMeneger.levelStatus = LevelStatus.Level4;
        levelText.text = "Bölüm 4";
    }

    public void Level5()
    {
        levelMeneger.levelStatus = LevelStatus.Level5;
        levelText.text = "Bölüm 5";
    }

    public void Level6()
    {
        levelMeneger.levelStatus = LevelStatus.Level6;
        levelText.text = "Bölüm 6";
    }

    public void Level7()
    {
        levelMeneger.levelStatus = LevelStatus.Level7;
        levelText.text = "Bölüm 7";
    }

    public void Level8()
    {
        levelMeneger.levelStatus = LevelStatus.Level8;
        levelText.text = "Bölüm 8";
    }

    public void Level9()
    {
        levelMeneger.levelStatus = LevelStatus.Level9;
        levelText.text = "Bölüm 9";
    }

    public void Level10()
    {
        levelMeneger.levelStatus = LevelStatus.Level10;
        levelText.text = "Bölüm 10";
    }

    public void Level11()
    {
        levelMeneger.levelStatus = LevelStatus.Level11;
        levelText.text = "Bölüm 11";
    }

    public void Level12()
    {
        levelMeneger.levelStatus = LevelStatus.Level12;
        levelText.text = "Bölüm 12";
    }

    public void Level13()
    {
        levelMeneger.levelStatus = LevelStatus.Level13;
        levelText.text = "Bölüm 13";
    }

    public void Level14()
    {
        levelMeneger.levelStatus = LevelStatus.Level14;
        levelText.text = "Bölüm 14";
    }

    public void Level15()
    {
        levelMeneger.levelStatus = LevelStatus.Level15;
        levelText.text = "Bölüm 15";
    }

    public void Level16()
    {
        levelMeneger.levelStatus = LevelStatus.Level16;
        levelText.text = "Bölüm 16";
    }

    public void Level17()
    {
        levelMeneger.levelStatus = LevelStatus.Level17;
        levelText.text = "Bölüm 17";
    }

    public void Level18()
    {
        levelMeneger.levelStatus = LevelStatus.Level18;
        levelText.text = "Bölüm 18";
    }

    public void Level19()
    {
        levelMeneger.levelStatus = LevelStatus.Level19;
        levelText.text = "Bölüm 19";
    }

    public void Level20()
    {
        levelMeneger.levelStatus = LevelStatus.Level20;
        levelText.text = "Bölüm 20";
    }

    public void Level21()
    {
        levelMeneger.levelStatus = LevelStatus.Level21;
        levelText.text = "Bölüm 21";
    }

    public void Level22()
    {
        levelMeneger.levelStatus = LevelStatus.Level22;
        levelText.text = "Bölüm 22";
    }

    public void Level23()
    {
        levelMeneger.levelStatus = LevelStatus.Level23;
        levelText.text = "Bölüm 23";
    }
}