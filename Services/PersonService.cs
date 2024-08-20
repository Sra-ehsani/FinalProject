﻿
using Models.DataServices;
using Models.DomainModels;


namespace Services
{
    public class PersonService
    {
        private readonly PersonDataService _personDataService;

        #region [- Ctor -]
        public PersonService()
        {
            _personDataService = new PersonDataService();
        }
        #endregion

        #region [- FillGrid() -]

        public List<Person> FillGrid() => _personDataService.SelectAll();

        #endregion

        #region [- Save() -]
        public void Save(Person person) => _personDataService.Insert(person);
        #endregion

        #region [- Edit() -]
        public void Edit(int id, Person person) => _personDataService.Update(id, person);
        #endregion

        #region [- Delete() -]
        public void Delete(int id) => _personDataService.Delete(id);
        #endregion
    }
}
