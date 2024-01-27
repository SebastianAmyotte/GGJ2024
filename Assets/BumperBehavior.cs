using UnityEngine;

public class BumperBehavior : MonoBehaviour
{
    public KeyCode arrowKey = KeyCode.RightArrow;
    private HingeJoint _hingeJoint;

    // Start is called before the first frame update
    void Start()
    {
        _hingeJoint = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(arrowKey))
        {
            _hingeJoint.useMotor = true;
        }
        else
        {
            _hingeJoint.useMotor = false;
        }
    }
}