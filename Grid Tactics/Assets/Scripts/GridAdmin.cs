using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Responsible for managing the grid and spawning

public class GridAdmin : MonoBehaviour {

    [SerializeField]
    private int height;
    [SerializeField]
    private int width;
    [SerializeField]
    private float GridOffsetSpace;

    [SerializeField]
    private GameObject gridCellPrefab;

    [SerializeField]
    private Transform _camera;

    private GameObject[,] gameGrid;

    private void Start() {
        SpawnPrefab();

    }

    private void SpawnPrefab() {

        gameGrid = new GameObject[height, width];

        //Edge cases
        if (gridCellPrefab == null)
            Debug.LogError("Error: No Prefab assigned");

        //Spawning Grid
        for (int y = 0; y < height; y++) {
            for (int x = 0; x < width; x++) {

                gameGrid[x, y] = Instantiate(gridCellPrefab, new Vector3(x * GridOffsetSpace, y * GridOffsetSpace),
                    Quaternion.identity);
                gameGrid[x, y].GetComponent<GridCube>().SetPosition(x, y);
                gameGrid[x, y].transform.parent = transform;
                gameGrid[x, y].gameObject.name = "Grid Space (X: " + x.ToString() + ", Y: " + y.ToString() + " ) ";

            }
        }

        _camera.transform.position = new Vector3((float)height / 2 - -3f, (float)width / 2 - -4f, -20);


    }

    //Getting gridpos from world pos































}//Class
