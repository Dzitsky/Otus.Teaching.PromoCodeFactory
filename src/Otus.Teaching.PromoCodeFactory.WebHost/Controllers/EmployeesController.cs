using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Otus.Teaching.PromoCodeFactory.Core.Abstractions.Repositories;
using Otus.Teaching.PromoCodeFactory.Core.Domain.Administration;
using Otus.Teaching.PromoCodeFactory.WebHost.Models;

namespace Otus.Teaching.PromoCodeFactory.WebHost.Controllers
{
   /// <summary>
    /// Сотрудники
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EmployeesController
        : ControllerBase
    {
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IRepository<Role> _roleRepository;
        //private readonly IMapper _mapper;

        public EmployeesController(
            IRepository<Employee> employeeRepository,
            IRepository<Role> roleRepository
            //,    IMapper mapper
            )
        {
            _employeeRepository = employeeRepository;
            _roleRepository = roleRepository;
            //_mapper = mapper;
        }

        /// <summary>
        /// Получить данные всех сотрудников
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            IEnumerable<Employee> employees = await _employeeRepository.GetAllAsync();
            //var employeesModelList = employees.Select(_mapper.Map<EmployeeShortResponse>).ToList();
            //return employeesModelList;

            return employees;
        }

        ///// <summary>
        ///// Получить данные сотрудника по Id
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet("{id:guid}")]
        //public async Task<ActionResult<EmployeeResponse>> GetByIdAsync(Guid id)
        //{
        //    var employee = await _employeeRepository.GetByIdAsync(id);
        //    if (employee == null) return NotFound();
        //    return _mapper.Map<EmployeeResponse>(employee);
        //}

        ///// <summary>
        ///// Создать нового сотрудника
        ///// </summary>
        ///// <param name="employeeCreateRequest"></param>
        ///// <returns></returns>
        //[HttpPost]
        //public async Task<ActionResult> CreateAsync(EmployeeCreateRequest employeeCreateRequest)
        //{
        //    var role = await _roleRepository.GetByIdAsync(employeeCreateRequest.RoleId);
        //    if (role == null) return BadRequest();
        //    var employee = _mapper.Map<Employee>(employeeCreateRequest);
        //    await _employeeRepository.CreateAsync(employee);
        //    return Ok();
        //}

        ///// <summary>
        ///// Обновить данные существующего сотрудника
        ///// </summary>
        ///// <param name="employeeUpdateRequest"></param>
        ///// <returns></returns>
        //[HttpPut]
        //public async Task<ActionResult> UpdateAsync(EmployeeUpdateRequest employeeUpdateRequest)
        //{
        //    var role = await _roleRepository.GetByIdAsync(employeeUpdateRequest.RoleId);
        //    if (role == null) return BadRequest();
        //    var employee = await _employeeRepository.GetByIdAsync(employeeUpdateRequest.Id);
        //    if (employee == null) return NotFound();
        //    _mapper.Map(employeeUpdateRequest, employee);
        //    await _employeeRepository.UpdateAsync(employee);
        //    return Ok();
        //}

        ///// <summary>
        ///// Удалить сотрудника по Id
        ///// </summary>
        ///// <param name="id"></param>
        ///// <returns></returns>
        //[HttpDelete("{id:guid}")]
        //public async Task<ActionResult> DeleteAsync(Guid id)
        //{
        //    var employee = await _employeeRepository.GetByIdAsync(id);
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }
        //    await _employeeRepository.DeleteAsync(employee);
        //    return Ok();
        //}
   
    }
}