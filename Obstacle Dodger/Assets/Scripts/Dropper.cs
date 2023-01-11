using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeBeforeFalling;
    [SerializeField] private float gravityDisableTimeMultiplier;
    private MeshRenderer meshRenderer;
    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log(Time.time + "seconds has elapsed since the game started");
        if(timeBeforeFalling <= Time.time)
        {
            rigidBody.useGravity = true;
            meshRenderer.enabled = true;
        }
        
        if(timeBeforeFalling * gravityDisableTimeMultiplier <= Time.time)
        {
            rigidBody.useGravity = false;
            rigidBody.isKinematic = true;
        }
    }
}
