using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationAccountRecord
public class RESTRC_a64eb89b2a60d0e75a7895ec0d3f2a26 : AbstractRESTStructure<RC_a64eb89b2a60d0e75a7895ec0d3f2a26> {
[JsonProperty("DocumentExtrationAccount")]
public ssConectaProveedores.RestRecords.RESTST_1074864f28737110728a1225e98b6e34Structure AttrDocumentExtrationAccount;

public RESTRC_a64eb89b2a60d0e75a7895ec0d3f2a26() { }

public RESTRC_a64eb89b2a60d0e75a7895ec0d3f2a26 (RC_a64eb89b2a60d0e75a7895ec0d3f2a26 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationAccount = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationAccount, new ST_1074864f28737110728a1225e98b6e34Structure(), ssConectaProveedores.RestRecords.RESTST_1074864f28737110728a1225e98b6e34Structure.FromStructure, config);
  } else {
AttrDocumentExtrationAccount = ssConectaProveedores.RestRecords.RESTST_1074864f28737110728a1225e98b6e34Structure.FromStructure(s.ssSTDocumentExtrationAccount, config);
  }
}

public static RC_a64eb89b2a60d0e75a7895ec0d3f2a26 ToStructure(ssConectaProveedores.RestRecords.RESTRC_a64eb89b2a60d0e75a7895ec0d3f2a26 obj) { 
  RC_a64eb89b2a60d0e75a7895ec0d3f2a26 s = new RC_a64eb89b2a60d0e75a7895ec0d3f2a26();
  if(obj != null) {
  s.ssSTDocumentExtrationAccount = ssConectaProveedores.RestRecords.RESTST_1074864f28737110728a1225e98b6e34Structure.ToStructure(obj.AttrDocumentExtrationAccount);
  }
  return s;
}

public static Func<RC_a64eb89b2a60d0e75a7895ec0d3f2a26, ssConectaProveedores.RestRecords.RESTRC_a64eb89b2a60d0e75a7895ec0d3f2a26> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_a64eb89b2a60d0e75a7895ec0d3f2a26 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_a64eb89b2a60d0e75a7895ec0d3f2a26 FromStructure(RC_a64eb89b2a60d0e75a7895ec0d3f2a26 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_a64eb89b2a60d0e75a7895ec0d3f2a26(s, config);
}

}


