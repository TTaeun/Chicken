using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDoctor : ICharacter {

	// Use this for initialization
	void Start () {
        job = "doctor";

        Skill();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    private void Skill()
    {
        Debug.Log("1");
    }
}
