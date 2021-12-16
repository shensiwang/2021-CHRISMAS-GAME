using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainTreeManager : MonoBehaviour
{
    public MainTreeDataBase mainTreeDB;
    public TextMeshProUGUI nameText;

    private int selectedOption = -1;


    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= mainTreeDB.MainTreeCount)
        {
            selectedOption = 0;
        }

        UpdateMainTree(selectedOption);
    }

    public void BackOption()
    {
        selectedOption--;

        if (selectedOption < 0)
        {
            selectedOption = mainTreeDB.MainTreeCount - 1;
        }

        UpdateMainTree(selectedOption);
    }

    private void UpdateMainTree(int selectedOption)
    {
        MainTree mainTree = mainTreeDB.GetMainTree(selectedOption);
        //Selected artwork and set the prefeb active
        int temp = mainTree.mainTreeIndex;
        PlayerManager.m_player.NotifyObservers("MainTree_" + temp);
        nameText.text = mainTree.mainTreeName;
    }
}
