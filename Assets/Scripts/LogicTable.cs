using System;
using TMPro;
using UnityEngine;

public class LogicTable : MonoBehaviour
{
    public TextMeshProUGUI ShowExampleFirstNumberText;
    public TextMeshProUGUI ShowExampleSecondNumberText;
    public int Number1;
    public int Number2;

    private System.Random random;
 
    public int TableCreative()
    {
        if (random == null)
            random = new System.Random();

        var number = random.Next(1, 9);
        return number;
    }

    public int ShowFirstExample()
    {
        int number = TableCreative();
        ShowExampleFirstNumberText.text = Convert.ToString(number);
        return number;
    }

    public int ShowSecondExample()
    {
        int number = TableCreative();
        ShowExampleSecondNumberText.text = Convert.ToString(number);
        return number;
    }

    public void ShowResultExample()
    {
        Debug.Log($"{Number1} x {Number2} = {Number1 * Number2}");
    }

    private void Start()
    {
        StartElements();
    }

    private void StartElements()
    {
        Number1 = ShowFirstExample();
        Number2 = ShowSecondExample();
        ShowResultExample();
    }
}