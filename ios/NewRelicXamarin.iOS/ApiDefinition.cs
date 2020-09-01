using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using SystemConfiguration;
using CoreTelephony;

namespace NewRelicXamarin
{
    // @interface NRTimer : NSObject
    [BaseType(typeof(NSObject))]
    [Preserve(AllMembers = true)]
    public partial interface NRTimer
    {
        // @property (readonly, nonatomic) double startTimeMillis;
        [Export("startTimeMillis")]
        double StartTimeMillis { get; }

        // @property (readonly, nonatomic) double endTimeMillis;
        [Export("endTimeMillis")]
        double EndTimeMillis { get; }

        // -(double)startTimeInMillis;
        [Export("startTimeInMillis")]
        double StartTimeInMillis { get; }

        // -(double)endTimeInMillis;
        [Export("endTimeInMillis")]
        double EndTimeInMillis { get; }

        // -(void)restartTimer;
        [Export("restartTimer")]
        void RestartTimer();

        // -(void)stopTimer;
        [Export("stopTimer")]
        void StopTimer();

        // -(BOOL)hasRunAndFinished;
        [Export("hasRunAndFinished")]
        bool HasRunAndFinished { get; }

        // -(double)timeElapsedInSeconds;
        [Export("timeElapsedInSeconds")]
        double TimeElapsedInSeconds { get; }

        // -(double)timeElapsedInMilliSeconds;
        [Export("timeElapsedInMilliSeconds")]
        double TimeElapsedInMilliSeconds { get; }
    }

    // @interface NewRelic : NSObject
    [BaseType(typeof(NSObject))]
    [Preserve(AllMembers = true)]
    public partial interface NewRelic
    {
        // +(void)crashNow:(NSString *)message;
        [Static, Export("crashNow:")]
        void CrashNow(string message);

        // +(void)crashNow;
        [Static, Export("crashNow")]
        void CrashNow();

        // +(void)enableFeatures:(NRMAFeatureFlags)featureFlags;
        [Static, Export("enableFeatures:")]
        void EnableFeatures(NRMAFeatureFlags featureFlags);

        // +(void)disableFeatures:(NRMAFeatureFlags)featureFlags;
        [Static, Export("disableFeatures:")]
        void DisableFeatures(NRMAFeatureFlags featureFlags);

        // +(void)enableCrashReporting:(BOOL)enabled;
        [Static, Export("enableCrashReporting:")]
        void EnableCrashReporting(bool enabled);

        // +(void)setApplicationVersion:(NSString *)versionString;
        [Static, Export("setApplicationVersion:")]
        void SetApplicationVersion(string versionString);

        // +(void)setApplicationBuild:(NSString *)buildNumber;
        [Static, Export("setApplicationBuild:")]
        void SetApplicationBuild(string buildNumber);

        // +(NSString *)currentSessionId;
        [Static, Export("currentSessionId")]
        string CurrentSessionId { get; }

        // +(void)startWithApplicationToken:(NSString *)appToken;
        [Static, Export("startWithApplicationToken:")]
        void StartWithApplicationToken(string appToken);

        // +(void)startWithApplicationToken:(NSString *)appToken withoutSecurity:(BOOL)disableSSL;
        [Static, Export("startWithApplicationToken:withoutSecurity:")]
        void StartWithApplicationToken(string appToken, bool disableSSL);

        // +(NRTimer *)createAndStartTimer;
        [Static, Export("createAndStartTimer")]
        NRTimer CreateAndStartTimer();

        // +(NSString *)startInteractionFromMethodName:(NSString *)selectorName object:(id)object __attribute__((deprecated("")));
        [Static, Export("startInteractionFromMethodName:object:")]
        string StartInteractionFromMethodName(string selectorName, NSObject obj);

        // +(NSString *)startInteractionFromMethodName:(NSString *)selectorName object:(id)object customizedName:(NSString *)interactionName __attribute__((deprecated("")));
        [Static, Export("startInteractionFromMethodName:object:customizedName:")]
        string StartInteractionFromMethodName(string selectorName, NSObject obj, string interactionName);

        // +(NSString *)startInteractionFromMethodName:(NSString *)selectorName object:(id)object customizedName:(NSString *)interactionName cancelRunningTrace:(BOOL)cancel __attribute__((deprecated("")));
        [Static, Export("startInteractionFromMethodName:object:customizedName:cancelRunningTrace:")]
        string StartInteractionFromMethodName(string selectorName, NSObject obj, string interactionName, bool cancel);

