using UnityEngine;

public class CreateController : MonoBehaviour
{

    public Transform[] createPoints;
    public GameObject block;
    private float createTime = 2.5f;
    private float createWawe = 1f;

    void Update()
    {

        if(Time.time >= createTime)
        {
            CreateBlocks();
            createTime = Time.time + createWawe;
        }
    }

    public void CreateBlocks()
    {
        int randomBlockIndis = Random.Range(0, createPoints.Length);

        for (int i = 0; i < createPoints.Length; i++)
        {
            if (randomBlockIndis != i)
            {
                Vector3 newPosition = new Vector3(createPoints[i].position.x, Random.Range(10f, 20f) + createWawe, 0f);
                block.transform.localScale = new Vector3(Random.Range(5, 10), 5f, 0f);
                Instantiate(block, newPosition,  Quaternion.identity);
            }
        }
    }
}
