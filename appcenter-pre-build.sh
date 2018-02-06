#!/usr/bin/env bash

if [ -z "$APPCENTER_IOS_KEY" ];
then
    sed -i "s/%APPCENTER_IOS_KEY%/$APPCENTER_IOS_KEY/g" $APPCENTER_SOURCE_DIRECTORY/Sport.Mobile.Shared/Keys.cs
fi

if [ -z "$APPCENTER_ANDROID_KEY" ];
then
    sed -i "s/%APPCENTER_ANDROID_KEY%/$APPCENTER_ANDROID_KEY/g" $APPCENTER_SOURCE_DIRECTORY/Sport.Mobile.Shared/Keys.cs
fi

cat $APPCENTER_SOURCE_DIRECTORY/Sport.Mobile.Shared/Keys.cs