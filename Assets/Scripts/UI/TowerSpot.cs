using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpot : MonoBehaviour
{
    public TowerSpotVariable selectedTowerSpot;
    public Unit myUnit;

    public void AddUnit(Unit newUnit) {
        myUnit = newUnit; // missing swap logic!!
        var newPos = transform.position;
        newPos.y = 1.0f;
        myUnit.positionRef.transform.position = newPos;
        myUnit.setIsBattling(true); // When added to a spot the unit is now battling!
    }

    private void OnMouseEnter() {
        selectedTowerSpot.Value = this;
    }

    private void OnMouseExit() {
        selectedTowerSpot.Value = null;
    }
}
