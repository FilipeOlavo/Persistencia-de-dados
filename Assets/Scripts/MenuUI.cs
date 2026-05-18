using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUI : MonoBehaviour
{
    public TMP_InputField inputName;

    public void StartGame()
    {
        MenuManager.Instance.playerName =
            inputName.text;

        SceneManager.LoadScene(1);
    }
}