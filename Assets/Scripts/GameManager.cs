using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI InputText;
    private float _result;
    private float _input;
    private string _operation;
    private int _checkLengthUserInput;

    public void ClickNumber(int val)
    {
        Debug.Log($"ClickNumber val: {val}");
        _operation += val;
        InputText.text = $"{_operation}";
        
        _checkLengthUserInput = Convert.ToInt32(_operation);
        if (_checkLengthUserInput > 999)
        {
            CleanLayout();
        }
       }

    public void ClickEqual(string val)
    {
      
        Debug.Log($"ClickEqual val: {val}");
    }

 

    public void CleanLayout()
    {
        InputText.text = "";
        _operation = "";
    }
}