using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class playerCollision : MonoBehaviour
{

    
    private UIManager uiManager;
    private gameManager gameManager;

    public int score = 0;
    public int maxScore = 5;

    FirstPersonController fps;


    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
        gameManager = FindObjectOfType<gameManager>();

        fps = FindObjectOfType<FirstPersonController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.CompareTag("Pickable"))
        {
            score++;

            Debug.Log("Objetos recojidos: " + score);

            uiManager.UpdateScore(score);

        Destroy(col.gameObject);
        }

        if (score >= maxScore)
        {
            uiManager.YouWinPanel();

            gameManager.FinalizarJuego();

            fps.enabled = false;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            Time.timeScale = 0f;
        }

    }
}
