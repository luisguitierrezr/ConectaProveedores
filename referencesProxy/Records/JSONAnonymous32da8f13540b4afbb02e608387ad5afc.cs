using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// TI_ITEM_OutRecord
public class JSONRC_0b4f56146907ab8c6c6acba005eb328c : AbstractRESTStructure<RC_0b4f56146907ab8c6c6acba005eb328c> {
[JsonProperty("TI_ITEM_Out")]
[JsonPropertyName("TI_ITEM_Out")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3b61de88b81d785d0616b445a04890fdStructure AttrTI_ITEM_Out;

public JSONRC_0b4f56146907ab8c6c6acba005eb328c() { }

public JSONRC_0b4f56146907ab8c6c6acba005eb328c (RC_0b4f56146907ab8c6c6acba005eb328c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_ITEM_Out = ConvertToRestWithoutDefaults(s.ssSTTI_ITEM_Out, new ST_3b61de88b81d785d0616b445a04890fdStructure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3b61de88b81d785d0616b445a04890fdStructure.FromStructure, config);
  } else {
AttrTI_ITEM_Out = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3b61de88b81d785d0616b445a04890fdStructure.FromStructure(s.ssSTTI_ITEM_Out, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0b4f56146907ab8c6c6acba005eb328c, RC_0b4f56146907ab8c6c6acba005eb328c> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0b4f56146907ab8c6c6acba005eb328c s) => ToStructure(s, config);
}
public static RC_0b4f56146907ab8c6c6acba005eb328c ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0b4f56146907ab8c6c6acba005eb328c obj, IBehaviorsConfiguration config) { 
  RC_0b4f56146907ab8c6c6acba005eb328c s = new RC_0b4f56146907ab8c6c6acba005eb328c();
  if(obj != null) {
  s.ssSTTI_ITEM_Out = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_3b61de88b81d785d0616b445a04890fdStructure.ToStructure(obj.AttrTI_ITEM_Out, config);
  }
  return s;
}

public static Func<RC_0b4f56146907ab8c6c6acba005eb328c, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0b4f56146907ab8c6c6acba005eb328c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0b4f56146907ab8c6c6acba005eb328c s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0b4f56146907ab8c6c6acba005eb328c FromStructure(RC_0b4f56146907ab8c6c6acba005eb328c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_0b4f56146907ab8c6c6acba005eb328c(s, config);
}

}


