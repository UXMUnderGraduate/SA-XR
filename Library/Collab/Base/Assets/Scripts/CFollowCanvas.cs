using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CFollowCanvas : MonoBehaviour
{
    public float CanvasSpeed = 5.0f;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        //tr = GetComponent <Transform>();
        Vector3 newVector = new Vector3(0, 0, -5000);
        this.transform.Translate(newVector);
    }   

    // Update is called once per frame
    void Update()
    {
        /*Vector3 dir = player.transform.position - this.transform.position;
        Vector3 moveVector = new Vector3(dir.x * CanvasSpeed * Time.deltaTime, dir.y * CanvasSpeed * Time.deltaTime, dir.z * CanvasSpeed * Time.deltaTime);
        this.transform.Translate(moveVector);*/
    }
    void LateUpdate()
    {
        /*  tr.position = new Vector3(target.position.x - 0.52f, tr.position.y, target.position.z - 6.56f);

          tr.LookAt(target);*/

    }
}
