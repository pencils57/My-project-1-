using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    List<Character> CharList = new List<Character>();
    void Start()
    {

        CreateCharacter(new Character("1", "1", 1, 1));
        CreateCharacter(new Character("2", "2", 2, 2));
        CreateCharacter(new Character("3", "3", 3, 3));

        RemoveCharacter(2);

        PrintAllCharacter();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CreateCharacter(Character character)
    {
        CharList.Add(character);
    }

    private void RemoveCharacter(int index)
    {
        CharList[index - 1] = null;
        //CharList.RemoveAt(index);
    }

    private void PrintAllCharacter()
    {
        int i = 0;

        while (i < CharList.Count)
        {
            if (CharList[i] == null)
            {
                Debug.Log("리스트가 비어있습니다.");
            }
            else
            {
                CharList[i].Getinfo();
            }
            i++;
        }
    }
}
