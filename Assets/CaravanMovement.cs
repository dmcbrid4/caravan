using UnityEngine;

public class CaravanMovement : MonoBehaviour
{
    public float speed = 2f; 
    public Transform caravan; 

    void Update()
    {
        MoveCaravan();
    }

    void MoveCaravan()
    {
        // movement to the right during journies
        caravan.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
