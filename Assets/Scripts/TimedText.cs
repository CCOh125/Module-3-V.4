﻿/*
This script is used for toggling on a UI Text component for a certain duration of time.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimedText : MonoBehaviour
{
    public TMP_Text ChosenText;
    public float Duration = 1f;
    
    void Start()
    {
        ChosenText.gameObject.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(timer());
    }

    IEnumerator timer()
    {
        ChosenText.gameObject.SetActive(true);
        
        yield return new WaitForSeconds(Duration);

        ChosenText.gameObject.SetActive(false);
    }
}
