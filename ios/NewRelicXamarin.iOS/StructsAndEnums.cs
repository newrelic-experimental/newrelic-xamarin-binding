using System;
using Foundation;
using CoreFoundation;

namespace NewRelicXamarin
{
	public enum NRLogLevels
	{
		None = 0,
		Error = 1 << 0,
		Warning = 1 << 1,
		Info = 1 << 2,
		Verbose = 1 << 3,
		All = 65535
	}

	public enum NRLogTargets
	{
		None = 0,
		Console = 1 << 0,
		File = 1 << 1
	}

	[Flags]
	public enum NRMAFeatureFlags
	{
		InteractionTracing = 1 << 1,
		SwiftInteractionTracing = 1 << 2,
		CrashReporting = 1 << 3,
		NSURLSessionInstrumentation = 1 << 4,
		HttpResponseBodyCapture = 1 << 5,
		DefaultInteractions = 1 << 12,
		ExperimentalNetworkingInstrumentation = 1 << 13,
		AllFeatures = 0
	}

	public enum NRTraceType
	{
		None = 0,
		ViewLoading,
		Layout,
		Database,
		Images,
		Json,
		Network
	}

	public enum NRNetworkFailureCode
	{
		Unknown = -1,
		Cancelled = -999,
		BadURL = -1000,
		TimedOut = -1001,
		UnsupportedURL = -1002,
		CannotFindHost = -1003,
		CannotConnectToHost = -1004,
		DataLengthExceedsMaximum = -1103,
		NetworkConnectionLost = -1005,
		DNSLookupFailed = -1006,
		HTTPTooManyRedirects = -1007,
		ResourceUnavailable = -1008,
		NotConnectedToInternet = -1009,
		RedirectToNonExistentLocation = -1010,
		BadServerResponse = -1011,
		UserCancelledAuthentication = -1012,
		UserAuthenticationRequired = -1013,
		ZeroByteResource = -1014,
		CannotDecodeRawData = -1015,
		CannotDecodeContentData = -1016,
		CannotParseResponse = -1017,
		InternationalRoamingOff = -1018,
		CallIsActive = -1019,
		DataNotAllowed = -1020,
		RequestBodyStreamExhausted = -1021,
		FileDoesNotExist = -1100,
		FileIsDirectory = -1101,
		NoPermissionsToReadFile = -1102,
		SecureConnectionFailed = -1200,
		ServerCertificateHasBadDate = -1201,
		ServerCertificateUntrusted = -1202,
		ServerCertificateHasUnknownRoot = -1203,
		ServerCertificateNotYetValid = -1204,
		ClientCertificateRejected = -1205,
		ClientCertificateRequired = -1206,
		CannotLoadFromNetwork = -2000,
		CannotCreateFile = -3000,
		CannotOpenFile = -3001,
		CannotCloseFile = -3002,
		CannotWriteToFile = -3003,
		CannotRemoveFile = -3004,
		CannotMoveFile = -3005,
		DownloadDecodingFailedMidStream = -3006,
		DownloadDecodingFailedToComplete = -3007
	}

}
