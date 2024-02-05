using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;
using System;

public class PlayfabLogin : MonoBehaviour
{
    private const string AuthGuidKey = "auth_guid_key";

    public void Start()
    {
        if (string.IsNullOrEmpty(PlayFabSettings.staticSettings.TitleId))
            PlayFabSettings.staticSettings.TitleId = "A8024";

        var needCreation = PlayerPrefs.HasKey(AuthGuidKey);
        var id = PlayerPrefs.GetString(AuthGuidKey, Guid.NewGuid().ToString());

        var request = new LoginWithCustomIDRequest
        {
            CustomId = id,
            CreateAccount = !needCreation
        };

        PlayFabClientAPI.LoginWithCustomID(request,
            result =>
            {
            PlayerPrefs.SetString(AuthGuidKey, id);
            OnLoginSucces(result);              
            }, OnLoginError);
    }

    private void OnLoginSucces(LoginResult result)
    {
        Debug.Log("Complete Login");
    }

    private void OnLoginError(PlayFabError error)
    {
        var errorMessage = error.GenerateErrorReport();
        Debug.LogError(errorMessage);
    }    
}

