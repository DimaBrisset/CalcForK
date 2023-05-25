using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField] private Button _startGame;

    public void OnStartMenu()
    {
        if (!_startGame)
            return;
        SceneManager.LoadScene(1);
    }
}