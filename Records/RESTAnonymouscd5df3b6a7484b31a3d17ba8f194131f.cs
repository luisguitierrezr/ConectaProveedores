using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_ITEM_EM2Record
public class RESTRC_e1057cc576f9e6054c23318f5973b604 : AbstractRESTStructure<RC_e1057cc576f9e6054c23318f5973b604> {
[JsonProperty("PI_ITEM_EM2")]
public ssConectaProveedores.RestRecords.RESTST_7dc1141edc6ff8164773775d2fc68a19Structure AttrPI_ITEM_EM2;

public RESTRC_e1057cc576f9e6054c23318f5973b604() { }

public RESTRC_e1057cc576f9e6054c23318f5973b604 (RC_e1057cc576f9e6054c23318f5973b604 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_ITEM_EM2 = ConvertToRestWithoutDefaults(s.ssSTPI_ITEM_EM2, new ST_7dc1141edc6ff8164773775d2fc68a19Structure(), ssConectaProveedores.RestRecords.RESTST_7dc1141edc6ff8164773775d2fc68a19Structure.FromStructure, config);
  } else {
AttrPI_ITEM_EM2 = ssConectaProveedores.RestRecords.RESTST_7dc1141edc6ff8164773775d2fc68a19Structure.FromStructure(s.ssSTPI_ITEM_EM2, config);
  }
}

public static RC_e1057cc576f9e6054c23318f5973b604 ToStructure(ssConectaProveedores.RestRecords.RESTRC_e1057cc576f9e6054c23318f5973b604 obj) { 
  RC_e1057cc576f9e6054c23318f5973b604 s = new RC_e1057cc576f9e6054c23318f5973b604();
  if(obj != null) {
  s.ssSTPI_ITEM_EM2 = ssConectaProveedores.RestRecords.RESTST_7dc1141edc6ff8164773775d2fc68a19Structure.ToStructure(obj.AttrPI_ITEM_EM2);
  }
  return s;
}

public static Func<RC_e1057cc576f9e6054c23318f5973b604, ssConectaProveedores.RestRecords.RESTRC_e1057cc576f9e6054c23318f5973b604> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_e1057cc576f9e6054c23318f5973b604 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_e1057cc576f9e6054c23318f5973b604 FromStructure(RC_e1057cc576f9e6054c23318f5973b604 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_e1057cc576f9e6054c23318f5973b604(s, config);
}

}


