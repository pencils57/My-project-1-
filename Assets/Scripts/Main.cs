using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    List<Character> CharList = new List<Character>();
    void Start()
    {
        for(int i = 0; i <= 2; i++)
        {
            CharList[i] = new Character("a", "b", 2, 3);
            CreateCharacter(CharList[i]);
        }

        PrintAllCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateCharacter( Character character)
    {
        character = new Character("a", "b", 2, 3);
    }

    private void RemoveCharacter(int index)
    {
        CharList[index] = null;
    }

    private void PrintAllCharacter()
    {
        CharList[0].Getinfo();
    }
}
