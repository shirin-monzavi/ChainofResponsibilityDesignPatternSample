using ChainofResponsibilityDesignPatternSample.Enums;
using ChainofResponsibilityDesignPatternSample.HelpHandlers;

namespace ChainofResponsibilityDesignPatternSample.Widegts;
public class Widget : HelpHandler
{
    #region Field
    private readonly Widget _parent;
    #endregion

    public Widget(Widget parent, TopicEnum topic = TopicEnum.NoHelpTopic) : base(parent, topic)
    {
        _parent = parent;
    }
}
