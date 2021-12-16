using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubTreeRBManager : MonoBehaviour
{
    public SubTreeRBDataBase subTreeRBDB;
    public TextMeshProUGUI nameText;

    private int selectedOption = -1;


    public void NextOption()
    {
        selectedOption++;

        if (selectedOption >= subTreeRBDB.SubTreeRBCount)
        {
            selectedOption = 0;
        }

        UpdateSubTreeRB(selectedOption);
    }

    public void BackOption()
    {
        selectedOption--;

        if (selectedOption < 0)
        {
            selectedOption = subTreeRBDB.SubTreeRBCount - 1;
        }

        UpdateSubTreeRB(selectedOption);
    }

    private void UpdateSubTreeRB(int selectedOption)
    {
        SubTreeRB subTreeRB = subTreeRBDB.GetSubTreeRB(selectedOption);
        //Selected artwork and set the prefeb active
        int temp = subTreeRB.subTreeRBIndex;
        PlayerManager.m_player.NotifyObservers("SubTreeRB_" + temp);
        nameText.text = subTreeRB.subTreeRBName;
    }
}
