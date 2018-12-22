using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMapia : MonoBehaviour {

    public int SelectedNum;
    public enum Character {
        Mapia, helper, policer, civil1, civil2
    }
	void Start () {
        SelectedNum = Random.Range(0, 5);	
	}
    public void selectCharacter()
    {
        for (int i = 0; i < 5; i++)
        {
            
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
