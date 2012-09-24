using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rs232app.AppEnum
{
	public enum StopSymbol
	{
		None = 0,
		CR = 0x0D,
		LF = 0x0A,
		CRLF = 0x0D0A,
		Custom
	}
}
