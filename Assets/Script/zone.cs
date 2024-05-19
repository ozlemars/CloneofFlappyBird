using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zone : MonoBehaviour
{
    public GameObject GameOverScreen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
