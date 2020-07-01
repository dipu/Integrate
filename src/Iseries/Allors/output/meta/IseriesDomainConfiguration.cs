using Allors;
using Allors.Meta;
using System.Reflection;

namespace AllorsDomains
{
	public class IseriesDomainConfiguration : AllorsDomainConfiguration
	{
		public Assembly DomainAssembly
        {
            get { return Assembly.GetExecutingAssembly(); }
        }

        public Assembly AllorsAssembly
        {
            get { return typeof(AllorsDomains.IseriesDomain).Assembly; }
        }

        public MetaDomain MetaDomain
        {
            get { return AllorsDomains.IseriesDomain.MetaDomain; }
        }
	}
}