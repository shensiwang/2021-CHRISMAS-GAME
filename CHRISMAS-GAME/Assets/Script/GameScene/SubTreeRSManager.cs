using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubTreeRSManager : MonoBehaviour
{
    public SubTreeRSDataBase subTreeRSDB;
    public TextMeshProUGUI nameText;

    private int selectedOption;
    private string aMsg;

    //private void Start()
    //{
    //    if (!PlayerPrefs.HasKey("subTreeRS_selectedOption")) { selectedOption = -1; }
    //    else { Load(); }

    //    UpdateSubTreeRS(selectedOption);
    //}

    public void NextOption()
    {
        selectedOption++;
        if (selectedOption >= subTreeRSDB.SubTreeRSCount) { selectedOption = 0; }

        UpdateSubTreeRS(selectedOption);
    }

    public void BackOption()
    {
        selectedOption--;
        if (selectedOption < 0) { selectedOption = subTreeRSDB.SubTreeRSCount - 1; }

        UpdateSubTreeRS(selectedOption);
    }

    private void UpdateSubTreeRS(int selectedOption)
    {
        SubTreeRS subTreeRS = subTreeRSDB.GetSubTreeRS(selectedOption);
        aMsg = "SubTreeRS_" + subTreeRS.subTreeRSIndex;
        PlayerManager.m_player.NotifyObservers(aMsg);
        nameText.text = subTreeRS.subTreeRSName;
    }

    public void Load()
    {
        selectedOption = PlayerPrefs.GetInt("subTreeRS_selectedOption");
        aMsg = PlayerPrefs.GetString("subTreeRS_aMsg");
        UpdateSubTreeRS(selectedOption);
    }

    public void Save()
    {
        PlayerPrefs.SetInt("subTreeRS_selectedOption", selectedOption);
        PlayerPrefs.SetString("subTreeRS_aMsg", aMsg);
    }

    public void Clean()
    {
        PlayerPrefs.DeleteKey("subTreeRS_selectedOption");
        PlayerPrefs.DeleteKey("subTreeRS_aMsg");
    }
}
