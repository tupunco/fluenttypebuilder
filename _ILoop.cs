using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Pfz.TypeBuilding
{
	internal interface _ILoop:
		_IBlockBuilder
	{
		LabelTarget ContinueTarget { get; }
		LabelTarget BreakTarget { get; }
	}
}
