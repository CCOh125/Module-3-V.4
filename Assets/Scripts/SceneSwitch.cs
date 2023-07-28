using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class SceenSwitch : MonoBehaviour
{
    public int sceneID = 0;
    public void NextScene()
    {
        SceneManager.LoadScene(sceneID);
    }
}