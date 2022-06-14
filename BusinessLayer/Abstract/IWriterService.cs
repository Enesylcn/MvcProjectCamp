﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();
        void WriterDelete(Writer writer);
        void WriterAdd(Writer writer);
        void WriterUpdate(Writer writer);
        Writer GetByID(int id);
    }
}
