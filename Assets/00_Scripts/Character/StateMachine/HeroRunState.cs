using UnityEngine;

public class HeroRunState : HeroGroundState
{
    public HeroRunState(HeroStateMachine stateMachine) : base(stateMachine)
    {
    }

    public override void Enter()
    {
        stateMachine.Hero.Agent.speed = 3f;
        base.Enter();
        StartAnimation(stateMachine.Hero.HeroData.animationData.RunParameterHash);
    }

    public override void Update()
    {
        base.Update();
        var range = Vector3.Distance(stateMachine.TargetEnemy.transform.position, stateMachine.Hero.transform.position);
        if (range <= 5f)
        {
            stateMachine.ChangeState(stateMachine.WalkState);
        }
    }

    public override void Exit()
    {
        base.Exit();
        StopAnimation(stateMachine.Hero.HeroData.animationData.RunParameterHash);
    }
}
