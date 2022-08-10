using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;
    [SerializeField]
    private GameObject FollowThisObject;

    [SerializeField]
    Vector3 _cameraOffSet;
    [SerializeField]
    bool _lockCameraToTarget;
    [SerializeField]
    float _speed;
    [SerializeField]
    bool _rotateCameraTowardsTarget;
    [SerializeField]
    Vector3 ManualCameraRotation;
    private void Start()
    {

    }

    private void Update()
    {
        if (_rotateCameraTowardsTarget)
        {
            _camera.transform.LookAt(FollowThisObject.transform);
        }
        else
        {
            _camera.transform.rotation = Quaternion.Euler(ManualCameraRotation.x, ManualCameraRotation.y, ManualCameraRotation.z);
        }
        //
        if (_lockCameraToTarget)
        {
            _camera.transform.position = FollowThisObject.transform.position + _cameraOffSet;
        }
        else 
        {
            //_camera.transform.position = Vector3.MoveTowards(_camera.transform.position, FollowThisObject.transform.position + _cameraOffSet, _speed * Time.deltaTime);
            _camera.transform.position = Vector3.Lerp(_camera.transform.position, FollowThisObject.transform.position + _cameraOffSet, _speed * Time.deltaTime);
        }
    }
    
}
