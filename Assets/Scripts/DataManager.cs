using System;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public string bestPlayerName;
    public int bestScore;

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
            Application.persistentDataPath + "/savefile.json";

        LoadData();
    }

    public void SaveData()
    {
        SaveData data = new SaveData();

        data.playerName = bestPlayerName;
        data.highScore = bestScore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(savePath, json);
    }

    public void LoadData()
    {
        if (File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);

            SaveData data =
                JsonUtility.FromJson<SaveData>(json);

            bestPlayerName = data.playerName;
            bestScore = data.highScore;
        }
    }

    internal void SaveDataFile()
    {
        throw new NotImplementedException();
    }
}