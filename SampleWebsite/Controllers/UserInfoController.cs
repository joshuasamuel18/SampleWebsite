using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample.Repository;
namespace SampleWebsite.Controllers
{
    public class UserInfoController : Controller
    {

        UserInfoRepository repository = null;

        //
        // GET: /UserInfo/


        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Registeration(UserInfo _user)
        {
            repository = new UserInfoRepository();
            repository.Save(_user);
            return View();
        }

        [HttpPost]
        public bool UpdateUser(UserInfo user)
        {
            repository = new UserInfoRepository();
            repository.UpdateStatus(user);
            return true;
        }

        public ActionResult Index()
        {
            repository = new UserInfoRepository();
            List<UserInfo> MyList = repository.GetAll();
            return View(MyList);
        }

        //
        // GET: /UserInfo/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        

        //
        // GET: /UserInfo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /UserInfo/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /UserInfo/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /UserInfo/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /UserInfo/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /UserInfo/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
