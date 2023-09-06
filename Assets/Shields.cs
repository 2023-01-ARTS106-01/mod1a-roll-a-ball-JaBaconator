using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shields : MonoBehaviour {
    public GameObject shieldA;
    public GameObject shieldB;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Trigger")) {
            shieldA.gameObject.SetActive(false);
            shieldB.gameObject.SetActive(false);
            other.gameObject.SetActive(false);
        }
    }
}
