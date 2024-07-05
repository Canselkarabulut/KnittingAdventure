using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevLevelControl : MonoBehaviour
{
    public LevelMeneger levelMeneger;
    public GameObject devLevelControlPanel;
    public TMPro.TextMeshProUGUI levelText;
    private void Start()
    {
        devLevelControlPanel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            devLevelControlPanel.SetActive(true);
        }
    }

    public void Close()
    {
        devLevelControlPanel.SetActive(false);
    }
    public void Open()
    {
        devLevelControlPanel.SetActive(true);
    }
    public void Level1()
   {
       levelMeneger.levelStatus = LevelStatus.Level1;
       levelText.text = "Bölüm 1";
       devLevelControlPanel.SetActive(false);
   }
   public void Level2()
   {
       levelMeneger.levelStatus = LevelStatus.Level2;
       levelText.text = "Bölüm 2";
       devLevelControlPanel.SetActive(false);
   }
   public void Level3()
   {
       levelMeneger.levelStatus = LevelStatus.Level3;
       levelText.text = "Bölüm 3";
       devLevelControlPanel.SetActive(false);
   }
   public void Level4()
   {
       levelMeneger.levelStatus = LevelStatus.Level4;
       levelText.text = "Bölüm 4";
       devLevelControlPanel.SetActive(false);
   }
   public void Level5()
   {
       levelMeneger.levelStatus = LevelStatus.Level5;
       levelText.text = "Bölüm 5";
       devLevelControlPanel.SetActive(false);
   }
   public void Level6()
   {
       levelMeneger.levelStatus = LevelStatus.Level6;
       levelText.text = "Bölüm 6";
       devLevelControlPanel.SetActive(false);
   }
   public void Level7()
   {
       levelMeneger.levelStatus = LevelStatus.Level7;
       levelText.text = "Bölüm 7";
       devLevelControlPanel.SetActive(false);
   }
   public void Level8()
   {
       levelMeneger.levelStatus = LevelStatus.Level8;
       levelText.text = "Bölüm 8";
       devLevelControlPanel.SetActive(false);
   }
   public void Level9()
   {
       levelMeneger.levelStatus = LevelStatus.Level9;
       levelText.text = "Bölüm 9";
       devLevelControlPanel.SetActive(false);
   }
   public void Level10()
   {
       levelMeneger.levelStatus = LevelStatus.Level10;
       levelText.text = "Bölüm 10";
       devLevelControlPanel.SetActive(false);
   }
   public void Level11()
   {
       levelMeneger.levelStatus = LevelStatus.Level11;
       levelText.text = "Bölüm 11";
       devLevelControlPanel.SetActive(false);
   }
   public void Level12()
   {
       levelMeneger.levelStatus = LevelStatus.Level12;
       levelText.text = "Bölüm 12";
       devLevelControlPanel.SetActive(false);
   }
   public void Level13()
   {
       levelMeneger.levelStatus = LevelStatus.Level13;
       levelText.text = "Bölüm 13";
       devLevelControlPanel.SetActive(false);
   }
   public void Level14()
   {
       levelMeneger.levelStatus = LevelStatus.Level14;
       levelText.text = "Bölüm 14";
       devLevelControlPanel.SetActive(false);
   }
   public void Level15()
   {
       levelMeneger.levelStatus = LevelStatus.Level15;
       levelText.text = "Bölüm 15";
       devLevelControlPanel.SetActive(false);
   }
   public void Level16()
   {
       levelMeneger.levelStatus = LevelStatus.Level16;
       levelText.text = "Bölüm 16";
       devLevelControlPanel.SetActive(false);
   }
   public void Level17()
   {
       levelMeneger.levelStatus = LevelStatus.Level17;
       levelText.text = "Bölüm 17";
       devLevelControlPanel.SetActive(false);
   }
   public void Level18()
   {
       levelMeneger.levelStatus = LevelStatus.Level18;
       levelText.text = "Bölüm 18";
       devLevelControlPanel.SetActive(false);
   }
   public void Level19()
   {
       levelMeneger.levelStatus = LevelStatus.Level19;
       levelText.text = "Bölüm 19";
       devLevelControlPanel.SetActive(false);
   }
   public void Level20()
   {
       levelMeneger.levelStatus = LevelStatus.Level20;
       levelText.text = "Bölüm 20";
       devLevelControlPanel.SetActive(false);
   }
   public void Level21()
   {
       levelMeneger.levelStatus = LevelStatus.Level21;
       levelText.text = "Bölüm 21";
       devLevelControlPanel.SetActive(false);
   }
   public void Level22()
   {
       levelMeneger.levelStatus = LevelStatus.Level22;
       levelText.text = "Bölüm 22";
       devLevelControlPanel.SetActive(false);
   }
   public void Level23()
   {
       levelMeneger.levelStatus = LevelStatus.Level23;
       levelText.text = "Bölüm 23";
       devLevelControlPanel.SetActive(false);
   }
   
}
