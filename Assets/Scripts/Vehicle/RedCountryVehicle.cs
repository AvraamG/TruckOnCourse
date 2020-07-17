using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCountryVehicle : Vehicle
{
    public RedCountryVehicle(float movementSpeed, float rotationSpeed, float remainingHealth) : base(movementSpeed, rotationSpeed, remainingHealth)
    {
        
    }

    public override void Steer(float steeringSpeed)
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        this.transform.Rotate(Vector3.up * (horizontalInput* (Time.deltaTime * rotationSpeed)));
    }

    public override void Move(float movementSpeed)
    {
        float verticalInput = Input.GetAxis("Vertical");
        this.transform.Translate(Vector3.forward * (verticalInput * (Time.deltaTime * movementSpeed)));
    }

    public override void TakeDamage(float damageTaken)
    {
        remainingHealth -= damageTaken;
    }

    
}