        // +(NSString *)startInteractionWithName:(NSString *)interactionName;
        [Static, Export("startInteractionWithName:")]
        string StartInteractionWithName(string interactionName);

        // +(void)stopCurrentInteraction:(NSString *)interactionIdentifier;
        [Static, Export("stopCurrentInteraction:")]
        void StopCurrentInteraction(string interactionIdentifier);

        // +(void)startTracingMethod:(SEL)selector object:(id)object timer:(NRTimer *)timer category:(enum NRTraceType)category;
        [Static, Export("startTracingMethod:object:timer:category:")]
        void StartTracingMethod(Selector selector, NSObject obj, NRTimer timer, NRTraceType category);

        // +(void)endTracingMethodWithTimer:(NRTimer *)timer;
        [Static, Export("endTracingMethodWithTimer:")]
        void EndTracingMethodWithTimer(NRTimer timer);

        // +(void)recordMetricWithName:(NSString *)name category:(NSString *)category;
        [Static, Export("recordMetricWithName:category:")]
        void RecordMetricWithName(string name, string category);

        // +(void)recordMetricWithName:(NSString *)name category:(NSString *)category value:(NSNumber *)value;
        [Static, Export("recordMetricWithName:category:value:")]
        void RecordMetricWithName(string name, string category, NSNumber value);

        // +(void)recordMetricWithName:(NSString *)name category:(NSString *)category value:(NSNumber *)value valueUnits:(NRMetricUnit *)valueUnits;
        [Static, Export("recordMetricWithName:category:value:valueUnits:")]
        void RecordMetricWithName(string name, string category, NSNumber value, string valueUnits);

        // +(void)recordMetricWithName:(NSString *)name category:(NSString *)category value:(NSNumber *)value valueUnits:(NRMetricUnit *)valueUnits countUnits:(NRMetricUnit *)countUnits;
        [Static, Export("recordMetricWithName:category:value:valueUnits:countUnits:")]
        void RecordMetricWithName(string name, string category, NSNumber value, string valueUnits, string countUnits);

        // +(void)noticeNetworkRequestForURL:(NSURL *)url httpMethod:(NSString *)httpMethod withTimer:(NRTimer *)timer responseHeaders:(NSDictionary *)headers statusCode:(NSInteger)httpStatusCode bytesSent:(NSUInteger)bytesSent bytesReceived:(NSUInteger)bytesReceived responseData:(NSData *)responseData andParams:(NSDictionary *)params;
        [Static, Export("noticeNetworkRequestForURL:httpMethod:withTimer:responseHeaders:statusCode:bytesSent:bytesReceived:responseData:andParams:")]
        void NoticeNetworkRequestForURL(NSUrl url, string httpMethod, NRTimer timer, NSDictionary headers, nint httpStatusCode, nuint bytesSent, nuint bytesReceived, NSData responseData, NSDictionary paramsDictionary);

        // +(void)noticeNetworkRequestForURL:(NSURL *)url withTimer:(NRTimer *)timer responseHeaders:(NSDictionary *)headers statusCode:(NSInteger)httpStatusCode bytesSent:(NSUInteger)bytesSent bytesReceived:(NSUInteger)bytesReceived responseData:(NSData *)responseData andParams:(NSDictionary *)params __attribute__((deprecated("")));
        [Static, Export("noticeNetworkRequestForURL:withTimer:responseHeaders:statusCode:bytesSent:bytesReceived:responseData:andParams:")]
        void NoticeNetworkRequestForURL(NSUrl url, NRTimer timer, NSDictionary headers, nint httpStatusCode, nuint bytesSent, nuint bytesReceived, NSData responseData, NSDictionary paramsDictionary);

        // +(void)noticeNetworkFailureForURL:(NSURL *)url httpMethod:(NSString *)httpMethod withTimer:(NRTimer *)timer andFailureCode:(NSInteger)iOSFailureCode;
        [Static, Export("noticeNetworkFailureForURL:httpMethod:withTimer:andFailureCode:")]
        void NoticeNetworkFailureForURL(NSUrl url, string httpMethod, NRTimer timer, nint iOSFailureCode);

        // +(void)noticeNetworkFailureForURL:(NSURL *)url withTimer:(NRTimer *)timer andFailureCode:(NSInteger)iOSFailureCode __attribute__((deprecated("")));
        [Static, Export("noticeNetworkFailureForURL:withTimer:andFailureCode:")]
        void NoticeNetworkFailureForURL(NSUrl url, NRTimer timer, nint iOSFailureCode);

