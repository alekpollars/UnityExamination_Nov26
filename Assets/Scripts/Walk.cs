using UnityEngine;
using UnityEngine.InputSystem;

public class Walk : MonoBehaviour
{
    public InputActionAsset aleksPlayerAction;
    public Animator aleksAnimator;


    // Update is called once per frame
    void Update()
    {
        if (aleksPlayerAction.FindAction("Sprint").IsPressed())
        {
            aleksAnimator.SetBool("walk", true);
        }
        else
            aleksAnimator.SetBool("walk", false);
        
        if (aleksPlayerAction.FindAction("Jump").IsPressed())
        {
            aleksAnimator.SetBool("Jumping", true);
        }
        else
            aleksAnimator.SetBool("Jumping", false);
    }
}
