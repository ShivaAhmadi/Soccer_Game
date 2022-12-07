using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    void Update()
    {
        
    }
    public void OnePlayer() {
        SceneManager.LoadScene("AIPlayer");
    }

    /*public void TwoPlayer() {
        SceneManager.LoadScene("ManualPlayer");
    }*/
}
