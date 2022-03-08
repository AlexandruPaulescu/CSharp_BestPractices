using System;

namespace Prestige.Common
{
    public class NotificationService
    {
        public string NotifyTalent(string talentName)
        {
            var message = "talent : " + talentName;
            Console.WriteLine(message);
            return message;
        }
    }
}
