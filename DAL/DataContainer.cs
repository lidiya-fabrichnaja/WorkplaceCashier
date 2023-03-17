using DAL.Commons;
using DAL.Repositories;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DataContainer
    {
       
        private static Context _ctx;

        public static Context GetContext() { return _ctx; }

        public static void Init()
        {
            _ctx = new Context();
        }

        public static void SaveChanges()
        {
            _ctx.SaveChanges();
        }
    }
}
