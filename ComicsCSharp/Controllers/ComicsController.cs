﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ComicsCSharp.Models;

namespace ComicsCSharp.Controllers
{
    public class ComicsController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.comics = ComicsData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Add(Comic comic)
        {
            ComicsData.Add(comic);
            return Redirect("/Comics");
        }

        [HttpPost]
        public IActionResult Remove(int[] removedComics)
        {
            foreach(int comicId in removedComics)
            {
                ComicsData.RemoveById(comicId);
            }
            return Redirect("/Comics");
        }
    }
}
