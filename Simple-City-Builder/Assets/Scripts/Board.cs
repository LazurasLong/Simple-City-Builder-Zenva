using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

    private Building[,] buildings = new Building[100,100];

	public void AddBuilding(Building building, Vector3 position)
    {
        Building buildingToAdd = Instantiate(building, position, Quaternion.identity);
        buildings[(int)position.x, (int)position.z] = buildingToAdd;
    }

    public bool CheckForBuildingAtPosition(Vector3 position)
    {
        return buildings[(int)position.x, (int)position.z] != null;
    }
    public Vector3 CalculateGridPosition(Vector3 position)
    {
        return new Vector3(Mathf.Round(position.x), .25f, Mathf.Round(position.z));
    }
}
