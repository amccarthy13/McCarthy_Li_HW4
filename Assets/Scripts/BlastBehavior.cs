using UnityEngine;
 
public class BlastBehavior : MonoBehaviour
{

    private Rigidbody _rb;

 
    void Start()
    {
        Destroy(this, 3f);
    }

}
