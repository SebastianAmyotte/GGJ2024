using UnityEngine;

public class BumperBehavior : MonoBehaviour
{
    private HingeJoint _hingeJoint;

    // Start is called before the first frame update
    void Start()
    {
        _hingeJoint = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _hingeJoint.useMotor = true;
        }
        else
        {
            _hingeJoint.useMotor = false;
        }
    }
}