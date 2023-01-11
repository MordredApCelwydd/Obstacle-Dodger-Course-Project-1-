using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] private float timeBeforeFalling;
    [SerializeField] private float gravityDisableTimeMultiplier;
    private MeshRenderer meshRenderer;
    private Rigidbody rigidBody;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    void Update()
    {
        if(timeBeforeFalling <= Time.timeSinceLevelLoad)
        {
            rigidBody.useGravity = true;
            meshRenderer.enabled = true;
        }
        
        if(timeBeforeFalling * gravityDisableTimeMultiplier <= Time.timeSinceLevelLoad)
        {
            rigidBody.useGravity = false;
            rigidBody.isKinematic = true;
        }
    }
}
