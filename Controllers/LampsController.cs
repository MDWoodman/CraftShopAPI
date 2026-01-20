using AutoMapper;
using CraftShopAPI.Application.DTO;
using CraftShopAPI.Application.Prototypes;
using CraftShopAPI.Application.Services.Interface;
using CraftShopAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CraftShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LampsController : ControllerBase
    {
        private readonly ILogger<LampsController> _logger;
        private readonly IWriteLampService _writeLampService;
        private readonly IReadLampService _readLampService;
        private readonly ILampPrototypeService _lampPrototypeService;
        private readonly IMapper _mapper;
        public LampsController(ILogger<LampsController> logger , IWriteLampService writeLampService , IReadLampService readLampService, ILampPrototypeService lampPrototypeService, IMapper mapper)
        {
            _logger = logger;
            _writeLampService = writeLampService;
            _mapper = mapper;
            _lampPrototypeService = lampPrototypeService;
            _readLampService = readLampService;
        }

        [HttpPost("add-lamp")]
        public async Task<ActionResult<int>> CreateLamp(CreateLampDTO createLampDTO)
        {
            // Implementation for creating a lamp

            int lampId = -1;
            try 
            {
                Lamp lamp = _mapper.Map<Lamp>(createLampDTO);
                lampId =  await _writeLampService.CreateLampAsync(lamp);
                return Ok(lampId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error extracting Lamp ID from DTO");
                return BadRequest("Invalid Lamp data.");
            }
          
        }
        [HttpGet("get-lamp/{lampId}")]
        public async Task<ActionResult<ReadLampDTO>> GetLampById(int lampId)
        {
            try
            {
                var lamp = await _readLampService.GetLampById(lampId);
                var readLampDto = _mapper.Map<ReadLampDTO>(lamp);

                return Ok(readLampDto);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, $"Error retriving lamp by id {lampId} ");
                return BadRequest($"Error retriving lamp by id {lampId} ");
            }
        } 

        [HttpGet("get-all-lamps/")]
        public async Task<ActionResult<List<ReadLampDTO>>> GetAllLamps()
        {
            try
            {
                var lamps = await _readLampService.GetAllLamps();
                var readLampDTOs = _mapper.Map<List<ReadLampDTO>>(lamps);
                return Ok(readLampDTOs);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving all Lamps");
                return BadRequest("Error retrieving lamps.");
            }
        }


        [HttpGet("clone-lamp/{lampId}")]
        public async Task<ActionResult<int>> CloneLamp(int lampId)
        {
            
            try
            {
                var clonedLamp = await _lampPrototypeService.CloneLampAsync(lampId);

             
                return Ok(clonedLamp);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error cloning Lamp with ID {LampId}", lampId);
                return BadRequest("Error cloning lamp.");
            }
        }
    }
}
