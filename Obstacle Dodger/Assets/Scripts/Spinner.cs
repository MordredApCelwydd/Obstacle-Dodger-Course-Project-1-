using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] private float xValue;
    [SerializeField] private float yValue;
    [SerializeField] private float zValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue * Time.deltaTime, yValue * Time.deltaTime, zValue * Time.deltaTime, Space.Self);
    }
}
