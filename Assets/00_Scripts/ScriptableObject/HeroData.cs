using System;
using UnityEngine;

[Serializable]
public class HeroAnimationData
{
    [SerializeField] private string groundParameterName = "@Ground";
    [SerializeField] private string idleParameterName = "Idle";
    [SerializeField] private string walkParameterName = "Walk";
    [SerializeField] private string runParameterName = "Run";

    [SerializeField] private string attackParameterName = "@Attack";
    [SerializeField] private string normalAttackParameterName = "NormalAttack";
    [SerializeField] private string skillAttackParameterName = "SkillAttack";

    public int GroundParameterHash { get; private set; }
    public int IdleParameterHash { get; private set; }
    public int WalkParameterHash { get; private set; }
    public int RunParameterHash { get; private set; }
    
    public int AttackParameterHash { get; private set; }
    public int NormalAttackParameterHash { get; private set; }
    public int SkillAttackParameterHash { get; private set; }

    public void Initialize()
    {
        GroundParameterHash = Animator.StringToHash(groundParameterName);
        IdleParameterHash = Animator.StringToHash(idleParameterName);
        WalkParameterHash = Animator.StringToHash(walkParameterName);
        RunParameterHash = Animator.StringToHash(runParameterName);

        AttackParameterHash = Animator.StringToHash(attackParameterName);
        NormalAttackParameterHash = Animator.StringToHash(normalAttackParameterName);
        SkillAttackParameterHash = Animator.StringToHash(skillAttackParameterName);
    }
}

[CreateAssetMenu(fileName = "HeroData", menuName = "Character/Hero Data")]
public class HeroData : ScriptableObject
{
    [Header("영웅 정보")] public string id;
    public string heroName;
    [Header("영웅 기본 스탯")] public float baseHp;
    public float baseDef;
    public float baseAtk;
    public float baseAtkSpeed;
    public float baseMoveSpeed;

    public HeroAnimationData animationData;
    //public Skill activeSkill;
}