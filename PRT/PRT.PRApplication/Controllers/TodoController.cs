using AutoMapper;
using PRT.Appliction.Interface;
using PRT.Domain.Entitites;
using PRT.PRApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace PRT.PRApplication.Controllers
{
    public class TodoController : ApiController
    {
        private readonly ITodoAppService _todoApp;

        public TodoController(ITodoAppService todoApp)
        {
            _todoApp = todoApp;
        }
        
        public IEnumerable<TodoViewModel> Get()
        {
            try
            {
                return Mapper.Map<IEnumerable<Todo>, IEnumerable<TodoViewModel>>(_todoApp.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public TodoViewModel Get(int id)
        {
            try
            {
                return Mapper.Map<Todo, TodoViewModel>(_todoApp.GetById(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Post([FromBody]TodoViewModel value)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _todoApp.Save(Mapper.Map<TodoViewModel, Todo>(value));
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Put(int id, [FromBody]TodoViewModel value)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    value.Id = id;
                    _todoApp.Update(Mapper.Map<TodoViewModel, Todo>(value));
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(int id)
        {
            try
            {
                if (id != 0)
                {
                    _todoApp.Remove(_todoApp.GetById(id));
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }
    }
}
