using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "newEnemy", menuName = "Scriptable Objects/Enemys")]
public class Enemy : ScriptableObject
{
    SpriteRenderer spriteRenderer;
    Slider enemyHealthBar;
    Animator enemyAnimation;
    CapsuleCollider2D enemyCollider;
    public int enemyHealth;
    public int enemyAtkDmg;
    public int enemySpeed;

    public void Start()
    {
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        enemyHealthBar = this.GetComponent<Slider>();
        enemyAnimation = this.GetComponent<Animator>();
    }
}
