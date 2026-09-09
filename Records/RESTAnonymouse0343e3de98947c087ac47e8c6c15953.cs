using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_POS_OutRecord
public class RESTRC_fba30a078cd557299475777baf35d313 : AbstractRESTStructure<RC_fba30a078cd557299475777baf35d313> {
[JsonProperty("TI_POS_Out")]
public ssConectaProveedores.RestRecords.RESTST_26cbe75ae3e20157af048dd188f74dc2Structure AttrTI_POS_Out;

public RESTRC_fba30a078cd557299475777baf35d313() { }

public RESTRC_fba30a078cd557299475777baf35d313 (RC_fba30a078cd557299475777baf35d313 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_POS_Out = ConvertToRestWithoutDefaults(s.ssSTTI_POS_Out, new ST_26cbe75ae3e20157af048dd188f74dc2Structure(), ssConectaProveedores.RestRecords.RESTST_26cbe75ae3e20157af048dd188f74dc2Structure.FromStructure, config);
  } else {
AttrTI_POS_Out = ssConectaProveedores.RestRecords.RESTST_26cbe75ae3e20157af048dd188f74dc2Structure.FromStructure(s.ssSTTI_POS_Out, config);
  }
}

public static RC_fba30a078cd557299475777baf35d313 ToStructure(ssConectaProveedores.RestRecords.RESTRC_fba30a078cd557299475777baf35d313 obj) { 
  RC_fba30a078cd557299475777baf35d313 s = new RC_fba30a078cd557299475777baf35d313();
  if(obj != null) {
  s.ssSTTI_POS_Out = ssConectaProveedores.RestRecords.RESTST_26cbe75ae3e20157af048dd188f74dc2Structure.ToStructure(obj.AttrTI_POS_Out);
  }
  return s;
}

public static Func<RC_fba30a078cd557299475777baf35d313, ssConectaProveedores.RestRecords.RESTRC_fba30a078cd557299475777baf35d313> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fba30a078cd557299475777baf35d313 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_fba30a078cd557299475777baf35d313 FromStructure(RC_fba30a078cd557299475777baf35d313 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_fba30a078cd557299475777baf35d313(s, config);
}

}


