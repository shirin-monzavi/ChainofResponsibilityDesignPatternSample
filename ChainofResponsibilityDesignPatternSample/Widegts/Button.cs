using ChainofResponsibilityDesignPatternSample.Enums;

namespace ChainofResponsibilityDesignPatternSample.Widegts;
public class Button : Widget
{
    public Button(Widget parent, TopicEnum topic = TopicEnum.NoHelpTopic) : base(parent, topic)
    {
    }

    public override void HandleHelp()
    {
        if (HasHelp())
        {
            Console.WriteLine("This is the help form button");

            return;
        }

        base.HandleHelp();
    }
}
