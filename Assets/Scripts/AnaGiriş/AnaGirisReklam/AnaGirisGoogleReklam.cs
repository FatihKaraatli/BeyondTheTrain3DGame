using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//using UnityEngine.UI;

public class AnaGirisGoogleReklam : MonoBehaviour
{
    /*private RewardedAd rewardedAd;

    public Button reklamButtonu;
    public GameObject reklamButtonuGameObject;

    public GameObject adFailedLoad;
    public GameObject adRewarded;

    void Start()
    {
        string adUnitId;
        #if UNITY_ANDROID
                adUnitId = "ca-app-pub-8851879222698600/1113696579";
        #elif UNITY_IPHONE
                    adUnitId = "ca-app-pub-3940256099942544/1712485313";
        #else
                    adUnitId = "unexpected_platform";
        #endif

        MobileAds.Initialize(initStatus => { });
        
        this.rewardedAd = new RewardedAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;


        AdRequest request = new AdRequest.Builder().Build();
        //this.rewardedAd.LoadAd(request);
        this.rewardedAd.LoadAd(request);
    }



    public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        adRewarded.SetActive(true);
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        this.CreateAndLoadRewardedAd();
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
    }


    public void UserChoseToWatchAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
            Invoke("RewardHasGiven" , 0.1f);
        }
        this.rewardedAd.Show();
    }

    public void CreateAndLoadRewardedAd()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-8851879222698600/1113696579";

#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            string adUnitId = "unexpected_platform";
#endif

        this.rewardedAd = new RewardedAd(adUnitId);

        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);
    }

    public void Rewarded()
    {
        adRewarded.SetActive(false);
        PlayerPrefs.SetFloat("ticket", PlayerPrefs.GetFloat("ticket") + 5000);
    }
    public void FailedToLoadClose()
    {
        adFailedLoad.SetActive(false);
    }

    private void RewardHasGiven()
    {
        adRewarded.SetActive(true);
    }
    */

}
