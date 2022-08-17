using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Conrete
{
    public class WorkOrderManager : IWorkOrderService
    {
        private IWorkOrderDal _workOrderDal;

        public WorkOrderManager(IWorkOrderDal workOrderDal)
        {
            _workOrderDal = workOrderDal;
        }

        public void Add(WorkOrder entity)
        {
            _workOrderDal.Add(entity);
        }

        public void Delete(WorkOrder entity)
        {
            _workOrderDal.Delete(entity);
        }

        public List<WorkOrder> GetAll()
        {
            return _workOrderDal.GetAll();
        }

        public WorkOrder GetById(int id)
        {
            return _workOrderDal.GetById(id);
        }

        public void Update(WorkOrder entity)
        {
            _workOrderDal.Update(entity);
        }
    }
}
