#import "PollfishUnity.h"
#import <Pollfish/Pollfish.h> //Must insure that this is accessible from this file.
//Include the same way we did for OpenCV in iOS

void UnityPause(bool pause);
void UnitySendMessage(const char * className,const char * methodName, const char * param);
@implementation PollfishUnity

//Loads before application's didFinishLaunching method is called (i.e. when this plugin
//is added to the Objective C runtime)
+ (void)load
{
    //Automatic actions that pollfish takes with the iOS client
    [[NSNotificationCenter defaultCenter] addObserver:self selector:@selector(createPollfish)
        name:UIApplicationDidFinishLaunchingNotification object:nil];

   [[NSNotificationCenter defaultCenter] addObserver:self selector:@selector(initializePollfish)
        name:UIApplicationDidBecomeActiveNotification object:nil];

   [[NSNotificationCenter defaultCenter] addObserver:self selector:@selector(destroyPollfish)
        name:UIApplicationWillTerminateNotification object:nil];

   //Actions upon pollfish-specific notifications, reliant on SDK
   [[NSNotificationCenter defaultCenter] addObserver:self selector:@selector(surveyCompleted)
        name:@"PollfishSurveyCompleted" object:nil];

   [[NSNotificationCenter defaultCenter] addObserver:self selector:@selector(surveyOpened)
        name:@"PollfishOpened" object:nil];

   [[NSNotificationCenter defaultCenter] addObserver:self selector:@selector(surveyClosed)
        name:@"PollfishClosed" object:nil];

   [[NSNotificationCenter defaultCenter] addObserver:self selector:@selector(surveyReceived)
        name:@"PollfishSurveyReceived" object:nil];

}
+ (void)createPollfish:(NSNotification *)notification
{
    [Pollfish createWithParentController:self.window.rootViewController andPosition: withPadding: andDeveloperKey:@"544d53ca-029a-47e2-8472-be253ae20280"];

}
+ (void)initializePollfish:(NSNotification *)notification
{

    [Pollfish initialize];
}
+ (void)destroyPollfish:(NSNotification *)notification
{

    [Pollfish destroy];
}
//iOS-to-Unity, methods get called when the notification triggers
+ (void)surveyCompleted:(NSNotification *)notification
{
    UnityPause(false);
    UnitySendMessage("Pollfish","surveyCompleted","");
}
+ (void)surveyOpened:(NSNotification *)notification
{

    UnityPause(false);
    UnitySendMessage("Pollfish","surveyOpened","");
}
+ (void)surveyClosed:(NSNotification *)notification
{
    UnityPause(false);
    UnitySendMessage("Pollfish","surveyClosed","");
}
+ (void)surveyReceived:(NSNotification *)notification
{

    UnityPause(false);
    UnitySendMessage("Pollfish","surveyReceived","");
}

@end
//Unity-to-iOS, will get called when Unity method is called.
extern "C"{
    void _ShowPollfish(){
        [Pollfish show]
    }
    void _HidePollfish(){
        [Pollfish hide]
    }

}
