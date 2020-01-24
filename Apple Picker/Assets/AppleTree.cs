using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    // Start is called before the first frame update
    public GameObject applePrefab;
    // speed at which the apple tree moves
    public float speed = 1f;
    //distance where the Apple Tree turns around
    public float leftAndRightEdge = 14f;
    // chance the tree will chagne directions
    public float chanceToChangeDirections = 0.001f;
    // rate at which the apples will be instantiated
    public float secoundsBetweenAppleDrops = 1f;
    // Use this for initialization
    void Start()
    {
        // drop apples every second
        Invoke("DropApple", 2f);
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        Vector3 pos = transform.position;
        pos.y += 0.8f;
        pos.z += -3f;
        apple.transform.position = pos;
        Invoke("DropApple", secoundsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        // basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;
        // changing direction
        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
    private void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
