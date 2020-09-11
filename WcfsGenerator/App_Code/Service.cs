using System;
using System.Collections.Generic;

public class Service : IService
{
	public string GenerateAllocations(int[,] blocker, int rows, int columns)
	{
		// Return something for now.
		return (DateTime.Now.Ticks.ToString());
	}
}
