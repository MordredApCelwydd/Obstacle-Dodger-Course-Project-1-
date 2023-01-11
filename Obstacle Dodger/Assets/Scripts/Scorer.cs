using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Hit" && other.gameObject.tag != "Finish")
        {
            PlayerData.playerScore++;
        }
    }
}
