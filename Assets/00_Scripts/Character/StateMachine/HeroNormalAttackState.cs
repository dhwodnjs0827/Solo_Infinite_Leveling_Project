using UnityEngine;

public class HeroNormalAttackState : HeroAttackState
{
    public HeroNormalAttackState(HeroStateMachine stateMachine) : base(stateMachine)
    {
    }
    
    public override void Enter()
    {
        Debug.Log("Entered NormalAttackState");
        base.Enter();
        StartAnimation(stateMachine.Hero.HeroData.animationData.NormalAttackParameterHash);
    }

    public override void Exit()
    {
        base.Exit();
        StopAnimation(stateMachine.Hero.HeroData.animationData.NormalAttackParameterHash);
    }
}
