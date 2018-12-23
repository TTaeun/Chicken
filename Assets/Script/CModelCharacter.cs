using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CModelCharacter : CSingletoneBase<CModelCharacter> 
{
    private int cnt;
    private string[] orders;
    private string[] names;

    public int Cnt
    {
        get
        {
            return cnt;
        }

        set
        {
            cnt = value;
        }
    }

    public string[] Orders
    {
        get
        {
            return orders;
        }

        set
        {
            orders = value;
        }
    }

    public string[] Names
    {
        get
        {
            return names;
        }

        set
        {
            names = value;
        }
    }
}
