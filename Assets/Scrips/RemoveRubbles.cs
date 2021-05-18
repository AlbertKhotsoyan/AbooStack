using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveRubbles : MonoBehaviour {

    private void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
    }
		
}
