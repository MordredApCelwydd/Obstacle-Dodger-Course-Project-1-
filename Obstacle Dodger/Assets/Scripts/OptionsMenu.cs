using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public void SetMovementSpeed(float speed)
    {
        GlobalSettings.movementSpeedSettings = speed;
    }

    public void SetRotationSpeed(float speed)
    {
        GlobalSettings.rotationSpeedSettings = speed;
    }

    public void SetMovementInversionMode(bool mode)
    {
        GlobalSettings.movementIsInvertedSettings = mode;
    }

    public void SetAdvancedControlsMode(bool mode)
    {
        GlobalSettings.advancedControlsSettings = mode;
    }
}
