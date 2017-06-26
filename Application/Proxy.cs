using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using RelayTest.BLL;
using RelayTest.Model;

namespace RelayTest.Application
{



    public class ProxyBllCommon : BllCommon { }
    public class ProxyBllCOM_SETTINGS : BllCOM_SETTINGS { }
    public class ProxyBllDEV_COILPOWER_INFO : BllDEV_COILPOWER_INFO { }
    public class ProxyBllDEV_COILPOWER_TO_LOAD : BllDEV_COILPOWER_TO_LOAD { }
    public class ProxyBllDEV_LOAD_CHANNEL_INFO : BllDEV_LOAD_CHANNEL_INFO { }
    public class ProxyBllDEV_LOAD_INFO : BllDEV_LOAD_INFO { }
    public class ProxyBllDEV_LOAD_TO_SUB : BllDEV_LOAD_TO_SUB { }
    public class ProxyBllDEV_POWER_INFO : BllDEV_POWER_INFO { }
    public class ProxyBllDEV_POWER_SWITCH : BllDEV_POWER_SWITCH {
      
    }
    public class ProxyBllDEV_POWER_TO_LOAD : BllDEV_POWER_TO_LOAD { }
    public class ProxyBllDEV_SENSOR_INFO : BllDEV_SENSOR_INFO { }
    public class ProxyBllDEV_SUBORDINATE_INFO : BllDEV_SUBORDINATE_INFO {
       
    }
    public class ProxyBllDEV_UPGRADERECORD : BllDEV_UPGRADERECORD { }
    public class ProxyBllDEV_WORKSTATION_INFO : BllDEV_WORKSTATION_INFO {
       
    }
    public class ProxyBllDEV_LOADPOWER_INFO : BllDEV_LOADPOWER_INFO
    {

    }

    public class ProxyBllDEV_SWITCH_INOUT : BllDEV_SWITCH_INOUT
    {

    }

    public class ProxyBllDEV_LOADPOW_TO_SWITCH : BllDEV_LOADPOW_TO_SWITCH
    {
    }

    public class ProxyBllDEV_SWITCH_TO_LOAD : BllDEV_SWITCH_TO_LOAD
    {
    }

    public class ProxyBllDEV_TESTBOX_INFO:BllDEV_TESTBOX_INFO{}
    public class ProxyBllDEV_WORK_TO_COILPOWER : BllDEV_WORK_TO_COILPOWER { }
    public class ProxyBllDEV_WORK_TO_POWER : BllDEV_WORK_TO_POWER { }
    public class ProxyBllDEV_WORK_TO_SENSOR : BllDEV_WORK_TO_SENSOR { }
    public class ProxyBllDEV_WORK_TO_SUB : BllDEV_WORK_TO_SUB { }
    public class ProxyBllFLOW_COIL_STATUS : BllFLOW_COIL_STATUS { }
    public class ProxyBllFLOW_DEVICE_STATUS : BllFLOW_DEVICE_STATUS { }
    public class ProxyBllFLOW_LOAD_CANNEL : BllFLOW_LOAD_CANNEL { }
    public class ProxyBllFLOW_POWER_SWITCH : BllFLOW_POWER_SWITCH { }
    public class ProxyBllFLOW_SENSOR_DATA : BllFLOW_SENSOR_DATA { }
    public class ProxyBllOPERATIONLOG : BllOPERATIONLOG { }
    public class ProxyBllPAR_COMMAND_INFO : BllPAR_COMMAND_INFO { }
    public class ProxyBllPAR_COMMAND_READT : BllPAR_COMMAND_READT { }
    public class ProxyBllPAR_COMMAND_RECEIVE : BllPAR_COMMAND_RECEIVE { }
    public class ProxyBllPAR_COMMAND_SEND : BllPAR_COMMAND_SEND { }
    public class ProxyBllPAR_COMMAND_SENDP : BllPAR_COMMAND_SENDP { }
    public class ProxyBllPAR_COMMAND_WORKTYPE : BllPAR_COMMAND_WORKTYPE { }
    public class ProxyBllSYSTEM_LIST : BllSYSTEM_LIST { }
    public class ProxyBllSYSTEM_MODULE : BllSYSTEM_MODULE { }
    public class ProxyBllSYSTEM_ROLE : BllSYSTEM_ROLE { }
    public class ProxyBllSYSTEM_ROLE_AUTH : BllSYSTEM_ROLE_AUTH { }
    public class ProxyBllSYSTEM_USER : BllSYSTEM_USER { }
    public class ProxyBllSYSTEM_USER_ROLE : BllSYSTEM_USER_ROLE { }
    public class ProxyBllTEST_ALLOCATION : BllTEST_ALLOCATION { }
    public class ProxyBllTEST_INFO : BllTEST_INFO { }
    public class ProxyBllTEST_PREPARE : BllTEST_PREPARE { }
    public class ProxyBllTEST_PREPARE_ATTATCH : BllTEST_PREPARE_ATTATCH { }
    public class ProxyBllTEST_SAMPLE_FAILURE : BllTEST_SAMPLE_FAILURE { }
    public class ProxyBllTEST_SAMPLE_INFO : BllTEST_SAMPLE_INFO { }
    public class ProxyBllTEST_SENDP_VALUE : BllTEST_SENDP_VALUE { }   

    public class ProxyBllTESTTASK_PARTYPE : BllTESTTASK_PARTYPE
    {
    }

    public class ProxyBllTESTTASK_PARVALUE : BllTESTTASK_PARVALUE
    {
    }

    //after 20150616 add
    public class ProxyBllCOMMAND_INFO : BllPAR_COMMAND_INFO { }
    public class ProxyBllCOMMAND_PAR_SEND : BllPAR_COMMAND_SEND { }
    public class ProxyBllCOMMAND_PAR_RECEIVE : BllPAR_COMMAND_RECEIVE { }
    public class ProxyBllTEST_PAR_VALUE_KHD : BllTEST_PAR_VALUE_KHD{ }
    public class ProxyBllTESINFODB : BllTESINFODB { }

    public class ProxyBllTEST_PAR_VALUE_SWJ : BllTEST_PAR_VALUE_SWJ { }
    
    //public class ProxyBllCOMMAND_WORKTYPE_PROGRAMM : BllCOMMAND_WORKTYPE_PROGRAMM { }
    //public class ProxyBllCOMMAND_START_PAR : BllCOMMAND_START_PAR { }
    //public class ProxyBllTEST_START_PAR_VALUE : BllTEST_START_PAR_VALUE { }

    //20161022-lims数据读取添加
    public class ProxyBllLIMS_DOWNLOAD_PARA : BllLIMS_DOWNLOAD_PARA { }
    public class ProxyBllLIMS_DOWNLOAD_SAM : BllLIMS_DOWNLOAD_SAM { }
    public class ProxyBllLIMS_CONTACT_TYPE : BllLIMS_CONTACT_TYPE { }


}
