using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharterSelection : MonoBehaviour
{

    public GameObject[] AllCharacters;
    int count = 0;
    private void Start()
    {
        PlayerPrefs.SetInt("player", 0);
    }

    public void NextCharacter()
    {
        // this method it uses the next button to change into the 4 characters.
        //it goes from the first player till 4th Player,you have to go back by  using the previous button.
        count++; 
       if(count>=AllCharacters.Length) 
        {
           count = AllCharacters.Length-1;
           
        }
       for(int i=0;i<AllCharacters.Length;i++)
        {
            AllCharacters[i].SetActive(false); // it makes the last character chosen invisible.
        }

        PlayerPrefs.SetInt("player", count);
        AllCharacters[count].SetActive(true); // makes the next players visible.
    }
    public void PreviousCharacter() 
    {
        // same method as above but the side ways
        // it goes from the 4th player till 1.
        count--;
        for (int i = 0; i < AllCharacters.Length; i++)
        {
            AllCharacters[i].SetActive(false);
        }
        if (count <0)
        {
            count = 0;

            
        }
        PlayerPrefs.SetInt("player", count);

        AllCharacters[count].SetActive(true);
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(1); // it loads the first level, which is called "level_1"
    }
}
