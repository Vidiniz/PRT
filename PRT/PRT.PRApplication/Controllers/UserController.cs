using AutoMapper;
using PRT.Appliction.Interface;
using PRT.Domain.Entitites;
using PRT.PRApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PRT.PRApplication.Controllers
{
    public class UserController : ApiController
    {
        private readonly IUserAppService _userApp;

        public UserController(IUserAppService userApp)
        {
            _userApp = userApp;
        }

        // GET: api/User
        public IEnumerable<UserViewModel> Get()
        {
            try
            {
                return Mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(_userApp.GetAll());
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // GET: api/User/5
        public UserViewModel Get(int id)
        {
            try
            {
                return Mapper.Map<User, UserViewModel>(_userApp.GetById(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        // POST: api/User
        public void Post([FromBody]UserViewModel value)
        {
            try
            {
                _userApp.Save(Mapper.Map<UserViewModel, User>(value));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]UserViewModel value)
        {
            try
            {
                value.Id = id;
                _userApp.Update(Mapper.Map<UserViewModel, User>(value));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
            try
            {
                _userApp.Remove(_userApp.GetById(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
