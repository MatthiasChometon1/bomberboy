﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    public string LevelToLoad;

    public void LoadLevel()
    {
        Debug.Log(LevelToLoad);
        SceneManager.LoadScene(LevelToLoad);
    }
}
