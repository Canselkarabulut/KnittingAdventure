using System;
using System.Collections;
using System.Collections.Generic;
using GamePlay.Enum;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelSelect : MonoBehaviour
{
    [SerializeField] private GameObject levelScene;
    [SerializeField] private GameObject gameScene;
    [SerializeField] public GameObject lockPanel;
    [SerializeField] public LevelCount levelCount;
    [SerializeField] private GameObject Star1;
    [SerializeField] private GameObject Star2;
    [SerializeField] private GameObject Star3;
    [SerializeField] private LevelMeneger levelMeneger;
    [SerializeField] private StitchControl stitchControl;
    [SerializeField] private StarControl starControl;
    [SerializeField] public DoneLevelControl doneLevelControl;
    [SerializeField] private DoneButton doneButton;
    [SerializeField] private BonusButton bonusButton;
    [SerializeField] private LockPanelControl lockPanelControl;
    [SerializeField] private TextMeshProUGUI countDiamondText; //üzerimde yazan elmas texti
    [SerializeField] private LevelTextControl levelTextControl; //elmas güncelleme
    [SerializeField] private int updateDiamondCount;
    [SerializeField] private ParticleSystem lockPanelActiveEffect;
    private int doneint = 0;
    private int baseBonus;
    private int unlockDiamond;
    private int remainingDiamond;

    private void Start()
    {
        LoadLevelStatus((int)levelCount);
        PlayerPrefs.SetInt("LockLevel_" + 0 + "_UnLockCount", 1); //kilit açıldı
    }

    public void LevelVisitControl()
    {
        doneLevelControl.DonePanelActiveCount();
        Star1.SetActive(starControl.starCount >= 1);
        Star2.SetActive(starControl.starCount >= 2);
        Star3.SetActive(starControl.starCount >= 3);
    }

    public void LevelSceneSelect()
    {
        if (!lockPanel.gameObject.activeInHierarchy)
        {
            Selected(levelCount);
        }
        else
        {
            LevelUnlock(levelCount);
        }
    }

    [SerializeField] private TutorialShowControl tutorialShowControl;
public void Selected(LevelCount levelCount)
    {
        switch (levelCount)
        {
            case LevelCount.lvl1:
                LevelControl(LevelStatus.Level1);
                tutorialShowControl.TutorialOne();
                break;
            case LevelCount.lvl2:
                LevelControl(LevelStatus.Level2);
                break;
            case LevelCount.lvl3:
                LevelControl(LevelStatus.Level3);
                break;
            case LevelCount.lvl4:
                LevelControl(LevelStatus.Level4);
                break;
            case LevelCount.lvl5:
                LevelControl(LevelStatus.Level5);
                break;
            case LevelCount.lvl6:
                LevelControl(LevelStatus.Level6);
                break;
            case LevelCount.lvl7:
                LevelControl(LevelStatus.Level7);
                break;
            case LevelCount.lvl8:
                LevelControl(LevelStatus.Level8);
                break;
            case LevelCount.lvl9:
                LevelControl(LevelStatus.Level9);
                break;
            case LevelCount.lvl10:
                LevelControl(LevelStatus.Level10);
                break;
            case LevelCount.lvl11:
                LevelControl(LevelStatus.Level11);
                break;
            case LevelCount.lvl12:
                LevelControl(LevelStatus.Level12);
                break;
            case LevelCount.lvl13:
                LevelControl(LevelStatus.Level13);
                break;
            case LevelCount.lvl14:
                LevelControl(LevelStatus.Level14);
                break;
            case LevelCount.lvl15:
                LevelControl(LevelStatus.Level15);
                break;
            case LevelCount.lvl16:
                LevelControl(LevelStatus.Level16);
                break;
            case LevelCount.lvl17:
                LevelControl(LevelStatus.Level17);
                break;
            case LevelCount.lvl18:
                LevelControl(LevelStatus.Level18);
                break;
            case LevelCount.lvl19:
                LevelControl(LevelStatus.Level19);
                break;
            case LevelCount.lvl20:
                LevelControl(LevelStatus.Level20);
                break;
            case LevelCount.lvl21:
                LevelControl(LevelStatus.Level21);
                break;
            case LevelCount.lvl22:
                LevelControl(LevelStatus.Level22);
                break;
            case LevelCount.lvl23:
                LevelControl(LevelStatus.Level23);
                break;
        }
    }

    public void LevelControl(LevelStatus level)
    {
        levelMeneger.levelStatus = level;
        levelScene.SetActive(false);
        gameScene.SetActive(true);
        levelMeneger.DesiredLevelControl();
        stitchControl.StartPixelColor();
        bonusButton.gameObject.SetActive(true);
    }

    public void LevelUnlock(LevelCount levelCount)
    {
        switch (levelCount)
        {
            case LevelCount.lvl1:
                LevelUnlockControl(LevelStatus.Level1);
                break;
            case LevelCount.lvl2:
                LevelUnlockControl(LevelStatus.Level2);
                break;
            case LevelCount.lvl3:
                LevelUnlockControl(LevelStatus.Level3);
                break;
            case LevelCount.lvl4:
                LevelUnlockControl(LevelStatus.Level4);
                break;
            case LevelCount.lvl5:
                LevelUnlockControl(LevelStatus.Level5);
                break;
            case LevelCount.lvl6:
                LevelUnlockControl(LevelStatus.Level6);
                break;
            case LevelCount.lvl7:
                LevelUnlockControl(LevelStatus.Level7);
                break;
            case LevelCount.lvl8:
                LevelUnlockControl(LevelStatus.Level8);
                break;
            case LevelCount.lvl9:
                LevelUnlockControl(LevelStatus.Level9);
                break;
            case LevelCount.lvl10:
                LevelUnlockControl(LevelStatus.Level10);
                break;
            case LevelCount.lvl11:
                LevelUnlockControl(LevelStatus.Level11);
                break;
            case LevelCount.lvl12:
                LevelUnlockControl(LevelStatus.Level12);
                break;
            case LevelCount.lvl13:
                LevelUnlockControl(LevelStatus.Level13);
                break;
            case LevelCount.lvl14:
                LevelUnlockControl(LevelStatus.Level14);
                break;
            case LevelCount.lvl15:
                LevelUnlockControl(LevelStatus.Level15);
                break;
            case LevelCount.lvl16:
                LevelUnlockControl(LevelStatus.Level16);
                break;
            case LevelCount.lvl17:
                LevelUnlockControl(LevelStatus.Level17);
                break;
            case LevelCount.lvl18:
                LevelUnlockControl(LevelStatus.Level18);
                break;
            case LevelCount.lvl19:
                LevelUnlockControl(LevelStatus.Level19);
                break;
            case LevelCount.lvl20:
                LevelUnlockControl(LevelStatus.Level20);
                break;
            case LevelCount.lvl21:
                LevelUnlockControl(LevelStatus.Level21);
                break;
            case LevelCount.lvl22:
                LevelUnlockControl(LevelStatus.Level22);
                break;
            case LevelCount.lvl23:
                LevelUnlockControl(LevelStatus.Level23);
                break;
        }
    }

    public void LevelUnlockControl(LevelStatus level)
    {
        levelTextControl.DiamondCountUpdate();
        updateDiamondCount = PlayerPrefs.GetInt("DiamondCount");
        unlockDiamond = Convert.ToInt32(countDiamondText.text);

        if (updateDiamondCount >= unlockDiamond) // güncel param kilit parasından yüksekse
        {
            lockPanelActiveEffect.Play();
            remainingDiamond = updateDiamondCount - unlockDiamond;
            PlayerPrefs.SetInt("DiamondCount", remainingDiamond);
            levelTextControl.DiamondCountUpdate();
            lockPanel.SetActive(false);
            lockPanelControl.LockPanelActive();
            OnLevelCompleted((int)levelCount);
        }
    }

    public void SaveLevelStatus(int levelIndex)
    {
        PlayerPrefs.SetInt("LockLevel_" + levelIndex + "_UnLockCount", 1); //kilit açıldı
        lockPanel.SetActive(false);
        PlayerPrefs.Save();
    }

    void LoadLevelStatus(int levelIndex)
    {
        // Seviye tamamlandı mı?
        bool isLevelCompleted = PlayerPrefs.GetInt("LockLevel_" + levelIndex + "_UnLockCount", 0) == 1;

        if (isLevelCompleted)
        {
            lockPanel.SetActive(false);
        }
        else
        {
            lockPanel.SetActive(true);
        }
    }

    public void OnLevelCompleted(int levelIndex)
    {
        SaveLevelStatus(levelIndex);
        LoadLevelStatus(levelIndex);
    }
}