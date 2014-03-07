using SearchGhoraan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SearchGhoraan.Controllers
{
    public class GhoraanController : Controller
    {
        //
        // GET: /Ghoraan/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SearchByKeyword(SearchData data )
        {
            List<SearchResult> lst = new List<SearchResult>();
            SearchEntities dbContext = new SearchEntities();
            var items=dbContext.Keywords.Where(w => w.Keyword1.Contains(data.Word.Trim())).OrderBy(sec=>sec.Chapter.Section).ToList();
            foreach (var item in items)
            {
                lst.Add(new SearchResult() {
                                            ChapterId=item.ChapterId,
                                            Text=item.Chapter.Text,
                                            sectionId=item.Chapter.Section
                                            });
                
            }
            return View(lst);
        }
        public ActionResult SectionDetail(int id)
        {
            List<SectionItem> lst = new List<SectionItem>();
            SearchEntities dbContext = new SearchEntities();
            var items = dbContext.Chapters.Where(w => w.Section==id).ToList();
            int index = 1;
            foreach (var item in items)
            {
                lst.Add(new SectionItem()
                {
                    Id = index++,
                    Text = item.Text
                });

            }
            return View(lst);
        }
	}
}