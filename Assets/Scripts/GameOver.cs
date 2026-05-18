/* void GameOver()
{
    m_GameOver = true;

    GameOverText.SetActive(true);

    Debug.Log("GAME OVER");

    Debug.Log("Pontos: " + m_Points);

    Debug.Log("Best atual: " +
        DataManager.Instance.bestScore);

    if (m_Points > DataManager.Instance.bestScore)
    {
        Debug.Log("NOVO RECORDE");

        DataManager.Instance.bestScore = m_Points;

        if (MenuManager.Instance != null)
        {
            DataManager.Instance.bestPlayerName =
                MenuManager.Instance.playerName;
        }

        DataManager.Instance.SaveData();

        BestScoreText.text =
            "Best Score : " +
            DataManager.Instance.bestPlayerName +
            " : " +
            DataManager.Instance.bestScore;
    }
}*/