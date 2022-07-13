using System;
using System.Threading.Tasks;
using AutoMapper;
using HotelListing.API.Contracts;
using HotelListing.API.Controllers;
using HotelListing.API.Data;
using HotelListing.API.Models.Country;
using HotelListing.API.Models.Hotel;
using HotelListing.API.Repository;
using HotelListing.API.Services;
using Moq;
using Serilog;
using Xunit;

namespace HotelListingAPI.Moq;

public class HotelsControllerTests
{
    private readonly HotelService _sut;
    private readonly Mock<IHotelsRepository> _hotelsRepositoryMock = new();
    private readonly Mock<ILogger> _loggerMock = new();


    public HotelsControllerTests()
    {
        _sut = new HotelService(_hotelsRepositoryMock.Object, _loggerMock.Object);
    }

    [Fact]
    public async Task GetCountry_ShouldReturnConcreteCountry()
    {
        var hotelId = new int();
        var hotelName = "Test Hotel";
        
        var hotel = new Hotel
        {
            Id = hotelId,
            Name = hotelName
        };

        _hotelsRepositoryMock.Setup(x => x.GetAsync(hotelId)).ReturnsAsync(hotel);

        var getHotel = await _sut.GetByIdAsync(hotelId);

        Assert.Equal(hotelId, getHotel.Id);
    }
}