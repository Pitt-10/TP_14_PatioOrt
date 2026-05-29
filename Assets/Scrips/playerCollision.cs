using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{

    
    private UIManager uiManager;

    public int score = 0;

    private void Awake()
    {
        uiManager = FindObjectOfType<UIManager>();
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

    }
}
