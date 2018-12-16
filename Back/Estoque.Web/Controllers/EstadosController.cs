﻿using Estoque.DAL.Entities;
using Estoque.DAL.InterfacesRepository;
using Estoque.DAL.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Estoque.Web.Controllers
{
    public class EstadosController : CrudController<EstadoRepository, Estado>
    {
        public EstadosController(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repository = _uow.EstadoRepository;
        }
        protected override void LoadDropdown(Estado entity)
        {
            ViewBag.PaisId = _uow.PaisRepository.CreateSelectList(entity.PaisId);
        }
    }
}