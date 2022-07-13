using System.ComponentModel.Design;
using AutoMapper;
using HotelListing.API.Contracts;
using HotelListing.API.Data;
using HotelListing.API.Models.Hotel;
using ILogger = Serilog.ILogger;

namespace HotelListing.API.Services;

public class HotelService
{
    private readonly IHotelsRepository _hotelRepository;
    private readonly ILogger _logger;

    public HotelService(IHotelsRepository hotelRepository, ILogger logger)
    {
        _hotelRepository = hotelRepository;
        _logger = logger;
    }

    public async Task<Hotel> GetByIdAsync(int id)
    {
        var hotel = await _hotelRepository.GetAsync(id);

        if (hotel == null)
        {
            throw new SystemException();
        }
        
        return hotel;
    }
    
}