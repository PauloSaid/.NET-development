using CRUD.Data;
using Microsoft.AspNetCore.Mvc;


namespace CRUD.Controllers
{
    public class EFController : Controller
    {
        public AppDbContext Db { get; set; }

        public EFController(AppDbContext db)
        {
            Db = db;
        }
    }
}
