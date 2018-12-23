using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JeJus : MonoBehaviour {
    [SerializeField]
    private GameObject[] managers;

	// Use this for initialization
	void Start () {
        InitManagers();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void InitManagers()
    {
        for(int i = 0; i < managers.Length; ++i) {
            Instantiate(managers[i]);
        }
    }
}
