using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundScript : MonoBehaviour
{
    public GameObject sparkleSound;

    public void SparkleSound(){
        Instantiate(sparkleSound, transform.position, Quaternion.identity);
    }
}
