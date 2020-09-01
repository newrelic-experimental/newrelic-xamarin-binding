BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
#Microsoft's build, use xbuild if you are on older version of Xamarin
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/msbuild

#Version number for iOS SDK for New Relic Mobile
VERSION=6.14.0

all: NewRelicXamarin.iOS.dll

NewRelic_iOS_Agent_$(VERSION).zip:
	curl -O https://download.newrelic.com/ios_agent/NewRelic_iOS_Agent_$(VERSION).zip > $@
	rm -rf NewRelic_iOS_Agent_$(VERSION)
	unzip $@

NewRelicAgent.a: NewRelic_iOS_Agent_$(VERSION).zip
	cp NewRelicAgent/NewRelicAgent.framework/NewRelicAgent NewRelicAgent.a

NewRelicXamarin.iOS.dll: NewRelicAgent.a
	$(MONOXBUILD) /p:Configuration=Release NewRelicXamarin.iOS.csproj
	cp bin/Release/NewRelicXamarin.iOS.dll NewRelicXamarin.iOS.dll

clean:
	-rm -rf bin obj *.a *.dll
	rm -rf NewRelic_iOS_Agent_* NewRelicAgent
