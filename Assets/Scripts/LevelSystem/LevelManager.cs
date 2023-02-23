using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
   

    [SerializeField]
    private GameObject cubes;

   
    private void Update()
    {
        LevelUp();
    }

    public void LevelUp()
    {
        if (cubes.transform.childCount == 0)
        {
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);
        }
    }
}
