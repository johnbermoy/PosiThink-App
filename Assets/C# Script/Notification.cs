using System.Collections;
using System.Collections.Generic;
using Unity.Notifications.Android;
using UnityEngine;

public class Notification : MonoBehaviour
{
    private int hours = 24;

    // Start is called before the first frame update
    void Start()
    {
        //
        AndroidNotificationCenter.CancelAllNotifications();

        //In this part / function It creates a Notification
        var channel = new AndroidNotificationChannel()
        {
            Id = "channel_id",
            Name = "PosiThink",
            Importance = Importance.Default,
            Description = "Remainders!",
        };
        AndroidNotificationCenter.RegisterNotificationChannel(channel);

        //The Content for the notification
        var notification = new AndroidNotification();
        notification.Title = "PosiThink";
        notification.Text = "Remainder To Read The Quote";
        notification.FireTime = System.DateTime.Now.AddHours(hours);

         var id = AndroidNotificationCenter.SendNotification(notification, "channel_id");


        //to check if the notification for application is schedule 
        // The application will send a notification for the user
        if(AndroidNotificationCenter.CheckScheduledNotificationStatus(id) == NotificationStatus.Scheduled)
        {
            AndroidNotificationCenter.CancelAllNotifications();
            AndroidNotificationCenter.SendNotification(notification, "channel_id");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
