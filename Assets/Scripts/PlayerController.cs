using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] float xRange = 20f;
    [SerializeField] float yRange = 15f;
    [SerializeField] float pitchPositionFactor = -1f;
    [SerializeField] float yawControlFactor = 2f;
    [SerializeField] float pitchControlFactor = -15f;
    [SerializeField] float rollControlFactor = -20f;
    float movementFactor = 35f;
    float horizontalMovement, verticalMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessMovement();
        ProcessRotation();
    }

    private void ProcessRotation()
    {
        transform.localRotation = Quaternion.Euler(
            transform.localPosition.y * pitchPositionFactor + verticalMovement * pitchControlFactor,
            transform.localPosition.x * yawControlFactor,
            horizontalMovement * rollControlFactor
        );
    }


    private void ProcessMovement()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");

        transform.localPosition = new Vector3(
            Mathf.Clamp(
                transform.localPosition.x + horizontalMovement * movementFactor * Time.deltaTime,
                -xRange,
                xRange
            ),
            Mathf.Clamp(
                transform.localPosition.y + verticalMovement * movementFactor * Time.deltaTime,
                -yRange,
                yRange
            ),
            transform.localPosition.z
        );
    }
}
