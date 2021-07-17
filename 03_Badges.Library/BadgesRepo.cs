using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Badges.Library
{
    public class BadgesRepo
    {
        Badges badges = new Badges();
        Dictionary<int, List<string>> _dictionaryOfIDAndDoors = new Dictionary<int, List<string>>();  // Lookups

        public void AddBadgeToDictionary(Badges badges)
        {
            _dictionaryOfIDAndDoors.Add(badges.BadgeID, badges.DoorNames);
        }

        public void CreateDictionaryOfIDAndDoorList()
        {
            //Dictionary.Add (pass in values)
            _dictionaryOfIDAndDoors.Add(badges.BadgeID, badges.DoorNames);
        }

        public Dictionary<int, List<string>> GetDictionaryOfIDAndDoorList()
        {
            return _dictionaryOfIDAndDoors;
        }

        public bool UpdateDoorsForBadge(int badgeID, Badges badges)
        {
            // Find the Badge ID Number
            Badges existingBadgeID = GetBadgeID(badgeID);
            
            // Update the Content 
            if (existingBadgeID != null)
            {
                existingBadgeID.DoorNames = badges.DoorNames;
                return true;                       
            }
            else
            {
                return false;
            }
        }

        public bool DeleteAllDoorsFromBadge(int badgeID) // Grab an object from list in the database. (int)
        {
            Badges badges = GetBadgeID(badgeID);

            if (badges == null)
            {
                return false;
            }
            else
            {
                badges.DoorNames.Clear();
            }
            return false;
        }

        //Helper Method
        public Badges GetBadgeID(int badgeID)
        {
            /*foreach (Badges badge in _listOfBadges)
            {
                if (badges.BadgeID == badgeID)
                {
                    return badge;
                }
            }*/
            return null;

        }
    }
}
