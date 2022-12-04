using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHolder : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void PlayDeadAnimation()
    {
        animator.SetTrigger("Destroy");
        Destroy(gameObject, 2f);
    }
}
