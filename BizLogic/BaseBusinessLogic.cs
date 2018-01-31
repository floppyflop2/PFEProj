﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFEProj.BizLogic
{
    public abstract class BaseBusinessLogic : IDisposable
    {

        public virtual object Get(string id)
        {
            throw new Exception("Not implemented for this object");
        }

        public virtual object Add(object obj, string id)
        {
            throw new Exception("Not implemented for this object");
        }

        public virtual void Modify(object obj, string id)
        {
            throw new Exception("Not implemented for this object");
        }

        public virtual void Remove(object obj)
        {
            throw new Exception("Not implemented for this object");
        }


        public void Dispose()
        {

        }
    }
}