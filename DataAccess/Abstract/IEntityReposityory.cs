using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class: referans tip
    //IEntity: IEntity veya onun implementasyonları olmalı
    //new() : newlenebilir olmalı (IEntity olamaz)
    public interface IEntityReposityory<T> where T:class,IEntity,new() //class referans tip olmalı  anlamında
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //filter=null filtre vermeyebilirsin demek
        T Get(Expression<Func<T, bool>> filter); // filtre vermek zorunlu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
