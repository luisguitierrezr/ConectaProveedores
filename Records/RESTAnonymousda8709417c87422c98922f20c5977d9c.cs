using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ReportSAPStatus_ItemRecord
public class RESTRC_46bc538195fa6f6c2cd854e16266e629 : AbstractRESTStructure<RC_46bc538195fa6f6c2cd854e16266e629> {
[JsonProperty("ReportSAPStatus_Item")]
public ssConectaProveedores.RestRecords.RESTST_fc6debbee6469de53c667334dded1d22Structure AttrReportSAPStatus_Item;

public RESTRC_46bc538195fa6f6c2cd854e16266e629() { }

public RESTRC_46bc538195fa6f6c2cd854e16266e629 (RC_46bc538195fa6f6c2cd854e16266e629 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrReportSAPStatus_Item = ConvertToRestWithoutDefaults(s.ssSTReportSAPStatus_Item, new ST_fc6debbee6469de53c667334dded1d22Structure(), ssConectaProveedores.RestRecords.RESTST_fc6debbee6469de53c667334dded1d22Structure.FromStructure, config);
  } else {
AttrReportSAPStatus_Item = ssConectaProveedores.RestRecords.RESTST_fc6debbee6469de53c667334dded1d22Structure.FromStructure(s.ssSTReportSAPStatus_Item, config);
  }
}

public static RC_46bc538195fa6f6c2cd854e16266e629 ToStructure(ssConectaProveedores.RestRecords.RESTRC_46bc538195fa6f6c2cd854e16266e629 obj) { 
  RC_46bc538195fa6f6c2cd854e16266e629 s = new RC_46bc538195fa6f6c2cd854e16266e629();
  if(obj != null) {
  s.ssSTReportSAPStatus_Item = ssConectaProveedores.RestRecords.RESTST_fc6debbee6469de53c667334dded1d22Structure.ToStructure(obj.AttrReportSAPStatus_Item);
  }
  return s;
}

public static Func<RC_46bc538195fa6f6c2cd854e16266e629, ssConectaProveedores.RestRecords.RESTRC_46bc538195fa6f6c2cd854e16266e629> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_46bc538195fa6f6c2cd854e16266e629 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_46bc538195fa6f6c2cd854e16266e629 FromStructure(RC_46bc538195fa6f6c2cd854e16266e629 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_46bc538195fa6f6c2cd854e16266e629(s, config);
}

}


