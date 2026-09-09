using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// HTTPRequestRecord
public class JSONRC_d32d3dec6fa4abe9694e52a298b9cce9 : AbstractRESTStructure<RC_d32d3dec6fa4abe9694e52a298b9cce9> {
[JsonProperty("HTTPRequest")]
[JsonPropertyName("HTTPRequest")]
public ssConectaProveedores.RestRecords.JSONST_ea2141f4206e3eb2cd0fdd847e008166Structure AttrHTTPRequest;

public JSONRC_d32d3dec6fa4abe9694e52a298b9cce9() { }

public JSONRC_d32d3dec6fa4abe9694e52a298b9cce9 (RC_d32d3dec6fa4abe9694e52a298b9cce9 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrHTTPRequest = ConvertToRestWithoutDefaults(s.ssSTHTTPRequest, new ST_ea2141f4206e3eb2cd0fdd847e008166Structure(), ssConectaProveedores.RestRecords.JSONST_ea2141f4206e3eb2cd0fdd847e008166Structure.FromStructure, config);
  } else {
AttrHTTPRequest = ssConectaProveedores.RestRecords.JSONST_ea2141f4206e3eb2cd0fdd847e008166Structure.FromStructure(s.ssSTHTTPRequest, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_d32d3dec6fa4abe9694e52a298b9cce9, RC_d32d3dec6fa4abe9694e52a298b9cce9> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_d32d3dec6fa4abe9694e52a298b9cce9 s) => ToStructure(s, config);
}
public static RC_d32d3dec6fa4abe9694e52a298b9cce9 ToStructure(ssConectaProveedores.RestRecords.JSONRC_d32d3dec6fa4abe9694e52a298b9cce9 obj, IBehaviorsConfiguration config) { 
  RC_d32d3dec6fa4abe9694e52a298b9cce9 s = new RC_d32d3dec6fa4abe9694e52a298b9cce9();
  if(obj != null) {
  s.ssSTHTTPRequest = ssConectaProveedores.RestRecords.JSONST_ea2141f4206e3eb2cd0fdd847e008166Structure.ToStructure(obj.AttrHTTPRequest, config);
  }
  return s;
}

public static Func<RC_d32d3dec6fa4abe9694e52a298b9cce9, ssConectaProveedores.RestRecords.JSONRC_d32d3dec6fa4abe9694e52a298b9cce9> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d32d3dec6fa4abe9694e52a298b9cce9 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_d32d3dec6fa4abe9694e52a298b9cce9 FromStructure(RC_d32d3dec6fa4abe9694e52a298b9cce9 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_d32d3dec6fa4abe9694e52a298b9cce9(s, config);
}

}


