using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreboardText;

    int Score = 0;

    public void IncreaseScore(int amount)
    {
       Score += amount;
       scoreboardText.text = Score.ToString();         
    }
}