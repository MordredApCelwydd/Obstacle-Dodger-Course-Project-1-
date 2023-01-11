using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private Color originalColor;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
                if(gameObject.tag != "Hit")
                {
                    gameObject.tag = "Hit";
                    originalColor = GetComponent<MeshRenderer>().material.color;    

                    GetComponent<MeshRenderer>().material.color = new Color(212/255f, 38/255f, 136/255f);

                    StartCoroutine(Waiter()); 
                }       
        }
    }

    IEnumerator Waiter()
    {
        yield return new WaitForSeconds(3);
        GetComponent<MeshRenderer>().material.color = originalColor;
    }
}
