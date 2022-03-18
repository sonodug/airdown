using UnityEngine;

public abstract class Plane : MonoBehaviour
{
    [SerializeField] private Sprite _spriteRenderer;
    [SerializeField] private int _shopPrice;
    [SerializeField] private Sprite _shopIcon;
    [SerializeField] private bool _isBuyed;

    [SerializeField] protected PlayerWeapon Weapon;

    public abstract void Shoot(Transform shootPoint);
    public void Buy()
    {
        _isBuyed = true;
    }
}
