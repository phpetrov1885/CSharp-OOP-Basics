using System;
using System.Collections.Generic;
using System.Text;


class Engine
{
    private string engineModel;
    private int engineSpeed;
    private int enginePower;
   
    public Engine(string engineModel,int engineSpeed,int enginePower)
    {
        EngineModel = engineModel;
        EngineSpeed = engineSpeed;
        EnginePower = enginePower;
    }
    public string EngineModel
    {
        get { return engineModel; }
        set { engineModel = value; }
    }
    public int EngineSpeed
    {
        get { return engineSpeed; }
        set { engineSpeed = value; }
    }
    public int EnginePower
    {
        get { return enginePower; }
        set { enginePower = value; }
    }

}

