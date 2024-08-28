using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    [SerializeField]
    private Movement player;

    private bool isShaking = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((player.score == 5 || player.score == 10 || player.score == 15 || player.score == 20) && !isShaking )
        {
            StartCoroutine(CameraShake());
        }   
    }

    IEnumerator CameraShake()
    {   
        Debug.Log("Shake");
        isShaking = true;
        animator.SetBool("Drunk", true);
        yield return new WaitForSeconds(6.0f);
        animator.SetBool("Drunk", false);
        isShaking = false;
    }
}
