BTOUCH=/Developer/MonoTouch/usr/bin/btouch
SMCS=/Developer/MonoTouch/usr/bin/smcs
MONOXBUILD=/Library/Frameworks/Mono.framework/Commands/msbuild

VERSION=6.9.2

all: NewRelic.dll

NewRelic_Android_Agent_$(VERSION).zip:
	curl -O https://download.newrelic.com/android_agent/ant/NewRelic_Android_Agent_$(VERSION).zip > $@
	rm -rf NewRelic_Android_Agent_$(VERSION)
	unzip $@

newrelic.android.jar: NewRelic_Android_Agent_$(VERSION).zip
	cp newrelic-android-$(VERSION)/lib/newrelic.android.jar Jars/

NewRelic.dll: newrelic.android.jar
	$(MONOXBUILD) /p:Configuration=Release NewRelicXamarin.Android.csproj
	cp bin/Release/NewRelicXamarin.Android.dll NewRelicXamarin.Android.dll

clean:
	rm -rf bin obj Jars/*.jar *.dll
	rm -rf NewRelic_Android_Agent_*
	rm -rf newrelic-android-*
