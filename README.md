# Wave'n'Click (Windows Server) (Alpha)
Connects an Android device to a PC (with Windows installed) via Bluetooth.

This project aims to make it possible to use your Android device for
manipulating PC as if you were using a remote control.

Features supported at the moment:
* connecting an Android device to a PC (look at 'greencis/wave-n-click-client' repo)
* 11 buttons mapped to keys (you can change them on Keys mapping tab)
* mouse buttons and movement emulation
* scrolling mouse wheel
* typing text messages and sending them to the PC

Originally, Wave'n'Click had been written in Nov 2012 - Feb 2013. It was
presented at National Computer Science conference for secondary school
students in 2013 and won a second degree award.

The project is still in alpha stage of development, and many interesting
features are awaiting their implementation. Some bugs can occur, so use with
caution!

Wave'n'Click Server is written in C# and is built under Microsoft Visual Studio 2015.
It requires .NET Framework 3.5 installed on your computer. Wave'n'Click Server uses
32feet.NET (https://32feet.codeplex.com/) and Windows Input Simulator
(https://inputsimulator.codeplex.com/) libraries, which are distributed under
Microsoft Public License (Ms-PL).

(c) 2012-2016, greencis
