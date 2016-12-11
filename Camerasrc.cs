using UnityEngine;            
using System.Collections;

public class Camerasrc : MonoBehaviour {
    public GameObject player;
    public Vector3 offset;
    public float smoothSpeed;
    float moveUp;

    void Awake()
    {
        transform.position = player.transform.position + offset;
         moveUp = player.transform.position.y;
    }

    void Update()
    {
        Vector3 moveCamera = new Vector3(player.transform.position.x, moveUp);
        transform.position = Vector3.Lerp(transform.position, moveCamera + offset, smoothSpeed * Time.deltaTime);
    }

}
