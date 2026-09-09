using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationAccountRecord
public class JSONRC_a64eb89b2a60d0e75a7895ec0d3f2a26 : AbstractRESTStructure<RC_a64eb89b2a60d0e75a7895ec0d3f2a26> {
[JsonProperty("DocumentExtrationAccount")]
[JsonPropertyName("DocumentExtrationAccount")]
public ssConectaProveedores.RestRecords.JSONST_1074864f28737110728a1225e98b6e34Structure AttrDocumentExtrationAccount;

public JSONRC_a64eb89b2a60d0e75a7895ec0d3f2a26() { }

public JSONRC_a64eb89b2a60d0e75a7895ec0d3f2a26 (RC_a64eb89b2a60d0e75a7895ec0d3f2a26 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationAccount = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationAccount, new ST_1074864f28737110728a1225e98b6e34Structure(), ssConectaProveedores.RestRecords.JSONST_1074864f28737110728a1225e98b6e34Structure.FromStructure, config);
  } else {
AttrDocumentExtrationAccount = ssConectaProveedores.RestRecords.JSONST_1074864f28737110728a1225e98b6e34Structure.FromStructure(s.ssSTDocumentExtrationAccount, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_a64eb89b2a60d0e75a7895ec0d3f2a26, RC_a64eb89b2a60d0e75a7895ec0d3f2a26> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_a64eb89b2a60d0e75a7895ec0d3f2a26 s) => ToStructure(s, config);
}
public static RC_a64eb89b2a60d0e75a7895ec0d3f2a26 ToStructure(ssConectaProveedores.RestRecords.JSONRC_a64eb89b2a60d0e75a7895ec0d3f2a26 obj, IBehaviorsConfiguration config) { 
  RC_a64eb89b2a60d0e75a7895ec0d3f2a26 s = new RC_a64eb89b2a60d0e75a7895ec0d3f2a26();
  if(obj != null) {
  s.ssSTDocumentExtrationAccount = ssConectaProveedores.RestRecords.JSONST_1074864f28737110728a1225e98b6e34Structure.ToStructure(obj.AttrDocumentExtrationAccount, config);
  }
  return s;
}

public static Func<RC_a64eb89b2a60d0e75a7895ec0d3f2a26, ssConectaProveedores.RestRecords.JSONRC_a64eb89b2a60d0e75a7895ec0d3f2a26> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a64eb89b2a60d0e75a7895ec0d3f2a26 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_a64eb89b2a60d0e75a7895ec0d3f2a26 FromStructure(RC_a64eb89b2a60d0e75a7895ec0d3f2a26 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_a64eb89b2a60d0e75a7895ec0d3f2a26(s, config);
}

}


