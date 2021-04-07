using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scr : MonoBehaviour
{
     public void GamePlay(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

    public void GameQuit(){
      Debug.Log("quit!");
      Application.Quit();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
