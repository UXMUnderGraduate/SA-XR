using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CFollowCamera : MonoBehaviour
{

    // public Transform target;

    // private Transform tr;

    public float cameraSpeed = 5.0f;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //tr = GetComponent <Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = player.transform.position - this.transform.position;
        Vector3 moveVector = new Vector3(dir.x * cameraSpeed * Time.deltaTime, dir.y * cameraSpeed * Time.deltaTime, dir.z * cameraSpeed * Time.deltaTime);
        this.transform.Translate(moveVector);
    }
    void LateUpdate()
    {
      /*  tr.position = new Vector3(target.position.x - 0.52f, tr.position.y, target.position.z - 6.56f);

        tr.LookAt(target);*/

    }
}
