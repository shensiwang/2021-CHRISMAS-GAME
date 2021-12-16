using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubTreeRSObserver : MonoBehaviour, IObserver
{
    public GameObject subtreers_0;
    public GameObject subtreers_1;
    public GameObject subtreers_2;
    public GameObject subtreers_3;


    private void Start()
    {
        PlayerManager.m_player.RegisterObserver(this);
        PlayerManager.m_player.NotifyObservers("SubTreeRS_-1");
    }

    public void Notify(string aMsg)
    {
        Debug.Log("SubTreeRS_" + aMsg);
        switch (aMsg)
        {
            case "SubTreeRS_-1":
                // DEFAULT SETTING
                subtreers_0.SetActive(false);
                subtreers_1.SetActive(false);
                subtreers_2.SetActive(false);
                subtreers_3.SetActive(false);
                break;

            case "SubTreeRS_0":
                subtreers_0.SetActive(true);
                subtreers_1.SetActive(false);
                subtreers_2.SetActive(false);
                subtreers_3.SetActive(false);
                break;

            case "SubTreeRS_1":
                subtreers_0.SetActive(false);
                subtreers_1.SetActive(true);
                subtreers_2.SetActive(false);
                subtreers_3.SetActive(false);
                break;

            case "SubTreeRS_2":
                subtreers_0.SetActive(false);
                subtreers_1.SetActive(false);
                subtreers_2.SetActive(true);
                subtreers_3.SetActive(false);
                break;

            case "SubTreeRS_3":
                subtreers_0.SetActive(false);
                subtreers_1.SetActive(false);
                subtreers_2.SetActive(false);
                subtreers_3.SetActive(true);
                break;
        }
    }
}
