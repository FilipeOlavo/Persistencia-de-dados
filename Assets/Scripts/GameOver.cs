/*void AddPoint(int point)
{
    m_Points += point;

    ScoreText.text = "Score : " + m_Points;
}

public void GameOver()
{
    m_GameOver = true;

    GameOverText.SetActive(true);

    if (m_Points > DataManager.Instance.bestScore)
    {
        DataManager.Instance.bestScore = m_Points;

        DataManager.Instance.bestPlayerName =
            MenuManager.Instance.playerName;

        DataManager.Instance.SaveDataFile();

        BestScoreText.text =
            "Best Score : " +
            DataManager.Instance.bestPlayerName +
            " : " +
            DataManager.Instance.bestScore;
    }
}
}*/