using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TI_POS_OutRecord
public class JSONRC_fba30a078cd557299475777baf35d313 : AbstractRESTStructure<RC_fba30a078cd557299475777baf35d313> {
[JsonProperty("TI_POS_Out")]
[JsonPropertyName("TI_POS_Out")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure AttrTI_POS_Out;

public JSONRC_fba30a078cd557299475777baf35d313() { }

public JSONRC_fba30a078cd557299475777baf35d313 (RC_fba30a078cd557299475777baf35d313 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_POS_Out = ConvertToRestWithoutDefaults(s.ssSTTI_POS_Out, new ST_26cbe75ae3e20157af048dd188f74dc2Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure.FromStructure, config);
  } else {
AttrTI_POS_Out = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure.FromStructure(s.ssSTTI_POS_Out, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_fba30a078cd557299475777baf35d313, RC_fba30a078cd557299475777baf35d313> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_fba30a078cd557299475777baf35d313 s) => ToStructure(s, config);
}
public static RC_fba30a078cd557299475777baf35d313 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_fba30a078cd557299475777baf35d313 obj, IBehaviorsConfiguration config) { 
  RC_fba30a078cd557299475777baf35d313 s = new RC_fba30a078cd557299475777baf35d313();
  if(obj != null) {
  s.ssSTTI_POS_Out = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure.ToStructure(obj.AttrTI_POS_Out, config);
  }
  return s;
}

public static Func<RC_fba30a078cd557299475777baf35d313, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_fba30a078cd557299475777baf35d313> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_fba30a078cd557299475777baf35d313 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_fba30a078cd557299475777baf35d313 FromStructure(RC_fba30a078cd557299475777baf35d313 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_fba30a078cd557299475777baf35d313(s, config);
}

}


