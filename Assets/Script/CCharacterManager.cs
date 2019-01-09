using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CData
{
    public int cnt;
    public string[] orders;
    public string[] names;
   
    public CData()
    {
        cnt = 6;

        orders = new string[6];
        orders[0] = "civil2";
        orders[1] = "civil1";
        orders[2] = "policer";
        orders[3] = "doctor";
        orders[4] = "mapia";
        orders[5] = "civil3";
        names = new string[6];
        names[0] = "taeeun";
        names[1] = "hanul";
        names[2] = "sunho";
        names[3] = "sukhwan";
        names[4] = "suncheol";
        names[5] = "hyuckki";
    }


}

public class CCharacterManager : MonoBehaviour {
    [SerializeField]
    private GameObject[] characters;
    public GameObject[] abc;
    public Text[] text;
    CData data;
  
    Vector2[] vectors;
    // Use this for initialization
    

    void Start()
    {
        
        data = new CData();

        vectors = new Vector2[6];

        for(int i = 0; i < 6; ++i)
        {
            vectors[i] = abc[i].gameObject.transform.position;
        }

        Init(data);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Init(CData data)
    {
        int type;
        for (int i = 0; i < data.cnt; ++i)
        {
            switch (data.orders[i])
            {
                case "civil1":
                    type = 0;
                    break;
                case "civil2":
                    type = 1;
                    break;
                case "civil3":
                    type = 2;
                    break;
                case "doctor":
                    type = 3;
                    break;
                case "policer":
                    type = 4;
                    break;
                default:
                    type = 5;
                    break;

            }
            GameObject clone = Instantiate(characters[type], vectors[i], Quaternion.identity) as GameObject;
            clone.transform.parent = abc[i].transform;
            clone.transform.localScale = abc[i].transform.localScale * 0.92f;
            text[i].text = data.names[i];
           
            clone.name = data.names[i];
        }
    }
}
