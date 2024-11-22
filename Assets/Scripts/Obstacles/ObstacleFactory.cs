using UnityEngine;

public enum EnemyType
{
    Saw,
    Flamethrower,
    Turret
}

public class ObstacleFactory : MonoBehaviour
{
    public static IObstacles CreateEnemy(EnemyType type, Vector3 position)
    {
        switch (type)
        {
            case EnemyType.Saw:
                GameObject sawObject = new GameObject("Saw");
                sawObject.transform.position = position;
                Saw saw = sawObject.AddComponent<Saw>();
                saw.Initialize();
                return saw;

            case EnemyType.Flamethrower:
                GameObject flamethrowerObject = new GameObject("Flamethrower");
                flamethrowerObject.transform.position = position;
                Flamethrower flamethrower = flamethrowerObject.AddComponent<Flamethrower>();
                flamethrower.Initialize();
                return flamethrower;

            case EnemyType.Turret:
                GameObject turretObject = new GameObject("Turret");
                turretObject.transform.position = position;
                Turret turret = turretObject.AddComponent<Turret>();
                turret.Initialize();
                return turret;

            default:
                return null;
        }
    }
}
