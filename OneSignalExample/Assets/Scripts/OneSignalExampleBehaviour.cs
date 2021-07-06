using System;
using System.Collections.Generic;
using UnityEngine;

namespace TestApp
{
    public class OneSignalExampleBehaviour : MonoBehaviour
    {
        public void Start()
        {
            OneSignal.StartInit("{YOUR_ONESIGNAL_APP_ID}")
                .HandleNotificationOpened(OneSignalHandleNotificationOpened) // these should be events ala +=/-=
                .HandleInAppMessageClicked(HandleIamClicked)
                .Settings(new Dictionary<string, bool>() {
                    { OneSignal.kOSSettingsAutoPrompt, false },
                    { OneSignal.kOSSettingsInAppLaunchURL, false } })
                .EndInit();
            
            OneSignal.inFocusDisplayType = OneSignal.OSInFocusDisplayOption.Notification;
        
            // iOS - Shows the iOS native notification permission prompt.
            //   - Instead we recomemnd using an In-App Message to prompt for notification 
            //     permission to explain how notifications are helpful to your users.
            OneSignal.PromptForPushNotificationsWithUserResponse(OneSignalPromptForPushNotificationsReponse);
        
        }
        
        private void HandleIamClicked(OSInAppMessageAction action)
        {
            throw new NotImplementedException();
        }
        
        private void OneSignalPromptForPushNotificationsReponse(bool accepted)
        {
            
        }
        
        private void OneSignalHandleNotificationOpened(OSNotificationOpenedResult result)
        {
            
        }

        public void Update()
        {
            
        }
    }
}