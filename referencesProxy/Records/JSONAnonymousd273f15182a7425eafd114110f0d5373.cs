using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// CfdFileWrapperRecord
public class JSONRC_22b8d69f2e3592de5742131565fc1e67 : AbstractRESTStructure<RC_22b8d69f2e3592de5742131565fc1e67> {
[JsonProperty("CfdFileWrapper")]
[JsonPropertyName("CfdFileWrapper")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure AttrCfdFileWrapper;

public JSONRC_22b8d69f2e3592de5742131565fc1e67() { }

public JSONRC_22b8d69f2e3592de5742131565fc1e67 (RC_22b8d69f2e3592de5742131565fc1e67 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCfdFileWrapper = ConvertToRestWithoutDefaults(s.ssSTCfdFileWrapper, new ST_1e51b813a2c6a26cea1c6c8c17329da8Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure.FromStructure, config);
  } else {
AttrCfdFileWrapper = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure.FromStructure(s.ssSTCfdFileWrapper, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_22b8d69f2e3592de5742131565fc1e67, RC_22b8d69f2e3592de5742131565fc1e67> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_22b8d69f2e3592de5742131565fc1e67 s) => ToStructure(s, config);
}
public static RC_22b8d69f2e3592de5742131565fc1e67 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_22b8d69f2e3592de5742131565fc1e67 obj, IBehaviorsConfiguration config) { 
  RC_22b8d69f2e3592de5742131565fc1e67 s = new RC_22b8d69f2e3592de5742131565fc1e67();
  if(obj != null) {
  s.ssSTCfdFileWrapper = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_1e51b813a2c6a26cea1c6c8c17329da8Structure.ToStructure(obj.AttrCfdFileWrapper, config);
  }
  return s;
}

public static Func<RC_22b8d69f2e3592de5742131565fc1e67, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_22b8d69f2e3592de5742131565fc1e67> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_22b8d69f2e3592de5742131565fc1e67 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_22b8d69f2e3592de5742131565fc1e67 FromStructure(RC_22b8d69f2e3592de5742131565fc1e67 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_22b8d69f2e3592de5742131565fc1e67(s, config);
}

}


