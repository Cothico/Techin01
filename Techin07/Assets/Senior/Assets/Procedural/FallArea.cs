using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallArea : MonoBehaviour
{
    public float speed;
    public Transform startArea;
    public Transform startFallArea;

    public LevelGenerator lg;

    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.transform.position = new Vector2(startArea.position.x, startArea.position.y);
            transform.position = new Vector2(startFallArea.position.x, startFallArea.position.y);
            lg.GetBorderNew(lg.startBlock);
            lg.LevelGeneratorF();
        }
    }
}
