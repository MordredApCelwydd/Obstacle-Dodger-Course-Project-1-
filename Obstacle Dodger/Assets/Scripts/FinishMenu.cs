using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class FinishMenu : MonoBehaviour
{

    public GameObject textmeshproCurrentText;
    private string bumpData;
    TextMeshProUGUI textmeshproNewText;

    void Awake() 
    {
        textmeshproNewText = textmeshproCurrentText.GetComponent<TextMeshProUGUI>();

        bumpData = "YOU'VE BUMPED INTO OTHER OBJECTS " + PlayerData.playerScore + " TIMES";

        textmeshproNewText.text = bumpData;
    }

    public void QuitMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2, LoadSceneMode.Single);
    }
}
