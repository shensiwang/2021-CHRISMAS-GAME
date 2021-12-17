using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubTreeRBObserver : MonoBehaviour, IObserver
{
    public GameObject subtreerb_0;
    public GameObject subtreerb_1;
    public GameObject subtreerb_2;
    public GameObject subtreerb_3;


    private void Start()
    {
        PlayerManager.m_player.RegisterObserver(this);
        PlayerManager.m_player.NotifyObservers("SubTreeRB_-1");
    }

    public void Notify(string aMsg)
    {
        switch (aMsg)
        {
            case "SubTreeRB_-1":
                // DEFAULT SETTING
                subtreerb_0.SetActive(false);
                subtreerb_1.SetActive(false);
                subtreerb_2.SetActive(false);
                subtreerb_3.SetActive(false);
                break;

            case "SubTreeRB_0":
                subtreerb_0.SetActive(true);
                subtreerb_1.SetActive(false);
                subtreerb_2.SetActive(false);
                subtreerb_3.SetActive(false);
                break;

            case "SubTreeRB_1":
                subtreerb_0.SetActive(false);
                subtreerb_1.SetActive(true);
                subtreerb_2.SetActive(false);
                subtreerb_3.SetActive(false);
                break;

            case "SubTreeRB_2":
                subtreerb_0.SetActive(false);
                subtreerb_1.SetActive(false);
                subtreerb_2.SetActive(true);
                subtreerb_3.SetActive(false);
                break;

            case "SubTreeRB_3":
                subtreerb_0.SetActive(false);
                subtreerb_1.SetActive(false);
                subtreerb_2.SetActive(false);
                subtreerb_3.SetActive(true);
                break;
        }
    }
}
