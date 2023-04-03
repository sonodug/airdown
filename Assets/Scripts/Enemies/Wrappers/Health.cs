using UnityEngine;
using UnityEngine.Events;

public class Health : IDamageable
{
    public float Value { get; private set; }

    public event UnityAction Died;

    private IDyingPolicy _dyingPolicy;

    public Health(IDyingPolicy dyingPolicy, float value)
    {
        _dyingPolicy = dyingPolicy;
        Value = value;
    }

    public void ApplyDamage(float damage)
    {
        Value -= damage;

        if (Value < 0)
            Value = 0;

        if (_dyingPolicy.Died(Value))
        {
            Died?.Invoke();
        }
    }
}