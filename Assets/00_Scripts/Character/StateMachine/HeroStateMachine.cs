using UnityEngine;

public class HeroStateMachine : StateMachine
{
    public StageManager StageManager { get; private set; }

    public Hero Hero { get; private set; }

    public HeroIdleState IdleState { get; private set; }
    public HeroWalkState WalkState { get; private set; }

    public HeroNormalAttackState NormalAttackState { get; private set; }
    
    public GameObject TargetEnemy { get; set; }

    public HeroStateMachine(Hero hero)
    {
        StageManager = StageManager.Instance;

        Hero = hero;

        IdleState = new HeroIdleState(this);
        WalkState = new HeroWalkState(this);

        NormalAttackState = new HeroNormalAttackState(this);
    }
}