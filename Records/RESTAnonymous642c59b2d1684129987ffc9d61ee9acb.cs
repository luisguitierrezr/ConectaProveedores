using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEMRecord
public class RESTRC_5b3a110e736062950b0c6cfa935e61d0 : AbstractRESTStructure<RC_5b3a110e736062950b0c6cfa935e61d0> {
[JsonProperty("PI_ITEM")]
public ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure AttrPI_ITEM;

public RESTRC_5b3a110e736062950b0c6cfa935e61d0() { }

public RESTRC_5b3a110e736062950b0c6cfa935e61d0 (RC_5b3a110e736062950b0c6cfa935e61d0 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM, new ST_d34c4878f870709fdbf7a3e48e70a4edStructure(), ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure.FromStructure, config);
  } else {
AttrPI_ITEM = ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure.FromStructure(s.ssSTPI_ITEM, config);
  }
}

public static RC_5b3a110e736062950b0c6cfa935e61d0 ToStructure(ssConectaProveedores.RestRecords.RESTRC_5b3a110e736062950b0c6cfa935e61d0 obj) { 
  RC_5b3a110e736062950b0c6cfa935e61d0 s = new RC_5b3a110e736062950b0c6cfa935e61d0();
  if(obj != null) {
  s.ssSTPI_ITEM = ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure.ToStructure(obj.AttrPI_ITEM);
  }
  return s;
}

public static Func<RC_5b3a110e736062950b0c6cfa935e61d0, ssConectaProveedores.RestRecords.RESTRC_5b3a110e736062950b0c6cfa935e61d0> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5b3a110e736062950b0c6cfa935e61d0 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_5b3a110e736062950b0c6cfa935e61d0 FromStructure(RC_5b3a110e736062950b0c6cfa935e61d0 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_5b3a110e736062950b0c6cfa935e61d0(s, config);
}

}


