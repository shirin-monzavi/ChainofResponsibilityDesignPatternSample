using ChainofResponsibilityDesignPatternSample.Applications;
using ChainofResponsibilityDesignPatternSample.Enums;
using ChainofResponsibilityDesignPatternSample.Widegts;

Application application = new(TopicEnum.ApplicationTopic);

Dialog dialog = new(application, TopicEnum.PrintTopic);

Button button = new(dialog, TopicEnum.PaperOrientationTopic);

button.HandleHelp();
