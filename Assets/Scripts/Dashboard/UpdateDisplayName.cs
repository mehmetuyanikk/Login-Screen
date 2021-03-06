using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.SceneManagement;

public class UpdateDisplayName : MonoBehaviour
{
    [SerializeField] InputField _displayName;

    public void UpdateDisplayNameOnClick()
    {
        PlayFabClientAPI.UpdateUserTitleDisplayName(new UpdateUserTitleDisplayNameRequest()
        {
            DisplayName = _displayName.text
        },
        Success =>
        {
            Debug.Log("Kullanıcı Adı Başarıyla Değiştirildi");
        },
        Error =>
        {
            Debug.Log("Display Name Güncellenemedi");
        }

            );
    }
}
