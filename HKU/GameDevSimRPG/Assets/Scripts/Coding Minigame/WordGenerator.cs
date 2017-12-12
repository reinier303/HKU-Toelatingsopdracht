using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

    private static string[] wordList = {"if", "else", "bool", "var", "string", "int", "float", "double", "public", "private", "static", "void", "class",
                                        "using", "System", "UnityEngine", "array", "List", "while", "for", "EventSystem", "GameObject", "UI", "Text", "Slider",
                                        "Canvas" , "print", "Start", "Update", "IEnumerator", "namespace", "MonoBehaviour", "new", "Vector2", "Vector3",
                                        "Quaternion", "transform", "position", "rotation", "value", "color", "Destroy", "Instantiate", "return", "yield",
                                        "GetComponent", "forward", "up", "Find", "left", "right", "Debug", "log", "Time", "DeltaTime", "in", "Awake",
                                        "name", "index", "Application", "Level", "Collision", "Mathf", "Random", "Network", "Renderer", "RigidBody", "rect",
                                        "Screen", "Sprite", "Texture", "WaitFor"};

    public static string GetRandomWord()
    {
        int randomIndex = Random.Range(0,wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    } 
}
