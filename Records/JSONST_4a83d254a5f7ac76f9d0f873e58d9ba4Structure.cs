using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// BAPI_ZMXFAPMF_CONSUL_RETENPROV_Req
public class JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure : AbstractRESTStructure<ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure> {
[JsonProperty("PI_BUKRS")]
[JsonPropertyName("PI_BUKRS")]
public string AttrPI_BUKRS;

[JsonProperty("PI_VENDORNO")]
[JsonPropertyName("PI_VENDORNO")]
public string AttrPI_VENDORNO;

[JsonProperty("TI_RETENCIONES_In")]
[JsonPropertyName("TI_RETENCIONES_In")]
public ssConectaProveedores.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure[] AttrTI_RETENCIONES_In;

public JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure() { }

public JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure (ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_BUKRS = s.ssPI_BUKRS;
AttrPI_VENDORNO = s.ssPI_VENDORNO;
AttrTI_RETENCIONES_In = s.ssTI_RETENCIONES_In.Length == 0 ? null : s.ssTI_RETENCIONES_In.ToArray<ssConectaProveedores.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure>(ssConectaProveedores.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure.FromStructureDelegate(config));
  } else {
AttrPI_BUKRS = s.ssPI_BUKRS;
AttrPI_VENDORNO = s.ssPI_VENDORNO;
AttrTI_RETENCIONES_In = s.ssTI_RETENCIONES_In.ToArray<ssConectaProveedores.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure>(ssConectaProveedores.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure, ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure s) => ToStructure(s, config);
}
public static ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure obj, IBehaviorsConfiguration config) { 
  ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure s = new ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure();
  if(obj != null) {
  s.ssPI_BUKRS = obj.AttrPI_BUKRS == null ? "" : obj.AttrPI_BUKRS;
  s.ssPI_VENDORNO = obj.AttrPI_VENDORNO == null ? "" : obj.AttrPI_VENDORNO;
  s.ssTI_RETENCIONES_In = RL_772621b2ef7c10f920402993065f4a21.ToList(obj.AttrTI_RETENCIONES_In, ssConectaProveedores.RestRecords.JSONST_2859defd6257fe38677ed819621e4236Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure, ssConectaProveedores.RestRecords.JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure FromStructure(ST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_4a83d254a5f7ac76f9d0f873e58d9ba4Structure(s, config);
}

}


