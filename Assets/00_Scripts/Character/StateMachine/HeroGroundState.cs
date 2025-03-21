using UnityEngine;

public class HeroGroundState : HeroBaseState
{
    protected HeroGroundState(HeroStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        base.Enter();
        StartAnimation(stateMachine.Hero.HeroData.animationData.GroundParameterHash);
    }

    public override void Exit()
    {
        base.Exit();
        StopAnimation(stateMachine.Hero.HeroData.animationData.GroundParameterHash);
    }
}
