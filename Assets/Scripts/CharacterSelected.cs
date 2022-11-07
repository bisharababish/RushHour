using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSelected : MonoBehaviour
{
    public GameObject[] allcharacters;
    void Start()
    {

        allcharacters[PlayerPrefs.GetInt("player", 0)].SetActive(true); // character prefab (Player) makes it active(visible) when selec
    }

    void Update()
    {
        
    }
}
