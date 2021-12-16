using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubTreeLManager : MonoBehaviour
{
    public SubTreeLDataBase subTreeLDB;
    public TextMeshProUGUI nameText;

    private int selectedOption = -1;


    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= subTreeLDB.SubTreeLCount)
        {
            selectedOption = 0;
        }

        UpdatesubTreeL(selectedOption);
    }

    public void BackOption()
    {
        selectedOption--;

        if (selectedOption < 0)
        {
            selectedOption = subTreeLDB.SubTreeLCount - 1;
        }

        UpdatesubTreeL(selectedOption);
    }

    private void UpdatesubTreeL(int selectedOption)
    {
        SubTreeL subTreeL = subTreeLDB.GetSubTreeL(selectedOption);
        int temp = subTreeL.subTreeLIndex;
        PlayerManager.m_player.NotifyObservers("SubTreeL_" + temp);
        nameText.text = subTreeL.subTreeLName;
    }
}
