using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuScreenUI : MonoBehaviour {
    public GameObject howToPlay;
    public GameObject PlayGame;

    public void checkPanel()
    {
        howToPlay.SetActive(!howToPlay.activeInHierarchy);
    }

    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
}
