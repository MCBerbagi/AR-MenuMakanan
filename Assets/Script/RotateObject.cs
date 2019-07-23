using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour {

	public GameObject[] objectRotate;
	
	public float	   rotateSpeed = 50f;
	bool			   rotateStatus = false;

	public void Rotasi() {

		if (rotateStatus==false){
			rotateStatus = true;
		}
		else{
			rotateStatus = false;
		}
	}

	void Update() {
		if (rotateStatus == true) {
			objectRotate[0].transform.Rotate (Vector3.up, rotateSpeed * Time.deltaTime);
            objectRotate[1].transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            objectRotate[2].transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            objectRotate[3].transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            objectRotate[4].transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            objectRotate[5].transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            objectRotate[6].transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            objectRotate[7].transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            objectRotate[8].transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
	}
}
