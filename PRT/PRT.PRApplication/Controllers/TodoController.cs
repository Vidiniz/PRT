﻿using AutoMapper;
using PRT.Appliction.Interface;
using PRT.Domain.Entitites;
using PRT.PRApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PRT.PRApplication.Controllers
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
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

        public IEnumerable<TodoViewModel> Get(string description)
        {
            try
            {
                if (!string.IsNullOrEmpty(description))
                {
                    return Mapper.Map<IEnumerable<Todo>, IEnumerable<TodoViewModel>>(_todoApp.GetByDescription(description));
                }
                return Mapper.Map<IEnumerable<Todo>, IEnumerable<TodoViewModel>>(_todoApp.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("api/get")]
        public IEnumerable<TodoViewModel> GetAllOrderBy(string field)
        {
            try
            {
                return Mapper.Map<IEnumerable<Todo>, IEnumerable<TodoViewModel>>(_todoApp.GetByDescription(field));
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
