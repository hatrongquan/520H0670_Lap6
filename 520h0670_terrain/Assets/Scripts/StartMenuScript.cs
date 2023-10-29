using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour
{
    public FaderScript fader;

    IEnumerator ChangeLevel()
    {
        FaderScript faderScript = FindObjectOfType<FaderScript>();

        float fadeDuration = faderScript.BeginFade(1);

        yield return new WaitForSeconds(fadeDuration);

        SceneManager.LoadScene("TerrainGame");
    }

    void Start()
    {
        fader.BeginFade(-1);
    }

    public void StartGame()
    {
        StartCoroutine(ChangeLevel());
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Out Game");
    }


}
