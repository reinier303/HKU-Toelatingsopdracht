using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScreen : MonoBehaviour {
    
    public void GoToNextScreen()
    {
        SceneManager.LoadScene("MainScene");
    }
}
