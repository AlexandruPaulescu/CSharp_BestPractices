using System;

namespace Prestige.Biz
{
    public class Actor
    {
        public Actor()
        {
            Console.WriteLine("YeeHaw HAAAw");
        }
        public Actor(string actorName)
        {
            this.ActorName = actorName;
        }

        private string actorName;
        public string ActorName
        {
            get => actorName;
            set {
                var formattedName = value?.Trim();
                actorName = formattedName; 
            }
        }

        public int ActorAge { get; set; } = 13;
        public string ActorDescription { get; set; } = "Regular Actor";

        private string jobTitle;
        public string JobTitle
        {
            get => jobTitle;
            set { jobTitle = value; }
        }
        private Agency currentAgency;
        public Agency CurrentAgency
        {
            get 
            {
                if (currentAgency == null)
                {
                    currentAgency = new Agency();
                }
                return currentAgency; 
            }
            set { currentAgency = value; }
        }

        public string GetOccupation()
        {
            jobTitle = "Actor";
            return jobTitle;
        }

        /// <summary>
        /// Books actor, but no date specified.
        /// </summary>
        public string BookActor()
        {
            string details = "Booking can change if actor " +
                "is causing problems.";
            return "Actor " + ActorName + " is booked. " + details;
        }
        /// <summary>
        /// Books actor on specific date.
        /// </summary>
        /// <param name="theDate"></param>
        /// <returns></returns>
        public string BookActor(string theDate)
        {
            string details = "Booking can change if actor " +
                "is causing problems.";
            return "Actor " + ActorName + " is booked on " + theDate + "." + details;
        }

    }
}
