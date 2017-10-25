Ripisha API
===========
The API for congolese made by congolese to integrate online mobile payement
it's should support 

* AIRTEL MONEY
* M-PESA
* ORANGE MONEY

All of these mobile systems in DRC rely on USSD code and SMS to accomplish some tasks
 what is ussd code ?

everytime you type *501# call
you have just ran an ussd code that will give you a response as a dialog form
example Airtel Money

step 1.  *501#
step 2. options

	1. USD
	2. CDF
STEP 3. options
	1.
	2.
	3.
	4.

the point here is to use an SMS gateway to sync to our webhost or app to be notified of an incoming transaction, and all
the informatin will sved to the database, then triger an event to notify the the status of the payment into our applicatino
and the person who is making the payement

example of an sms gate way =  SMSSync which has  mobile app, Android, that can sync an sms to the server..we can use that library
for the ussd code we can also get library that triger ussd code