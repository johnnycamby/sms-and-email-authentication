using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSmsAuth
{
    public static class Keys
    {

        /*
         * AccountSid and AuthToken from Twilio api
         */
        public static string TwilioSid = "AC8a2df98537ad29712c43d0afed30ceba";
        public static string TwilioToken = "0b785db1ff4feababa667fb9c620eda7";

        /*
         * Sandbox phone number for trial accounts or an SMS-enabled Twilio phone number you purchased for upgraded accounts.
        */
        public static string FromPhone = "+15592016138";

    }
}