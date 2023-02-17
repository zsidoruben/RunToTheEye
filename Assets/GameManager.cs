using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject lose;
    public GameObject win;
    public void Restart()
    {
        lose.SetActive(true);
    }

    public void ReloadScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Win() {
        win.SetActive(true);
    }
}
