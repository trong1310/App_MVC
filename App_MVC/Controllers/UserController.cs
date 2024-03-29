﻿using ClassLib_App_Data.Models;
using ClassLib_App_Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App_MVC.Controllers
{
    public class UserController : Controller
    {
        WebMvcContext _context;
        Repository<User> _repository;
        DbSet<User> _users;
        public UserController()
        {
            _context = new WebMvcContext();
            _users = _context.Users;
            _repository = new Repository<User>(_users, _context);

        }
        public IActionResult Index()
        {
            var userData = _repository.GetAll();
            return View(userData);
        }
        // add data
        public  IActionResult Create() // acction mở form điền thông tin
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            user.ID = Guid.NewGuid();
            _repository.CreateObj(user);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Guid id)
        {
            var updateUser = _repository.GetByID(id);
            return View(updateUser);
        }
        public IActionResult EditUser(User user)
        {
            _repository.UpdateObj(user);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(Guid id)
        {
            
            _repository.DeleteObj(id);
            return RedirectToAction("Index");
        }
        public IActionResult Details(Guid id) 
        {
            var getUser = _repository.GetByID(id);
            return View(getUser);
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string userName,string passWord)
        {
            var user = _repository.GetAll().FirstOrDefault(x=>x.UserName == userName && x.Password == passWord);
            if(user != null)
            {
                // return Content("Đăng nhập thành công");
                //  dùng tempdata để lưu chữ đăng nhập tạm thời
                TempData["Login"] = userName;
                return RedirectToAction("Index","Home");
            }
            else
            {
                return Content("Đăng nhập thất bại");
            }
        }
    }
}
