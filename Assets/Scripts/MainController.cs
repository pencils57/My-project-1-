using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    List<Character> CharList = new List<Character>();
    void Start()
    {
  
        CreateCharacter(new Character("1", "1", 1, 1));
        CreateCharacter(new Character("2", "2", 2, 3));
        CreateCharacter(new Character("3", "3", 3, 3));

        RemoveCharacter(1);

        PrintAllCharacter();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateCharacter( Character character)
    {
        CharList.Add(character);
    }

    private void RemoveCharacter(int index)
    {
        CharList[index] = null;
    }

    private void PrintAllCharacter()
    {
        for(int i = 0; i < CharList.Count; i++)
        {
            CharList[i].Getinfo();
        }
        
    }
}
