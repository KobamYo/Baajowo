using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultySelector : MonoBehaviour
{
    public void OpenGampang()
    {
        SceneManager.LoadScene("Gampang");
    }

    public void OpenSedang()
    {
        SceneManager.LoadScene("Sedang");
    }

    public void OpenAngel()
    {
        SceneManager.LoadScene("Angel");
    }

    public void BackToDifficulty()
    {
        SceneManager.LoadScene("Difficulty");
    }
}
