﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetCommentsWithUser(int id)
        {
            Context c = new Context();
            return c.Comments.Where(x => x.BlogID == id).Include(x => x.User).ToList();
        }
    }
}
