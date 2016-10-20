using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using CalculateServiceContract;

namespace CalculateServiceClient
{
    public class ServiceProxy: ClientBase<ICalculator>, ICalculator
    {
        public ServiceProxy()
        { }

        public ServiceProxy(System.ServiceModel.Channels.Binding binding, EndpointAddress remoteAddress)  
        : base(binding, remoteAddress)  
        {  
            
      
        }
        public int Add(int x, int y)
        {
            return base.Channel.Add(x, y);
        }
    }
}
