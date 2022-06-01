using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ManagerEnemies : MonoBehaviour
{
    public static ManagerEnemies ins;
    GameObject[] enemies;
    public Text score;

    private void Awake()
    {
        ins = this;
    }
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Opponent");

        score.text = "Enemies Left : " + enemies.Length.ToString();
        
        if (enemies.Length == 0)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
