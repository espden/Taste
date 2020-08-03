﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taste.DataAccess;
using Taste.DataAccess.Data.Repository.IRepository;

namespace Taste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public FoodTypeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var b = _unitOfWork.FoodType.GetAll();
            var a = Json(new { data = b });
            return a;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.FoodType.Get(id);
            if (objFromDb != null)
            {
                _unitOfWork.FoodType.Remove(objFromDb);
                _unitOfWork.Save();
                return Json(new { success = true, message = "Delete Sucessful" });
            }
            else
                return Json(new { success = false, message = "Error while deleting" });
        }
    }
}