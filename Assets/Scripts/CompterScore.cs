using TMPro;
using UnityEngine;

public class CompterScore : MonoBehaviour
{
    int Score;
    public TextMeshProUGUI ScoreAffiche;

    void Start()
    {
        Score = 0;
    }

    public void CalculScore()
    {
        Score++;
        ScoreAffiche.text = Score.ToString();
    }
}
