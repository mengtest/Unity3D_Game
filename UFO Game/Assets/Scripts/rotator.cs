﻿using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime);
	}
}
