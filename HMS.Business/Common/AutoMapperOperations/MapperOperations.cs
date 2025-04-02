using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Business.Common.AutoMapperOperations
{
    public  class MapperOperations
    {
        public virtual MapperConfiguration MapperConfig<TSource, TDestination>()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TSource, TDestination>();
                cfg.CreateMap<DateTime, DateTime>().ConvertUsing((s, d) => {
                    return DateTime.SpecifyKind(s, DateTimeKind.Utc);
                });
            });
            return config;

        }
    }
}
