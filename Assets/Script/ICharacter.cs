using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ICharacter : MonoBehaviour {

   protected string job; //캐릭터의 직업
   // protected string playerName; //플레이어이름 (마피아가 죽일떄 필요)

   // protected bool isAlive; //생존여부
    


	// Use this for initialization
	void Start () {
		
	}

    virtual protected void Skill() 
    {
        Debug.Log("2");
    }


}
