using System.IO;
using TMPro;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string bestPlayerName;
    public int bestScore;

    public TMP_Text bestScoreText;

    private string savePath;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);

        savePath =
            Application.persistentDataPath +
            "/savefile.json";

        LoadData();
    }

    private void Update()
    {
        if (bestScoreText != null)
        {
            bestScoreText.text =
                "Best Score : " +
                bestPlayerName +
                " : " +
                bestScore;
        }
    }

    [System.Serializable]
    class SaveFile
    {
        public string playerName;
        public int highScore;
    }

    public void SaveData()
    {
        SaveFile data = new SaveFile();

        data.playerName = bestPlayerName;
        data.highScore = bestScore;

        string json =
            JsonUtility.ToJson(data);

        File.WriteAllText(savePath, json);
    }

    public void LoadData()
    {
        if (File.Exists(savePath))
        {
            string json =
                File.ReadAllText(savePath);

            SaveFile data =
                JsonUtility.FromJson<SaveFile>(json);

            bestPlayerName =
                data.playerName;

            bestScore =
                data.highScore;
        }

        if (bestScoreText != null)
        {
            bestScoreText.text =
                "Best Score : " +
                bestPlayerName +
                " : " +
                bestScore;
        }
    }
}