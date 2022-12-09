using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Lift : MonoBehaviour
{
    public Text groundf;
    public Text floor1;
    public Text floor2;
    public Text floor3;
    public Text floor4;
    public Text floor5;
    public Text floor6;
    public Text floor7;
    public Text floor8;
    public Text floor9;

    bool fl = false;    
    bool fl0 = false;
    bool fl1 = false;
    bool fl2 = false;
    bool fl3 = false;
    bool fl4 = false;
    bool fl5 = false;
    bool fl6 = false;
    bool fl7 = false;
    bool fl8 = false;
    bool fl9 = false;

    public Vector2 targetFloor0;
    public GameObject box;
    public float speed = 4.0f;
    public GameObject[] grasses;
    float moveDir = 0;
   
    void Start()
    {
        groundf.text = "groundf";
        floor1.text = "floor1";
        floor2.text = "floor2";
        floor3.text = "floor3";
        floor4.text = "floor4";
        floor5.text = "floor5";
        floor6.text = "floor6";
        floor7.text = "floor7";
        floor8.text = "floor8";
        floor9.text = "floor9";
    }
    public void OnButtonClick(string floor)
    {
        Debug.Log(floor);
        switch (floor)
        {
            case "groundf": fl = true; targetFloor0 = new Vector2(grasses[0].transform.position.x + 200, grasses[0].transform.position.y); break;
            case "floor1": fl = true; targetFloor0 = new Vector2(grasses[1].transform.position.x + 200, grasses[1].transform.position.y); break;
            case "floor2": fl = true; targetFloor0 = new Vector2(grasses[2].transform.position.x + 200, grasses[2].transform.position.y); break;
            case "floor3": fl = true; targetFloor0 = new Vector2(grasses[3].transform.position.x + 200, grasses[3].transform.position.y); break;
            case "floor4": fl = true; targetFloor0 = new Vector2(grasses[4].transform.position.x + 200, grasses[4].transform.position.y); break;
            case "floor5": fl = true; targetFloor0 = new Vector2(grasses[5].transform.position.x + 200, grasses[5].transform.position.y); break;
            case "floor6": fl = true; targetFloor0 = new Vector2(grasses[6].transform.position.x + 200, grasses[6].transform.position.y); break;
            case "floor7": fl = true; targetFloor0 = new Vector2(grasses[7].transform.position.x + 200, grasses[7].transform.position.y); break;
            case "floor8": fl= true; targetFloor0 = new Vector2(grasses[8].transform.position.x + 200, grasses[8].transform.position.y); break;
            case "floor9": fl = true; targetFloor0 = new Vector2(grasses[9].transform.position.x + 200, grasses[9].transform.position.y); break;
        }
       
    }
    
    void Update()
    {
        float step = speed * Time.deltaTime*30;
        if (fl)
        {
            if (box.transform.position.y != targetFloor0.y)
                box.transform.position = Vector2.MoveTowards(box.transform.position, targetFloor0, step);
            else
                fl = false;
        }
    }

}
 