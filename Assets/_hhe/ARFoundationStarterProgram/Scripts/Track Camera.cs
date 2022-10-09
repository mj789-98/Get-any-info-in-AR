using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
  private Transform _transform;
    private Transform _target;
    
   /* public Transform Target
    {
        get => _target;
        set => _target = value;
    }
*/
    private void Start()
    {
        _transform = transform;
        _target = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }


    // Update is called once per frame
    void Update()
    {
        _transform.Translate(_target.position * (1f * Time.deltaTime), Space.Self);
    }
}
