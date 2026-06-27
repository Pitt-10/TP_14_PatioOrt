using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class gameManager : MonoBehaviour
{
    public float timer = 60f;

    private UIManager uiManager;

    private bool JuegoFinalizado = false;

    private void Start()
    {
        Time.timeScale = 1f;
        uiManager = FindObjectOfType<UIManager>();
    }

    private void Update()
    {
        if (!JuegoFinalizado)
        {
        if (timer > 0)
            {
                timer -= Time.deltaTime;

                uiManager.UpdateTimer(timer);
            }
        
        else
        {
            timer = 0;
            uiManager.UpdateTimer(timer);

            JuegoFinalizado = true;

            uiManager.GameOverPanel();

            FindObjectOfType<FirstPersonController>().enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            Time.timeScale = 0f;
        }

        }
    
    }

    public void FinalizarJuego()
    {
        JuegoFinalizado = true;
    }

    public void ReiniciarJuego()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);    }
    
}
