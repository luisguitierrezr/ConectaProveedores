using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FilesJsonRecord
public class JSONRC_4d24471d0d73e8226f7ca6dd09937c26 : AbstractRESTStructure<RC_4d24471d0d73e8226f7ca6dd09937c26> {
[JsonProperty("FilesJson")]
[JsonPropertyName("FilesJson")]
public ssConectaProveedores.RestRecords.JSONST_6c0a0d3b1d72414f90bb9301bad200fbStructure AttrFilesJson;

public JSONRC_4d24471d0d73e8226f7ca6dd09937c26() { }

public JSONRC_4d24471d0d73e8226f7ca6dd09937c26 (RC_4d24471d0d73e8226f7ca6dd09937c26 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFilesJson = ConvertToRestWithoutDefaults(s.ssSTFilesJson, new ST_6c0a0d3b1d72414f90bb9301bad200fbStructure(), ssConectaProveedores.RestRecords.JSONST_6c0a0d3b1d72414f90bb9301bad200fbStructure.FromStructure, config);
  } else {
AttrFilesJson = ssConectaProveedores.RestRecords.JSONST_6c0a0d3b1d72414f90bb9301bad200fbStructure.FromStructure(s.ssSTFilesJson, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_4d24471d0d73e8226f7ca6dd09937c26, RC_4d24471d0d73e8226f7ca6dd09937c26> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_4d24471d0d73e8226f7ca6dd09937c26 s) => ToStructure(s, config);
}
public static RC_4d24471d0d73e8226f7ca6dd09937c26 ToStructure(ssConectaProveedores.RestRecords.JSONRC_4d24471d0d73e8226f7ca6dd09937c26 obj, IBehaviorsConfiguration config) { 
  RC_4d24471d0d73e8226f7ca6dd09937c26 s = new RC_4d24471d0d73e8226f7ca6dd09937c26();
  if(obj != null) {
  s.ssSTFilesJson = ssConectaProveedores.RestRecords.JSONST_6c0a0d3b1d72414f90bb9301bad200fbStructure.ToStructure(obj.AttrFilesJson, config);
  }
  return s;
}

public static Func<RC_4d24471d0d73e8226f7ca6dd09937c26, ssConectaProveedores.RestRecords.JSONRC_4d24471d0d73e8226f7ca6dd09937c26> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4d24471d0d73e8226f7ca6dd09937c26 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_4d24471d0d73e8226f7ca6dd09937c26 FromStructure(RC_4d24471d0d73e8226f7ca6dd09937c26 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_4d24471d0d73e8226f7ca6dd09937c26(s, config);
}

}


