﻿using Bogus;
using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;

namespace CommomTestUtilities.Requests;
public class RequestRegisterExpenseJsonBuilder
{
    public static RequestRegisterExpenseJson Build()
    {
        return new Faker<RequestRegisterExpenseJson>()
            .RuleFor(r => r.Title, faker => faker.Commerce.ProductName())
            .RuleFor(r => r.Description, faker => faker.Commerce.ProductDescription())
            .RuleFor(r => r.Date, faker => faker.Date.Past())
            .RuleFor(r => r.PaymentType, faker => faker.PickRandom<PaymentType>())
            .RuleFor(r => r.Amount, faker => faker.Random.Decimal(min: 1, max: 1000));


        /* var faker = new Faker();
         * return new RequestRegisterExpenseJson
         {
             Amount = 100,
             Date = DateTime.Now.AddDays(-1),
             Description = "Description",
             Title = "Title",
             PaymentType = CashFlow.Communication.Enums.PaymentType.Cash
         };
        */
    }
}
