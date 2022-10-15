using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiding
{
    public abstract class BaseHero
	{
		public BaseHero(string name)
		{
			this.Name = name;
		}

		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private int power;

		public int Power
		{
			get { return power; }
			set { power = value; }
		}

		public virtual string CastAbility()
		{
			return "";
		}



	}
}
