using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubTreeRSManager : MonoBehaviour
{
    public SubTreeRSDataBase subTreeRSDB;
    public TextMeshProUGUI nameText;

    private int selectedOption = -1;


    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= subTreeRSDB.SubTreeRSCount)
        {
            selectedOption = 0;
        }

        UpdateSubTreeRS(selectedOption);
    }

    public void BackOption()
    {
        selectedOption--;

        if (selectedOption < 0)
        {
            selectedOption = subTreeRSDB.SubTreeRSCount - 1;
        }

        UpdateSubTreeRS(selectedOption);
    }

    private void UpdateSubTreeRS(int selectedOption)
    {
        SubTreeRS subTreeRS = subTreeRSDB.GetSubTreeRS(selectedOption);
        //Selected artwork and set the prefeb active
        int temp = subTreeRS.subTreeRSIndex;
        PlayerManager.m_player.NotifyObservers("SubTreeRS_" + temp);
        nameText.text = subTreeRS.subTreeRSName;
    }
}
