using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{ //Core katmanı diğer katmanları referans almaz.
  //Generic constraint generic kısıt
  //Class: referans tip olabilir demek.
  //                       where T: şartı yazarak kısıtlama getirdik.
  // IEntity: IEntity olabilir veya IEntity implemente eden bir nesne olabilir demek.
  //New() yazdık çünkü IEntity kullanılmasını istemiyoruz 
  //Ientity implemente eden classlar kullanılsın istiyoruz sadece
  //o yüzden IEntity newlenemediği için New() şartı ekledik
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
