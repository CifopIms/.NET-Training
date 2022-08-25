using Sofrecom.Crm.DataAccessLayer;

namespace Sofrecom.Crm.BusinessLogicLayer
{
    public class ContactService
    {
        public string Load(int contactid)
        {
            DBManager dbManager = new DBManager();
            string contactName = dbManager.GetContactById(contactid);
            return contactName;
        }
    }
}
