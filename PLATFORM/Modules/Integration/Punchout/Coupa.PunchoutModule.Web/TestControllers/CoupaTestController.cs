﻿using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using VirtoCommerce.Domain.Order.Services;
using VirtoCommerce.Domain.Punchout.Services;
using System.Linq;
using System;

namespace Coupa.PunchoutModule.Web.TestEnvironment
{
    //[ApiExplorerSettings(IgnoreApi = true)]
    //[RoutePrefix("api/coupa/test")]
    //public class CoupaTestController : ApiController
    //{
    //    [HttpPost]
    //    [Route("setup")]
    //    [AllowAnonymous]
    //    public async Task<IHttpActionResult> PunchoutSetup()
    //    {
    //        var setupRequest = await Request.Content.ReadAsStringAsync();
    //        var punchoutGateways = _punchoutService.GetAllPunchoutGateways();
    //        if (punchoutGateways != null && punchoutGateways.Any(x => x.Name.Equals("Coupa", StringComparison.InvariantCultureIgnoreCase)))
    //        {
    //            var coupaGateway = punchoutGateways.First(x => x.Name.Equals("Coupa", StringComparison.InvariantCultureIgnoreCase));
    //            var retVal = coupaGateway.PunchoutSetup(setupRequest);
                
    //            return Ok(retVal);
    //        }
    //        return NotFound();
    //    }

    //    /// <summary>
    //    /// Send shopping cart to coupa system
    //    /// </summary>
    //    /// <param name="cartId">Shopping cart id</param>
    //    [HttpGet]
    //    [Route("ordermessage")]
    //    [AllowAnonymous]
    //    public IHttpActionResult SendOrderMessage(string cartId)
    //    {
    //        var punchoutGateways = _punchoutService.GetAllPunchoutGateways();
    //        if (punchoutGateways != null && punchoutGateways.Any(x => x.Name.Equals("Coupa", StringComparison.InvariantCultureIgnoreCase)))
    //        {
    //            var coupaGateway = punchoutGateways.First(x => x.Name.Equals("Coupa", StringComparison.InvariantCultureIgnoreCase));
    //            var retVal = coupaGateway.PunchoutOrderMessage(cartId);
    //            if (!string.IsNullOrEmpty(retVal))
    //                return Ok(retVal);
    //        }

    //        return NotFound();
    //    }

    //    /// <summary>
    //    /// Create order by received order data
    //    /// </summary>
    //    [HttpGet]
    //    [Route("createorder")]
    //    [AllowAnonymous]
    //    public async Task<IHttpActionResult> CreateOrder()
    //    {
    //        var createOrderRequest = await Request.Content.ReadAsStringAsync();
    //        var punchoutGateways = _punchoutService.GetAllPunchoutGateways();
    //        if (punchoutGateways != null && punchoutGateways.Any(x => x.Name.Equals("Coupa", StringComparison.InvariantCultureIgnoreCase)))
    //        {
    //            var coupaGateway = punchoutGateways.First(x => x.Name.Equals("Coupa", StringComparison.InvariantCultureIgnoreCase));
    //            var response = coupaGateway.CreateOrder(createOrderRequest);

    //            return Ok(response);
    //        }

    //        return NotFound();
    //    }
    //}
}