using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// CfdFileWrapperRecord
public class RESTRC_22b8d69f2e3592de5742131565fc1e67 : AbstractRESTStructure<RC_22b8d69f2e3592de5742131565fc1e67> {
[JsonProperty("CfdFileWrapper")]
public ssConectaProveedores.RestRecords.RESTST_1e51b813a2c6a26cea1c6c8c17329da8Structure AttrCfdFileWrapper;

public RESTRC_22b8d69f2e3592de5742131565fc1e67() { }

public RESTRC_22b8d69f2e3592de5742131565fc1e67 (RC_22b8d69f2e3592de5742131565fc1e67 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrCfdFileWrapper = ConvertToRestWithoutDefaults(s.ssSTCfdFileWrapper, new ST_1e51b813a2c6a26cea1c6c8c17329da8Structure(), ssConectaProveedores.RestRecords.RESTST_1e51b813a2c6a26cea1c6c8c17329da8Structure.FromStructure, config);
  } else {
AttrCfdFileWrapper = ssConectaProveedores.RestRecords.RESTST_1e51b813a2c6a26cea1c6c8c17329da8Structure.FromStructure(s.ssSTCfdFileWrapper, config);
  }
}

public static RC_22b8d69f2e3592de5742131565fc1e67 ToStructure(ssConectaProveedores.RestRecords.RESTRC_22b8d69f2e3592de5742131565fc1e67 obj) { 
  RC_22b8d69f2e3592de5742131565fc1e67 s = new RC_22b8d69f2e3592de5742131565fc1e67();
  if(obj != null) {
  s.ssSTCfdFileWrapper = ssConectaProveedores.RestRecords.RESTST_1e51b813a2c6a26cea1c6c8c17329da8Structure.ToStructure(obj.AttrCfdFileWrapper);
  }
  return s;
}

public static Func<RC_22b8d69f2e3592de5742131565fc1e67, ssConectaProveedores.RestRecords.RESTRC_22b8d69f2e3592de5742131565fc1e67> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_22b8d69f2e3592de5742131565fc1e67 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_22b8d69f2e3592de5742131565fc1e67 FromStructure(RC_22b8d69f2e3592de5742131565fc1e67 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_22b8d69f2e3592de5742131565fc1e67(s, config);
}

}


