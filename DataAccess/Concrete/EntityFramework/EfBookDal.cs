﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstact;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
namespace DataAccess.Concrete.EntityFramework
{
    public class EfBookDal:EfEntityRepositoryBase<Book,BookStoreContext>,IBookDal
    {

    }
}
