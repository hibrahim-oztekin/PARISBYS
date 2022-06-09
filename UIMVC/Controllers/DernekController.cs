using Business.Abstract;
using Entities.Concrete;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIMVC.Models;

namespace UIMVC.Controllers
{
    public class DernekController : BaseController
    {
        IDernekService _dernekService;
        ISehirService _sehirService;
        ICrcmUyelikFormDurumService _crcmUyelikFormDurumService;
        IKurulusKanunService _kurulusKanunService;
        IBkBolgeService _bkBolgeService;

        public DernekController(IDernekService dernekService, ISehirService sehirService, ICrcmUyelikFormDurumService crcmUyelikFormDurumService, IKurulusKanunService kurulusKanunService, IBkBolgeService bkBolgeService)
        {
            _dernekService = dernekService;
            _sehirService = sehirService;
            _crcmUyelikFormDurumService = crcmUyelikFormDurumService;
            _kurulusKanunService = kurulusKanunService;
            _bkBolgeService = bkBolgeService;
        }


        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Ad()
        {
            ListeDoldur();

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Ad(Derneks derneks)
        {

            ListeDoldur();
            derneks.KayitTarihi = DateTime.Now;
            var result = _dernekService.Add(derneks);
            if (result.Success)
            {
                Notify(derneks.Ad, result.Message, notificationType: NotificationType.success);
                return View(new Derneks());
            }
            else
            {
                TempData["ErrorMessage"] = derneks.Ad + " " + result.Message;
                return View("Ad", derneks);
            }


        }

        public IActionResult DernekList()

        {
            ListeDoldur();
            return View();
        }
        public void ListeDoldur()
        {
            List<SelectListItem> sehirler = _sehirService.GetAll().Data.Select(x => new SelectListItem { Text = x.Ad, Value = x.Id.ToString() }).ToList();
            List<SelectListItem> uyelikFormDurumlar = _crcmUyelikFormDurumService.GetAll().Data.Select(x => new SelectListItem { Text = x.Durum, Value = x.Id.ToString() }).ToList();
            List<SelectListItem> kurulusKanuns = _kurulusKanunService.GetAll().Data.Select(x => new SelectListItem { Text = x.Kanun, Value = x.Id.ToString() }).ToList();
            List<SelectListItem> bkBolgeler = _bkBolgeService.GetAll().Data.Select(x => new SelectListItem { Text = x.Ad, Value = x.Id.ToString() }).ToList();
            ViewBag.crcmKurulusUyelikDurum = uyelikFormDurumlar;
            ViewBag.sehirler = sehirler;
            ViewBag.kurulusKanuns = kurulusKanuns;
            ViewBag.bkBolgeler = bkBolgeler;
        }
        public void AdViewBagaGonder()
        {

        }
        public IActionResult DernekDetail()
        {
            return View();
        }
    }
}
