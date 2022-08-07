using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class that holds tile information

public class GridCube : MonoBehaviour {

    private int posX;
    private int posY;

    //saving reff to GO that gets placed on this cell
    /*    [SerializeField]*/
    private GameObject objectInThisGridSpace = null;

    //Saving reff is space is full
    private bool isOccuupied = false;

    //setting pos of cube
    public void SetPosition(int x, int y) {
        posX = x;
        posY = y;

    }

    //Getting pos
    private Vector2Int GetPosition() {

        return new Vector2Int(posX, posY);
    }


















}//Class
