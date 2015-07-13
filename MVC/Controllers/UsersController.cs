using Android_Push_Notifications.Models;
using BLL.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Android_Push_Notifications.Controllers
{
    public class UsersController : Controller
    {
       
        IDeviceService _deviceService;
        IUserService _userService;

        public UsersController(IDeviceService deviceService, IUserService userService)
        {
            _deviceService = deviceService;
            _userService = userService;
        }
        
        // GET: User
        public ActionResult Index()
        {
            return View(_userService.GetAll().ToList());
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Login,Password")] UserModel userModel)
        {
            
            if(ModelState.IsValid)
            {
                _userService.Create(userModel);
                
            }
            return View("Create");
        }

        // GET 
        public ActionResult Details(UserModel user)
        {
            var devices = (DeviceModel)_deviceService.GetAllByUser(user);

            return View(devices);
        }
        

       
    }
}
