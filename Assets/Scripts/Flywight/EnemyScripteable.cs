using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemyData", menuName = "Flyweight/EnemyData", order = 1)]

public class EnemyScripteable : ScriptableObject
{
    [SerializeField] public Sprite sprite;
    [SerializeField] public float attackTime;
}
