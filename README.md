# WapPushSmser

Code is alpha and might not work with your usb modem/phone.

Create and send wap push sms to phones that have it enabled, if the user doesnt have allow wap push messages enabled they will not get the sms.

Download Visual studio to compile and create exe. there is an exe in the debug folder already built.

######DISCLAIMER ###################
I take no responsibilty on what you do with this app and it might be illegal in your country to do this so use at your own risk.
This is only proof of concept code.


1. The header or url has to be 18 digits in length so if its not use spaces to make it 18.

2. the msg that you send can only be 70 chars or less.

3. modem has to be in PDU mode, AT+CMGF=0 is the command to put it in PDU mode.

4. the expiry data has to be more than the current date and time otherwise the user wont get the sms. (If you use a date less than the current this becomes a silent sms) date format has to be the same as you see in the app otherwise sms wont send.

5. My phone and modem sends this without any problems and I've only tested it on them so I can help you if your modem does not send unless its thesame model as mine.

6. phone number has to be in full international format (Google if you dont know what it is)
Here is what it looks like on a phone https://github.com/banjaxbanjo/WapPushSmser/blob/master/poc.jpg
