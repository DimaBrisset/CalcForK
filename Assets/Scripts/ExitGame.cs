using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
   [SerializeField] private Button _exitGame;


   public void OnExitGame()
   {
      if(!_exitGame) return;
      SceneManager.LoadScene(0);
   }
   
}
