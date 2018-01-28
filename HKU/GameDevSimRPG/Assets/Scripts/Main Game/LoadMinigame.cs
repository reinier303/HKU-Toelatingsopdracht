using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMinigame : MonoBehaviour {

    public void MinigameLoad(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }
}
