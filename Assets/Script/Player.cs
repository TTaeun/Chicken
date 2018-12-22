using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour {
   
    private Player[] thePlayer;
    [SerializeField]
    private GameObject MapiaKill;
    [SerializeField]
    private InputField KillName;
    public string character;
    public int selectedNum;
    public enum Character
    {
        Mapia, helper, policer, civil1, civil2
    }
    private void job(Character i){
        switch(i)
        {
            case Character.Mapia :
                character = "Mapia";
                break;
            case Character.helper:
                character = "helper";
                break;
            case Character.policer:
                character = "policer";
                break;
            case Character.civil1:
                character = "civil1";
                break;
            case Character.civil2:
                character = "civil2";
                break;

        } 

    }
    public void Kill()
    {

        if (gameObject.name == "Player1" && character == "Mapia")
        {
            MapiaKill.SetActive(true);
        }
        for (int i=0; i <thePlayer.Length;i++)
        {
            if (KillName.text == thePlayer[i].name && thePlayer[i].character != "Mapia") 
            {
                Debug.Log("죽"+KillName.text);
                thePlayer[i].gameObject.SetActive(false);
                Debug.Log(gameObject.name + "사망하셨습니다");
                MapiaKill.SetActive(false);
                break;
                
            }
            
        }
       
        
    }
	// Use this for initialization
	void Start () {
        thePlayer = FindObjectsOfType<Player>();
        job((Character)selectedNum);

    }
	
	// Update is called once per frame
	void Update () {
      
	}
}
