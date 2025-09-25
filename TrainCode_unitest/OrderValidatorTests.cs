using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainCode;
using TrainCode.Validator;
using Xunit;

namespace TrainCode_unitest
{
    public class OrderValidatorTests
    {

        private readonly Validate _validate=new Validate();
     

        [Fact]
        public void Validate_InvalidateUserId_ThrowArgumentException()
        {
            int userId = 0;
            int productId = 0;
    
            decimal totalPrice = -9;
            Assert.Throws<ArgumentException>(() => _validate.IsValidateOder(userId, productId, totalPrice));

        }
        [Fact]
        public void Validate_ValidData_DoesNotThrow()
        {
            // Arrange
            int userId = 1; // Valid case
            int productId = 1;
            decimal totalPrice = 100m;

            // Act & Assert
            _validate.IsValidateOder(userId, productId, totalPrice); // Không throw
            Assert.True(true); // Pass nếu không throw
        }
    }
}
