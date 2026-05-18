using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour
{
    public Text playerText;

    void Start()
    {
        if (playerText != null &&
            MenuManager.Instance != null)
        {
            playerText.text =
                "Name : " +
                MenuManager.Instance.playerName;
        }
    }
}