using BasarsoftProje.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BasarsoftProje.Business.Concrete;
using BasarsoftProje.Business.Abstract;
using BasarsoftProje.Entity;
using BasarsoftProje.Entity.DTOs;

namespace BasarsoftProje.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInfoService _infoService;
        private readonly IPointService _pointService;

        public HomeController(IInfoService infoService, IPointService pointService)
        {
            _infoService = infoService;
            _pointService = pointService;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel();

            homeViewModel.userLocationDTOList = _infoService.SplitUserInfoList();

            return View(homeViewModel);
        }

        [HttpGet]
        public PointViewModel GetPoints()
        {
            PointViewModel pointViewModel = new PointViewModel();

            pointViewModel.points = _pointService.GetPoints();

            return pointViewModel;
        }

        [HttpPost]
        public IActionResult TakeInformation(HomeViewModel homeViewModel)
        {
            _infoService.TakeUserInfo(homeViewModel.userLocationDTOForPost);

            homeViewModel.userLocationDTOList = _infoService.SplitUserInfoList();

            return View("Index",homeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}