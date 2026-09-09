using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FilesJsonRecord
public class RESTRC_4d24471d0d73e8226f7ca6dd09937c26 : AbstractRESTStructure<RC_4d24471d0d73e8226f7ca6dd09937c26> {
[JsonProperty("FilesJson")]
public ssConectaProveedores.RestRecords.RESTST_6c0a0d3b1d72414f90bb9301bad200fbStructure AttrFilesJson;

public RESTRC_4d24471d0d73e8226f7ca6dd09937c26() { }

public RESTRC_4d24471d0d73e8226f7ca6dd09937c26 (RC_4d24471d0d73e8226f7ca6dd09937c26 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFilesJson = ConvertToRestWithoutDefaults(s.ssSTFilesJson, new ST_6c0a0d3b1d72414f90bb9301bad200fbStructure(), ssConectaProveedores.RestRecords.RESTST_6c0a0d3b1d72414f90bb9301bad200fbStructure.FromStructure, config);
  } else {
AttrFilesJson = ssConectaProveedores.RestRecords.RESTST_6c0a0d3b1d72414f90bb9301bad200fbStructure.FromStructure(s.ssSTFilesJson, config);
  }
}

public static RC_4d24471d0d73e8226f7ca6dd09937c26 ToStructure(ssConectaProveedores.RestRecords.RESTRC_4d24471d0d73e8226f7ca6dd09937c26 obj) { 
  RC_4d24471d0d73e8226f7ca6dd09937c26 s = new RC_4d24471d0d73e8226f7ca6dd09937c26();
  if(obj != null) {
  s.ssSTFilesJson = ssConectaProveedores.RestRecords.RESTST_6c0a0d3b1d72414f90bb9301bad200fbStructure.ToStructure(obj.AttrFilesJson);
  }
  return s;
}

public static Func<RC_4d24471d0d73e8226f7ca6dd09937c26, ssConectaProveedores.RestRecords.RESTRC_4d24471d0d73e8226f7ca6dd09937c26> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4d24471d0d73e8226f7ca6dd09937c26 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_4d24471d0d73e8226f7ca6dd09937c26 FromStructure(RC_4d24471d0d73e8226f7ca6dd09937c26 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_4d24471d0d73e8226f7ca6dd09937c26(s, config);
}

}


