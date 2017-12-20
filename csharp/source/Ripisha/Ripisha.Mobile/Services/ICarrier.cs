using System;
using System.Text;
namespace Ripisha.Mobile.Services
{
    public interface ICarrier
    {
        //this interface is to be implemented in platform specific
        //and return the carrier that the mobile is using
         string GetCarrierInfo();
    }
}