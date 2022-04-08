using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtahAccidents.Models;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;
using UtahAccidents.Models.ViewModels;

namespace UtahAccidents.Controllers
{
    public class HomeController : Controller
    {
        private InferenceSession _session;
        private AccidentsDbContext _context { get; set; }
        private IAccidentsRepository _repo { get; set; }

        public HomeController(IAccidentsRepository temp, InferenceSession session)
        {
            _repo = temp;
            _session = session;
        }

        public IActionResult Index()
        {
            var blah = _repo.Accidents.ToList();

            return View(blah);
        }

        //public IActionResult SummaryData(int pageNum = 1)
        //{
            
        //    int pageSize = 50;

        //    var x = new AccidentsViewModel
        //    {
        //        Accidents = _repo.Accidents
        //        .OrderBy(a => a.CRASH_ID)
        //        .Skip(pageSize * (pageNum - 1))
        //        .Take(pageSize),

        //        PageInfo = new PageInfo
        //        {
        //            TotalNumAccidents = _repo.Accidents.Count(),
        //            AccidentsPerPage = pageSize,
        //            CurrentPage = pageNum
        //        }
        //    };

        //    return View(x);
        //}

        [HttpGet]
        public IActionResult SummaryData(int? page)
        {
            var Accidents = _repo.Accidents
                .OrderBy(a => a.CRASH_ID);
                //.Skip(pageSize * (pageNum - 1))
                //.Take(pageSize)
            var pager = new Pager(Accidents.Count(), page);


            var viewModel = new IndexViewModel
            {
                Accidents = Accidents.Skip((pager.CurrentPage - 1) * pager.PageSize).Take(pager.PageSize),
                Pager = pager
            };

            return View(viewModel);

        }


        public IActionResult Filter()
        {
            var county = _context.Accidents
                .FromSqlRaw("SELECT DISTINCT COUNTY_NAME FROM accidents ORDER BY COUNTY_NAME")
                .ToList();

            //var blah = _repo.Accidents.AsQueryable();
            //blah = blah.Where(x => x.COUNTY_NAME == )

            return View(county);
        }


        public IActionResult Privacy()
        {

            return View();
        }

        [HttpGet]
        public IActionResult ScorePredictor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ScorePredictor(AccidentInfoPredictor data)
        {
            var result = _session.Run(new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor("float_input", data.AsTensor())
            });
            Tensor<float> score = result.First().AsTensor<float>();
            var prediction = new CrashPrediction { CrashSeverity = score.First() };
            result.Dispose();
            return View("PredictorResults", prediction);
        }
        public IActionResult Insights()
        {

            return View();
        }

    }
}
