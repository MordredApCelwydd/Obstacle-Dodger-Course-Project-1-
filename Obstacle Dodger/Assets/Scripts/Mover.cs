

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mover : MonoBehaviour
{
    [SerializeField] float movementSpeed;
    [SerializeField] float rotationSpeed;
    [SerializeField] bool movementIsInverted;
    [SerializeField] bool advancedControls;

    private float xValue;
    private float yValue;
    private float zValue;

    void Start() 
    {
        PlayerData.playerScore = 0;

        if(GlobalSettings.settingsModeIsActive)
        {
            movementSpeed = GlobalSettings.movementSpeedSettings;
            rotationSpeed = GlobalSettings.rotationSpeedSettings;
            movementIsInverted = GlobalSettings.movementIsInvertedSettings;
            advancedControls = GlobalSettings.advancedControlsSettings;
        }
    }

    void Update()
    {
        if(!advancedControls)
        {
            classicMovePlayer();
        }
        else
        {
            advancedMovePlayer();
        }
        isReturnButtonPressed();
    }

    void classicMovePlayer()
    {
        
        xValue = Input.GetAxis("Horizontal") * Time.deltaTime * movementSpeed;
        zValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

        transform.Translate(xValue * (movementIsInverted ? -1 : 1), 0, zValue * (movementIsInverted ? -1 : 1));
    }

    void advancedMovePlayer()
    {

        zValue = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime * (movementIsInverted ? -1 : 1), 0, Space.Self);
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime * (movementIsInverted ? -1 : 1) * -1, 0, Space.Self);
        }

        transform.Translate(0, 0, zValue * (movementIsInverted ? -1 : 1));
    }

    void isReturnButtonPressed()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1, LoadSceneMode.Single);
        }
    }
}
