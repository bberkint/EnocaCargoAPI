using EnocaCargoAPI.Models;
using EnocaCargoAPI.Repositories.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EnocaCargoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrierConfigurationsController : ControllerBase
    {
        private readonly ICarrierConfigurationsRepository _carrierConfigurationsRepository;

        public CarrierConfigurationsController(ICarrierConfigurationsRepository carrierConfigurationsRepository)
        {
            _carrierConfigurationsRepository = carrierConfigurationsRepository;
        }

        [HttpGet]
        public List<CarrierConfigurations>? GetAll()
        {
            return _carrierConfigurationsRepository.GetAll().ToList();
        }

        [HttpGet("{id}")]
        public CarrierConfigurations? GetById(int id)
        {
            return _carrierConfigurationsRepository.GetById(id);
        }

        [HttpPost]
        public string? Add(CarrierConfigurations carrierConfigurations)
        {
            _carrierConfigurationsRepository.Add(carrierConfigurations);
            return "Kargo konfigürasyon bilgisi eklendi";
        }

        [HttpPut]
        public string? Update(CarrierConfigurations carrierConfigurations)
        {
            _carrierConfigurationsRepository.Update(carrierConfigurations);
            return (carrierConfigurations.CarrierConfigurationId + " numaralı kargo konfigürasyon bilgisi güncellendi");
        }

        [HttpDelete("{id}")]
        public string? Remove(int id)
        {
            _carrierConfigurationsRepository.RemoveById(id);
            return (id + " numaralı kargo konfigürasyon bilgisi silindi");
        }
    }
}
