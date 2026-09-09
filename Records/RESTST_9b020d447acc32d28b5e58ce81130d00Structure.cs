using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderTemp
public class RESTST_9b020d447acc32d28b5e58ce81130d00Structure : AbstractRESTStructure<ST_9b020d447acc32d28b5e58ce81130d00Structure> {
[JsonProperty("TotalAmount")]
public string AttrTotalAmount;

public RESTST_9b020d447acc32d28b5e58ce81130d00Structure() { }

public RESTST_9b020d447acc32d28b5e58ce81130d00Structure (ST_9b020d447acc32d28b5e58ce81130d00Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTotalAmount = ConvertToRestWithoutDefaults(s.ssTotalAmount, "");
  } else {
AttrTotalAmount = s.ssTotalAmount;
  }
}

public static ST_9b020d447acc32d28b5e58ce81130d00Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_9b020d447acc32d28b5e58ce81130d00Structure obj) { 
  ST_9b020d447acc32d28b5e58ce81130d00Structure s = new ST_9b020d447acc32d28b5e58ce81130d00Structure();
  if(obj != null) {
  s.ssTotalAmount = obj.AttrTotalAmount == null ? "" : obj.AttrTotalAmount;
  }
  return s;
}

public static Func<ST_9b020d447acc32d28b5e58ce81130d00Structure, ssConectaProveedores.RestRecords.RESTST_9b020d447acc32d28b5e58ce81130d00Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_9b020d447acc32d28b5e58ce81130d00Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_9b020d447acc32d28b5e58ce81130d00Structure FromStructure(ST_9b020d447acc32d28b5e58ce81130d00Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_9b020d447acc32d28b5e58ce81130d00Structure(s, config);
}

}


