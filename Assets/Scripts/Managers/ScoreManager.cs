using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] TMP_Text scoreboardText;

    int Score = 0;

    public void IncreaseScore(int amount)
    {
        if(gameManager.GameOver) return;
        
       Score += amount;
       scoreboardText.text = Score.ToString();         
    }
}