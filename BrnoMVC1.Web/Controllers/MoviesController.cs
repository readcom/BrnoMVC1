using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BrnoMVC1.Business.ActionResults;
using BrnoMVC1.Business.Extensions;
using BrnoMVC1.Business.Services;
using BrnoMVC1.Web.Models;


namespace BrnoMVC1.Web.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IEmailService emailService;
        private readonly ApplicationDbContext context;

        public List<MovieViewModel> seznamFilmuViewModel { get; set; } = new List<MovieViewModel>();
        public List<Movie> seznamFilmu { get; set; } = new List<Movie>();


        public MoviesController(IEmailService emailService, ApplicationDbContext context)
        {
            ViewBag.MoviesNadpis = "Seznam Filmu";
            ViewData["nadpis"] = "Seznam filmu 2";


            //MovieViewModel film1 = new MovieViewModel();

            //film1.Id = 1;
            //film1.Title = "Pelisky";
            //film1.Genres = Genres.Komedie;

            //MovieViewModel film2 = new MovieViewModel();

            //film2.Id = 2;
            //film2.Title = "patek 13";
            //film2.Genres = Genres.Horror;


            //seznamFilmu.Add(film1);
            //seznamFilmu.Add(film2);

            var movie = new Movie() { Id = 20, Title = "Test Auto Mapper" };
            var movieViewModel = new MovieViewModel();


            // context misto using (var ctx = new ApplicationDbContext())

            this.seznamFilmu = this.context.Movies.ToList();

            //using (var ctx = new ApplicationDbContext())
            //{
            //    this.seznamFilmu = ctx.Movies.ToList();
            //}

            movieViewModel = AutoMapper.Mapper.Map<Movie, MovieViewModel>(movie);

            seznamFilmuViewModel = AutoMapper.Mapper.Map<List<Movie>, List<MovieViewModel>>(seznamFilmu);
            this.emailService = emailService;
            this.context = context;

            //Debugger.Break();

        }

        // poznamka

        // GET: Movies
        public ActionResult Index()
        {
            TempData["nadpis2"] = "Seznam filmu 3";
            return View(seznamFilmuViewModel);
        }

        public ActionResult Details(int Id)
        {
            List<MovieViewModel> seznamFilmu2 = new List<MovieViewModel>();

            MovieViewModel film = seznamFilmuViewModel.Find(i => i.Id == Id);


            return View(film);
        }

        //DefaultControllerFactory faktorka = new DefaultControllerFactory();
        
        public ActionResult JsonResult()
        {
            return this.Json(seznamFilmu, JsonRequestBehavior.AllowGet);
        }

        public ActionResult XMLResult()
        {
             return this.Xml(seznamFilmu);
        }

        public ActionResult Released(string year, string month)
        {           
            return this.Content(year + " " + month);
        }

        public ActionResult Create()
        {

            MovieViewModel model = new MovieViewModel();

            



            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovieViewModel model)
        {

            if (this.ModelState.IsValid)
            {
                return this.Json(model, JsonRequestBehavior.AllowGet);
            }

            return View(model);
        }

        public PartialViewResult _Grid()
        {
           
            return PartialView(seznamFilmuViewModel);
        }

        [HttpGet]
        public ActionResult CreateMovies()
        {

            List<MovieViewModel> movies = new List<MovieViewModel>();

            movies = seznamFilmuViewModel;

            return View(movies);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateMovies(List<MovieViewModel> movies)
        {

            if (this.ModelState.IsValid)
            {
                return this.Json(movies, JsonRequestBehavior.AllowGet);
            }

            return View(movies);
        }

        public ActionResult SendEmail()
        {

            //Business.Services.EmailService emailService = new Business.Services.EmailService();

            this.emailService.Send($"Film odeslan...");

            return this.Content("Odeslano...");
        }


    }
}