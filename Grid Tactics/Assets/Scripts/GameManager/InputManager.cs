using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Class is reposnible for handling inputs 

public class InputManager : MonoBehaviour {

    private GridAdmin gridAdmin;
    [SerializeField] private LayerMask whatIsAGridLayer;


    private void Update() {
        GridCube cubeIsMouseIsOver = IsMouseOverAGridSpace();
        if (cubeIsMouseIsOver != null) {
            if (Input.GetMouseButtonDown(0)) {
                cubeIsMouseIsOver.GetComponent<MeshRenderer>().material.color = Color.green;
            }

        }

    }


    //Returning Grid cell if mouse is over grid cell & returns null if it not
    private GridCube IsMouseOverAGridSpace() {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hitInfo, 100f, whatIsAGridLayer)) {
            return hitInfo.transform.GetComponent<GridCube>();
        } else {

            return null;
        }

    }



}//Class
