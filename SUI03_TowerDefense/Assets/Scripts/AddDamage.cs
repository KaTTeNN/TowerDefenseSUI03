using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddDamage : MonoBehaviour {

    public Button damageButton;
    int addDamage = 5;

    // Use this for initialization
    void Start()
    {
        Button btnDamage = damageButton.GetComponent<Button>();
        btnDamage.onClick.AddListener(AddDam);
    }

    void AddDam()
    {
        Turret.chosenTurret.GetComponent<Turret>().AddDamage(addDamage);
    }
}
