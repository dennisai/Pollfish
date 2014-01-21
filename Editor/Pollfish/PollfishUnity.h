
@interface PollfishUnity : NSObject
+ (void)createPollfish:(NSNotification *)notification;
+ (void)initializePollfish:(NSNotification *)notification;
+ (void)destroyPollfish:(NSNotification *)notification;
+ (void)surveyCompleted:(NSNotification *)notification;
+ (void)surveyOpened:(NSNotification *)notification;
+ (void)surveyClosed:(NSNotification *)notification;
+ (void)surveyReceived:(NSNotification *)notification;

@end
