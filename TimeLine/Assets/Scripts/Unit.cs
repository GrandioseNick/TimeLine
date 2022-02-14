using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;

    public int speed;
    public int stamina;
    public int mana;

    private float currentspeed;
    private float currentstamina;
    private float currentmana;
    //public List<Transform> movesSpots = new List<Transform>();
    public GameObject movetile;
    public GameObject actiontile;

    private bool hovering;
    private bool canact;
    private bool acting;
    private bool placeMove;
    private bool placeAction;

  
    // Start is called before the first frame update
    void Start()
    { 
        currentstamina = stamina;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (canact == true && acting == false)
        {
            currentmana++;
        }
        if (Input.GetMouseButton(0) && hovering == true)
        {
            Debug.Log("Begin Movement targeting");
            hovering = false;

        }
        if (Input.GetMouseButton(1) && hovering == true)
        {
            Debug.Log("Begin Action targeting");
            hovering = false;

        }
        if (Input.GetMouseButton(0) && placeMove == true)
        {
            GameObject Movement = Instantiate(movetile);
        }
        if (Input.GetMouseButton(1) && placeAction == true)
        {
            
        }
    }
    private void OnMouseEnter()
    {
        hovering = true;
    }
    private void OnMouseExit()
    {
        hovering = false;
    }
    
}
