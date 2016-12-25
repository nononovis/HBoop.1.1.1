using HBoop.DataAccess.Bson;
using HBoop.Model.Bson.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBoop.Business.Layer
{
    public interface IBusinessLayer
    {
     IManager<Address> AddressRepository { get; }
     IManager<Beneficiary> BeneficiaryRepository { get; }
     IManager<Affiliate> AffiliateRepository { get; }
     IManager<BookingDetail> BookingDetailRepository { get; }
     IManager<Booking> BookingRepository { get; }
     IManager<Comment> CommentRepository { get; }
     IManager<CreditCard> CreditCardRepository { get; }
     IManager<Currency> CurrencyRepository { get; }
     IManager<Discount> DiscountRepository { get; }
     IManager<Language> LanguageRepository { get; }
     IManager<Media> MediaRepository { get; }
     IManager<Message> MessageRepository { get; }
     IManager<Notification> NotificationRepository { get; }
     IManager<OrderDetail> OrderDetailRepository { get; }
     IManager<Order> OrderRepository { get; }
     IManager<Person> PersonRepository { get; }
     IManager<Price> PriceRepository { get; }
     IManager<ProductCategory> ProductCategoryRepository { get; }
     IManager<Product> ProductRepository { get; }
     IManager<Role> RoleRepository { get; }
     IManager<ShipMethod> ShipMethodRepository { get; }
     IManager<Store> StoreRepository { get; }
     IManager<User> UserRepository { get; }
     IManager<Vat> VatRepository { get; }

    }
}
