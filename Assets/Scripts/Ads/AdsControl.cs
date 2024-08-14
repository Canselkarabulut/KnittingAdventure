using UnityEngine;
using GoogleMobileAds.Api;
using TMPro;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;

public class AdsControl : MonoBehaviour
{
    private void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) => { });
        LoadAd(); // banner reklam
        //    LoadInterstitialAd(); // geçiş reklamı
        LevelSceneRewardDiamond(); //ödüllü reklam level sahnesi ödüllü elmas kazanmak
        BonusButtonRewardDiamond(); // bonus buton elmas ödülü
    }

    #region Banner

    // These ad units are configured to always serve test ads.
#if UNITY_ANDROID

      private string _adUnitId = "ca-app-pub-6768650963516253/9055199379"; //orjinal
  //  private string _adUnitId = "ca-app-pub-3940256099942544/6300978111"; //test
#elif UNITY_IPHONE
  private string _adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
  private string _adUnitId = "unused";
#endif

    BannerView _bannerView;

    /// <summary>
    /// Creates a 320x50 banner view at top of the screen.
    /// </summary>
    public void CreateBannerView()
    {
/////        Debug.Log("Creating banner view");

        // If we already have a banner, destroy the old one.
        if (_bannerView != null)
        {
            DestroyBannerView();
        }

        // Create a 320x50 banner at top of the screen
        //  AdSize adSize = new AdSize(50, 50);
        _bannerView = new BannerView(_adUnitId, AdSize.Banner, AdPosition.Bottom);
    }


    public void LoadAd()
    {
        // create an instance of a banner view first.
        if (_bannerView == null)
        {
            CreateBannerView();
        }

        // create our request used to load the ad.
        var adRequest = new AdRequest();

        // send the request to load the ad.
/////        Debug.Log("Loading banner ad.");
        _bannerView.LoadAd(adRequest);
    }

    /// <summary>
    /// listen to events the banner view may raise.
    /// </summary>
    private void ListenToAdEvents()
    {
        // Raised when an ad is loaded into the banner view.
        _bannerView.OnBannerAdLoaded += () =>
        {
            /////       Debug.Log("Banner view loaded an ad with response : "
            /////                 + _bannerView.GetResponseInfo());
        };
        // Raised when an ad fails to load into the banner view.
        _bannerView.OnBannerAdLoadFailed += (LoadAdError error) =>
        {
            Debug.LogError("Banner view failed to load an ad with error : "
                           + error);
        };
        // Raised when the ad is estimated to have earned money.
        _bannerView.OnAdPaid += (AdValue adValue) =>
        {
            /////           Debug.Log(String.Format("Banner view paid {0} {1}.",
/////                adValue.Value,
            /////               adValue.CurrencyCode));
        };
        // Raised when an impression is recorded for an ad.
        _bannerView.OnAdImpressionRecorded += () =>
        {
            /* Debug.Log("Banner view recorded an impression.");*/
        };
        // Raised when a click is recorded for an ad.
        _bannerView.OnAdClicked += () =>
        {
            /* Debug.Log("Banner view was clicked.");*/
        };
        // Raised when an ad opened full screen content.
        _bannerView.OnAdFullScreenContentOpened += () =>
        {
            /*"Banner view full screen content opened.");*/
        };
        // Raised when the ad closed full screen content.
        _bannerView.OnAdFullScreenContentClosed += () =>
        {
            /*"Banner view full screen content closed.");*/
        };
    }

    /// <summary>
    /// Destroys the banner view.
    /// </summary>
    public void DestroyBannerView()
    {
        if (_bannerView != null)
        {
/////            Debug.Log("Destroying banner view.");
            _bannerView.Destroy();
            _bannerView = null;
        }
    }

    #endregion

    #region RewardedAd levelSceneRewardDiamond

// level sahnesi ödüllü elmas kazanmak


#if UNITY_ANDROID
      private string _adRewardedUnitId = "ca-app-pub-6768650963516253/2039199031"; //orjinal
   // private string _adRewardedUnitId = "ca-app-pub-3940256099942544/5224354917"; //test
#elif UNITY_IPHONE
  private string _adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
  private string _adUnitId = "unused";
