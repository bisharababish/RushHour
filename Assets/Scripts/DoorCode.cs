using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorCode : MonoBehaviour
{
    public int  ILevelToLoad; //  if 0 it won't work, mkes the door as a loader.( works as 1 and 0)
    public string sLevelToLoad; // typing the level name in the inspector and once the character hits the door he goes to next level.

    public bool useIntegerToLoadLevel = false;
    void Start()
    {
    }
	private void OnTriggerEnter2D(Collider2D  col)
    {
        GameObject collisionGameObject = col.gameObject;
        // if these characters hits the door they go to level_2 and so on.
        if ( (collisionGameObject.name == "Soldier") || (collisionGameObject.name == "Ninja")|| (collisionGameObject.name == "Wizard")|| (collisionGameObject.name == "LightBandit"))
        {
            LoadScene();
        } 
    	}

        void LoadScene(){
            // if ILevelToLoad is 1 then turn on the sLevelToLoad.
            if ( useIntegerToLoadLevel){
                SceneManager.LoadScene(ILevelToLoad);
            }
            else
            {
                SceneManager.LoadScene(sLevelToLoad);
            }
        }
    }

