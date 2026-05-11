using TMPro;
using UnityEngine;

public class MainUI : MonoBehaviour
{
    public TextMeshProUGUI playerText;

    private void Start()
    {
        playerText.text =
            "Name: " + MenuManager.Instance.playerName;
    }
}