#endif

    private RewardedAd _rewardedAdlevelScene;

    public void LevelSceneRewardDiamond()
    {
     
        if (_rewardedAdlevelScene != null)
        {
            _rewardedAdlevelScene.Destroy();
            _rewardedAdlevelScene = null;
        }
        var adRequest = new AdRequest();


        RewardedAd.Load(_adRewardedUnitId, adRequest,
            (RewardedAd ad, LoadAdError error) =>
            {
               
                if (error != null || ad == null)
                {
                    Debug.LogError("Rewarded ad failed to load an ad " +
                                   "with error : " + error);
                    return;
                }
                _rewardedAdlevelScene = ad;
            });
    }

    public EarnDiamondControl earnDiamondControl;

    public void ShowRewardedAdLevelScene() //butona tıklanınca çağırılacak
    {
        const string rewardMsg =
            "Rewarded ad rewarded the user. Type: {0}, amount: {1}.";

        if (_rewardedAdlevelScene != null && _rewardedAdlevelScene.CanShowAd())
        {
            _rewardedAdlevelScene.Show((Reward reward) =>
            {
                // TODO: Reward the user.
                earnDiamondControl.EarnDiamonfButton();
            });
            RegisterReloadHandler(_rewardedAdlevelScene);
        }
        NoAdsShowRewardedAdLevelScene();
    }
    

    private void RegisterReloadHandler(RewardedAd ad)
    {
        ad.OnAdFullScreenContentClosed += () =>
        {
            LevelSceneRewardDiamond();
        };
        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            Debug.LogError("Rewarded ad failed to open full screen content " +
                           "with error : " + error);
            
            LevelSceneRewardDiamond();
        };
    }

    #endregion
    
    #region RewardedAd BonusButton
#if UNITY_ANDROID
      private string _adRewardedUnitIdBonusButton = "ca-app-pub-6768650963516253/7011020772"; //orjinal
  //  private string _adRewardedUnitIdBonusButton = "ca-app-pub-3940256099942544/5224354917"; //test
#elif UNITY_IPHONE
  private string _adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
  private string _adUnitId = "unused";
#endif

    private RewardedAd _rewardedAdBonusButton;

    public void BonusButtonRewardDiamond()
    {
     
        if (_rewardedAdBonusButton != null)
        {
            _rewardedAdBonusButton.Destroy();
            _rewardedAdBonusButton = null;
        }
        var adRequest = new AdRequest();


        RewardedAd.Load(_adRewardedUnitId, adRequest,
            (RewardedAd ad, LoadAdError error) =>
            {
               
                if (error != null || ad == null)
                {
                    Debug.LogError("Rewarded ad failed to load an ad " +
                                   "with error : " + error);
                    return;
                }
                _rewardedAdBonusButton = ad;
            });
    }

    
    public BonusButton bonusButton;

    public void ShowRewardedAdBonusButton() //butona tıklanınca çağırılacak
    {
        const string rewardMsg =
            "Rewarded ad rewarded the user. Type: {0}, amount: {1}.";

        if (_rewardedAdBonusButton != null && _rewardedAdBonusButton.CanShowAd())
        {
            _rewardedAdBonusButton.Show((Reward reward) =>
            {
                // TODO: Reward the user.
                bonusButton.BonusButtonClick();
            });
            RegisterReloadHandlerBonusButton(_rewardedAdBonusButton);
        }

        NoAdsShowRewardedAdsBonusButton();
    }
    private void RegisterReloadHandlerBonusButton(RewardedAd ad)
    {
        ad.OnAdFullScreenContentClosed += () =>
        {
            BonusButtonRewardDiamond(); 
        };
        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            Debug.LogError("Rewarded ad failed to open full screen content " +
                           "with error : " + error);
            
            BonusButtonRewardDiamond(); 
        };
    }
    #endregion


    

    #region ifNoAds

     public void NoAdsShowRewardedAdsBonusButton()
    {
        if (_rewardedAdBonusButton == null)
        {
            bonusButton.BonusButtonClick();
        }
    }
     public void NoAdsShowRewardedAdLevelScene()
     {
         if (_rewardedAdlevelScene == null)
         {
             earnDiamondControl.EarnDiamonfButton();
         }
     }
     

    #endregion
}