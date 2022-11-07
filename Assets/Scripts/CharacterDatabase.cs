using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CharacterDatabase : ScriptableObject
{
    public List<Character> Characters = new List<Character>(); // Database List for the Characters.

    public int CharacterCount
    {
        get
        {
            return Characters.Count; // returns the count of the 4 chaaracters
        }
    }

    public Character GetCharacter(int index)
    {
        return Characters[index];
    }
}