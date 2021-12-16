using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerManager
{
    public static Initializer m_player;

    public static void SetPlayer(Initializer m_player)
    {
        PlayerManager.m_player = m_player;
    }
}
