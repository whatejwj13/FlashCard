#region
using System.Linq;
#endregion

namespace FlashCard.Data
{
    public class FormLocationData : EntityData<FormLocation>
    {
        public FormLocation GetByPK(string formName)
        {
            using (FlashCardEntities context = new FlashCardEntities())
            {
                return context.FormLocations.FirstOrDefault(f => f.FormName == formName);
            }
        }

        public void DeleteByPK(string formName)
        {
            FormLocation formLocation = GetByPK(formName);

            if (formLocation == null)
                return;

            Delete(formLocation);
        }
    }
}