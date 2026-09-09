using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ItemSMRecord
public class RESTRC_bc90ae5f0dadb418c4abf32f2cb9fe8c : AbstractRESTStructure<RC_bc90ae5f0dadb418c4abf32f2cb9fe8c> {
[JsonProperty("ItemSM")]
public ssConectaProveedores.RestRecords.RESTST_ab77394b00ae0f5875687584d175cf59Structure AttrItemSM;

public RESTRC_bc90ae5f0dadb418c4abf32f2cb9fe8c() { }

public RESTRC_bc90ae5f0dadb418c4abf32f2cb9fe8c (RC_bc90ae5f0dadb418c4abf32f2cb9fe8c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrItemSM = ConvertToRestWithoutDefaults(s.ssSTItemSM, new ST_ab77394b00ae0f5875687584d175cf59Structure(), ssConectaProveedores.RestRecords.RESTST_ab77394b00ae0f5875687584d175cf59Structure.FromStructure, config);
  } else {
AttrItemSM = ssConectaProveedores.RestRecords.RESTST_ab77394b00ae0f5875687584d175cf59Structure.FromStructure(s.ssSTItemSM, config);
  }
}

public static RC_bc90ae5f0dadb418c4abf32f2cb9fe8c ToStructure(ssConectaProveedores.RestRecords.RESTRC_bc90ae5f0dadb418c4abf32f2cb9fe8c obj) { 
  RC_bc90ae5f0dadb418c4abf32f2cb9fe8c s = new RC_bc90ae5f0dadb418c4abf32f2cb9fe8c();
  if(obj != null) {
  s.ssSTItemSM = ssConectaProveedores.RestRecords.RESTST_ab77394b00ae0f5875687584d175cf59Structure.ToStructure(obj.AttrItemSM);
  }
  return s;
}

public static Func<RC_bc90ae5f0dadb418c4abf32f2cb9fe8c, ssConectaProveedores.RestRecords.RESTRC_bc90ae5f0dadb418c4abf32f2cb9fe8c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bc90ae5f0dadb418c4abf32f2cb9fe8c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_bc90ae5f0dadb418c4abf32f2cb9fe8c FromStructure(RC_bc90ae5f0dadb418c4abf32f2cb9fe8c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_bc90ae5f0dadb418c4abf32f2cb9fe8c(s, config);
}

}


