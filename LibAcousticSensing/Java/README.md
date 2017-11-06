

## Troubleshooting
Even though this Java LibAS should be executed on any Java(Javax)-supported device,
different devices might have their own limitations on using built-in microphones/speakers.
Unfortunately, we can't tune LibAS against every Java-supported devices (like what we do for the Android/iPhone/Tizen) for you since there are just too many.
Followings are some tips to make acoustic sensing app work:
- **Mac**: Even MAC has two microphones, one is used only for noise cancellation. We suggest you turn off the ``ambient noise reduction`` in your ``System Preferences -> Sound -> Input`` setting.
