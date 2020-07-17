using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : Vehicle
{
    
    public Tank(float movementSpeed, float rotationSpeed, float remainingHealth) : base(movementSpeed, rotationSpeed, remainingHealth)
    {
    }

    public override void Steer(float steeringSpeed)
    {
    }

    public override void Move(float movementSpeed)
    {
    }

    public override void TakeDamage(float damageTaken)
    {
    }
}
