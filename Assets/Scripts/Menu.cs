using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField] private Button _menuGame;

    public void OnStartMenu()
    {
        if (!_menuGame)
            return;
        SceneManager.LoadScene(0);
    }
}
