using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerLevelOne : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private GameObject scoreDisplay;
    [SerializeField] private GameObject highScoreDisplay;

    void Start() {
        highScoreDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetInt("LevelOneHighScore", 0).ToString();
    }

    void Update(){
        scoreDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Coin")) {
            score++;
            if (score > PlayerPrefs.GetInt("LevelOneHighScore", 0)) {
                PlayerPrefs.SetInt("LevelOneHighScore", score);
                highScoreDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetInt("LevelOneHighScore", 0).ToString();
            }
            Debug.Log(score);
        }
    }
}
