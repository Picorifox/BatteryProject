﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWalls : MonoBehaviour
{
    private bool activate = false;

    private bool setup = false;

    public List<GameObject> walls;

	void Start ()
    {
        
    }
	
	
	void Update ()
    {
        if (GameObject.Find("Moveable Walls") != null && setup != true)
        {
            //Transform[] ts = GameObject.Find("Moveable Walls").gameObject.GetComponentsInChildren<Transform>();
            //foreach (Transform t in ts)
            //{
            //    if (t != null && t.gameObject != null)
            //    {
            //        walls.Add(t.gameObject);
            //    }
            //}
            for(int i = 0; i < GameObject.Find("Moveable Walls").transform.childCount; i++)
            {
                walls.Add(GameObject.Find("Moveable Walls").transform.GetChild(i).gameObject);
            }

            if(walls != null)
            {
                setup = true;
            }
        }

        if (activate == true)
        {
            //foreach (GameObject child in walls)
            //{
            //    //Debug.Log("Move");
            //    //Debug.Log(child.transform);
            //    child.GetComponent<Movement>().Move();
            //}
            for (int i = 0; i < walls.Count; i++)
            {
                walls[i].GetComponent<Movement>().Move();
            }

            activate = false;
        }
	}

    public bool Activate
    {
        get
        {
            return activate;
        }
        set
        {
            activate = value;
        }
    }
}