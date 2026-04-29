using TMPro;
using UnityEngine;

public class Scoring : MonoBehaviour
{
    public int score = 0;
    public TextMeshPro scoreText;

    public GameObject endScreen;
    public int winScore = 10;

    private bool gameEnded = false;

    private void OnTriggerEnter(Collider other)
    {
        if (gameEnded) return;

        if (other.CompareTag("Fruit"))
        {
            score += 1;
            scoreText.text = "Score: " + score;

            Debug.Log("Score: " + score);

            if (score >= winScore)
            {
                EndGame();
            }
        }
    }

    void EndGame()
    {
        gameEnded = true;

        endScreen.SetActive(true);

        Debug.Log("Game Over!");
    }
}