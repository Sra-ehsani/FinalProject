
using Models.DomainModels;

namespace Models.DataServices
{
    public class PersonDataService
    {
        #region [- SelectAll() -]
        public List<Person> SelectAll()
        {
            try
            {
                using (var context = new FinalProjectDbContext())
                {
                    var persons = context.Person.ToList();
                    return persons;
                }
            }
            catch
            {

                throw;
            }
            finally
            {

            }
        }
        #endregion

        #region [- Insert() -]
        public void Insert(Person person)
        {
            try
            {
                using (var context = new FinalProjectDbContext())
                {
                    context.Person.Add(person);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }
        #endregion

        #region [- Update() -]
        public void Update(int id, Person person)
        {
            try
            {
                using (var context = new FinalProjectDbContext())
                {
                    var personToModify = context.Person.SingleOrDefault(p => p.Id == id);
                    personToModify.FirstName = person.FirstName;
                    personToModify.LastName = person.LastName;
                    context.SaveChanges();

                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        #region [- Delete() -]
        public void Delete(int id)
        {
            try
            {
                using (var context = new FinalProjectDbContext())
                {
                    var personToDelete = context.Person.SingleOrDefault(p => p.Id == id);
                    context.Person.Remove(personToDelete);
                    context.SaveChanges();
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion
    }
}
