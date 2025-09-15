using UnityEngine;
using TMPro;

public class ScorePoint : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI leScore;
    public static int zero;
    // Update is called once per frame
    public void compter()
    {
        zero++;
        leScore.text = zero.ToString();
    }
}
