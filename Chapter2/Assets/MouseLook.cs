using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

    public enum RotationAxes
    {
        MouseXAndY = 0,
        MouseX = 1,
        MouseY = 2
    };
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityHor = 9.0f;
    public float sensitivityVer = 9.0f;

    public float minimumVerticalAngle = -45.0f;
    public float maximumVerticalAngle = 45.0f;

    private float _rotationX = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityHor, 0);
        }
        else if (axes == RotationAxes.MouseY)
        {
            _rotationX -= Input.GetAxis("Mouse Y") * sensitivityVer;
            _rotationX = Mathf.Clamp(_rotationX, minimumVerticalAngle, maximumVerticalAngle);

            float rotationY = transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
        }
        else
        {

        }
	}
}
