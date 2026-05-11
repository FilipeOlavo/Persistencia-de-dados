using TMPro;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    public TextMeshProUGUI playerText;

    private void Start()
    {
        playerText.text =
            "Player: " + MenuManager.Instance.playerName;
    }
}