using UnityEngine;

public class Paddle : MonoBehaviour
{
    public Vector2 Pos;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = Pos;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = gameObject.transform.position;
        gameObject.transform.position = pos + new Vector2(0, -0.2f);
    }
}
