﻿using AutoFixture.NUnit3;
using FluentAssertions;
using InvoiceCloud.Tests;
using InvoiceCloud.UI.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace InvoiceCloud;

[TestFixture(typeof(ChromeDriver))]
public class InvoviceCloudTest<TWebDriver>:BaseTest<TWebDriver> where TWebDriver : IWebDriver
{
    [Test, AutoData]
    public void AddElementTest(int count)
    {
        browser
            .NavigateTo<AddRemoveElementsPage>()
            .ClickAddElementButton(count)
            .DeleteElementsCount
            .Should().Be(count);    
    }
}
