using UnityEngine;

// Used to store all the constant in the gameplay
public static class Constant
{
    // Bullet's speed
    public static float BULLET_SPEED = 20f;
    // Max energy to activate the special bullet
    public static int MAX_POWER_ENERGY = 6;
    // The time allowed to shoot special bullet
    public static float POWER_DURATION = 5;
    // Max time to spawn the enemy
    public static float MAX_TIME_SPAWN_ENEMY = 5f;
    // Min time to spawn the enemy
    public static float MIN_TIME_SPAWN_ENEMY = 3f;
    // Time to spawn boss
    public static float TIME_SPAWN_BOSS = 10f;
    // Max HP for an enemy
    public static int MAX_HP_ENEMY = 50;
    // Min HP for an enemy
    public static int MIN_HP_ENEMY = 10;
    // Bouncy bullet normal damage
    public static int BOUNCY_BULLET_NORMAL_DAMAGE = 1;
    // Bouncy bullet power damage
    public static int BOUNCY_BULLET_POWER_DAMAGE = 2;
    // Piercing bullet normal damage
    public static int PIERCING_BULLET_NORMAL_DAMAGE = 1;
    // Piercing bullet power damage
    public static int PIERCING_BULLET_POWER_DAMAGE = 2;
    // Max speed of enemy
    public static float MAX_ENEMY_SPEED = 0.12f;
    // Min speed of enemy
    public static float MIN_ENEMY_SPEED = 0.05f;
}
