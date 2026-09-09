using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderTemp
public class JSONST_9b020d447acc32d28b5e58ce81130d00Structure : AbstractRESTStructure<ST_9b020d447acc32d28b5e58ce81130d00Structure> {
[JsonProperty("TotalAmount")]
[JsonPropertyName("TotalAmount")]
public string AttrTotalAmount;

public JSONST_9b020d447acc32d28b5e58ce81130d00Structure() { }

public JSONST_9b020d447acc32d28b5e58ce81130d00Structure (ST_9b020d447acc32d28b5e58ce81130d00Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, "");
  } else {
AttrTotalAmount = s.ssTotalAmount;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_9b020d447acc32d28b5e58ce81130d00Structure, ST_9b020d447acc32d28b5e58ce81130d00Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_9b020d447acc32d28b5e58ce81130d00Structure s) => ToStructure(s, config);
}
public static ST_9b020d447acc32d28b5e58ce81130d00Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_9b020d447acc32d28b5e58ce81130d00Structure obj, IBehaviorsConfiguration config) { 
  ST_9b020d447acc32d28b5e58ce81130d00Structure s = new ST_9b020d447acc32d28b5e58ce81130d00Structure();
  if(obj != null) {
  s.ssTotalAmount = obj.AttrTotalAmount == null ? "" : obj.AttrTotalAmount;
  }
  return s;
}

public static Func<ST_9b020d447acc32d28b5e58ce81130d00Structure, ssConectaProveedores.RestRecords.JSONST_9b020d447acc32d28b5e58ce81130d00Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9b020d447acc32d28b5e58ce81130d00Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_9b020d447acc32d28b5e58ce81130d00Structure FromStructure(ST_9b020d447acc32d28b5e58ce81130d00Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_9b020d447acc32d28b5e58ce81130d00Structure(s, config);
}

}


