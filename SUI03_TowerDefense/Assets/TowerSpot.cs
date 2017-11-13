using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpot : MonoBehaviour {

	void OnMouseUp()
    {
        Debug.Log("Tower");


        BuildingMenager bm = GameObject.FindObjectOfType<BuildingMenager>();
        if(bm.selectedTower != null)
        {
            //FIXME: Assume that object is nested in parent.
            Instantiate(bm.selectedTower, transform.parent.position, transform.parent.rotation);
            Destroy(transform.parent.gameObject);
        }
    }
}
