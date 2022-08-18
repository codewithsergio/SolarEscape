using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public GameObject gameOverSound;
    private void Start(){
        Instantiate(gameOverSound, transform.position, Quaternion.identity);
    }
    private void Update() {
        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        } else if (Input.GetKeyDown(KeyCode.Q)) {
            SceneManager.LoadScene(0);
        }
    }

}
