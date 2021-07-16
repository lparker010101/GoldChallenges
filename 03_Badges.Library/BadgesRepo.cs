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

        private void UpdateDoorsForBadge()
        {
            
        }

        private void DeleteAllDoorsFromBadge()
        {

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
