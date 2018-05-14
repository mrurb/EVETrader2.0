using AutoMapper;
using EVETrader.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EVETrader.Api.ViewModel
{
    public class EntityMapper : Profile
    {
		public EntityMapper()
		{

			CreateMap<Core.Model.SalesOrder, ViewModel.SalesOrder>()
				.ForMember(d => d.BuyerID, opt => opt.MapFrom(src => src.Buyer.Id))
				.ReverseMap();
			/* no need for manual reverse mapping by using the reverseMap
			CreateMap<ViewModel.SalesOrder, Core.Model.SalesOrder>()
				.ForMember(dest => dest.Buyer, opts => opts.MapFrom(source => new User
				{
					Id = source.Id
				}))
				.ForMember(dest => dest.Trader, opts => opts.MapFrom(source => new User
				{
					Id = source.Id
				}));
			CreateMap<Core.Model.SalesOrder, ViewModel.SalesOrder>()
				.ForMember(dest => dest.BuyerID, opts => opts.MapFrom(source => source.Buyer.Id))
				.ForMember(dest => dest.TraderID, opts => opts.MapFrom(source => source.Trader.Id));
				*/
			CreateMap<ViewModel.ShoppingList, Core.Model.ShoppingList>().ReverseMap();
		}
    }
}
