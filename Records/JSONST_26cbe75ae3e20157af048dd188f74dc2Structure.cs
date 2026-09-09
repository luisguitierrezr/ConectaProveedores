using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_POS_Out
public class JSONST_26cbe75ae3e20157af048dd188f74dc2Structure : AbstractRESTStructure<ST_26cbe75ae3e20157af048dd188f74dc2Structure> {
[JsonProperty("PARAMETRO")]
[JsonPropertyName("PARAMETRO")]
public string AttrPARAMETRO;

public JSONST_26cbe75ae3e20157af048dd188f74dc2Structure() { }

public JSONST_26cbe75ae3e20157af048dd188f74dc2Structure (ST_26cbe75ae3e20157af048dd188f74dc2Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPARAMETRO = ConvertToRestWithoutDefaults(s.ssPARAMETRO, "");
  } else {
AttrPARAMETRO = s.ssPARAMETRO;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure, ST_26cbe75ae3e20157af048dd188f74dc2Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure s) => ToStructure(s, config);
}
public static ST_26cbe75ae3e20157af048dd188f74dc2Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure obj, IBehaviorsConfiguration config) { 
  ST_26cbe75ae3e20157af048dd188f74dc2Structure s = new ST_26cbe75ae3e20157af048dd188f74dc2Structure();
  if(obj != null) {
  s.ssPARAMETRO = obj.AttrPARAMETRO == null ? "" : obj.AttrPARAMETRO;
  }
  return s;
}

public static Func<ST_26cbe75ae3e20157af048dd188f74dc2Structure, ssConectaProveedores.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_26cbe75ae3e20157af048dd188f74dc2Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure FromStructure(ST_26cbe75ae3e20157af048dd188f74dc2Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_26cbe75ae3e20157af048dd188f74dc2Structure(s, config);
}

}


