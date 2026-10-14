using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PlayChinese () 
    {
        SceneManager.LoadScene(1);
    
    
    }
    public void PlayEnglish ()
    {
        SceneManager.LoadScene(2);


    }
    public void PlayMaths()
    {
        SceneManager.LoadScene(5);


    }
    public void PlayGeography()
    {
        SceneManager.LoadScene(3);


    }
    public void PlayMusic()
    {
        SceneManager.LoadScene(4);


    }
    public void PlayBiology()
    {
        SceneManager.LoadScene(6);


    }
    public void Quitgame()
    {
        Debug.Log("quit");
        Application.Quit();

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
