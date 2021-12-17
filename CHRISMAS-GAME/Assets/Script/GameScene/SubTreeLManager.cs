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
    private string aMsg;


    //private void Start()
    //{
    //    if (!PlayerPrefs.HasKey("subTreeL_selectedOption")) { selectedOption = -1; }
    //    else { Load(); }

    //    UpdatesubTreeL(selectedOption);
    //}

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
        aMsg = "SubTreeL_" + subTreeL.subTreeLIndex;
        PlayerManager.m_player.NotifyObservers(aMsg);
        nameText.text = subTreeL.subTreeLName;
    }

    public void Load()
    {
        selectedOption = PlayerPrefs.GetInt("subTreeL_selectedOption");
        aMsg = PlayerPrefs.GetString("subTreeL_aMsg");
    }

    public void Save()
    {
        PlayerPrefs.SetInt("subTreeL_selectedOption", selectedOption);
        PlayerPrefs.SetString("subTreeL_aMsg", aMsg);
    }

    public void Clean()
    {
        PlayerPrefs.DeleteKey("subTreeL_selectedOption");
        PlayerPrefs.DeleteKey("subTreeL_aMsg");
    }
}
