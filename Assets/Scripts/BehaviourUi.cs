using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BehaviourUi : MonoBehaviour
{
    public GameObject WinWindow;
    public GameObject LoseWindow;



    private void Awake()
    {
        GlobalEventManager.EndLevel.AddListener(EndOfLevel);
    }
    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(gameObject.scene.name);
    }

    public void EndOfLevel(string result)
    {
       
        if (result == "Win")
        {
            winWindow();

        }
        else if (result == "Lose")
        {
            loseWindow();
        }
        else {
            print(result + " What's wrong?");
        }
    }

    private void loseWindow()
    {
        LoseWindow.SetActive(true);
    }
    private void winWindow()
    {
        WinWindow.SetActive(true);
    }

}
