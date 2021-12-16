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
        selectedOption++; //to display the gameobjects in an array

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

    private void UpdateMainTree(int selectedOption)//int: tell which obejct to draw, which one in the array.
    {
        MainTree mainTree = mainTreeDB.GetMainTree(selectedOption);//给实例赋值
        //Selected artwork and set the prefeb active
        int temp = mainTree.mainTreeIndex;
        PlayerManager.m_player.NotifyObservers("MainTree_" + temp);//在parameter里面加一个string，告诉obeserver应该做什么事情
        nameText.text = mainTree.mainTreeName;
    }
}
