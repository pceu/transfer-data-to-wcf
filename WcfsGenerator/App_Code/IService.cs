using System.ServiceModel;


[ServiceContract]
public interface IService
{

	[OperationContract]
	string GenerateAllocations(int[,] blocker, int rows, int columns);
}

