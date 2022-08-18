using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private Vector2 targetPos;
    public float Yincrement;

    public float speed;

    public float maxHeight;
    public float minHeight;

    public GameObject gameOver;

    public int health = 3;

    public GameObject healthDisplay;

    public GameObject dashSound;


    void Update(){
        healthDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = health.ToString();
        if(health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && transform.position.y < maxHeight)
        {
            Instantiate(dashSound, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        else if ((Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && transform.position.y > minHeight)
        {
            Instantiate(dashSound, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

}
