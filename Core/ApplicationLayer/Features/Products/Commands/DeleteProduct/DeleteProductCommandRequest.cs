﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandRequest :IRequest
    {
        public int Id { get; set; }
    }
}
