using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddFireRate : MonoBehaviour
{
    public Button fireRateButton;

    // Use this for initialization
    void Start()
    {
        Button btnFireRate = fireRateButton.GetComponent<Button>();
        btnFireRate.onClick.AddListener(AddFire);
    }

    void AddFire()
    {
        Turret.chosenTurret.GetComponent<Turret>().AddFireRate(5);
    }

}
