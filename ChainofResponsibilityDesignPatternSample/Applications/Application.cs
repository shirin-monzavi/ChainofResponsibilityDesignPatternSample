using ChainofResponsibilityDesignPatternSample.Enums;
using ChainofResponsibilityDesignPatternSample.HelpHandlers;

namespace ChainofResponsibilityDesignPatternSample.Applications;

public class Application : HelpHandler
{
    public Application(TopicEnum topic) : base(null, topic)
    {
    }

    public override void HandleHelp()
    {
        Console.WriteLine("This is the help from Application");
    }
}
