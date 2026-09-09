using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_SM3Record
public class RESTRC_235876c2392dec3fee0f6332b46ff11b : AbstractRESTStructure<RC_235876c2392dec3fee0f6332b46ff11b> {
[JsonProperty("PI_ITEM_SM3")]
public ssConectaProveedores.RestRecords.RESTST_21ada127931bc47aabf2d9a5964b17feStructure AttrPI_ITEM_SM3;

public RESTRC_235876c2392dec3fee0f6332b46ff11b() { }

public RESTRC_235876c2392dec3fee0f6332b46ff11b (RC_235876c2392dec3fee0f6332b46ff11b s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_SM3 = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_SM3, new ST_21ada127931bc47aabf2d9a5964b17feStructure(), ssConectaProveedores.RestRecords.RESTST_21ada127931bc47aabf2d9a5964b17feStructure.FromStructure, config);
  } else {
AttrPI_ITEM_SM3 = ssConectaProveedores.RestRecords.RESTST_21ada127931bc47aabf2d9a5964b17feStructure.FromStructure(s.ssSTPI_ITEM_SM3, config);
  }
}

public static RC_235876c2392dec3fee0f6332b46ff11b ToStructure(ssConectaProveedores.RestRecords.RESTRC_235876c2392dec3fee0f6332b46ff11b obj) { 
  RC_235876c2392dec3fee0f6332b46ff11b s = new RC_235876c2392dec3fee0f6332b46ff11b();
  if(obj != null) {
  s.ssSTPI_ITEM_SM3 = ssConectaProveedores.RestRecords.RESTST_21ada127931bc47aabf2d9a5964b17feStructure.ToStructure(obj.AttrPI_ITEM_SM3);
  }
  return s;
}

public static Func<RC_235876c2392dec3fee0f6332b46ff11b, ssConectaProveedores.RestRecords.RESTRC_235876c2392dec3fee0f6332b46ff11b> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_235876c2392dec3fee0f6332b46ff11b s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_235876c2392dec3fee0f6332b46ff11b FromStructure(RC_235876c2392dec3fee0f6332b46ff11b s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_235876c2392dec3fee0f6332b46ff11b(s, config);
}

}


