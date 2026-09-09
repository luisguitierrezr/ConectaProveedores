using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// TI_ITEM_OutRecord
public class RESTRC_0b4f56146907ab8c6c6acba005eb328c : AbstractRESTStructure<RC_0b4f56146907ab8c6c6acba005eb328c> {
[JsonProperty("TI_ITEM_Out")]
public ssConectaProveedores.RestRecords.RESTST_3b61de88b81d785d0616b445a04890fdStructure AttrTI_ITEM_Out;

public RESTRC_0b4f56146907ab8c6c6acba005eb328c() { }

public RESTRC_0b4f56146907ab8c6c6acba005eb328c (RC_0b4f56146907ab8c6c6acba005eb328c s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrTI_ITEM_Out = ConvertToRestWithoutDefaults(s.ssSTTI_ITEM_Out, new ST_3b61de88b81d785d0616b445a04890fdStructure(), ssConectaProveedores.RestRecords.RESTST_3b61de88b81d785d0616b445a04890fdStructure.FromStructure, config);
  } else {
AttrTI_ITEM_Out = ssConectaProveedores.RestRecords.RESTST_3b61de88b81d785d0616b445a04890fdStructure.FromStructure(s.ssSTTI_ITEM_Out, config);
  }
}

public static RC_0b4f56146907ab8c6c6acba005eb328c ToStructure(ssConectaProveedores.RestRecords.RESTRC_0b4f56146907ab8c6c6acba005eb328c obj) { 
  RC_0b4f56146907ab8c6c6acba005eb328c s = new RC_0b4f56146907ab8c6c6acba005eb328c();
  if(obj != null) {
  s.ssSTTI_ITEM_Out = ssConectaProveedores.RestRecords.RESTST_3b61de88b81d785d0616b445a04890fdStructure.ToStructure(obj.AttrTI_ITEM_Out);
  }
  return s;
}

public static Func<RC_0b4f56146907ab8c6c6acba005eb328c, ssConectaProveedores.RestRecords.RESTRC_0b4f56146907ab8c6c6acba005eb328c> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_0b4f56146907ab8c6c6acba005eb328c s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_0b4f56146907ab8c6c6acba005eb328c FromStructure(RC_0b4f56146907ab8c6c6acba005eb328c s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_0b4f56146907ab8c6c6acba005eb328c(s, config);
}

}


