using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CApiClient : MonoBehaviour {

    private bool isNetwork = false;

	// Use this for initialization
	void Start () {
		if(isNetwork == false)
        {
            InitCharacter();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void InitCharacter()
    {
        CModelCharacter modelCharacter = CModelCharacter.Instance;

        modelCharacter.Cnt = 6;

        modelCharacter.Orders = new string[6];
        modelCharacter.Orders[0] = "civil";
        modelCharacter.Orders[1] = "civil";
        modelCharacter.Orders[2] = "policer";
        modelCharacter.Orders[3] = "doctor";
        modelCharacter.Orders[4] = "mapia";
        modelCharacter.Orders[5] = "civil";

        modelCharacter.Names = new string[6];
        modelCharacter.Names[0] = "taeeun";
        modelCharacter.Names[1] = "hanul";
        modelCharacter.Names[2] = "sunho";
        modelCharacter.Names[3] = "sukhwan";
        modelCharacter.Names[4] = "suncheol";
        modelCharacter.Names[5] = "hyuckki";
    }
}
