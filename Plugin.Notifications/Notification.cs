﻿using System;


namespace Plugin.Notifications
{

    public class Notification
    {
        public static string DefaultTitle { get; set; }
        public static string DefaultSound { get; set; }

        public int Id { get; set; }
        public DateTime? NextScheduledDate { get; set; }

        public string Title { get; set; } = DefaultTitle;
        public string Message { get; set; }


        /// <summary>
        /// Options specific to android
        /// </summary>
        public AndroidOptions Android { get; set; } = new AndroidOptions();


        /// <summary>
        /// Options specific to windows (Uwp)
        /// </summary>
        public UwpOptions Windows { get; set; } = new UwpOptions();


        /// <summary>
        /// Play a sound from the native platform
        /// </summary>
        public string Sound { get; set; } = DefaultSound;


        /// <summary>
        /// The notification trigger to use - leaving this null will use a non-repeating immediate trigger
        /// </summary>
        public INotificationTrigger Trigger { get; set; }


        /// <summary>
        /// Additional data you can add to your notification
        /// </summary>
        public string Payload { get; set; }
    }
}