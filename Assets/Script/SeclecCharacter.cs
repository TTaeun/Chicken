using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeclecCharacter : MonoBehaviour {

    public int SelectedNum;

    private Player[] thePlayers;
    void Start()
    {
        thePlayers = FindObjectsOfType<Player>();
        selectCharacter();
    }
    public void selectCharacter()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i + " " + thePlayers[i].name);
            SelectedNum = Random.Range(0, 5);
            thePlayers[i].selectedNum = SelectedNum;
            for (int j = 0; j <i; j++) 
            {
                
                if (i != j && i != 0) 
                {
                    while (true)
                    {
                        if (thePlayers[i].selectedNum == thePlayers[j].selectedNum)
                        {
                            j = 0;
                            SelectedNum = Random.Range(0, 5);
                            thePlayers[i].selectedNum = SelectedNum;
                        }
                        else break;
                    }

                }
                

            }
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}


