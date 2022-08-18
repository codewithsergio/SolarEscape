using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsHighScores : MonoBehaviour
{
    [SerializeField] private GameObject highScore1Display;
    [SerializeField] private GameObject highScore2Display;
    [SerializeField] private GameObject highScore3Display;

    public void Start() {
        highScore1Display.GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetInt("LevelOneHighScore", 0).ToString();
        highScore2Display.GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetInt("LevelTwoHighScore", 0).ToString();
        highScore3Display.GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetInt("LevelThreeHighScore", 0).ToString();
    }
}
