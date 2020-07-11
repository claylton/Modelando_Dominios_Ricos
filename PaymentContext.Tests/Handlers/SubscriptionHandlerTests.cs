using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        // Red, Green, Refactor
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();

            command.FirstName = "Tony";
            command.LastName = "Stark";
            command.Document = "11111111111";
            command.Email = "claylton1@teste.com";
            command.BarCode = "123456789";
            command.BoletoNumber = "2134325452312";
            command.PaymentNumber = "3214234";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "Stark Company";
            command.PayerDocument = "3214214";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "Stark@marvel.com";
            command.Street = "as";
            command.Number = "sas";
            command.Neightborhood = "as";
            command.City = "asd";
            command.State = "dsa";
            command.Country = "sda";
            command.ZipCode = "123423432";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}
