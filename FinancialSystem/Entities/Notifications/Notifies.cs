using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notifications
{
    public class Notifies
    {

        [NotMapped]
        public string PropretyName { get; set; }

        [NotMapped]
        public string Message { get; set; }

        [NotMapped]
        public List<Notifies> Notifications;

        public Notifies()
        {
            Notifications = new List<Notifies>();
        }

        public bool ValidateStringProperty(string value, string propertyName)
        {
            if(string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Required Field",
                    PropretyName = propertyName
                });
                return false;
            }
            return true;
        }

        public bool ValidateIntProperty(int value, string propertyName)
        {
            if(value < 1 || string.IsNullOrWhiteSpace(propertyName))
            {
                Notifications.Add(new Notifies
                {
                    Message = "Required Field",
                    PropretyName = propertyName
                });
                return false;
            }
            return true;
        }


    }
}
