using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    public float timer = 60f;

    private UIManager uiManager;

    private void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;

            uiManager.UpdateTimer(timer);
        }
    }
}
