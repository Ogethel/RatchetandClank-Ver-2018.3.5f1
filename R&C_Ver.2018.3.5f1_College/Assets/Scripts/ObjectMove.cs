using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public GameObject vehicle;
    public float moveSpeed = 5f;
    
    void Update()
    {
        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);

        Destroy(gameObject, 8); //5 is how many seconds you want before the object deletes itself
     
    }
    private void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }

}
