using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public List <GameObject> characters;

    void Start()
    {
        int i = 0;
        foreach(GameObject character in characters)
        {
            character.GetComponent<Unit>().Id = i;
            i++;
        }
    }
}