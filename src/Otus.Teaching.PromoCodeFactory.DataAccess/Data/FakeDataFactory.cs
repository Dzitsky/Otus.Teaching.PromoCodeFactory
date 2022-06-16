using System;
using System.Collections.Generic;
using System.Linq;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using Otus.Teaching.PromoCodeFactory.Core.Domain.PromoCodeManagement;

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Data
{
    public static class FakeDataFactory
    {
        public static IEnumerable<Employee> Employees => new List<Employee>()
        {
            new Employee()
            {
                Id = Guid.Parse("451533d5-d8d5-4a11-9c7b-eb9f14e1a32f"),
                Email = "owner@somemail.ru",
                FirstName = "Иван",
                LastName = "Сергеев",
                RoleId = Roles.FirstOrDefault(x => x.Name == "Admin").Id,
                AppliedPromocodesCount = 5
            },
            new Employee()
            {
                Id = Guid.Parse("f766e2bf-340a-46ea-bff3-f1700b435895"),
                Email = "andreev@somemail.ru",
                FirstName = "Петр",
                LastName = "Андреев",
                RoleId = Roles.FirstOrDefault(x => x.Name == "PartnerManager").Id,
                AppliedPromocodesCount = 10
            },
        };

        public static IEnumerable<Role> Roles => new List<Role>()
        {
            new Role()
            {
                Id = Guid.Parse("53729686-a368-4eeb-8bfa-cc69b6050d02"),
                Name = "Admin",
                Description = "Администратор",
            },
            new Role()
            {
                Id = Guid.Parse("b0ae7aac-5493-45cd-ad16-87426a5e7665"),
                Name = "PartnerManager",
                Description = "Партнерский менеджер"
            }
        };

        public static IEnumerable<Preference> Preferences => new List<Preference>()
        {
            new Preference
            {
                Id = Guid.Parse("e8c961b1-6180-45dd-adda-07dc368f83f4"),
                Name = "Кино"
            },
            new Preference
            {
                Id = Guid.Parse("2022f06d-5e8a-4715-a348-b8267cfa0d7a"),
                Name = "Музыка"
            },
            new Preference
            {
                Id = Guid.Parse("55a47c18-159a-415a-a0ef-ad1ae2825c8e"),
                Name = "Видеоигры"
            }
        };

        public static IEnumerable<Customer> Customers
        {
            get
            {
                var customerId = Guid.Parse("3f7f9555-f27f-46d8-b6cc-546b238fe517");
                var customers = new List<Customer>
                {
                    new Customer
                    {
                        Id = customerId,
                        FirstName = "Игорь",
                        LastName = "Марков",
                        Email = "markovigor@gmail.com",
                        Preferences = new List<CustomerPreference>
                        {
                            new CustomerPreference
                            {
                                CustomerId = customerId,
                                PreferenceId = Guid.Parse("e8c961b1-6180-45dd-adda-07dc368f83f4")
                            },
                            new CustomerPreference
                            {
                                CustomerId = customerId,
                                PreferenceId = Guid.Parse("55a47c18-159a-415a-a0ef-ad1ae2825c8e")
                            }
                        }
                    }
                };
                return customers;
            }
        }

        public static IEnumerable<Partner> Partners => new List<Partner>
        {
            new Partner
            {
                Id = Guid.Parse("b708fb50-7160-4582-ba8a-80502177a3b5"),
                Name = "Каро",
                NumberIssuedPromoCodes = 20,
                IsActive = true
            },
            new Partner
            {
                Id = Guid.Parse("e47d413c-96df-4e0e-abce-bcffe30ebc01"),
                Name = "Спортмастер",
                NumberIssuedPromoCodes = 10,
                IsActive = true
            }
        };
    }
}