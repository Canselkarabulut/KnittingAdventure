using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BonusButton : MonoBehaviour
{
    public LevelMeneger levelMeneger;
    public TextMeshProUGUI bonusText;

    public void BonusText()
    {
    
        switch (levelMeneger.levelStatus)
        {
            case LevelStatus.Level1:
                bonusText.text = "+500";
                break;
            case LevelStatus.Level2:
                bonusText.text = "+600";
                break;
            case LevelStatus.Level3:
                bonusText.text = "+700";
                break;
            case LevelStatus.Level4:
                bonusText.text = "+800";
                break;
            case LevelStatus.Level5:
                bonusText.text = "+900";
                break;
            case LevelStatus.Level6:
                bonusText.text = "+1000";
                break;
            case LevelStatus.Level7:
                bonusText.text = "+1100";
                break;
            case LevelStatus.Level8:
                bonusText.text = "+1200";
                break;
            case LevelStatus.Level9:
                bonusText.text = "+1300";
                break;
            case LevelStatus.Level10:
                bonusText.text = "+1400";
                break;
            case LevelStatus.Level11:
                bonusText.text = "+1500";
                break;
            case LevelStatus.Level12:
                bonusText.text = "+1600";
                break;
            case LevelStatus.Level13:
                bonusText.text = "+1700";
                break;
            case LevelStatus.Level14:
                bonusText.text = "+1800";
                break;
            case LevelStatus.Level15:
                bonusText.text = "+1900";
                break;
            case LevelStatus.Level16:
                bonusText.text = "+2000";
                break;
            case LevelStatus.Level17:
                bonusText.text = "+2100";
                break;
            case LevelStatus.Level18:
                bonusText.text = "+2200";
                break;
            case LevelStatus.Level19:
                bonusText.text = "+2300";
                break;
            case LevelStatus.Level20:
                bonusText.text = "+2400";
                break;
            case LevelStatus.Level21:
                bonusText.text = "+2500";
                break;
            case LevelStatus.Level22:
                bonusText.text = "+2600";
                break;
            case LevelStatus.Level23:
                bonusText.text = "+2700";
                break;
        }
    }
}