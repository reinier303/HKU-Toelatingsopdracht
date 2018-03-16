using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMinigame : MonoBehaviour {

    public SaveStats Save;

    public void MinigameLoad(int sceneNumber)
    {
        Save.StatSave();
        SceneManager.LoadScene(sceneNumber);
    }
}
