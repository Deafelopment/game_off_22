using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Debug.Log("QUIT");
            Application.Quit();

        if (Input.GetKeyDown(KeyCode.N))
            SceneManager.LoadScene(1);
    }
}
