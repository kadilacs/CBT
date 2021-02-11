using CBT.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CBT.Controllers
{
    public class TestScoreController : Controller
    {
        private CBTEntities db;

        public TestScoreController()
        {
            db = new CBTEntities();
        }

        protected override void Dispose(bool disposing)
        {
            //base.Dispose(disposing);
            db.Dispose();
        }
        // GET: TestScore
        public ActionResult TestScore()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveTestScore(TestScorez TestScoreInfo)
        {
            var TestScoreInDb = new TestScore();
            TestScoreInDb.Score = TestScoreInfo.Score;
            TestScoreInDb.Date = DateTime.Now;
            TestScoreInDb.Name = TestScoreInfo.Name;
            TestScoreInDb.CandidateId = TestScoreInfo.CandidateId;

            try
            {
                db.TestScores.Add(TestScoreInDb);
                db.SaveChanges();
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

            return View("TestScore");


            
        }
    }
}