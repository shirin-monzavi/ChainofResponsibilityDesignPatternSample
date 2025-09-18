using ChainofResponsibilityDesignPatternSample.Enums;
using ChainofResponsibilityDesignPatternSample.HelpHandlers;

namespace ChainofResponsibilityDesignPatternSample.Widegts;
public class Dialog : Widget
{
    public Dialog(HelpHandler parent, TopicEnum topic = TopicEnum.NoHelpTopic) : base(null, topic)
    {
        SetHandler(parent, topic);
    }

    public override void HandleHelp()
    {
        if (HasHelp())
        {
            Console.WriteLine("This is the help from dialog");
            return;
        }
        base.HandleHelp();
    }
}