        // +(BOOL)recordCustomEvent:(NSString *)eventType attributes:(NSDictionary *)attributes;
        [Static, Export("recordCustomEvent:attributes:")]
        bool RecordCustomEvent(string eventType, NSDictionary attributes);

	    // +(void)recordError:(NSError* __nonnull)error attributes:(NSDictionary* __nullable)attributes;
	    [Static, Export("recordError:attributes:")]
	    void RecordError(NSError error, NSDictionary attributes);

	    // +(BOOL)recordHandledException:(NSException* __nonnull)exception withAttributes:(NSDictionary* __nullable)attributes;
	    [Static, Export("recordHandledException:withAttributes:")]
	    bool RecordHandledException(NSException exception, NSDictionary attributes);

        // +(void)setMaxEventBufferTime:(unsigned int)seconds;
        [Static, Export("setMaxEventBufferTime:")]
        void SetMaxEventBufferTime(uint seconds);

        // +(void)setMaxEventPoolSize:(unsigned int)size;
        [Static, Export("setMaxEventPoolSize:")]
        void SetMaxEventPoolSize(uint size);

        // +(BOOL)setAttribute:(NSString *)name value:(id)value;
        [Static, Export("setAttribute:value:")]
        bool SetAttribute(string name, NSObject value);

        // +(BOOL)incrementAttribute:(NSString *)name;
        [Static, Export("incrementAttribute:")]
        bool IncrementAttribute(string name);

        // +(BOOL)incrementAttribute:(NSString *)name value:(NSNumber *)amount;
        [Static, Export("incrementAttribute:value:")]
        bool IncrementAttribute(string name, NSNumber amount);

        // +(BOOL)removeAttribute:(NSString *)name;
        [Static, Export("removeAttribute:")]
        bool RemoveAttribute(string name);

        // +(BOOL)removeAllAttributes;
        [Static, Export("removeAllAttributes")]
        bool RemoveAllAttributes();
    }

    // @interface NRCustomMetrics : NSObject
    [BaseType(typeof(NSObject))]
    [Preserve(AllMembers = true)]
    public partial interface NRCustomMetrics
    {
        // +(void)recordMetricWithName:(NSString *)name category:(NSString *)category;
        [Static, Export("recordMetricWithName:category:")]
        void RecordMetricWithName(string name, string category);

        // +(void)recordMetricWithName:(NSString *)name category:(NSString *)category value:(NSNumber *)value;
        [Static, Export("recordMetricWithName:category:value:")]
        void RecordMetricWithName(string name, string category, NSNumber value);

        // +(void)recordMetricWithName:(NSString *)name category:(NSString *)category value:(NSNumber *)value valueUnits:(NRMetricUnit *)valueUnits;
        [Static, Export("recordMetricWithName:category:value:valueUnits:")]
        void RecordMetricWithName(string name, string category, NSNumber value, string valueUnits);

        // +(void)recordMetricWithName:(NSString *)name category:(NSString *)category value:(NSNumber *)value valueUnits:(NRMetricUnit *)valueUnits countUnits:(NRMetricUnit *)countUnits;
        [Static, Export("recordMetricWithName:category:value:valueUnits:countUnits:")]
        void RecordMetricWithName(string name, string category, NSNumber value, string valueUnits, string countUnits);
    }

    // @interface NRLogger : NSObject
    [BaseType(typeof(NSObject))]
    [Preserve(AllMembers = true)]
    public partial interface NRLogger
    {
        // +(void)log:(unsigned int)level inFile:(NSString *)file atLine:(unsigned int)line inMethod:(NSString *)method withMessage:(NSString *)message;
        [Static, Export("log:inFile:atLine:inMethod:withMessage:")]
        void Log(uint level, string file, uint line, string method, string message);

        // +(void)setLogLevels:(unsigned int)levels;
        [Static, Export("setLogLevels:")]
        void SetLogLevels(uint levels);

        // +(void)setLogTargets:(unsigned int)targets;
        [Static, Export("setLogTargets:")]
        void SetLogTargets(uint targets);

        // +(NSString *)logFilePath;
        [Static, Export("logFilePath")]
        string LogFilePath { get; }

        // +(void)clearLog;
        [Static, Export("clearLog")]
        void ClearLog();
    }
}


