using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Vehicle : MonoBehaviour,ISteerable,IMovable,IDamageable<float>,IRecyclable
{
    [SerializeField]
    protected string horizontalAxis;
    [SerializeField]
    protected string verticalAxis;
    
    protected float movementSpeed;
    protected float rotationSpeed;
    protected float remainingHealth;

    protected Vehicle(float movementSpeed, float rotationSpeed,float remainingHealth)
    {
        this.movementSpeed = movementSpeed;
        this.rotationSpeed = rotationSpeed;
        this.remainingHealth = remainingHealth;
    }

  

    public abstract void Steer(float steeringSpeed);
    public abstract void Move(float movementSpeed);
    public abstract void TakeDamage(float damageTaken);
    
    public virtual void Recycle()
    {
       this.gameObject.SetActive(false);
    }
}
