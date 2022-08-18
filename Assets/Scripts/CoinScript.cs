using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int speed;

    public GameObject effect;

    public GameObject coinSound;

    void Update(){
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.CompareTag("Player")){
            Instantiate(effect, transform.position, Quaternion.identity);
            Instantiate(coinSound, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
