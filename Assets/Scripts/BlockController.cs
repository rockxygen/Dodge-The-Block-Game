using UnityEngine;

public class BlockController : MonoBehaviour
{
    public float gravityForce = 1f;

    private void Start()
    {
        //GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / gravityForce;
    }

    void Update()
    {
        if(transform.position.y < -2f)
        {
            Destroy(gameObject);
        }
    }
}
