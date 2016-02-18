#include <iostream>
using namespace std;

class VideoCard
{
public:
	bool Start()
	{
		return true;
	}
	bool PingMonitor()
	{
		return true;
	}
	bool OutputRAM()
	{
		return true;
	}
};

class RAM
{
public:
	bool LaunchDevices()
	{
		return true;
	}
	bool MemoryAnalysis()
	{
		return true;
	}
	
};

class Winchester
{
public:

};

class ÎpticalDiscReader
{
public:
	bool RunOPD()
	{
		return true;
	}
};

class PowerSupply
{
public:
	bool Power()
	{
		return true;
	}
	bool PowerVideoCard()
	{
		return true;
	}
	bool PowerRAM()
	{
		return true;
	}
	bool PowerCDROM()
	{
		return true;
	}
};

class Sensors
{
public:

	bool SensorsVoltage()
	{
		return true;
	}
	bool SensorsTempPower()
	{
		return true;
	}
	bool SensorsTempVideo()
	{
		return true;
	}
	bool SensorsTempRAM()
	{
		return true;
	}
};

class Facade
{
public:
	Facade()
	{
		cout << "\tloading..." << endl << endl;
	}

	void BeginWork()
	{
		cout << "\tBeginWork." << endl << endl;

		if (PS.Power() == true)
			cout << "Power supply: supply power." << endl;
		else
			cout << "Power supply: error." << endl;

		if (S.SensorsVoltage() == true)
			cout << "Sensors: check the voltage." << endl;
		else
			cout << "Sensors: error." << endl;

		if (S.SensorsTempPower() == true)
			cout << "Sensors: check the temperature in the power supply." << endl;
		else
			cout << "Sensors: error." << endl;

		if (S.SensorsTempVideo() == true)
			cout << "Sensors: check the temperature of the video card." << endl;
		else
			cout << "Sensors: error." << endl;

		if (PS.PowerVideoCard() == true)
			cout << "Power supply : supply power to the card." << endl;
		else
			cout << "Power supply: error." << endl;

		if (V.Start() == true)
			cout << "Video Card : Startup." << endl;
		else
			cout << "Video Card: error." << endl;

		if (V.PingMonitor() == true)
			cout << "Video Card : ping monitor." << endl;
		else
			cout << "Video Card: error." << endl;
		
		if (S.SensorsTempRAM() == true)
			cout << "Sensors: check the temperature in RAM." << endl;
		else
			cout << "Sensors: error." << endl;

		if (PS.PowerRAM() == true)
			cout << "Power supply : supply power to the RAM." << endl;
		else
			cout << "Power supply: error." << endl;
	
		if (ram.LaunchDevices() == true)
			cout << "RAM : launch devices." << endl;
		else
			cout << "RAM: error." << endl;

		if (ram.LaunchDevices() == true)
			cout << "RAM : Memory Analysis." << endl;
		else
			cout << "RAM: error." << endl;

		if (V.OutputRAM() == true)
			cout << "Video Card : output of the RAM." << endl;
		else
			cout << "Video Card: error." << endl;
		
		if (PS.Power() == true)
			cout << "Power supply: supply power to the CD - ROM drive." << endl;
		else
			cout << "Power supply: error." << endl;

		if (OPR.RunOPD()== true)
			cout << "The reader of optical disks : run." << endl;
		else
			cout << "The reader of optical disks : error." << endl;

		//	15. The optical disc reader : Checking disk.
		//	16. Video card : display information on the CD - ROM drive.
		//	17. Power supply : supply power to the hard drive.
		//	18. Winchester : Start.
		//	19. Winchester : check the boot sector.
		//	20. Video Card : Output data on the hard drive.
		//	21. Sensors : check the temperature of all systems.

	}

	void EndWork()
	{

	}

private:
	VideoCard V;
	RAM ram;
	Winchester W;
	ÎpticalDiscReader OPR;
	PowerSupply PS;
	Sensors S;
};

int main()
{
	Facade F;

	F.BeginWork();

	return 0;
}