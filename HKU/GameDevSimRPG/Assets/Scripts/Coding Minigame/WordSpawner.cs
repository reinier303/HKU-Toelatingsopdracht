using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

    public GameObject wordPrefab;
    public Transform wordCanvas;

    public CodingScoreKeeper codingScoreKeeper;

    public WordDisplay SpawnWord()
    {
        Vector3 randomPosition = new Vector3(Random.Range(200, (Screen.width - 200)), Random.Range(((Screen.height/2) - (Screen.height / 2.5f)), ((Screen.height/2) + (Screen.height / 2.5f))));

        if(codingScoreKeeper.Energy > 0)
        {
            GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);
            WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();
            return wordDisplay;
        }
        return null;      
    }
}
