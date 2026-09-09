using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public ssConectaProveedores.RestRecords.RESTST_382afa1d8361f400b6ea03403d75e294Structure outParamList;
[JsonProperty("Totalenmonedanacional")]
public decimal? outParamTotalenmonedanacional;
[JsonProperty("Importetotaldefacturasmonedaextranjera")]
public decimal? outParamImportetotaldefacturasmonedaextranjera;
[JsonProperty("Totalenmonedanacional2")]
public decimal? outParamTotalenmonedanacional2;
[JsonProperty("Importetotaldefacturasmonedaextranjera2")]
public decimal? outParamImportetotaldefacturasmonedaextranjera2;


    public static RESTConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Outputs FromOutputs(IBehaviorsConfiguration conf, ST_382afa1d8361f400b6ea03403d75e294Structure outParamList, decimal outParamTotalenmonedanacional, decimal outParamImportetotaldefacturasmonedaextranjera, decimal outParamTotalenmonedanacional2, decimal outParamImportetotaldefacturasmonedaextranjera2) {RESTConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Outputs result = new RESTConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Outputs();
// Write the needed fields of the record outParamList to the result.outParamList
result.outParamList = new ssConectaProveedores.RestRecords.RESTST_382afa1d8361f400b6ea03403d75e294Structure();
// Write the needed fields of the list outParamList.ssT_DAT_PROV_Out to the result.outParamList.AttrT_DAT_PROV_Out
ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure tmpoutParamList_ssT_DAT_PROV_OutElement;
if(outParamList.ssT_DAT_PROV_Out.Empty) {
// Write the needed fields of the record outParamList.ssT_DAT_PROV_Out.CurrentRec to the tmpoutParamList_ssT_DAT_PROV_OutElement
tmpoutParamList_ssT_DAT_PROV_OutElement = new ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure();
tmpoutParamList_ssT_DAT_PROV_OutElement.AttrLIFNR = outParamList.ssT_DAT_PROV_Out.CurrentRec.ssLIFNR;
tmpoutParamList_ssT_DAT_PROV_OutElement.AttrNAME1 = outParamList.ssT_DAT_PROV_Out.CurrentRec.ssNAME1;
tmpoutParamList_ssT_DAT_PROV_OutElement.AttrNAME2 = outParamList.ssT_DAT_PROV_Out.CurrentRec.ssNAME2;
result.outParamList.AttrT_DAT_PROV_Out = new RestList<ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure>(new ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure[] {}, tmpoutParamList_ssT_DAT_PROV_OutElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure>
 tmpoutParamList_ssT_DAT_PROV_Out1List = new List<ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure>
();
try {outParamList.ssT_DAT_PROV_Out.StartIteration();
while (!(outParamList.ssT_DAT_PROV_Out.Eof)) {
// Write the needed fields of the record outParamList.ssT_DAT_PROV_Out.CurrentRec to the tmpoutParamList_ssT_DAT_PROV_OutElement
tmpoutParamList_ssT_DAT_PROV_OutElement = new ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure();
tmpoutParamList_ssT_DAT_PROV_OutElement.AttrLIFNR = outParamList.ssT_DAT_PROV_Out.CurrentRec.ssLIFNR;
tmpoutParamList_ssT_DAT_PROV_OutElement.AttrNAME1 = outParamList.ssT_DAT_PROV_Out.CurrentRec.ssNAME1;
tmpoutParamList_ssT_DAT_PROV_OutElement.AttrNAME2 = outParamList.ssT_DAT_PROV_Out.CurrentRec.ssNAME2;
tmpoutParamList_ssT_DAT_PROV_Out1List.Add(tmpoutParamList_ssT_DAT_PROV_OutElement);
outParamList.ssT_DAT_PROV_Out.Advance();
}

} finally {
outParamList.ssT_DAT_PROV_Out.EndIteration();
}

result.outParamList.AttrT_DAT_PROV_Out = new RestList<ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure>(tmpoutParamList_ssT_DAT_PROV_Out1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_4639a265770186863b3ecaeafd29fb96Structure));
}

// Write the needed fields of the list outParamList.ssT_FACT_PEN_PAG_Out to the result.outParamList.AttrT_FACT_PEN_PAG_Out
ssConectaProveedores.RestRecords.RESTST_9f44b824af1405b8fbe038a5a393bb86Structure tmpoutParamList_ssT_FACT_PEN_PAG_OutElement;
if(outParamList.ssT_FACT_PEN_PAG_Out.Empty) {
// Write the needed fields of the record outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec to the tmpoutParamList_ssT_FACT_PEN_PAG_OutElement
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement = new ssConectaProveedores.RestRecords.RESTST_9f44b824af1405b8fbe038a5a393bb86Structure();
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrXBLNR = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssXBLNR;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrZUONR = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssZUONR;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrZFBDT = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssZFBDT);
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrZTERM = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssZTERM;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrAUGDT = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssAUGDT);
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrWRBTR = (decimal?) outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssWRBTR;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrWAERS = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssWAERS;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrWRBT2 = (decimal?) outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssWRBT2;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrWRBT3 = (decimal?) outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssWRBT3;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrUMSKZ = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssUMSKZ;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrBLART = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssBLART;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrZLSCH = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssZLSCH;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrKURSF = (decimal?) outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssKURSF;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrUSNAM = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssUSNAM;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrUSRID_LONG = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssUSRID_LONG;
result.outParamList.AttrT_FACT_PEN_PAG_Out = new RestList<ssConectaProveedores.RestRecords.RESTST_9f44b824af1405b8fbe038a5a393bb86Structure>(new ssConectaProveedores.RestRecords.RESTST_9f44b824af1405b8fbe038a5a393bb86Structure[] {}, tmpoutParamList_ssT_FACT_PEN_PAG_OutElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_9f44b824af1405b8fbe038a5a393bb86Structure>
 tmpoutParamList_ssT_FACT_PEN_PAG_Out1List = new List<ssConectaProveedores.RestRecords.RESTST_9f44b824af1405b8fbe038a5a393bb86Structure>
();
try {outParamList.ssT_FACT_PEN_PAG_Out.StartIteration();
while (!(outParamList.ssT_FACT_PEN_PAG_Out.Eof)) {
// Write the needed fields of the record outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec to the tmpoutParamList_ssT_FACT_PEN_PAG_OutElement
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement = new ssConectaProveedores.RestRecords.RESTST_9f44b824af1405b8fbe038a5a393bb86Structure();
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrXBLNR = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssXBLNR;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrZUONR = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssZUONR;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrZFBDT = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssZFBDT);
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrZTERM = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssZTERM;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrAUGDT = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssAUGDT);
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrWRBTR = (decimal?) outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssWRBTR;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrWAERS = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssWAERS;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrWRBT2 = (decimal?) outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssWRBT2;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrWRBT3 = (decimal?) outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssWRBT3;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrUMSKZ = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssUMSKZ;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrBLART = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssBLART;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrZLSCH = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssZLSCH;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrKURSF = (decimal?) outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssKURSF;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrUSNAM = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssUSNAM;
tmpoutParamList_ssT_FACT_PEN_PAG_OutElement.AttrUSRID_LONG = outParamList.ssT_FACT_PEN_PAG_Out.CurrentRec.ssUSRID_LONG;
tmpoutParamList_ssT_FACT_PEN_PAG_Out1List.Add(tmpoutParamList_ssT_FACT_PEN_PAG_OutElement);
outParamList.ssT_FACT_PEN_PAG_Out.Advance();
}

} finally {
outParamList.ssT_FACT_PEN_PAG_Out.EndIteration();
}

