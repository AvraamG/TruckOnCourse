using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISteerable
{
    void Steer(float steeringSpeed);
}

public interface IMovable
{
    void Move(float movementSpeed);

}
public interface IRecyclable
{
    void Recycle();

}
    
//This is a generic interface where T is a placeholder
//for a data type that will be provided by the 
//implementing class.
public interface IDamageable<T>
{
    void TakeDamage(T damageTaken);
}