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
        public List<Badges> _listOfBadges = new List<Badges>();
        Dictionary<int, List<string>> _dictionaryOfIDAndDoors = new Dictionary<int, List<string>>();  // Lookups

        public void AddBadgeToList(Badges badges)
        {
            _listOfBadges.Add(badges);
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

        private bool UpdateDoorsForBadge(int badgeID, Badges badges)
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

        public bool DeleteAllDoorsFromBadge(Badges badgeID)
        {
            if (badgeID == null)
            {
                return false;
            }
            else
            {
                return _dictionaryOfIDAndDoors.Remove(badges.DoorNames);
            }
        }

        //Helper Method
        public Badges GetBadgeID(int badgeID)
        {
            foreach (Badges badge in _listOfBadges)
            {
                if (badges.BadgeID == badgeID)
                {
                    return badge;
                }
            }
            return null;
        }
    }
}