result.outParamList.AttrT_FACT_PEN_PAG_Out = new RestList<ssConectaProveedores.RestRecords.RESTST_9f44b824af1405b8fbe038a5a393bb86Structure>(tmpoutParamList_ssT_FACT_PEN_PAG_Out1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_9f44b824af1405b8fbe038a5a393bb86Structure));
}

// Write the needed fields of the list outParamList.ssT_FAC_PAG_Out to the result.outParamList.AttrT_FAC_PAG_Out
ssConectaProveedores.RestRecords.RESTST_99acd807840db0272ca95b7e5ca3fca1Structure tmpoutParamList_ssT_FAC_PAG_OutElement;
if(outParamList.ssT_FAC_PAG_Out.Empty) {
// Write the needed fields of the record outParamList.ssT_FAC_PAG_Out.CurrentRec to the tmpoutParamList_ssT_FAC_PAG_OutElement
tmpoutParamList_ssT_FAC_PAG_OutElement = new ssConectaProveedores.RestRecords.RESTST_99acd807840db0272ca95b7e5ca3fca1Structure();
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrKURSF = (decimal?) outParamList.ssT_FAC_PAG_Out.CurrentRec.ssKURSF;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrAUGBL = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssAUGBL;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrWRBTR = (decimal?) outParamList.ssT_FAC_PAG_Out.CurrentRec.ssWRBTR;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrLIFNR = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssLIFNR;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrWRBT2 = (decimal?) outParamList.ssT_FAC_PAG_Out.CurrentRec.ssWRBT2;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrWRBT3 = (decimal?) outParamList.ssT_FAC_PAG_Out.CurrentRec.ssWRBT3;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrXBLNR = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssXBLNR;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrZUONR = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssZUONR;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrZFBDT = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.ssT_FAC_PAG_Out.CurrentRec.ssZFBDT);
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrZTERM = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssZTERM;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrAUGDT = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.ssT_FAC_PAG_Out.CurrentRec.ssAUGDT);
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrWAERS = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssWAERS;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrBLART = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssBLART;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrZLSCH = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssZLSCH;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrUSNAM = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssUSNAM;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrUSRID_LONG = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssUSRID_LONG;
result.outParamList.AttrT_FAC_PAG_Out = new RestList<ssConectaProveedores.RestRecords.RESTST_99acd807840db0272ca95b7e5ca3fca1Structure>(new ssConectaProveedores.RestRecords.RESTST_99acd807840db0272ca95b7e5ca3fca1Structure[] {}, tmpoutParamList_ssT_FAC_PAG_OutElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_99acd807840db0272ca95b7e5ca3fca1Structure>
 tmpoutParamList_ssT_FAC_PAG_Out1List = new List<ssConectaProveedores.RestRecords.RESTST_99acd807840db0272ca95b7e5ca3fca1Structure>
();
try {outParamList.ssT_FAC_PAG_Out.StartIteration();
while (!(outParamList.ssT_FAC_PAG_Out.Eof)) {
// Write the needed fields of the record outParamList.ssT_FAC_PAG_Out.CurrentRec to the tmpoutParamList_ssT_FAC_PAG_OutElement
tmpoutParamList_ssT_FAC_PAG_OutElement = new ssConectaProveedores.RestRecords.RESTST_99acd807840db0272ca95b7e5ca3fca1Structure();
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrKURSF = (decimal?) outParamList.ssT_FAC_PAG_Out.CurrentRec.ssKURSF;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrAUGBL = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssAUGBL;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrWRBTR = (decimal?) outParamList.ssT_FAC_PAG_Out.CurrentRec.ssWRBTR;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrLIFNR = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssLIFNR;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrWRBT2 = (decimal?) outParamList.ssT_FAC_PAG_Out.CurrentRec.ssWRBT2;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrWRBT3 = (decimal?) outParamList.ssT_FAC_PAG_Out.CurrentRec.ssWRBT3;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrXBLNR = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssXBLNR;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrZUONR = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssZUONR;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrZFBDT = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.ssT_FAC_PAG_Out.CurrentRec.ssZFBDT);
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrZTERM = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssZTERM;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrAUGDT = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.ssT_FAC_PAG_Out.CurrentRec.ssAUGDT);
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrWAERS = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssWAERS;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrBLART = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssBLART;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrZLSCH = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssZLSCH;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrUSNAM = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssUSNAM;
tmpoutParamList_ssT_FAC_PAG_OutElement.AttrUSRID_LONG = outParamList.ssT_FAC_PAG_Out.CurrentRec.ssUSRID_LONG;
tmpoutParamList_ssT_FAC_PAG_Out1List.Add(tmpoutParamList_ssT_FAC_PAG_OutElement);
outParamList.ssT_FAC_PAG_Out.Advance();
}

} finally {
outParamList.ssT_FAC_PAG_Out.EndIteration();
}

