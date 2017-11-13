using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddRange : MonoBehaviour
{
    public Button rangeButton;
    int rangeAdd = 2;
    

    // Use this for initialization
    void Start ()
    {
        Button btnRange = rangeButton.GetComponent<Button>();
        btnRange.onClick.AddListener(AddRangeTest);
    }

    void AddRangeTest()
    {
        Turret.chosenTurret.GetComponent<Turret>().AddRange(rangeAdd);
    }
}
