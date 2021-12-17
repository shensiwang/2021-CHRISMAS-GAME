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
    private string aMsg;


    //private void Start()
    //{
    //    if (!PlayerPrefs.HasKey("subTreeRB_selectedOption")) { selectedOption = -1; }
    //    else { Load(); }

    //    UpdateSubTreeRB(selectedOption);
    //}

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
        aMsg = "SubTreeRB_" + subTreeRB.subTreeRBIndex;
        PlayerManager.m_player.NotifyObservers(aMsg);
        nameText.text = subTreeRB.subTreeRBName;
    }

    public void Load()
    {
        selectedOption = PlayerPrefs.GetInt("subTreeRB_selectedOption");
        aMsg = PlayerPrefs.GetString("subTreeRB_aMsg");
    }

    public void Save()
    {
        PlayerPrefs.SetInt("subTreeRB_selectedOption", selectedOption);
        PlayerPrefs.SetString("subTreeRB_aMsg", aMsg);
    }

    public void Clean()
    {
        PlayerPrefs.DeleteKey("subTreeRB_selectedOption");
        PlayerPrefs.DeleteKey("subTreeRB_aMsg");
    }
}
