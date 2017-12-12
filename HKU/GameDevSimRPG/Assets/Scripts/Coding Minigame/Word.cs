using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Word{

    
    public string word;
    private int typeIndex;

    public CodingScoreKeeper codingScoreKeeper;

    private WordDisplay display;

    public Word(string _word, WordDisplay _display)
    {
        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;

        display.RemoveLetter();
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if(wordTyped)
        {
            if(codingScoreKeeper == null)
            {
                codingScoreKeeper = GameObject.Find("Canvas").GetComponent<CodingScoreKeeper>();
            }
            display.RemoveWord();
            codingScoreKeeper.Score += codingScoreKeeper.scoreToGive;
            codingScoreKeeper.scoreToGive += 10;
            codingScoreKeeper.EnergyCounter++;
        }
        return wordTyped;
    }
}