result.outParamList.AttrT_FAC_PAG_Out = new RestList<ssConectaProveedores.RestRecords.RESTST_99acd807840db0272ca95b7e5ca3fca1Structure>(tmpoutParamList_ssT_FAC_PAG_Out1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_99acd807840db0272ca95b7e5ca3fca1Structure));
}

// Write the needed fields of the list outParamList.ssT_FAC_PAG_CAB_Out to the result.outParamList.AttrT_FAC_PAG_CAB_Out
ssConectaProveedores.RestRecords.RESTST_27647b039a03d40c5b921de2dccb61f4Structure tmpoutParamList_ssT_FAC_PAG_CAB_OutElement;
if(outParamList.ssT_FAC_PAG_CAB_Out.Empty) {
// Write the needed fields of the record outParamList.ssT_FAC_PAG_CAB_Out.CurrentRec to the tmpoutParamList_ssT_FAC_PAG_CAB_OutElement
tmpoutParamList_ssT_FAC_PAG_CAB_OutElement = new ssConectaProveedores.RestRecords.RESTST_27647b039a03d40c5b921de2dccb61f4Structure();
tmpoutParamList_ssT_FAC_PAG_CAB_OutElement.AttrKURSF = (decimal?) outParamList.ssT_FAC_PAG_CAB_Out.CurrentRec.ssKURSF;
tmpoutParamList_ssT_FAC_PAG_CAB_OutElement.AttrAUGBL = outParamList.ssT_FAC_PAG_CAB_Out.CurrentRec.ssAUGBL;
result.outParamList.AttrT_FAC_PAG_CAB_Out = new RestList<ssConectaProveedores.RestRecords.RESTST_27647b039a03d40c5b921de2dccb61f4Structure>(new ssConectaProveedores.RestRecords.RESTST_27647b039a03d40c5b921de2dccb61f4Structure[] {}, tmpoutParamList_ssT_FAC_PAG_CAB_OutElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_27647b039a03d40c5b921de2dccb61f4Structure>
 tmpoutParamList_ssT_FAC_PAG_CAB_Out1List = new List<ssConectaProveedores.RestRecords.RESTST_27647b039a03d40c5b921de2dccb61f4Structure>
();
try {outParamList.ssT_FAC_PAG_CAB_Out.StartIteration();
while (!(outParamList.ssT_FAC_PAG_CAB_Out.Eof)) {
// Write the needed fields of the record outParamList.ssT_FAC_PAG_CAB_Out.CurrentRec to the tmpoutParamList_ssT_FAC_PAG_CAB_OutElement
tmpoutParamList_ssT_FAC_PAG_CAB_OutElement = new ssConectaProveedores.RestRecords.RESTST_27647b039a03d40c5b921de2dccb61f4Structure();
tmpoutParamList_ssT_FAC_PAG_CAB_OutElement.AttrKURSF = (decimal?) outParamList.ssT_FAC_PAG_CAB_Out.CurrentRec.ssKURSF;
tmpoutParamList_ssT_FAC_PAG_CAB_OutElement.AttrAUGBL = outParamList.ssT_FAC_PAG_CAB_Out.CurrentRec.ssAUGBL;
tmpoutParamList_ssT_FAC_PAG_CAB_Out1List.Add(tmpoutParamList_ssT_FAC_PAG_CAB_OutElement);
outParamList.ssT_FAC_PAG_CAB_Out.Advance();
}

} finally {
outParamList.ssT_FAC_PAG_CAB_Out.EndIteration();
}

result.outParamList.AttrT_FAC_PAG_CAB_Out = new RestList<ssConectaProveedores.RestRecords.RESTST_27647b039a03d40c5b921de2dccb61f4Structure>(tmpoutParamList_ssT_FAC_PAG_CAB_Out1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_27647b039a03d40c5b921de2dccb61f4Structure));
}

