using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TI_POS_In
public class JSONST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure : AbstractRESTStructure<ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure> {
[JsonProperty("PARAMETRO")]
[JsonPropertyName("PARAMETRO")]
public string AttrPARAMETRO;

public JSONST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure() { }

public JSONST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure (ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPARAMETRO = ConvertToRestWithoutDefaults(s.ssPARAMETRO, "");
  } else {
AttrPARAMETRO = s.ssPARAMETRO;
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure, ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure s) => ToStructure(s, config);
}
public static ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure obj, IBehaviorsConfiguration config) { 
  ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure s = new ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure();
  if(obj != null) {
  s.ssPARAMETRO = obj.AttrPARAMETRO == null ? "" : obj.AttrPARAMETRO;
  }
  return s;
}

public static Func<ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure FromStructure(ST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_b1e959d1ca95497ef5f6ec59a9b0e5dbStructure(s, config);
}

}


