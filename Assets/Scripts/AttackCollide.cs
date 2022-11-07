using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollide : MonoBehaviour
{ 
         void OnCollisionEnter2D(Collision2D coll) {
         if (coll.gameObject.tag == "Enemy")  // takes the tag of the enemy and once the character hits the Object (Enemy Charcter ) it disappears. ( the code will be in Player Character).
             Destroy(coll.gameObject);
     }
 
    }
 
