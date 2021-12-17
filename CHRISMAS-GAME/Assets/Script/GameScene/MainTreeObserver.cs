using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTreeObserver : MonoBehaviour, IObserver
{
    public GameObject maintree_0;
    public GameObject maintree_1;
    public GameObject maintree_2;
    public GameObject maintree_3;


    private void Start()
    {
        PlayerManager.m_player.RegisterObserver(this);
        PlayerManager.m_player.NotifyObservers("MainTree_-1");
    }

    public void Notify(string aMsg)
    {
        switch (aMsg)
        {
            case "MainTree_-1":
                // DEFAULT SETTING
                maintree_0.SetActive(false);
                maintree_1.SetActive(false);
                maintree_2.SetActive(false);
                maintree_3.SetActive(false);
                break;

            case "MainTree_0":
                maintree_0.SetActive(true);
                maintree_1.SetActive(false);
                maintree_2.SetActive(false);
                maintree_3.SetActive(false);
                break;

            case "MainTree_1":
                maintree_0.SetActive(false);
                maintree_1.SetActive(true);
                maintree_2.SetActive(false);
                maintree_3.SetActive(false);
                break;

            case "MainTree_2":
                maintree_0.SetActive(false);
                maintree_1.SetActive(false);
                maintree_2.SetActive(true);
                maintree_3.SetActive(false);
                break;

            case "MainTree_3":
                maintree_0.SetActive(false);
                maintree_1.SetActive(false);
                maintree_2.SetActive(false);
                maintree_3.SetActive(true);
                break;
        }
    }
}
