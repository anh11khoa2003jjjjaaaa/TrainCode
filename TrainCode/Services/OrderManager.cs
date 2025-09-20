using Microsoft.AspNetCore.Http.HttpResults;
using System.Collections.Generic;
using TrainCode.DB;

using TrainCode.Log;
using TrainCode.Models;
using TrainCode.Notification;
using TrainCode.Status;
using TrainCode.Validator;

namespace TrainCode.Services
{
    public class OrderManager
    {
        private readonly Validate _validate;
        private readonly NotifyOrder _notifyOrder;
        private readonly LogOrder _logOrder;
        private readonly OrderRespository _orderRespository;
        private readonly StatusOrder _statusOrder;
        public OrderManager( Validate validate, NotifyOrder notifyOrder, LogOrder logOrder, OrderRespository orderRespository, StatusOrder statusOrder)
        {
            _validate = validate;
            _notifyOrder = notifyOrder;
            _logOrder = logOrder;
            _orderRespository = orderRespository;
            _statusOrder = statusOrder;
        }

        public  List<Order>CreateOrder(int userId, int productId, int quantity, decimal totalPrice)
        {
            // Gọi hàm Validate
            _validate.IsValidateOder(userId, productId, quantity);
            //Gọi hàm Lưu Data Order
            var order = _orderRespository.saveOrder(userId,productId, quantity, totalPrice);
       
            //Gọi hàm Log
            _logOrder.LogODer(userId,productId);
            //Gọi hàm Notification
            _notifyOrder.NotificationOrder(userId);
            //Gọi hàm status
            _statusOrder.StatusOrDer();

            return order;

        }
    }
}
