using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    public void PlayLevelOne(){
        SceneManager.LoadScene(1);
    }
    public void PlayLevelTwo(){
        SceneManager.LoadScene(2);
    }
    public void PlayLevelThree(){
        SceneManager.LoadScene(3);
    }
}
