﻿using CarWashApp.BLL.Service;
using CarWashApp.DAL.Concrete;
using CarWashApp.Entity.Concrete;

namespace CarWashApp.BLL.Manager
{
    public class PersonelManager : BaseManager<Personel>, IPersonelService
    {
        protected PersonelRepository _personelRepository;

        public PersonelManager(PersonelRepository personelRepository) : base(personelRepository)
        {
            _personelRepository = personelRepository;
        }

        public (bool, bool) CheckLoginInfo(string username, string password)
        {
            try
            {
                return _personelRepository.CheckLoginInfo(username, password);
            }
            catch (Exception)
            {
                return (false, false);
            }
        }
        public bool AddUser(string name, string surname, int salary, string shiftName, bool isWasher)
        {
            try
            {
                return _personelRepository.AddUser(name, surname, salary, shiftName, isWasher);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddLoginDetails(string idAndName, string username, string password)
        {
            try
            {
                var splittedParts = idAndName.Split('-');
                return _personelRepository.AddLoginDetails(int.Parse(splittedParts[0]), username, password);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AddPersonelLeave(string idAndName, DateTime startDate, int dayCount)
        {
            try
            {
                var splittedParts = idAndName.Split('-');
                return _personelRepository.AddPersonelLeave(int.Parse(splittedParts[0]), startDate, dayCount);
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<string> FillCombobox()
        {
            var personel = _genericRepository.GetAll();
            List<string> outputList = new List<string>();

            foreach (var person in personel)
            {
                outputList.Add(person.PersonelID + "-" + person.Name);
            }

            return outputList;
        }

        public override void Add(Personel entity)
        {
            entity.LeavesLeft = 14;
            entity.IsWorking = false;
            base.Add(entity);
        }
    }
}
