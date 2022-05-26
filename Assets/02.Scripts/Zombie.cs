using System.Collections;
using UnityEngine;
using UnityEngine.AI;

// 좀비 AI 구현
public class Zombie : LivingEntity{
    public LayerMask WhatIsTarget; // 추적 대상 레이어

    private LivingEntity targetEntitiy;// 추적 대상
    private NavMeshAgent navMeshAgent; // 경로 계산 AI 에이전트

    public ParticleSystem hitEffect; // 피격시 재생할 파티클 효과
    public AudioClip deathSound; // 사망 시 재생할 소리
    public AudioClip hitSound; // 피격 시 재생할 소리

    private Animator zombieAnimator; // 애니메이터 컴포넌트
    private AudioSource zombieAudioPlater; // 오디오 소스 컴포넌트
    private Renderer zombieRenderer; // 랜더러 컴포넌트

    public float damage = 20f; // 공격력
    public float timeBetAttack = 0.5f; // 공격 간격
    private float lastAttackTime; // 마지막 공격 시점
}
