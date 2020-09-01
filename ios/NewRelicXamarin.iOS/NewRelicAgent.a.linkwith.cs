using ObjCRuntime;
using SystemConfiguration;
using CoreTelephony;

[assembly: LinkWith("NewRelicAgent.a", IsCxx = true, SmartLink = true, ForceLoad = true, Frameworks = "UIKit SystemConfiguration, CoreTelephony")]
