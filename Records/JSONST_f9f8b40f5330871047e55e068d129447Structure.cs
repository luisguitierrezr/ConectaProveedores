using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// MFU_Error
public class JSONST_f9f8b40f5330871047e55e068d129447Structure : AbstractRESTStructure<ST_f9f8b40f5330871047e55e068d129447Structure> {
[JsonProperty("Success")]
[JsonPropertyName("Success")]
public bool? AttrSuccess;

[JsonProperty("ErrorMessage")]
[JsonPropertyName("ErrorMessage")]
public string AttrErrorMessage;

public JSONST_f9f8b40f5330871047e55e068d129447Structure() { }

public JSONST_f9f8b40f5330871047e55e068d129447Structure (ST_f9f8b40f5330871047e55e068d129447Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSuccess = ConvertToRestWithoutDefaults(s.ssSuccess, false);
AttrErrorMessage = ConvertToRestWithoutDefaults(s.ssErrorMessage, "");
  } else {
AttrSuccess = (bool?) s.ssSuccess;
AttrErrorMessage = s.ssErrorMessage;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_f9f8b40f5330871047e55e068d129447Structure, ST_f9f8b40f5330871047e55e068d129447Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_f9f8b40f5330871047e55e068d129447Structure s) => ToStructure(s, config);
}
public static ST_f9f8b40f5330871047e55e068d129447Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_f9f8b40f5330871047e55e068d129447Structure obj, IBehaviorsConfiguration config) { 
  ST_f9f8b40f5330871047e55e068d129447Structure s = new ST_f9f8b40f5330871047e55e068d129447Structure();
  if(obj != null) {
  s.ssSuccess = obj.AttrSuccess == null ? false : obj.AttrSuccess.Value;
  s.ssErrorMessage = obj.AttrErrorMessage == null ? "" : obj.AttrErrorMessage;
  }
  return s;
}

public static Func<ST_f9f8b40f5330871047e55e068d129447Structure, ssConectaProveedores.RestRecords.JSONST_f9f8b40f5330871047e55e068d129447Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f9f8b40f5330871047e55e068d129447Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_f9f8b40f5330871047e55e068d129447Structure FromStructure(ST_f9f8b40f5330871047e55e068d129447Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_f9f8b40f5330871047e55e068d129447Structure(s, config);
}

}


