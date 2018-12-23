using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDoctor : ICharacter {

	// Use this for initialization
	void Start () {
        job = "doctor";

        OnSkill();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    override protected void OnSkill()
    {
        Debug.Log("1");
    }
}
