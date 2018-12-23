using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPlayer
{
    protected string playerName; //플레이어이름 (마피아가 죽일떄 필요)
    protected bool isAlive; //생존여부

    public CPlayer(string _playerName)
    {
        playerName = _playerName;
        isAlive = true;
       

    }


}
