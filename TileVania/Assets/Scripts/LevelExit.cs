using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{    
    //config
    [SerializeField] private float LevelLoadDelay = 2f;
    [SerializeField] private float LevelExitSlowFactor = 0.2f;
    void OnTriggerEnter2D(Collider2D other)
    {
        StartCoroutine(LoadNextLevel());   
    }
    IEnumerator LoadNextLevel()
    {
        Time.timeScale = LevelExitSlowFactor;
        yield return new WaitForSecondsRealtime(LevelLoadDelay);
        Time.timeScale = 1f;
        var currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
