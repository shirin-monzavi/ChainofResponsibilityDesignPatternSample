using ChainofResponsibilityDesignPatternSample.Enums;

namespace ChainofResponsibilityDesignPatternSample.HelpHandlers;

public class HelpHandler
{
    #region Field
    private HelpHandler _successor;
    private TopicEnum _topic;
    #endregion

    public HelpHandler(HelpHandler successor = null, TopicEnum topic = TopicEnum.NoHelpTopic)
    {
        SetFields(successor, topic);
    }

    public virtual bool HasHelp()
    {
        return _topic != TopicEnum.NoHelpTopic;
    }

    public virtual void SetHandler(HelpHandler successor, TopicEnum topic)
    {
        SetFields(successor, topic);
    }

    public virtual void HandleHelp()
    {
        if (_successor is not null)
        {
            _successor.HandleHelp();
        }
    }

    #region Private
    private void SetFields(HelpHandler successor, TopicEnum topic)
    {
        _successor = successor;
        _topic = topic;
    }
    #endregion
}
