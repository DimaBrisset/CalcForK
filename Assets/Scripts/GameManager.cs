using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region MyRegion

    


    // [SerializeField] private Button _oneButton;
    //   [SerializeField] private Button _twoButton;
    //   [SerializeField] private Button _threeButton;
    //  [SerializeField] private Button _fourButton;
    //   [SerializeField] private Button _fiveButton;
    //   [SerializeField] private Button _sixButton;
    //   [SerializeField] private Button _sevenButton;
    //   [SerializeField] private Button _eightButton;
    //   [SerializeField] private Button _nineButton;
    //  [SerializeField] private Button _zeroButton;
    //  [SerializeField] private TextMeshProUGUI  _showText;
    //  [SerializeField] private string _calc;
    #endregion
    
    
    
    public TextMeshProUGUI InputText;
    private float _result;
    private float _input;
    private string _operation;
    
    public void ClickNumber(int val)
   
    
    {
        Debug.Log($"ClickNumber val: {val}");
        _operation+= val;
        InputText.text = $"{_operation}";
        
    }
    public void ClickEqual(string val)
    {
        Debug.Log($"ClickEqual val: {val}");
    }

    public void CleanLayout()
    {
        InputText.text="";
        _operation = "";
    }
}