result.outParamTotalenmonedanacional = (decimal?) outParamTotalenmonedanacional;
result.outParamImportetotaldefacturasmonedaextranjera = (decimal?) outParamImportetotaldefacturasmonedaextranjera;
result.outParamTotalenmonedanacional2 = (decimal?) outParamTotalenmonedanacional2;
result.outParamImportetotaldefacturasmonedaextranjera2 = (decimal?) outParamImportetotaldefacturasmonedaextranjera2;
return result;
}


    public static ConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Model ToModel(RESTConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Outputs variables) {ConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Model result = new ConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Model();
result.outParamList = variables == null ? new ST_382afa1d8361f400b6ea03403d75e294Structure() : ssConectaProveedores.RestRecords.RESTST_382afa1d8361f400b6ea03403d75e294Structure.ToStructure(variables.outParamList);
result.outParamTotalenmonedanacional = variables == null || variables.outParamTotalenmonedanacional == null ? (((decimal)0)) : variables.outParamTotalenmonedanacional.Value;
result.outParamImportetotaldefacturasmonedaextranjera = variables == null || variables.outParamImportetotaldefacturasmonedaextranjera == null ? (((decimal)0)) : variables.outParamImportetotaldefacturasmonedaextranjera.Value;
result.outParamTotalenmonedanacional2 = variables == null || variables.outParamTotalenmonedanacional2 == null ? (((decimal)0)) : variables.outParamTotalenmonedanacional2.Value;
result.outParamImportetotaldefacturasmonedaextranjera2 = variables == null || variables.outParamImportetotaldefacturasmonedaextranjera2 == null ? (((decimal)0)) : variables.outParamImportetotaldefacturasmonedaextranjera2.Value;
return result;
}


    public static RESTConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Outputs result = new RESTConectaProveedores_c_Proveedor_AccountStatus_DataActionGetSapData_Outputs();
result.outParamList = ssConectaProveedores.RestRecords.RESTST_382afa1d8361f400b6ea03403d75e294Structure.FromStructure(screenModel.outParamList, conf);
result.outParamTotalenmonedanacional = (decimal?) screenModel.outParamTotalenmonedanacional;
result.outParamImportetotaldefacturasmonedaextranjera = (decimal?) screenModel.outParamImportetotaldefacturasmonedaextranjera;
result.outParamTotalenmonedanacional2 = (decimal?) screenModel.outParamTotalenmonedanacional2;
result.outParamImportetotaldefacturasmonedaextranjera2 = (decimal?) screenModel.outParamImportetotaldefacturasmonedaextranjera2;
return result;
}

}
