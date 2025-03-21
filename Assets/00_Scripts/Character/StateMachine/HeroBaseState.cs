using UnityEngine;

public class HeroBaseState : IState
{
    
    protected HeroStateMachine stateMachine;

    public HeroBaseState(HeroStateMachine stateMachine)
    {
        this.stateMachine = stateMachine;
    }

    protected void StartAnimation(int parameterID)
    {
        stateMachine.Hero.Animator.SetBool(parameterID, true);
    }

    protected void StopAnimation(int parameterID)
    {
        stateMachine.Hero.Animator.SetBool(parameterID, false);
    }
    
    public virtual void Enter()
    {
    }

    public virtual void Update()
    {
    }

    public virtual void Exit()
    {
    }
}
